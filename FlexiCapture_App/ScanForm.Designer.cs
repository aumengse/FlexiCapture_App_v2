namespace FlexiCapture_App
{
    partial class ScanForm
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
            this.dg_scanned_trans = new System.Windows.Forms.DataGridView();
            this.progress_Bar = new FlexiCapture_App.Progress_Bar();
            this.dg_icbs_trans = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_scanned_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_icbs_trans)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_scanned_trans
            // 
            this.dg_scanned_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_scanned_trans.Location = new System.Drawing.Point(12, 154);
            this.dg_scanned_trans.Name = "dg_scanned_trans";
            this.dg_scanned_trans.Size = new System.Drawing.Size(190, 135);
            this.dg_scanned_trans.TabIndex = 2;
            // 
            // progress_Bar
            // 
            this.progress_Bar.Location = new System.Drawing.Point(12, 81);
            this.progress_Bar.Name = "progress_Bar";
            this.progress_Bar.Size = new System.Drawing.Size(429, 23);
            this.progress_Bar.TabIndex = 0;
            // 
            // dg_icbs_trans
            // 
            this.dg_icbs_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_icbs_trans.Location = new System.Drawing.Point(236, 154);
            this.dg_icbs_trans.Name = "dg_icbs_trans";
            this.dg_icbs_trans.Size = new System.Drawing.Size(190, 135);
            this.dg_icbs_trans.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scanning Complete 100%";
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_icbs_trans);
            this.Controls.Add(this.dg_scanned_trans);
            this.Controls.Add(this.progress_Bar);
            this.Name = "ScanForm";
            this.Text = "Scanning Files";
            this.Load += new System.EventHandler(this.ScanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_scanned_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_icbs_trans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Progress_Bar progress_Bar;
        private System.Windows.Forms.DataGridView dg_scanned_trans;
        private System.Windows.Forms.DataGridView dg_icbs_trans;
        private System.Windows.Forms.Label label1;
    }
}