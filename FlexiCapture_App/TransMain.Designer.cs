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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingCriteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmatchedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.setUpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // initializeDatabaseToolStripMenuItem
            // 
            this.initializeDatabaseToolStripMenuItem.Name = "initializeDatabaseToolStripMenuItem";
            this.initializeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.initializeDatabaseToolStripMenuItem.Text = "Initialize Database";
            this.initializeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.initializeDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importSettingsToolStripMenuItem,
            this.matchingCriteriaToolStripMenuItem});
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.setUpToolStripMenuItem.Text = "SetUp";
            // 
            // importSettingsToolStripMenuItem
            // 
            this.importSettingsToolStripMenuItem.Name = "importSettingsToolStripMenuItem";
            this.importSettingsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.importSettingsToolStripMenuItem.Text = "Import Settings";
            // 
            // matchingCriteriaToolStripMenuItem
            // 
            this.matchingCriteriaToolStripMenuItem.Name = "matchingCriteriaToolStripMenuItem";
            this.matchingCriteriaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.matchingCriteriaToolStripMenuItem.Text = "Matching Criteria";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionsToolStripMenuItem,
            this.archivedTransactionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importedToolStripMenuItem,
            this.matchedToolStripMenuItem,
            this.unmatchedToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions ";
            // 
            // importedToolStripMenuItem
            // 
            this.importedToolStripMenuItem.Name = "importedToolStripMenuItem";
            this.importedToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.importedToolStripMenuItem.Text = "Imported";
            this.importedToolStripMenuItem.Click += new System.EventHandler(this.importedToolStripMenuItem_Click);
            // 
            // matchedToolStripMenuItem
            // 
            this.matchedToolStripMenuItem.Name = "matchedToolStripMenuItem";
            this.matchedToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.matchedToolStripMenuItem.Text = "Matched";
            this.matchedToolStripMenuItem.Click += new System.EventHandler(this.matchedToolStripMenuItem_Click);
            // 
            // unmatchedToolStripMenuItem
            // 
            this.unmatchedToolStripMenuItem.Name = "unmatchedToolStripMenuItem";
            this.unmatchedToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.unmatchedToolStripMenuItem.Text = "Unmatched";
            this.unmatchedToolStripMenuItem.Click += new System.EventHandler(this.unmatchedToolStripMenuItem_Click);
            // 
            // archivedTransactionsToolStripMenuItem
            // 
            this.archivedTransactionsToolStripMenuItem.Name = "archivedTransactionsToolStripMenuItem";
            this.archivedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.archivedTransactionsToolStripMenuItem.Text = "Archived";
            this.archivedTransactionsToolStripMenuItem.Click += new System.EventHandler(this.archivedTransactionsToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchingToolStripMenuItem,
            this.archiveToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // archiveToolStripMenuItem
            // 
            this.archiveToolStripMenuItem.Name = "archiveToolStripMenuItem";
            this.archiveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.archiveToolStripMenuItem.Text = "Archive";
            this.archiveToolStripMenuItem.Click += new System.EventHandler(this.archiveToolStripMenuItem_Click);
            // 
            // matchingToolStripMenuItem
            // 
            this.matchingToolStripMenuItem.Name = "matchingToolStripMenuItem";
            this.matchingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.matchingToolStripMenuItem.Text = "Matching";
            this.matchingToolStripMenuItem.Click += new System.EventHandler(this.matchingToolStripMenuItem_Click_1);
            // 
            // TransMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1362, 696);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Vouching and Verification System";
            this.Load += new System.EventHandler(this.TransMain_Load);
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
        private System.Windows.Forms.ToolStripMenuItem archiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivedTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unmatchedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingCriteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchingToolStripMenuItem;
    }
}

