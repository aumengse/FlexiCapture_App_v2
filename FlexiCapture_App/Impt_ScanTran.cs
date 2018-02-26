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

namespace FlexiCapture_App
{
    public partial class Impt_ScanTran : Form
    {
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;

        public Impt_ScanTran()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }



        private void Impt_ScanTran_Load(object sender, EventArgs e)
        {
           
        }

        private void get_data()
        {
            try
            {
                conString();
                String query = "SELECT * FROM [" + tb_table_name.Text + "]";
                OleDbCommand cmd = new OleDbCommand(query, con);
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
            string date_string, acct_name, acct_num, amount;
            DateTime date_xx;
            conString();
           
            try
            { 
                foreach (DataGridViewRow row in dg_data_imported.Rows)
                {
                    date_string = DateTime.Parse(row.Cells[1].Value.ToString()).ToString("MM/dd/yyyy");
                    date_xx = DateTime.Parse(date_string);
                    acct_name = row.Cells[2].Value.ToString();
                    acct_num = row.Cells[3].Value.ToString();
                    amount = row.Cells[4].Value.ToString();
                    

                    con.Open();
                    String query = "INSERT INTO scanned_trans(trans_date,acct_name,acct_num,amount) VALUES ('" + date_string + "','" + acct_name + "','"+ acct_num + "','" + amount + "');";

                    OleDbCommand cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show("Import Successfully");
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         }


        /*private void import_from_flexiCapture()
        {
            try
            {
                conString();
                con.Open();

                string query = "INSERT INTO scanned_trans(date,acct_name,acct_num,amount) SELECT date,acct_name,acct_num,amount from"+ tb_data_source.Text+"."+tb_table_name+"";

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

        }*/

      

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //import_from_flexiCapture();
            get_data();
            inserting();
            //this.Close();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile_browse_icbs = new OpenFileDialog();

            openfile_browse_icbs.InitialDirectory = @"C:\";
            openfile_browse_icbs.Title = "Browse Database";

            openfile_browse_icbs.CheckFileExists = true;
            openfile_browse_icbs.CheckPathExists = true;

            openfile_browse_icbs.DefaultExt = "accdb";
            openfile_browse_icbs.Filter = "Access files (*.accdb)|*.accdb";
            openfile_browse_icbs.FilterIndex = 2;
            openfile_browse_icbs.RestoreDirectory = true;


            openfile_browse_icbs.ReadOnlyChecked = true;
            openfile_browse_icbs.ShowReadOnly = true;


            if (openfile_browse_icbs.ShowDialog() == DialogResult.OK)

            {
                tb_data_source.Text = openfile_browse_icbs.FileName;
            }
        }
    }
}
