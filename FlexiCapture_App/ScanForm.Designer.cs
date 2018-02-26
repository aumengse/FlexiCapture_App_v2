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
            this.button1 = new System.Windows.Forms.Button();
            this.dg_scanned_trans = new System.Windows.Forms.DataGridView();
            this.progress_Bar = new FlexiCapture_App.Progress_Bar();
            this.dg_icbs_trans = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_scanned_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_icbs_trans)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_scanned_trans
            // 
            this.dg_scanned_trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_scanned_trans.Location = new System.Drawing.Point(12, 110);
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
            this.dg_icbs_trans.Location = new System.Drawing.Point(231, 110);
            this.dg_icbs_trans.Name = "dg_icbs_trans";
            this.dg_icbs_trans.Size = new System.Drawing.Size(190, 135);
            this.dg_icbs_trans.TabIndex = 3;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 249);
            this.Controls.Add(this.dg_icbs_trans);
            this.Controls.Add(this.dg_scanned_trans);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progress_Bar);
            this.Name = "ScanForm";
            this.Text = "Scanning Files";
            this.Load += new System.EventHandler(this.ScanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_scanned_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_icbs_trans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Progress_Bar progress_Bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dg_scanned_trans;
        private System.Windows.Forms.DataGridView dg_icbs_trans;
    }
}