using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Threading;
using System.IO;

namespace FlexiCapture_App
{
    public partial class Impt_ICBSTran : Form
    {
        private OleDbConnection con; //Initialize OleDBConnection
        private Conf.conf dbcon; //Initialize Conf.dbs dbcon class where the target Connection String is resided

        public Impt_ICBSTran()
        {
            InitializeComponent();
        }

        private void Impt_ICBSTran_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private string ReadFromFile(string FilePath)
        {
            string readText = File.ReadAllText(FilePath);
            return readText;
        }

       
        private void btn_browse_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                tb_textfile.Text = fdlg.FileName;
            }
        }

        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_textfile.Text))
            {
                MessageBox.Show("Please select a file First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conString();
                DateTime date;
                string[] lines = File.ReadAllLines(tb_textfile.Text);

                try
                {
                    foreach (string line in lines) //read all records
                    {
                        string[] col = line.Split(new char[] { ',' });
                        string date_string = DateTime.Parse(col[1]).ToString("MM/dd/yyyy");
                        date = DateTime.Parse(date_string);

                        con.Open();
                        //string query = "INSERT INTO scanned_trans(date,acct_name,acct_num,amount) VALUES ('" + thisDay + "','" + acct_name + "','" + acct_num + "','" + amount + "');";
                        String query = "INSERT INTO icbs_trans (trans_code,trans_date,acct_name,acct_num,amount) VALUES(@code, @date, @acct_name, @acct_num, @amount)";
                        OleDbCommand cmd = new OleDbCommand(query, con);
                        cmd.Parameters.AddWithValue("@code", col[0]);
                        cmd.Parameters.AddWithValue("@date", date); // set parameterized query @a to fname parameter
                        cmd.Parameters.AddWithValue("@acct_name", col[2]); // set parameterized query @b to mname parameter
                        cmd.Parameters.AddWithValue("@acct_num", col[3]);
                        cmd.Parameters.AddWithValue("@amount", col[4]);
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Import Successfully");
                this.Close();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_textfile.Text))
            {
                MessageBox.Show("Please select a file First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] lines = File.ReadAllLines(tb_textfile.Text);
                view_ICBStrans viewall = new view_ICBStrans(lines);
                viewall.Show();
            }
        }
    }
}
