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
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Account_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unmatched_Scanned_Records = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Unmatched_Icbs_Records
            // 
            this.Unmatched_Icbs_Records.CheckBoxes = true;
            this.Unmatched_Icbs_Records.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Check,
            this.Date,
            this.Account_Name,
            this.Account_Number,
            this.Amount});
            this.Unmatched_Icbs_Records.FullRowSelect = true;
            this.Unmatched_Icbs_Records.Location = new System.Drawing.Point(9, 18);
            this.Unmatched_Icbs_Records.Name = "Unmatched_Icbs_Records";
            this.Unmatched_Icbs_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Icbs_Records.TabIndex = 3;
            this.Unmatched_Icbs_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Icbs_Records.View = System.Windows.Forms.View.Details;
            this.Unmatched_Icbs_Records.SelectedIndexChanged += new System.EventHandler(this.Unmatched_Icbs_Records_SelectedIndexChanged);
            // 
            // Check
            // 
            this.Check.Text = "Check";
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
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.Unmatched_Scanned_Records.FullRowSelect = true;
            this.Unmatched_Scanned_Records.Location = new System.Drawing.Point(6, 17);
            this.Unmatched_Scanned_Records.Name = "Unmatched_Scanned_Records";
            this.Unmatched_Scanned_Records.Size = new System.Drawing.Size(584, 401);
            this.Unmatched_Scanned_Records.TabIndex = 4;
            this.Unmatched_Scanned_Records.UseCompatibleStateImageBehavior = false;
            this.Unmatched_Scanned_Records.View = System.Windows.Forms.View.Details;
            this.Unmatched_Scanned_Records.SelectedIndexChanged += new System.EventHandler(this.Unmatched_Trans_Records_SelectedIndexChanged);
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
            this.button1.Location = new System.Drawing.Point(585, 448);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 430);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ICBS Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Unmatched_Scanned_Records);
            this.groupBox2.Location = new System.Drawing.Point(636, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 430);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scanned Data";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Check";
            // 
            // Unmatched_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 488);
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
    }
}