namespace FlexiCapture_App
{
    partial class Matched
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
            this.Matched_Icbs_Records = new System.Windows.Forms.ListView();
            this.check = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Matched_Trans_Records = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_undo = new System.Windows.Forms.Button();
            this.lbl_scan_total_amount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_scan_value_items = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_icbs_total_amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_icbs_value_items = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.match_icbs_filter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.match_scan_filter = new System.Windows.Forms.ComboBox();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Matched_Icbs_Records
            // 
            this.Matched_Icbs_Records.CheckBoxes = true;
            this.Matched_Icbs_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.check,
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount,
            this.columnHeader6});
            this.Matched_Icbs_Records.FullRowSelect = true;
            this.Matched_Icbs_Records.GridLines = true;
            this.Matched_Icbs_Records.Location = new System.Drawing.Point(19, 16);
            this.Matched_Icbs_Records.Name = "Matched_Icbs_Records";
            this.Matched_Icbs_Records.Size = new System.Drawing.Size(543, 429);
            this.Matched_Icbs_Records.TabIndex = 6;
            this.Matched_Icbs_Records.UseCompatibleStateImageBehavior = false;
            this.Matched_Icbs_Records.View = System.Windows.Forms.View.Details;
            // 
            // check
            // 
            this.check.Text = "Check";
            this.check.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.check.Width = 45;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 120;
            // 
            // Account_Name
            // 
            this.Account_Name.Text = "Account Name";
            this.Account_Name.Width = 100;
            // 
            // Account_Number
            // 
            this.Account_Number.Text = "Account Number";
            this.Account_Number.Width = 100;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 100;
            // 
            // Matched_Trans_Records
            // 
            this.Matched_Trans_Records.CheckBoxes = true;
            this.Matched_Trans_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.Matched_Trans_Records.FullRowSelect = true;
            this.Matched_Trans_Records.GridLines = true;
            this.Matched_Trans_Records.Location = new System.Drawing.Point(22, 16);
            this.Matched_Trans_Records.Name = "Matched_Trans_Records";
            this.Matched_Trans_Records.Size = new System.Drawing.Size(543, 429);
            this.Matched_Trans_Records.TabIndex = 7;
            this.Matched_Trans_Records.UseCompatibleStateImageBehavior = false;
            this.Matched_Trans_Records.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account Name";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Account Number";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 103;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Matched_Icbs_Records);
            this.groupBox1.Location = new System.Drawing.Point(9, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(581, 474);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ICBS Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Matched_Trans_Records);
            this.groupBox2.Location = new System.Drawing.Point(633, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 474);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scanned Data";
            // 
            // btn_undo
            // 
            this.btn_undo.Location = new System.Drawing.Point(18, 611);
            this.btn_undo.Name = "btn_undo";
            this.btn_undo.Size = new System.Drawing.Size(132, 38);
            this.btn_undo.TabIndex = 10;
            this.btn_undo.Text = "Undo Force Matched";
            this.btn_undo.UseVisualStyleBackColor = true;
            this.btn_undo.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_scan_total_amount
            // 
            this.lbl_scan_total_amount.AutoSize = true;
            this.lbl_scan_total_amount.Location = new System.Drawing.Point(1072, 560);
            this.lbl_scan_total_amount.Name = "lbl_scan_total_amount";
            this.lbl_scan_total_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_scan_total_amount.TabIndex = 23;
            this.lbl_scan_total_amount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(996, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Amount";
            // 
            // lbl_scan_value_items
            // 
            this.lbl_scan_value_items.AutoSize = true;
            this.lbl_scan_value_items.Location = new System.Drawing.Point(695, 560);
            this.lbl_scan_value_items.Name = "lbl_scan_value_items";
            this.lbl_scan_value_items.Size = new System.Drawing.Size(13, 13);
            this.lbl_scan_value_items.TabIndex = 21;
            this.lbl_scan_value_items.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Items";
            // 
            // lbl_icbs_total_amount
            // 
            this.lbl_icbs_total_amount.AutoSize = true;
            this.lbl_icbs_total_amount.Location = new System.Drawing.Point(440, 560);
            this.lbl_icbs_total_amount.Name = "lbl_icbs_total_amount";
            this.lbl_icbs_total_amount.Size = new System.Drawing.Size(13, 13);
            this.lbl_icbs_total_amount.TabIndex = 19;
            this.lbl_icbs_total_amount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Amount";
            // 
            // lbl_icbs_value_items
            // 
            this.lbl_icbs_value_items.AutoSize = true;
            this.lbl_icbs_value_items.Location = new System.Drawing.Point(80, 560);
            this.lbl_icbs_value_items.Name = "lbl_icbs_value_items";
            this.lbl_icbs_value_items.Size = new System.Drawing.Size(13, 13);
            this.lbl_icbs_value_items.TabIndex = 17;
            this.lbl_icbs_value_items.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total Items";
            // 
            // match_icbs_filter
            // 
            this.match_icbs_filter.FormattingEnabled = true;
            this.match_icbs_filter.Items.AddRange(new object[] {
            "All",
            "Regular Match",
            "Force Match"});
            this.match_icbs_filter.Location = new System.Drawing.Point(430, 32);
            this.match_icbs_filter.Name = "match_icbs_filter";
            this.match_icbs_filter.Size = new System.Drawing.Size(141, 21);
            this.match_icbs_filter.TabIndex = 24;
            this.match_icbs_filter.SelectedIndexChanged += new System.EventHandler(this.match_icbs_filter_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(996, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Filter:";
            // 
            // match_scan_filter
            // 
            this.match_scan_filter.FormattingEnabled = true;
            this.match_scan_filter.Items.AddRange(new object[] {
            "All",
            "Regular Match",
            "Force Match"});
            this.match_scan_filter.Location = new System.Drawing.Point(1034, 32);
            this.match_scan_filter.Name = "match_scan_filter";
            this.match_scan_filter.Size = new System.Drawing.Size(156, 21);
            this.match_scan_filter.TabIndex = 26;
            this.match_scan_filter.SelectedIndexChanged += new System.EventHandler(this.match_scan_filter_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Match Code";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Match Code";
            this.columnHeader7.Width = 70;
            // 
            // Matched
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.match_scan_filter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.match_icbs_filter);
            this.Controls.Add(this.lbl_scan_total_amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_scan_value_items);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_icbs_total_amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_icbs_value_items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_undo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Matched";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matched";
            this.Load += new System.EventHandler(this.Matched_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Matched_Icbs_Records;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Account_Name;
        private System.Windows.Forms.ColumnHeader Account_Number;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ListView Matched_Trans_Records;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader check;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_undo;
        private System.Windows.Forms.Label lbl_scan_total_amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_scan_value_items;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_icbs_total_amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_icbs_value_items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox match_icbs_filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox match_scan_filter;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}