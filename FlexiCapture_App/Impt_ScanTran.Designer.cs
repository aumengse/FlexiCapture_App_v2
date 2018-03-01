namespace FlexiCapture_App
{
    partial class Impt_ScanTran
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
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_data_source = new System.Windows.Forms.TextBox();
            this.openfile_browse = new System.Windows.Forms.OpenFileDialog();
            this.dg_data_imported = new System.Windows.Forms.DataGridView();
            this.chk_view_imp_data = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data_imported)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(344, 49);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(83, 20);
            this.btn_browse.TabIndex = 32;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(183, 122);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 29;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter location/file name of Scanned Transactions:";
            // 
            // tb_data_source
            // 
            this.tb_data_source.Location = new System.Drawing.Point(109, 49);
            this.tb_data_source.Name = "tb_data_source";
            this.tb_data_source.Size = new System.Drawing.Size(229, 20);
            this.tb_data_source.TabIndex = 27;
            // 
            // openfile_browse
            // 
            this.openfile_browse.FileName = "openFileDialog1";
            // 
            // dg_data_imported
            // 
            this.dg_data_imported.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data_imported.Location = new System.Drawing.Point(206, 195);
            this.dg_data_imported.Name = "dg_data_imported";
            this.dg_data_imported.Size = new System.Drawing.Size(206, 150);
            this.dg_data_imported.TabIndex = 33;
            // 
            // chk_view_imp_data
            // 
            this.chk_view_imp_data.AutoSize = true;
            this.chk_view_imp_data.Location = new System.Drawing.Point(109, 86);
            this.chk_view_imp_data.Name = "chk_view_imp_data";
            this.chk_view_imp_data.Size = new System.Drawing.Size(164, 17);
            this.chk_view_imp_data.TabIndex = 34;
            this.chk_view_imp_data.Text = "Check to view imported data.";
            this.chk_view_imp_data.UseVisualStyleBackColor = true;
            // 
            // Impt_ScanTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 170);
            this.Controls.Add(this.chk_view_imp_data);
            this.Controls.Add(this.dg_data_imported);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_data_source);
            this.Name = "Impt_ScanTran";
            this.Text = "Import Scanned Transactions";
            this.Load += new System.EventHandler(this.Impt_ScanTran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_data_imported)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_data_source;
        private System.Windows.Forms.OpenFileDialog openfile_browse;
        private System.Windows.Forms.DataGridView dg_data_imported;
        private System.Windows.Forms.CheckBox chk_view_imp_data;
    }
}