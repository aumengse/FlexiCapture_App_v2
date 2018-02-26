namespace FlexiCapture_App
{
    partial class TransMain
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
            this.openfile_browse = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromScannedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromICBSTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewImportedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmatchedTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile_browse_icbs = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_amt = new System.Windows.Forms.TextBox();
            this.tb_transac_date = new System.Windows.Forms.TextBox();
            this.tb_acc_num = new System.Windows.Forms.TextBox();
            this.tb_acc_name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbl_scan_total_items = new System.Windows.Forms.Label();
            this.lbl_scan_total_amt = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_icbs_total_amt = new System.Windows.Forms.Label();
            this.lbl_icbs_total_items = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pnl_info_icbs = new System.Windows.Forms.Panel();
            this.btn_exit_icbs = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_amt_icbs = new System.Windows.Forms.TextBox();
            this.tb_transac_date_icbs = new System.Windows.Forms.TextBox();
            this.tb_acc_num_icbs = new System.Windows.Forms.TextBox();
            this.tb_acc_name_icbs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lv_icbs = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lv_data = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trans_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acc_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.acc_num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.pnl_info.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_info_icbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfile_browse
            // 
            this.openfile_browse.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStrip,
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStrip
            // 
            this.fileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStrip.Name = "fileToolStrip";
            this.fileToolStrip.Size = new System.Drawing.Size(37, 20);
            this.fileToolStrip.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromScannedTransactionsToolStripMenuItem,
            this.importFromICBSTransactionsToolStripMenuItem,
            this.viewImportedRecordsToolStripMenuItem,
            this.performMatchingToolStripMenuItem,
            this.matchedTransactionsToolStripMenuItem,
            this.unmatchedTransactionsToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // importFromScannedTransactionsToolStripMenuItem
            // 
            this.importFromScannedTransactionsToolStripMenuItem.Name = "importFromScannedTransactionsToolStripMenuItem";
            this.importFromScannedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.importFromScannedTransactionsToolStripMenuItem.Text = "Import Scanned Transactions";
            this.importFromScannedTransactionsToolStripMenuItem.Click += new System.EventHandler(this.importFromScannedTransactionsToolStripMenuItem_Click);
            // 
            // importFromICBSTransactionsToolStripMenuItem
            // 
            this.importFromICBSTransactionsToolStripMenuItem.Name = "importFromICBSTransactionsToolStripMenuItem";
            this.importFromICBSTransactionsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.importFromICBSTransactionsToolStripMenuItem.Text = "Import ICBS Transactions";
            this.importFromICBSTransactionsToolStripMenuItem.Click += new System.EventHandler(this.importFromICBSTransactionsToolStripMenuItem_Click);
            // 
            // viewImportedRecordsToolStripMenuItem
            // 
            this.viewImportedRecordsToolStripMenuItem.Name = "viewImportedRecordsToolStripMenuItem";
            this.viewImportedRecordsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.viewImportedRecordsToolStripMenuItem.Text = "View Imported Records";
            this.viewImportedRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewImportedRecordsToolStripMenuItem_Click);
            // 
            // performMatchingToolStripMenuItem
            // 
            this.performMatchingToolStripMenuItem.Name = "performMatchingToolStripMenuItem";
            this.performMatchingToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.performMatchingToolStripMenuItem.Text = "Perform Matching";
            this.performMatchingToolStripMenuItem.Click += new System.EventHandler(this.performMatchingToolStripMenuItem_Click);
            // 
            // matchedTransactionsToolStripMenuItem
            // 
            this.matchedTransactionsToolStripMenuItem.Name = "matchedTransactionsToolStripMenuItem";
            this.matchedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.matchedTransactionsToolStripMenuItem.Text = "View Matched Transactions";
            this.matchedTransactionsToolStripMenuItem.Click += new System.EventHandler(this.matchedTransactionsToolStripMenuItem_Click);
            // 
            // unmatchedTransactionsToolStripMenuItem
            // 
            this.unmatchedTransactionsToolStripMenuItem.Name = "unmatchedTransactionsToolStripMenuItem";
            this.unmatchedTransactionsToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.unmatchedTransactionsToolStripMenuItem.Text = "View Unmatched Transactions";
            this.unmatchedTransactionsToolStripMenuItem.Click += new System.EventHandler(this.unmatchedTransactionsToolStripMenuItem_Click);
            // 
            // openfile_browse_icbs
            // 
            this.openfile_browse_icbs.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scanned Transactions";
            // 
            // pnl_info
            // 
            this.pnl_info.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnl_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_info.Controls.Add(this.btn_exit);
            this.pnl_info.Controls.Add(this.label13);
            this.pnl_info.Controls.Add(this.tb_amt);
            this.pnl_info.Controls.Add(this.tb_transac_date);
            this.pnl_info.Controls.Add(this.tb_acc_num);
            this.pnl_info.Controls.Add(this.tb_acc_name);
            this.pnl_info.Controls.Add(this.label12);
            this.pnl_info.Controls.Add(this.label11);
            this.pnl_info.Controls.Add(this.label10);
            this.pnl_info.Controls.Add(this.label9);
            this.pnl_info.Location = new System.Drawing.Point(77, 137);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Size = new System.Drawing.Size(436, 369);
            this.pnl_info.TabIndex = 7;
            this.pnl_info.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_Paint_1);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(318, 266);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "OK";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(31, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(210, 22);
            this.label13.TabIndex = 8;
            this.label13.Text = "Transaction Information";
            // 
            // tb_amt
            // 
            this.tb_amt.Location = new System.Drawing.Point(152, 204);
            this.tb_amt.Name = "tb_amt";
            this.tb_amt.ReadOnly = true;
            this.tb_amt.Size = new System.Drawing.Size(241, 20);
            this.tb_amt.TabIndex = 7;
            // 
            // tb_transac_date
            // 
            this.tb_transac_date.Location = new System.Drawing.Point(152, 167);
            this.tb_transac_date.Name = "tb_transac_date";
            this.tb_transac_date.ReadOnly = true;
            this.tb_transac_date.Size = new System.Drawing.Size(241, 20);
            this.tb_transac_date.TabIndex = 6;
            // 
            // tb_acc_num
            // 
            this.tb_acc_num.Location = new System.Drawing.Point(152, 132);
            this.tb_acc_num.Name = "tb_acc_num";
            this.tb_acc_num.ReadOnly = true;
            this.tb_acc_num.Size = new System.Drawing.Size(241, 20);
            this.tb_acc_num.TabIndex = 5;
            // 
            // tb_acc_name
            // 
            this.tb_acc_name.Location = new System.Drawing.Point(152, 96);
            this.tb_acc_name.Name = "tb_acc_name";
            this.tb_acc_name.ReadOnly = true;
            this.tb_acc_name.Size = new System.Drawing.Size(241, 20);
            this.tb_acc_name.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Transaction Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(42, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Account Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Account Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Deposits",
            "Withdrawals"});
            this.comboBox1.Location = new System.Drawing.Point(423, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(385, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Filter:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 682);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "Total items:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(360, 686);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(72, 13);
            this.label27.TabIndex = 12;
            this.label27.Text = "Total amount:";
            // 
            // lbl_scan_total_items
            // 
            this.lbl_scan_total_items.AutoSize = true;
            this.lbl_scan_total_items.Location = new System.Drawing.Point(105, 682);
            this.lbl_scan_total_items.Name = "lbl_scan_total_items";
            this.lbl_scan_total_items.Size = new System.Drawing.Size(41, 13);
            this.lbl_scan_total_items.TabIndex = 13;
            this.lbl_scan_total_items.Text = "label29";
            this.lbl_scan_total_items.Visible = false;
            // 
            // lbl_scan_total_amt
            // 
            this.lbl_scan_total_amt.AutoSize = true;
            this.lbl_scan_total_amt.Location = new System.Drawing.Point(472, 686);
            this.lbl_scan_total_amt.Name = "lbl_scan_total_amt";
            this.lbl_scan_total_amt.Size = new System.Drawing.Size(41, 13);
            this.lbl_scan_total_amt.TabIndex = 14;
            this.lbl_scan_total_amt.Text = "label30";
            this.lbl_scan_total_amt.Visible = false;
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.label2);
            this.pnl_main.Controls.Add(this.label3);
            this.pnl_main.Controls.Add(this.lbl_icbs_total_amt);
            this.pnl_main.Controls.Add(this.lbl_icbs_total_items);
            this.pnl_main.Controls.Add(this.label24);
            this.pnl_main.Controls.Add(this.pnl_info_icbs);
            this.pnl_main.Controls.Add(this.comboBox2);
            this.pnl_main.Controls.Add(this.lv_icbs);
            this.pnl_main.Controls.Add(this.label8);
            this.pnl_main.Controls.Add(this.lbl_scan_total_amt);
            this.pnl_main.Controls.Add(this.lbl_scan_total_items);
            this.pnl_main.Controls.Add(this.label27);
            this.pnl_main.Controls.Add(this.label25);
            this.pnl_main.Controls.Add(this.label23);
            this.pnl_main.Controls.Add(this.comboBox1);
            this.pnl_main.Controls.Add(this.pnl_info);
            this.pnl_main.Controls.Add(this.lv_data);
            this.pnl_main.Controls.Add(this.label1);
            this.pnl_main.Location = new System.Drawing.Point(12, 27);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1216, 772);
            this.pnl_main.TabIndex = 17;
            this.pnl_main.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 686);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total items:";
            // 
            // lbl_icbs_total_amt
            // 
            this.lbl_icbs_total_amt.AutoSize = true;
            this.lbl_icbs_total_amt.Location = new System.Drawing.Point(1108, 686);
            this.lbl_icbs_total_amt.Name = "lbl_icbs_total_amt";
            this.lbl_icbs_total_amt.Size = new System.Drawing.Size(41, 13);
            this.lbl_icbs_total_amt.TabIndex = 25;
            this.lbl_icbs_total_amt.Text = "label32";
            this.lbl_icbs_total_amt.Visible = false;
            // 
            // lbl_icbs_total_items
            // 
            this.lbl_icbs_total_items.AutoSize = true;
            this.lbl_icbs_total_items.Location = new System.Drawing.Point(733, 686);
            this.lbl_icbs_total_items.Name = "lbl_icbs_total_items";
            this.lbl_icbs_total_items.Size = new System.Drawing.Size(41, 13);
            this.lbl_icbs_total_items.TabIndex = 24;
            this.lbl_icbs_total_items.Text = "label31";
            this.lbl_icbs_total_items.Visible = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(1017, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "Filter:";
            // 
            // pnl_info_icbs
            // 
            this.pnl_info_icbs.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnl_info_icbs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_info_icbs.Controls.Add(this.btn_exit_icbs);
            this.pnl_info_icbs.Controls.Add(this.label4);
            this.pnl_info_icbs.Controls.Add(this.tb_amt_icbs);
            this.pnl_info_icbs.Controls.Add(this.tb_transac_date_icbs);
            this.pnl_info_icbs.Controls.Add(this.tb_acc_num_icbs);
            this.pnl_info_icbs.Controls.Add(this.tb_acc_name_icbs);
            this.pnl_info_icbs.Controls.Add(this.label16);
            this.pnl_info_icbs.Controls.Add(this.label20);
            this.pnl_info_icbs.Controls.Add(this.label21);
            this.pnl_info_icbs.Controls.Add(this.label22);
            this.pnl_info_icbs.Location = new System.Drawing.Point(700, 143);
            this.pnl_info_icbs.Name = "pnl_info_icbs";
            this.pnl_info_icbs.Size = new System.Drawing.Size(436, 369);
            this.pnl_info_icbs.TabIndex = 21;
            this.pnl_info_icbs.Visible = false;
            this.pnl_info_icbs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_info_icbs_Paint_1);
            // 
            // btn_exit_icbs
            // 
            this.btn_exit_icbs.Location = new System.Drawing.Point(318, 266);
            this.btn_exit_icbs.Name = "btn_exit_icbs";
            this.btn_exit_icbs.Size = new System.Drawing.Size(75, 23);
            this.btn_exit_icbs.TabIndex = 9;
            this.btn_exit_icbs.Text = "OK";
            this.btn_exit_icbs.UseVisualStyleBackColor = true;
            this.btn_exit_icbs.Click += new System.EventHandler(this.btn_exit_icbs_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transaction Information";
            // 
            // tb_amt_icbs
            // 
            this.tb_amt_icbs.Location = new System.Drawing.Point(152, 204);
            this.tb_amt_icbs.Name = "tb_amt_icbs";
            this.tb_amt_icbs.ReadOnly = true;
            this.tb_amt_icbs.Size = new System.Drawing.Size(241, 20);
            this.tb_amt_icbs.TabIndex = 7;
            // 
            // tb_transac_date_icbs
            // 
            this.tb_transac_date_icbs.Location = new System.Drawing.Point(152, 167);
            this.tb_transac_date_icbs.Name = "tb_transac_date_icbs";
            this.tb_transac_date_icbs.ReadOnly = true;
            this.tb_transac_date_icbs.Size = new System.Drawing.Size(241, 20);
            this.tb_transac_date_icbs.TabIndex = 6;
            // 
            // tb_acc_num_icbs
            // 
            this.tb_acc_num_icbs.Location = new System.Drawing.Point(152, 132);
            this.tb_acc_num_icbs.Name = "tb_acc_num_icbs";
            this.tb_acc_num_icbs.ReadOnly = true;
            this.tb_acc_num_icbs.Size = new System.Drawing.Size(241, 20);
            this.tb_acc_num_icbs.TabIndex = 5;
            // 
            // tb_acc_name_icbs
            // 
            this.tb_acc_name_icbs.Location = new System.Drawing.Point(152, 96);
            this.tb_acc_name_icbs.Name = "tb_acc_name_icbs";
            this.tb_acc_name_icbs.ReadOnly = true;
            this.tb_acc_name_icbs.Size = new System.Drawing.Size(241, 20);
            this.tb_acc_name_icbs.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(40, 167);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Transaction Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(86, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Amount:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(42, 132);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Account Number:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(46, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Account Name:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All",
            "Deposits",
            "Withdrawals"});
            this.comboBox2.Location = new System.Drawing.Point(1055, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // lv_icbs
            // 
            this.lv_icbs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv_icbs.FullRowSelect = true;
            this.lv_icbs.GridLines = true;
            this.lv_icbs.Location = new System.Drawing.Point(670, 133);
            this.lv_icbs.Name = "lv_icbs";
            this.lv_icbs.Size = new System.Drawing.Size(506, 535);
            this.lv_icbs.TabIndex = 20;
            this.lv_icbs.UseCompatibleStateImageBehavior = false;
            this.lv_icbs.View = System.Windows.Forms.View.Details;
            this.lv_icbs.DoubleClick += new System.EventHandler(this.lv_icbs_DoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 38;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Transac Date";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Account Name";
            this.columnHeader3.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Account Number";
            this.columnHeader4.Width = 144;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader5.Width = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(664, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(356, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tellering Transactions (ICBS)";
            // 
            // lv_data
            // 
            this.lv_data.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.trans_date,
            this.acc_name,
            this.acc_num,
            this.amount});
            this.lv_data.FullRowSelect = true;
            this.lv_data.GridLines = true;
            this.lv_data.Location = new System.Drawing.Point(38, 129);
            this.lv_data.Name = "lv_data";
            this.lv_data.Size = new System.Drawing.Size(506, 535);
            this.lv_data.TabIndex = 6;
            this.lv_data.UseCompatibleStateImageBehavior = false;
            this.lv_data.View = System.Windows.Forms.View.Details;
            this.lv_data.DoubleClick += new System.EventHandler(this.lv_data_DoubleClick);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 38;
            // 
            // trans_date
            // 
            this.trans_date.Text = "Transac Date";
            this.trans_date.Width = 93;
            // 
            // acc_name
            // 
            this.acc_name.Text = "Account Name";
            this.acc_name.Width = 132;
            // 
            // acc_num
            // 
            this.acc_num.Text = "Account Number";
            this.acc_num.Width = 144;
            // 
            // amount
            // 
            this.amount.Text = "Amount";
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amount.Width = 95;
            // 
            // TransMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1251, 811);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TransMain";
            this.Text = "Vouching Transactions Management System";
            this.Load += new System.EventHandler(this.TransMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_info.ResumeLayout(false);
            this.pnl_info.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_info_icbs.ResumeLayout(false);
            this.pnl_info_icbs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openfile_browse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openfile_browse_icbs;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchedTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unmatchedTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromScannedTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromICBSTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewImportedRecordsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_amt;
        private System.Windows.Forms.TextBox tb_transac_date;
        private System.Windows.Forms.TextBox tb_acc_num;
        private System.Windows.Forms.TextBox tb_acc_name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lbl_scan_total_items;
        private System.Windows.Forms.Label lbl_scan_total_amt;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_icbs_total_amt;
        private System.Windows.Forms.Label lbl_icbs_total_items;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnl_info_icbs;
        private System.Windows.Forms.Button btn_exit_icbs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_amt_icbs;
        private System.Windows.Forms.TextBox tb_transac_date_icbs;
        private System.Windows.Forms.TextBox tb_acc_num_icbs;
        private System.Windows.Forms.TextBox tb_acc_name_icbs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView lv_icbs;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lv_data;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader trans_date;
        private System.Windows.Forms.ColumnHeader acc_name;
        private System.Windows.Forms.ColumnHeader acc_num;
        private System.Windows.Forms.ColumnHeader amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

