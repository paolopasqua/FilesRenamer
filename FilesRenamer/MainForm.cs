using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

/*
Program information:
Realized to rename all the files inside a selected foldter with a progressive. 
You can process the file in alphabetical order or creation data order, ascendent or descendent.

Made by Paolo Pasquali (https://github.com/paolopasqua)

Icon credits:
Vectors Market (https://www.flaticon.com/authors/vectors-market)
*/

namespace FilesRenamer
{
    public partial class frmFilesRenamer : Form
    {
        #region Attributes

        private DirectoryInfo dir = null;
        private FileInfo[] files = null;

        private enum Order { ALPHABETICAL, DATA };
        private enum OrderType { ASCENDENT, DESCENDENT };

        #endregion

        public frmFilesRenamer()
        {
            InitializeComponent();
        }

        #region Private Methods

        /**
        Updates files counter under the folder path textbox.
            <param name="count">value to view</param>
        */
        private void updateFilesCounter(int count)
        {
            lblFilesNumber.Text = count.ToString().Trim();
        }

        /**
        Updates the progress bar value and the percentage viewed on the label on right.
            <param name="value">value to set</param>
        */
        private void updateProgressBar(int value)
        {
            prbRenameProgress.Value = value;
            lblRenameProgress.Text = value.ToString().Trim() + "%";
        }

        /**
        Loads the selected directory information.
        */
        private void loadDirectoryInfo()
        {
            if (txtFolderPath.Text.TrimEnd().Length > 0)
            {
                DirectoryInfo dirToSet = new DirectoryInfo(txtFolderPath.Text);

                loadDirectoryInfo(dirToSet);
            }
        }

        /**
        Loads the information of the directory passed as a parameter.
            <param name="dirToSet">directory to load</param>
        */
        private void loadDirectoryInfo(DirectoryInfo dirToSet)
        {
            if (dirToSet != null)
            {
                dir = dirToSet;

                if (!dir.Exists)
                {
                    MessageBox.Show(this, "Directory [\"" + dir.FullName + "\"] must exist!", "Error");
                    txtFolderPath.Text = string.Empty;
                    updateFilesCounter(0);
                }
                else
                {
                    files = dir.GetFiles();
                    updateFilesCounter(files.Length);
                }
            }
        }

        /**
        Processes all the files inside the selected directory to execute the renaming.
            <param name="prefix">prefix to apply to the progressive on the new file name</param>
            <param name="suffix">suffix to apply to the progressive on the new file name</param>
            <param name="seed">starting number of the progressive</param>
            <param name="progressiveLength">progressive (in string) length</param>
            <param name="order">files elaboration order</param>
            <param name="orderType">files elaboration order type (acendent/descendent)</param>
        */
        private bool processFiles (string prefix, string suffix, int seed, int progressiveLength, Order order, OrderType orderType)
        {
            IOrderedEnumerable<FileInfo> filesSorted;
            double advancement = 100.0 / files.Length;
            double progressAdvancement = 0;
            bool bWithError = false;
            
            if (order.Equals(Order.ALPHABETICAL))
            {
                if (orderType.Equals(OrderType.ASCENDENT))
                    filesSorted = files.OrderBy(f => f.Name);
                else
                    filesSorted = files.OrderByDescending(f => f.Name);
            }
            else
            {
                if (orderType.Equals(OrderType.ASCENDENT))
                    filesSorted = files.OrderBy(f => f.CreationTime);
                else
                    filesSorted = files.OrderByDescending(f => f.CreationTime);
            }
            
            foreach(FileInfo f in filesSorted)
            {
                DialogResult diagRes = DialogResult.Retry;

                while (diagRes != DialogResult.Cancel)
                {
                    try
                    {
                        string newName = f.DirectoryName + "/" + prefix + seed.ToString().Trim().PadLeft(progressiveLength, '0') + suffix + f.Extension;
                        f.MoveTo(newName);

                        diagRes = DialogResult.Cancel;
                    }
                    catch (Exception ex)
                    {
                        diagRes = MessageBox.Show(this, "Execution for file \"" + f.FullName + "\" failed: " + ex.Message, "Warning!", MessageBoxButtons.RetryCancel);
                        bWithError = true;
                    }
                }

                seed++;
                progressAdvancement += advancement;
                updateProgressBar(Convert.ToInt32(progressAdvancement));
            }

            return !bWithError;
        }

