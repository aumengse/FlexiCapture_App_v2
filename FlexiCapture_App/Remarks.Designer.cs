namespace FlexiCapture_App
{
    partial class Remarks
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
            this.txt_remarks = new System.Windows.Forms.RichTextBox();
            this.btn_remarks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(38, 40);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(254, 62);
            this.txt_remarks.TabIndex = 0;
            this.txt_remarks.Text = "";
            // 
            // btn_remarks
            // 
            this.btn_remarks.Location = new System.Drawing.Point(130, 114);
            this.btn_remarks.Name = "btn_remarks";
            this.btn_remarks.Size = new System.Drawing.Size(75, 23);
            this.btn_remarks.TabIndex = 1;
            this.btn_remarks.Text = "OK";
            this.btn_remarks.UseVisualStyleBackColor = true;
            this.btn_remarks.Click += new System.EventHandler(this.btn_remarks_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Reason for Force Matching";
            // 
            // Remarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remarks);
            this.Controls.Add(this.txt_remarks);
            this.Name = "Remarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remarks";
            this.Load += new System.EventHandler(this.Remarks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_remarks;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox txt_remarks;
    }
}