namespace FlexiCapture_App
{
    partial class Archiving_Trans
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archiving_Trans));
            this.pbar_archive = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.pbar_timer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // pbar_archive
            // 
            this.pbar_archive.Location = new System.Drawing.Point(23, 105);
            this.pbar_archive.Name = "pbar_archive";
            this.pbar_archive.Size = new System.Drawing.Size(299, 23);
            this.pbar_archive.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Archiving Matched Transactions......";
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(193, 38);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(13, 13);
            this.lbl_percent.TabIndex = 2;
            this.lbl_percent.Text = "0";
            // 
            // pbar_timer
            // 
            this.pbar_timer.Tick += new System.EventHandler(this.pbar_timer_Tick);
            // 
            // Archiving_Trans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 160);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbar_archive);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archiving_Trans";
            this.Text = "Archiving_Trans";
            this.Load += new System.EventHandler(this.Archiving_Trans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbar_archive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_percent;
        private System.Windows.Forms.Timer pbar_timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}