namespace FilesRenamer
{
    partial class frmFilesRenamer
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilesRenamer));
            this.prbRenameProgress = new System.Windows.Forms.ProgressBar();
            this.scntData = new System.Windows.Forms.SplitContainer();
            this.lblFilesNumber = new System.Windows.Forms.Label();
            this.lblFilesSelected = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.grpOrderType = new System.Windows.Forms.GroupBox();
            this.rdbDesc = new System.Windows.Forms.RadioButton();
            this.rdbAsc = new System.Windows.Forms.RadioButton();
            this.grpElabOrder = new System.Windows.Forms.GroupBox();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbAlpha = new System.Windows.Forms.RadioButton();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.mtxtLength = new System.Windows.Forms.MaskedTextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.mtxtSeed = new System.Windows.Forms.MaskedTextBox();
            this.lblSeed = new System.Windows.Forms.Label();
            this.lblSuffix = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblRenameProgress = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.scntBase = new System.Windows.Forms.SplitContainer();
            this.llblInformation = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scntData)).BeginInit();
            this.scntData.Panel1.SuspendLayout();
            this.scntData.Panel2.SuspendLayout();
            this.scntData.SuspendLayout();
            this.grpOrderType.SuspendLayout();
            this.grpElabOrder.SuspendLayout();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scntBase)).BeginInit();
            this.scntBase.Panel1.SuspendLayout();
            this.scntBase.Panel2.SuspendLayout();
            this.scntBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // prbRenameProgress
            // 
            this.prbRenameProgress.Location = new System.Drawing.Point(57, 156);
            this.prbRenameProgress.Name = "prbRenameProgress";
            this.prbRenameProgress.Size = new System.Drawing.Size(211, 23);
            this.prbRenameProgress.Step = 1;
            this.prbRenameProgress.TabIndex = 0;
            // 
            // scntData
            // 
            this.scntData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scntData.Location = new System.Drawing.Point(0, 0);
            this.scntData.Name = "scntData";
            this.scntData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scntData.Panel1
            // 
            this.scntData.Panel1.Controls.Add(this.lblFilesNumber);
            this.scntData.Panel1.Controls.Add(this.lblFilesSelected);
            this.scntData.Panel1.Controls.Add(this.lblFolderPath);
            this.scntData.Panel1.Controls.Add(this.btnFolderBrowse);
            this.scntData.Panel1.Controls.Add(this.txtFolderPath);
            // 
            // scntData.Panel2
            // 
            this.scntData.Panel2.Controls.Add(this.btnGo);
            this.scntData.Panel2.Controls.Add(this.grpOrderType);
            this.scntData.Panel2.Controls.Add(this.grpElabOrder);
            this.scntData.Panel2.Controls.Add(this.grpSettings);
            this.scntData.Panel2.Controls.Add(this.lblRenameProgress);
            this.scntData.Panel2.Controls.Add(this.prbRenameProgress);
            this.scntData.Size = new System.Drawing.Size(310, 270);
            this.scntData.SplitterDistance = 80;
            this.scntData.TabIndex = 1;
            // 
            // lblFilesNumber
            // 
            this.lblFilesNumber.AutoSize = true;
            this.lblFilesNumber.Location = new System.Drawing.Point(92, 47);
            this.lblFilesNumber.Name = "lblFilesNumber";
            this.lblFilesNumber.Size = new System.Drawing.Size(13, 13);
            this.lblFilesNumber.TabIndex = 4;
            this.lblFilesNumber.Text = "0";
            // 
            // lblFilesSelected
            // 
            this.lblFilesSelected.AutoSize = true;
            this.lblFilesSelected.Location = new System.Drawing.Point(12, 47);
            this.lblFilesSelected.Name = "lblFilesSelected";
            this.lblFilesSelected.Size = new System.Drawing.Size(74, 13);
            this.lblFilesSelected.TabIndex = 3;
            this.lblFilesSelected.Text = "Files selected:";
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(12, 9);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(39, 13);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "Folder:";
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.Location = new System.Drawing.Point(230, 22);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFolderBrowse.TabIndex = 1;
            this.btnFolderBrowse.Text = "Browse";
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(14, 24);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(210, 20);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.Leave += new System.EventHandler(this.txtFolderPath_Leave);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(12, 156);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(39, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // grpOrderType
            // 
            this.grpOrderType.Controls.Add(this.rdbDesc);
            this.grpOrderType.Controls.Add(this.rdbAsc);
            this.grpOrderType.Location = new System.Drawing.Point(190, 85);
            this.grpOrderType.Name = "grpOrderType";
            this.grpOrderType.Size = new System.Drawing.Size(115, 65);
            this.grpOrderType.TabIndex = 4;
            this.grpOrderType.TabStop = false;
            this.grpOrderType.Text = "Order type";
            // 
            // rdbDesc
            // 
            this.rdbDesc.AutoSize = true;
            this.rdbDesc.Location = new System.Drawing.Point(16, 42);
            this.rdbDesc.Name = "rdbDesc";
            this.rdbDesc.Size = new System.Drawing.Size(83, 17);
            this.rdbDesc.TabIndex = 1;
            this.rdbDesc.Text = "Descendent";
            this.rdbDesc.UseVisualStyleBackColor = true;
            // 
            // rdbAsc
            // 
            this.rdbAsc.AutoSize = true;
            this.rdbAsc.Checked = true;
            this.rdbAsc.Location = new System.Drawing.Point(16, 19);
            this.rdbAsc.Name = "rdbAsc";
            this.rdbAsc.Size = new System.Drawing.Size(76, 17);
            this.rdbAsc.TabIndex = 0;
            this.rdbAsc.TabStop = true;
            this.rdbAsc.Text = "Ascendent";
            this.rdbAsc.UseVisualStyleBackColor = true;
            // 
            // grpElabOrder
            // 
            this.grpElabOrder.Controls.Add(this.rdbData);
            this.grpElabOrder.Controls.Add(this.rdbAlpha);
            this.grpElabOrder.Location = new System.Drawing.Point(190, 12);
            this.grpElabOrder.Name = "grpElabOrder";
            this.grpElabOrder.Size = new System.Drawing.Size(115, 67);
            this.grpElabOrder.TabIndex = 3;
            this.grpElabOrder.TabStop = false;
            this.grpElabOrder.Text = "Elaboration order";
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Location = new System.Drawing.Point(16, 42);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(48, 17);
            this.rdbData.TabIndex = 1;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = true;
            // 
            // rdbAlpha
            // 
            this.rdbAlpha.AutoSize = true;
            this.rdbAlpha.Checked = true;
            this.rdbAlpha.Location = new System.Drawing.Point(16, 19);
            this.rdbAlpha.Name = "rdbAlpha";
            this.rdbAlpha.Size = new System.Drawing.Size(83, 17);
            this.rdbAlpha.TabIndex = 0;
            this.rdbAlpha.TabStop = true;
            this.rdbAlpha.Text = "Alphabetical";
            this.rdbAlpha.UseVisualStyleBackColor = true;
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.mtxtLength);
            this.grpSettings.Controls.Add(this.lblLength);
            this.grpSettings.Controls.Add(this.mtxtSeed);
            this.grpSettings.Controls.Add(this.lblSeed);
            this.grpSettings.Controls.Add(this.lblSuffix);
            this.grpSettings.Controls.Add(this.txtSuffix);
            this.grpSettings.Controls.Add(this.lblPrefix);
            this.grpSettings.Controls.Add(this.txtPrefix);
            this.grpSettings.Location = new System.Drawing.Point(12, 12);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(172, 138);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // mtxtLength
            // 
            this.mtxtLength.Location = new System.Drawing.Point(100, 75);
            this.mtxtLength.Mask = "999999999";
            this.mtxtLength.Name = "mtxtLength";
            this.mtxtLength.PromptChar = ' ';
            this.mtxtLength.Size = new System.Drawing.Size(66, 20);
            this.mtxtLength.TabIndex = 8;
            this.mtxtLength.Text = "1";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(6, 78);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(94, 13);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Progressive length";
            // 
            // mtxtSeed
            // 
            this.mtxtSeed.Location = new System.Drawing.Point(100, 47);
            this.mtxtSeed.Mask = "999999999";
            this.mtxtSeed.Name = "mtxtSeed";
            this.mtxtSeed.PromptChar = ' ';
            this.mtxtSeed.Size = new System.Drawing.Size(66, 20);
            this.mtxtSeed.TabIndex = 6;
            this.mtxtSeed.Text = "0";
            // 
            // lblSeed
            // 
            this.lblSeed.AutoSize = true;
            this.lblSeed.Location = new System.Drawing.Point(6, 50);
            this.lblSeed.Name = "lblSeed";
            this.lblSeed.Size = new System.Drawing.Size(88, 13);
            this.lblSeed.TabIndex = 5;
            this.lblSeed.Text = "Progressive seed";
            // 
            // lblSuffix
            // 
            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Location = new System.Drawing.Point(6, 106);
            this.lblSuffix.Name = "lblSuffix";
            this.lblSuffix.Size = new System.Drawing.Size(33, 13);
            this.lblSuffix.TabIndex = 3;
            this.lblSuffix.Text = "Suffix";
            // 
            // txtSuffix
            // 
            this.txtSuffix.Location = new System.Drawing.Point(66, 103);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(100, 20);
            this.txtSuffix.TabIndex = 2;
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(6, 22);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(33, 13);
            this.lblPrefix.TabIndex = 1;
            this.lblPrefix.Text = "Prefix";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(66, 19);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 20);
            this.txtPrefix.TabIndex = 0;
            // 
            // lblRenameProgress
            // 
            this.lblRenameProgress.AutoSize = true;
            this.lblRenameProgress.Location = new System.Drawing.Point(270, 161);
            this.lblRenameProgress.Name = "lblRenameProgress";
            this.lblRenameProgress.Size = new System.Drawing.Size(21, 13);
            this.lblRenameProgress.TabIndex = 1;
            this.lblRenameProgress.Text = "0%";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // scntBase
            // 
            this.scntBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scntBase.Location = new System.Drawing.Point(0, 0);
            this.scntBase.Name = "scntBase";
            this.scntBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scntBase.Panel1
            // 
            this.scntBase.Panel1.Controls.Add(this.scntData);
            // 
            // scntBase.Panel2
            // 
            this.scntBase.Panel2.Controls.Add(this.llblInformation);
            this.scntBase.Panel2MinSize = 20;
            this.scntBase.Size = new System.Drawing.Size(310, 294);
            this.scntBase.SplitterDistance = 270;
            this.scntBase.TabIndex = 2;
            // 
            // llblInformation
            // 
            this.llblInformation.AutoSize = true;
            this.llblInformation.Location = new System.Drawing.Point(3, 3);
            this.llblInformation.Name = "llblInformation";
            this.llblInformation.Size = new System.Drawing.Size(44, 13);
            this.llblInformation.TabIndex = 0;
            this.llblInformation.TabStop = true;
            this.llblInformation.Text = "About...";
            this.llblInformation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblInformation_LinkClicked);
            // 
            // frmFilesRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 294);
            this.Controls.Add(this.scntBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilesRenamer";
            this.Text = "Files Renamer";
            this.scntData.Panel1.ResumeLayout(false);
            this.scntData.Panel1.PerformLayout();
            this.scntData.Panel2.ResumeLayout(false);
            this.scntData.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scntData)).EndInit();
            this.scntData.ResumeLayout(false);
            this.grpOrderType.ResumeLayout(false);
            this.grpOrderType.PerformLayout();
            this.grpElabOrder.ResumeLayout(false);
            this.grpElabOrder.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.scntBase.Panel1.ResumeLayout(false);
            this.scntBase.Panel2.ResumeLayout(false);
            this.scntBase.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scntBase)).EndInit();
            this.scntBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbRenameProgress;
        private System.Windows.Forms.SplitContainer scntData;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Label lblRenameProgress;
        private System.Windows.Forms.Label lblFilesNumber;
        private System.Windows.Forms.Label lblFilesSelected;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.GroupBox grpOrderType;
        private System.Windows.Forms.RadioButton rdbDesc;
        private System.Windows.Forms.RadioButton rdbAsc;
        private System.Windows.Forms.GroupBox grpElabOrder;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.RadioButton rdbAlpha;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.MaskedTextBox mtxtSeed;
        private System.Windows.Forms.Label lblSeed;
        private System.Windows.Forms.Label lblSuffix;
        private System.Windows.Forms.TextBox txtSuffix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.MaskedTextBox mtxtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.SplitContainer scntBase;
        private System.Windows.Forms.LinkLabel llblInformation;
    }
}

