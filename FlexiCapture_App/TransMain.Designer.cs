namespace FlexiCapture_App
{
    partial class TransMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scannedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCBSFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.viewToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1444, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importedTransactionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // importedTransactionsToolStripMenuItem
            // 
            this.importedTransactionsToolStripMenuItem.Name = "importedTransactionsToolStripMenuItem";
            this.importedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.importedTransactionsToolStripMenuItem.Text = "Imported Transactions";
            this.importedTransactionsToolStripMenuItem.Click += new System.EventHandler(this.importedTransactionsToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.matchingToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scannedFilesToolStripMenuItem,
            this.iCBSFileToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // scannedFilesToolStripMenuItem
            // 
            this.scannedFilesToolStripMenuItem.Name = "scannedFilesToolStripMenuItem";
            this.scannedFilesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.scannedFilesToolStripMenuItem.Text = "Scanned Transactions";
            this.scannedFilesToolStripMenuItem.Click += new System.EventHandler(this.scannedFilesToolStripMenuItem_Click);
            // 
            // iCBSFileToolStripMenuItem
            // 
            this.iCBSFileToolStripMenuItem.Name = "iCBSFileToolStripMenuItem";
            this.iCBSFileToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.iCBSFileToolStripMenuItem.Text = "ICBS Transactions";
            this.iCBSFileToolStripMenuItem.Click += new System.EventHandler(this.iCBSFileToolStripMenuItem_Click);
            // 
            // matchingToolStripMenuItem
            // 
            this.matchingToolStripMenuItem.Name = "matchingToolStripMenuItem";
            this.matchingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matchingToolStripMenuItem.Text = "Matching";
            this.matchingToolStripMenuItem.Click += new System.EventHandler(this.matchingToolStripMenuItem_Click);
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // TransMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransMain";
            this.Text = "Vouching Transactions Management System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scannedFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCBSFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importedTransactionsToolStripMenuItem;
    }
}

