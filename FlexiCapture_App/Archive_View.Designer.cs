namespace FlexiCapture_App
{
    partial class Archive_View
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
            this.listview_archive = new System.Windows.Forms.ListView();
            this.tran_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trans_src = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.match_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.remarks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listview_archive
            // 
            this.listview_archive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tran_code,
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount,
            this.trans_src,
            this.match_code,
            this.remarks});
            this.listview_archive.FullRowSelect = true;
            this.listview_archive.GridLines = true;
            this.listview_archive.Location = new System.Drawing.Point(12, 30);
            this.listview_archive.Name = "listview_archive";
            this.listview_archive.Size = new System.Drawing.Size(1224, 401);
            this.listview_archive.TabIndex = 7;
            this.listview_archive.UseCompatibleStateImageBehavior = false;
            this.listview_archive.View = System.Windows.Forms.View.Details;
            this.listview_archive.SelectedIndexChanged += new System.EventHandler(this.listview_archive_SelectedIndexChanged);
            // 
            // tran_code
            // 
            this.tran_code.Text = "Trans Code";
            this.tran_code.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Account_Name
            // 
            this.Account_Name.Text = "Account Name";
            this.Account_Name.Width = 200;
            // 
            // Account_Number
            // 
            this.Account_Number.Text = "Account Number";
            this.Account_Number.Width = 130;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // trans_src
            // 
            this.trans_src.Text = "Trans Source";
            this.trans_src.Width = 120;
            // 
            // match_code
            // 
            this.match_code.Text = "Match Code";
            this.match_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.match_code.Width = 100;
            // 
            // remarks
            // 
            this.remarks.Text = "Remarks";
            this.remarks.Width = 350;
            // 
            // Archive_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1248, 486);
            this.Controls.Add(this.listview_archive);
            this.Name = "Archive_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive_View";
            this.Load += new System.EventHandler(this.Archive_View_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listview_archive;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Account_Name;
        private System.Windows.Forms.ColumnHeader Account_Number;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader tran_code;
        private System.Windows.Forms.ColumnHeader trans_src;
        private System.Windows.Forms.ColumnHeader match_code;
        private System.Windows.Forms.ColumnHeader remarks;
    }
}