namespace FlexiCapture_App_v2
{
    partial class Main_Process
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
            this.progress_Bar = new FlexiCapture_App.Progress_Bar();
            this.gb_details = new System.Windows.Forms.GroupBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_details.SuspendLayout();
            this.SuspendLayout();
            // 
            // progress_Bar
            // 
            this.progress_Bar.Location = new System.Drawing.Point(39, 210);
            this.progress_Bar.Name = "progress_Bar";
            this.progress_Bar.Size = new System.Drawing.Size(544, 23);
            this.progress_Bar.TabIndex = 0;
            // 
            // gb_details
            // 
            this.gb_details.Controls.Add(this.label4);
            this.gb_details.Controls.Add(this.label3);
            this.gb_details.Controls.Add(this.label2);
            this.gb_details.Location = new System.Drawing.Point(39, 76);
            this.gb_details.Name = "gb_details";
            this.gb_details.Size = new System.Drawing.Size(544, 100);
            this.gb_details.TabIndex = 1;
            this.gb_details.TabStop = false;
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(36, 41);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(272, 13);
            this.lbl_warning.TabIndex = 2;
            this.lbl_warning.Text = "Warning: This window will perform the following process:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1. Importing Scanned Transactions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "2. Importing ICBS Transactions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "3. Regular Matching";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 293);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.gb_details);
            this.Controls.Add(this.progress_Bar);
            this.Name = "Main_Process";
            this.Text = "Main_Process";
            this.Load += new System.EventHandler(this.Main_Process_Load);
            this.gb_details.ResumeLayout(false);
            this.gb_details.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlexiCapture_App.Progress_Bar progress_Bar;
        private System.Windows.Forms.GroupBox gb_details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_warning;
        private System.Windows.Forms.Button button1;
    }
}