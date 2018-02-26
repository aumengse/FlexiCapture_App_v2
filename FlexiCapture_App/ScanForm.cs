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
using System.Threading;

namespace FlexiCapture_App
{
    public partial class ScanForm : Form
    {
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;
        public ScanForm()
        {
            InitializeComponent();

        }

        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }

        private void load_progressbar()
        {
            progress_Bar.Minimum = 0;
            progress_Bar.Maximum = 101;
            for (int i = 0; i <= 100; i++)
            {
                progress_Bar.Value = i;
                Thread.Sleep(20);

                if (i == 100)
                {
                    get_data_icbs();
                    matching_ICBS();
                    get_data_scanned();
                    matching_scanned();
                }
            }

        }



        private void ScanForm_Load(object sender, EventArgs e)
        {
            this.Show();
            this.CenterToScreen();

            load_progressbar();



        }

        private void yes()
        {

            conString();

            try
            {
                foreach (DataGridViewRow row in dg_scanned_trans.Rows)
                {
                    DateTime trans_date = DateTime.Parse(row.Cells[1].Value.ToString());

                    //  MessageBox.Show(cc.ToString());
                    con.Open();
                    string cmd = "SELECT StrComp(acct_name," + row.Cells[2].Value.ToString() + ",0) ";
                    {

                        OleDbCommand command = new OleDbCommand(cmd, con);
                        OleDbDataReader rdr = command.ExecuteReader();
                        rdr.Read();
                        MessageBox.Show(rdr.GetValue(0).ToString());


                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {

            }
        }


        private void matching_ICBS()
        {
            int row_id;
            conString();

            try
            {

                foreach (DataGridViewRow row in dg_icbs_trans.Rows)
                {
                    
                    con.Open();
                    string cmd = "SELECT id,trans_date,acct_name FROM [icbs_trans] where [trans_date] =#" + DateTime.Parse(row.Cells[1].Value.ToString()) + "# and [acct_name] ='" + row.Cells[2].Value.ToString() + "'" +
                                                             "and [acct_num] =" + int.Parse(row.Cells[3].Value.ToString()) + " and [amount] = " + Double.Parse(row.Cells[4].Value.ToString()) + "";
                    {
                        OleDbCommand command = new OleDbCommand(cmd, con);
                        OleDbDataReader rdr = command.ExecuteReader();
                        rdr.Read();
                        if (rdr.HasRows)
                        {
                            row_id = Convert.ToInt16(rdr.GetValue(0).ToString());
                            con.Close();

                            con.Open();
                            string nw_cmd = "UPDATE [icbs_trans] SET match_code='R' where id=" + row_id + "";
                            {

                                OleDbCommand nw_command = new OleDbCommand(nw_cmd, con);
                                OleDbDataReader nw_rdr = nw_command.ExecuteReader();
                                nw_rdr.Read();
                                //MessageBox.Show("Updated");

                            }
                            con.Close();
                            con.Open();
                            string nw_cmd2 = "UPDATE [scanned_trans] SET match_code='R' where id=" + row_id + "";
                            {

                                OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                                OleDbDataReader nw_rdr2 = nw_command2.ExecuteReader();
                                nw_rdr2.Read();
                                //MessageBox.Show("SCAN Updated");

                            }
                            con.Close();
                        }

                        else
                        {
                            con.Close();
                            con.Open();
                            string nw_cmd1 = "UPDATE [icbs_trans] SET match_code='U' where id=" + int.Parse(row.Cells[0].Value.ToString()) + "";
                            {

                                OleDbCommand nw_command1 = new OleDbCommand(nw_cmd1, con);
                                OleDbDataReader nw_rdr1 = nw_command1.ExecuteReader();
                                nw_rdr1.Read();
                                //MessageBox.Show("SCAN Unmatched Updated");

                            }
                            con.Close();
                            con.Open();
                            string nw_cmd2 = "UPDATE [scanned_trans] SET match_code='U' where id=" + int.Parse(row.Cells[0].Value.ToString()) + "";
                            {

                                OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                                OleDbDataReader nw_rdr2 = nw_command2.ExecuteReader();
                                nw_rdr2.Read();
                                //MessageBox.Show("ICBS Unmatched Updated");

                            }
                            con.Close();

                        }
                        con.Close();

                    }
                    MessageBox.Show("MATCHING ICBS DONE");
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }

        private void matching_scanned()
        {
            int row_id;
            conString();

            try
            {

                foreach (DataGridViewRow row in dg_scanned_trans.Rows)
                {

                    con.Open();
                    string cmd = "SELECT id,trans_date,acct_name FROM [scanned_trans] where [trans_date] =#" + DateTime.Parse(row.Cells[1].Value.ToString()) + "# and [acct_name] ='" + row.Cells[2].Value.ToString() + "'" +
                                                             "and [acct_num] =" + int.Parse(row.Cells[3].Value.ToString()) + " and [amount] = " + Double.Parse(row.Cells[4].Value.ToString()) + "";
                    {
                        OleDbCommand command = new OleDbCommand(cmd, con);
                        OleDbDataReader rdr = command.ExecuteReader();
                        rdr.Read();
                        if (rdr.HasRows)
                        {
                            row_id = Convert.ToInt16(rdr.GetValue(0).ToString());
                            con.Close();

                            con.Open();
                            string nw_cmd = "UPDATE [scanned_trans] SET match_code='R' where id=" + row_id + "";
                            {

                                OleDbCommand nw_command = new OleDbCommand(nw_cmd, con);
                                OleDbDataReader nw_rdr = nw_command.ExecuteReader();
                                nw_rdr.Read();
                                //MessageBox.Show("Updated");

                            }
                            con.Close();
                            con.Open();
                            string nw_cmd2 = "UPDATE [icbs_trans] SET match_code='R' where id=" + row_id + "";
                            {

                                OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                                OleDbDataReader nw_rdr2 = nw_command2.ExecuteReader();
                                nw_rdr2.Read();
                                //MessageBox.Show("SCAN Updated");

                            }
                            con.Close();
                        }

                        else
                        {
                            con.Close();
                            con.Open();
                            string nw_cmd1 = "UPDATE [scanned_trans] SET match_code='U' where id=" + int.Parse(row.Cells[0].Value.ToString()) + "";
                            {

                                OleDbCommand nw_command1 = new OleDbCommand(nw_cmd1, con);
                                OleDbDataReader nw_rdr1 = nw_command1.ExecuteReader();
                                nw_rdr1.Read();
                                //MessageBox.Show("SCAN Unmatched Updated");

                            }
                            con.Close();
                            con.Open();
                            string nw_cmd2 = "UPDATE [icbs_trans] SET match_code='U' where id=" + int.Parse(row.Cells[0].Value.ToString()) + "";
                            {

                                OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                                OleDbDataReader nw_rdr2 = nw_command2.ExecuteReader();
                                nw_rdr2.Read();
                                //MessageBox.Show("ICBS Unmatched Updated");

                            }
                            con.Close();

                        }
                        con.Close();

                    }
                    MessageBox.Show("MATCHING SCANNED DONE");
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }


        private void get_data_scanned()
        {
            try
            {
                conString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT id,trans_date,acct_name,acct_num,amount FROM scanned_trans";
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dg_scanned_trans.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void get_data_icbs()
        {
            try
            {
                conString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT id,trans_date,acct_name,acct_num,amount FROM icbs_trans";
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dg_icbs_trans.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_data_scanned();
            get_data_icbs();
        }
    }
}
