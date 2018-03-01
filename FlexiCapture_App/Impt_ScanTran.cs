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
        private void get_data(string table_name)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_data_source.Text + "; Persist Security Info=False;");
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT trans_date,acct_name,acct_num,amount,trans_code FROM [" + table_name + "] where is_import="+ false +"";
                cmd.Connection = con;
                //OleDbDataReader rdr = cmd.ExecuteReader();
                //while (rdr.Read())
                //{
                //    MessageBox.Show(rdr[0].ToString());
                //}
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
        private void mark_imported_data(string table_name,string acct_num)
        {
            string cmd = "";
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + tb_data_source.Text + "; Persist Security Info=False;");
                
                con.Open();
                if (!string.IsNullOrWhiteSpace(acct_num))
                {
                    cmd = "update [" + table_name + "] set is_import=" + true + " where acct_num='" + acct_num + "'";
                }

                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inserting(string table_name)
        {
            string date_string;
            DateTime? date_x = null;
            conString();

            try
            {
                foreach (DataGridViewRow row in dg_data_imported.Rows)
                {
                    string is_emp_date = row.Cells[0].Value.ToString();
                    if (!string.IsNullOrWhiteSpace(is_emp_date))
                    {
                        date_string = DateTime.Parse(row.Cells[0].Value.ToString()).ToString("MM/dd/yyyy");
                        date_x = DateTime.Parse(date_string);
                    }



                    con.Open();

                    String query = "INSERT INTO scanned_trans (trans_date,acct_name,acct_num,amount,trans_code) VALUES(@trans_date, @acct_name, @acct_num, @amount, @trans_code)";
                    OleDbCommand cmd = new OleDbCommand(query, con);
                    if (!string.IsNullOrWhiteSpace(is_emp_date))
                    {
                        cmd.Parameters.AddWithValue("@trans_date", date_x); // set parameterized query @a to fname parameter
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@trans_date", DBNull.Value); // set parameterized query @a to fname parameter
                    }
                    if (!string.IsNullOrWhiteSpace(row.Cells[1].Value.ToString())) {
                        cmd.Parameters.AddWithValue("@acct_name", row.Cells[1].Value.ToString()); // set parameterized query @b to mname parameter
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@acct_name", DBNull.Value); // set parameterized query @b to mname parameter
                    }
                    cmd.Parameters.AddWithValue("@acct_num", row.Cells[2].Value.ToString());
                    if (!string.IsNullOrWhiteSpace(row.Cells[3].Value.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@amount", double.Parse(row.Cells[3].Value.ToString()));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@amount", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@trans_code", row.Cells[4].Value.ToString());
                    if (table_name == "depo_slip")
                    {
                        mark_imported_data("depo_slip", row.Cells[2].Value.ToString());
                    }
                    else
                    {
                        mark_imported_data("with_slip", row.Cells[2].Value.ToString());
                    }

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                
            }
            catch
            {
                //MessageBox.Show(e.Message);
            }
            if (table_name == "depo_slip")
            {
                MessageBox.Show("Import Successfully", "Import Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        
        //private void import_from_flexiCapture()
        //{
        //    try
        //    {
        //        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
        //        con.Open();

        //        string query = "INSERT INTO scanned_trans(date,acct_name,acct_num,amount) SELECT date,acct_name,acct_num,amount from" + tb_data_source.Text + "." + tb_table_name + "";

        //        using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
        //        {
        //            sqlCeCommand.ExecuteNonQuery();
        //            MessageBox.Show("Import Successfully");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}

        private void openfile_browse_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb_data_source.Text))
            {
                //import_from_flexiCapture();
                get_data("depo_slip");
                inserting("depo_slip");
                get_data("with_slip");
                inserting("with_slip");
                if (chk_view_imp_data.Checked == true)
                {
                    View_Imported vi = new View_Imported();
                    vi.Show();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Please insert Location.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
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
