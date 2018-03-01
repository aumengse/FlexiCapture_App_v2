namespace FlexiCapture_App
{
    partial class Impt_ICBSTran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Impt_ICBSTran));
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_textfile = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(397, 67);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(83, 20);
            this.btn_browse.TabIndex = 35;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Enter location/file name of ICBS Transactions:";
            // 
            // tb_textfile
            // 
            this.tb_textfile.Location = new System.Drawing.Point(162, 67);
            this.tb_textfile.Name = "tb_textfile";
            this.tb_textfile.Size = new System.Drawing.Size(229, 20);
            this.tb_textfile.TabIndex = 33;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(192, 120);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 36;
            this.btn_ok.Text = "Import";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click_1);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(298, 120);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 37;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // Impt_ICBSTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 171);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_textfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Impt_ICBSTran";
            this.Text = "Import ICBS Transactions";
            this.Load += new System.EventHandler(this.Impt_ICBSTran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_textfile;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_view;
    }
}