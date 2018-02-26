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
            this.tb_table_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_data_source = new System.Windows.Forms.TextBox();
            this.openfile_browse = new System.Windows.Forms.OpenFileDialog();
            this.dg_data_imported = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data_imported)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(418, 73);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(83, 20);
            this.btn_browse.TabIndex = 32;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_table_name
            // 
            this.tb_table_name.Location = new System.Drawing.Point(184, 112);
            this.tb_table_name.Name = "tb_table_name";
            this.tb_table_name.Size = new System.Drawing.Size(228, 20);
            this.tb_table_name.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(111, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Table name:";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(257, 156);
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
            this.label2.Location = new System.Drawing.Point(111, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter location/file name of Scanned Transactions:";
            // 
            // tb_data_source
            // 
            this.tb_data_source.Location = new System.Drawing.Point(183, 73);
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
            this.dg_data_imported.Location = new System.Drawing.Point(11, 156);
            this.dg_data_imported.Name = "dg_data_imported";
            this.dg_data_imported.Size = new System.Drawing.Size(240, 150);
            this.dg_data_imported.TabIndex = 33;
            // 
            // Impt_ScanTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 306);
            this.Controls.Add(this.dg_data_imported);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_table_name);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.TextBox tb_table_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_data_source;
        private System.Windows.Forms.OpenFileDialog openfile_browse;
        private System.Windows.Forms.DataGridView dg_data_imported;
    }
}