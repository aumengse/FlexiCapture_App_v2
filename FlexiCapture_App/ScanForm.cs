using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;


namespace FlexiCapture_App
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();

        }
        private void load_progressbar()
        {
            progress_Bar.Minimum = 0;
            progress_Bar.Maximum = 100;
            for (int i = 0; i < 100; i++)
            {
                progress_Bar.Value = i;
                Thread.Sleep(20);
            }
        }



        private void ScanForm_Load(object sender, EventArgs e)
        {
            this.Show();
            this.CenterToScreen();
            load_progressbar();
        }

        private void matching_ICBS()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
            con.Open();

            string query = "SELECT ICBS_Trans.ID, ICBS_Trans.date, ICBS_Trans.acct_name, ICBS_Trans.acct_num, Scanned_Trans.amount FROM ICBS_Trans INNER JOIN Scanned_Trans ON(ICBS_Trans.amount = Scanned_Trans.amount) AND(ICBS_Trans.acct_num = Scanned_Trans.acct_num) AND(ICBS_Trans.acct_name = Scanned_Trans.acct_name) AND(ICBS_Trans.date = Scanned_Trans.date)";
          
            {
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader rdr = command.ExecuteReader();
                if (rdr.HasRows)
                {

                    MessageBox.Show("Has Rows_I");
                }
                else
                {
                    MessageBox.Show("No Rows_I");
                }

            }

        }

        private void matching_Scanned()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
            con.Open();

            string query = "SELECT Scanned_Trans.date, Scanned_Trans.acct_name, Scanned_Trans.acct_num, Scanned_Trans.amount FROM ICBS_Trans INNER JOIN Scanned_Trans ON(ICBS_Trans.amount = Scanned_Trans.amount) AND(ICBS_Trans.acct_num = Scanned_Trans.acct_num) AND(ICBS_Trans.acct_name = Scanned_Trans.acct_name) AND(ICBS_Trans.date = Scanned_Trans.date)";

            {
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader rdr = command.ExecuteReader();
                if (rdr.HasRows)
                {

                    MessageBox.Show("Has Rows_S");
                }
                else
                {
                    MessageBox.Show("No Rows_I");
                }

            }

        }

        private void match_loop()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            matching_Scanned();
            matching_ICBS();
        }
    }
}
