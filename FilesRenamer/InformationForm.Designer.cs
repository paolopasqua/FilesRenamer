namespace FilesRenamer
{
    partial class InformationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformationForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.llblAuthor = new System.Windows.Forms.LinkLabel();
            this.lblInformationText = new System.Windows.Forms.Label();
            this.llblIconCredit = new System.Windows.Forms.LinkLabel();
            this.pnlInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(0, 143);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(338, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.llblIconCredit);
            this.pnlInformation.Controls.Add(this.llblAuthor);
            this.pnlInformation.Controls.Add(this.lblInformationText);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(338, 143);
            this.pnlInformation.TabIndex = 1;
            // 
            // llblAuthor
            // 
            this.llblAuthor.AutoSize = true;
            this.llblAuthor.Location = new System.Drawing.Point(127, 86);
            this.llblAuthor.Name = "llblAuthor";
            this.llblAuthor.Size = new System.Drawing.Size(161, 13);
            this.llblAuthor.TabIndex = 1;
            this.llblAuthor.TabStop = true;
            this.llblAuthor.Text = "https://github.com/paolopasqua";
            this.llblAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // lblInformationText
            // 
            this.lblInformationText.Location = new System.Drawing.Point(3, 9);
            this.lblInformationText.Name = "lblInformationText";
            this.lblInformationText.Size = new System.Drawing.Size(332, 134);
            this.lblInformationText.TabIndex = 0;
            this.lblInformationText.Text = resources.GetString("lblInformationText.Text");
            // 
            // llblIconCredit
            // 
            this.llblIconCredit.AutoSize = true;
            this.llblIconCredit.Location = new System.Drawing.Point(85, 125);
            this.llblIconCredit.Name = "llblIconCredit";
            this.llblIconCredit.Size = new System.Drawing.Size(242, 13);
            this.llblIconCredit.TabIndex = 2;
            this.llblIconCredit.TabStop = true;
            this.llblIconCredit.Text = "https://www.flaticon.com/authors/vectors-market";
            this.llblIconCredit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // InformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 176);
            this.Controls.Add(this.pnlInformation);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InformationForm";
            this.Text = "Information";
            this.TopMost = true;
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Label lblInformationText;
        private System.Windows.Forms.LinkLabel llblAuthor;
        private System.Windows.Forms.LinkLabel llblIconCredit;
    }
}