        /**
        Resets all the variables used on program.
        */
        private void reset()
        {
            updateProgressBar(0);
            updateFilesCounter(0);
            txtFolderPath.Text = string.Empty;
            dir = null;
            files = null;
            txtPrefix.Text = string.Empty;
            mtxtSeed.Text = "0";
            mtxtLength.Text = "1";
            txtSuffix.Text = string.Empty;
            rdbAlpha.Checked = true;
            rdbAsc.Checked = true;
        }

        #endregion

        #region Events

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        /**
        System event: directory search button's clicks
        Starts the directory search and loads it's information.
            <param name="sender"></param>
            <param name="e"></param>
        */
        private void btnFolderBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
                loadDirectoryInfo();
            }
        }

        /**
        System event: loosing focus of the directory path textbox
        When edited the directory path, loads the information of new directory path.
        */
        private void txtFolderPath_Leave(object sender, EventArgs e)
        {
            if (txtFolderPath.Text.TrimEnd().Length > 0)
            {
                if (dir == null)
                {
                    loadDirectoryInfo();
                }
                else
                {
                    DirectoryInfo writtenDir = new DirectoryInfo(txtFolderPath.Text);

                    if (!writtenDir.FullName.Equals(dir.FullName))
                    {
                        dir = null;
                        files = null;
                        loadDirectoryInfo(writtenDir);
                    }
                }
            }
            else
            {
                updateFilesCounter(0);
            }
        }

        /**
        System event: files elaboration start button's clicks
        Executes verification on data and then starts the files renaming.
        At the end, resets the program conditions.
        */
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this,"Sure to proceed?", "Process confirmation", MessageBoxButtons.YesNo).Equals(DialogResult.Yes))
            {
                int seedLength = Int32.Parse(mtxtLength.Text);
                int seed = Int32.Parse(mtxtSeed.Text);
                Order order = rdbAlpha.Checked ? Order.ALPHABETICAL : Order.DATA;
                OrderType orderType = rdbAsc.Checked ? OrderType.ASCENDENT : OrderType.DESCENDENT;
                bool bWithError = false;

                if (dir == null || txtFolderPath.Text.TrimEnd().Length == 0)
                {
                    MessageBox.Show(this, "Select a folder!", "Error");
                    txtFolderPath.Focus();
                    return;
                }

                if (files == null || files.Length == 0)
                {
                    MessageBox.Show(this, "No files selected!", "Error");
                    txtFolderPath.Focus();
                    return;
                }

                if (seedLength <= 0)
                {
                    MessageBox.Show(this, "Progressive length can't be less or equal to zero!", "Error");
                    mtxtLength.Focus();
                    return;
                }

                if (mtxtSeed.Text.Trim().Length > seedLength)
                {
                    MessageBox.Show(this, "Progressive seed can't be longer than Progressive length!", "Error");
                    mtxtSeed.Focus();
                    return;
                }

                if ((seed+files.Length).ToString().Trim().Length > seedLength)
                {
                    MessageBox.Show(this, "Last used progressive [" + (seed + files.Length).ToString().Trim() + "] can't be longer than Progressive length!", "Error");
                    mtxtSeed.Focus();
                    return;
                }

                bWithError = !processFiles(txtPrefix.Text.TrimEnd(), txtSuffix.Text.TrimEnd(), seed, seedLength, order, orderType);
                
                if (bWithError)
                    MessageBox.Show(this, "Files renamed. Error[s] occurred while execution running.", "Information");
                else
                    MessageBox.Show(this, "Files renamed with success.", "Information");

                reset();
                txtFolderPath.Focus();
            }
        }

        /**
        System event: informations link's clicks
        Show the information form.
        */
        private void llblInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InformationForm inf = new InformationForm();

            inf.Show(this);
        }

        #endregion

    }
}
