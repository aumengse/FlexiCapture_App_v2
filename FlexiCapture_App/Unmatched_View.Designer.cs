namespace FlexiCapture_App
{
    partial class Unmatched_View
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
            this.Unmatched_Icbs_Records = new System.Windows.Forms.ListView();
            this.Check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trans_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unmatched_Scanned_Records = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_icbs_value_items = new System.Windows.Forms.Label();
            this.lbl_icbs_total_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_scan_total_amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_scan_value_items = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmb_icbs_trans = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_scan_trans = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Unmatched_Icbs_Records
            // 
            this.Unmatched_Icbs_Records.CheckBoxes = true;
            this.Unmatched_Icbs_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check,
            this.trans_code,
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount});
            this.Unmatched_Icbs_Records.FullRowSelect = true;
            this.Unmatched_Icbs_Records.Location = new System.Drawing.Point(9, 18);
            this.Unmatched_Icbs_Records.MultiSelect = false;
            this.Unmatched_Icbs_Records.Name = "Unmatched_Icbs_Records";
            this.Unmatched_Icbs_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Icbs_Records.TabIndex = 3;
            this.Unmatched_Icbs_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Icbs_Records.View = System.Windows.Forms.View.Details;
            this.Unmatched_Icbs_Records.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.Unmatched_Icbs_Records_ItemChecked);
            this.Unmatched_Icbs_Records.SelectedIndexChanged += new System.EventHandler(this.Unmatched_Icbs_Records_SelectedIndexChanged);
            // 
            // Check
            // 
            this.Check.Text = "Check";
            // 
            // trans_code
            // 
            this.trans_code.Text = "Trans Code";
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
            // Unmatched_Scanned_Records
            // 
            this.Unmatched_Scanned_Records.CheckBoxes = true;
            this.Unmatched_Scanned_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Unmatched_Scanned_Records.FullRowSelect = true;
            this.Unmatched_Scanned_Records.Location = new System.Drawing.Point(6, 17);
            this.Unmatched_Scanned_Records.MultiSelect = false;
            this.Unmatched_Scanned_Records.Name = "Unmatched_Scanned_Records";
            this.Unmatched_Scanned_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Scanned_Records.TabIndex = 4;
            this.Unmatched_Scanned_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Scanned_Records.View = System.Windows.Forms.View.Details;
            this.Unmatched_Scanned_Records.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.Unmatched_Scanned_Records_ItemChecked);
            this.Unmatched_Scanned_Records.SelectedIndexChanged += new System.EventHandler(this.Unmatched_Trans_Records_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trans Code";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account Name";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Account Number";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 100;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(580, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Verify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Unmatched_Icbs_Records);
            this.groupBox1.Location = new System.Drawing.Point(9, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ICBS Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Unmatched_Scanned_Records);
            this.groupBox2.Location = new System.Drawing.Point(633, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scanned Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total Items";
            // 
            // lbl_icbs_value_items
            // 
            this.lbl_icbs_value_items.AutoSize = true;
            this.lbl_icbs_value_items.Location = new System.Drawing.Point(83, 482);
            this.lbl_icbs_value_items.Name = "lbl_icbs_value_items";
            this.lbl_icbs_value_items.Size = new System.Drawing.Size(13, 13);
            this.lbl_icbs_value_items.TabIndex = 9;
            this.lbl_icbs_value_items.Text = "0";
            // 
            // lbl_icbs_total_amount
            // 
            this.lbl_icbs_total_amount.AutoSize = true;
            this.lbl_icbs_total_amount.Location = new System.Drawing.Point(536, 482);
            this.lbl_icbs_total_amount.Name = "lbl_icbs_total_amount";
            this.lbl_icbs_total_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_icbs_total_amount.TabIndex = 11;
            this.lbl_icbs_total_amount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Amount";
            // 
            // lbl_scan_total_amount
            // 
            this.lbl_scan_total_amount.AutoSize = true;
            this.lbl_scan_total_amount.Location = new System.Drawing.Point(1157, 478);
            this.lbl_scan_total_amount.Name = "lbl_scan_total_amount";
            this.lbl_scan_total_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_scan_total_amount.TabIndex = 15;
            this.lbl_scan_total_amount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1092, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Amount";
            // 
            // lbl_scan_value_items
            // 
            this.lbl_scan_value_items.AutoSize = true;
            this.lbl_scan_value_items.Location = new System.Drawing.Point(704, 478);
            this.lbl_scan_value_items.Name = "lbl_scan_value_items";
            this.lbl_scan_value_items.Size = new System.Drawing.Size(13, 13);
            this.lbl_scan_value_items.TabIndex = 13;
            this.lbl_scan_value_items.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total Items";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1077, 29);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Filter:";
            // 
            // cmb_icbs_trans
            // 
            this.cmb_icbs_trans.FormattingEnabled = true;
            this.cmb_icbs_trans.Items.AddRange(new object[] {
            "All",
            "Deposits",
            "Withdrawals"});
            this.cmb_icbs_trans.Location = new System.Drawing.Point(491, 20);
            this.cmb_icbs_trans.Name = "cmb_icbs_trans";
            this.cmb_icbs_trans.Size = new System.Drawing.Size(121, 21);
            this.cmb_icbs_trans.TabIndex = 26;
            this.cmb_icbs_trans.SelectedIndexChanged += new System.EventHandler(this.cmb_icbs_trans_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(453, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "Filter:";
            // 
            // cmb_scan_trans
            // 
            this.cmb_scan_trans.FormattingEnabled = true;
            this.cmb_scan_trans.Items.AddRange(new object[] {
            "All",
            "Deposits",
            "Withdrawals"});
            this.cmb_scan_trans.Location = new System.Drawing.Point(1115, 23);
            this.cmb_scan_trans.Name = "cmb_scan_trans";
            this.cmb_scan_trans.Size = new System.Drawing.Size(121, 21);
            this.cmb_scan_trans.TabIndex = 24;
            this.cmb_scan_trans.SelectedIndexChanged += new System.EventHandler(this.cmb_scan_trans_SelectedIndexChanged);
            // 
            // Unmatched_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1251, 569);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.cmb_icbs_trans);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.cmb_scan_trans);
            this.Controls.Add(this.lbl_scan_total_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_scan_value_items);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_icbs_total_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_icbs_value_items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Unmatched_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unmatch Transaction";
            this.Load += new System.EventHandler(this.Unmatched_View_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Account_Name;
        private System.Windows.Forms.ColumnHeader Account_Number;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ListView Unmatched_Scanned_Records;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Check;
        public System.Windows.Forms.ListView Unmatched_Icbs_Records;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_icbs_value_items;
        private System.Windows.Forms.Label lbl_icbs_total_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_scan_total_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_scan_value_items;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader trans_code;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmb_icbs_trans;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_scan_trans;
    }
}