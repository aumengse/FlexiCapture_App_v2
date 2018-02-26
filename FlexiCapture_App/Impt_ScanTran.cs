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
    public partial class Impt_ScanTran : Form
    {
        private OleDbConnection con; //Initialize OleDBConnection
        private Conf.conf dbcon;
        public Impt_ScanTran()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        private void Impt_ScanTran_Load(object sender, EventArgs e)
        {

        }
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }
        private void get_data()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_data_source.Text + "; Persist Security Info=False;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT trans_date,acct_name,acct_num,amount FROM [" + tb_table_name.Text + "]";
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dg_data_imported.DataSource = ds.Tables[0];




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inserting()
        {
            string date_string , acct_name, acct_num, amount;
            DateTime date_x;
            conString();

            try
            {
                foreach (DataGridViewRow row in dg_data_imported.Rows)
                {
                    
                    date_string = DateTime.Parse(row.Cells[0].Value.ToString()).ToString("MM/dd/yyyy");
                    date_x = DateTime.Parse(date_string);
                   

                    con.Open();

                    String query = "INSERT INTO scanned_trans (trans_date,acct_name,acct_num,amount) VALUES(@trans_date, @acct_name, @acct_num, @amount)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@trans_date", date_x ); // set parameterized query @a to fname parameter
                    cmd.Parameters.AddWithValue("@acct_name", row.Cells[1].Value.ToString()); // set parameterized query @b to mname parameter
                    cmd.Parameters.AddWithValue("@acct_num", double.Parse(row.Cells[2].Value.ToString()));
                    cmd.Parameters.AddWithValue("@amount", double.Parse(row.Cells[3].Value.ToString()));
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch
            {
                //MessageBox.Show(e.Message);
            }
            MessageBox.Show("Import Successfully");

        }




        private void import_from_flexiCapture()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();

                string query = "INSERT INTO scanned_trans(date,acct_name,acct_num,amount) SELECT date,acct_name,acct_num,amount from" + tb_data_source.Text + "." + tb_table_name + "";

                using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
                {
                    sqlCeCommand.ExecuteNonQuery();
                    MessageBox.Show("Import Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void openfile_browse_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //import_from_flexiCapture();
            get_data();
            inserting();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_browse_icbs = new OpenFileDialog();

            openfile_browse.InitialDirectory = @"C:\";
            openfile_browse_icbs.Title = "Browse Database";

            openfile_browse.CheckFileExists = true;
            openfile_browse_icbs.CheckPathExists = true;

            openfile_browse.DefaultExt = "accdb";
            openfile_browse.Filter = "Access files (*.accdb)|*.accdb";
            openfile_browse.FilterIndex = 2;
            openfile_browse.RestoreDirectory = true;


            openfile_browse.ReadOnlyChecked = true;
            openfile_browse.ShowReadOnly = true;


            if (openfile_browse.ShowDialog() == DialogResult.OK)

            {
                tb_data_source.Text = openfile_browse.FileName;
            }
        }
    }
}
