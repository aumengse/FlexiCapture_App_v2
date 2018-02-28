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
                    matching_trans();
                    
                }
            }

        }



        private void ScanForm_Load(object sender, EventArgs e)
        {
            this.Show();
            this.CenterToScreen();

            load_progressbar();
        }

        private void matching_trans()
        {
            matching_ICBS();
            matching_SCAN();
            unmatching_SCAN();
            unmatching_ICBS();
            MessageBox.Show("Scan Complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        
        private void matching_ICBS()
        {
            conString();
            int i;
            try
            {
                
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText  = "SELECT icbs_trans.id FROM icbs_trans INNER JOIN scanned_trans ON(icbs_trans.trans_code = scanned_trans.trans_code) " +
                                "AND(icbs_trans.amount = scanned_trans.amount) AND(icbs_trans.acct_num = scanned_trans.acct_num) AND(icbs_trans.acct_name = scanned_trans.acct_name) AND(icbs_trans.trans_date = scanned_trans.trans_date);";
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();

                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        con.Open();
                        string nw_cmd = "UPDATE [icbs_trans] SET match_code='R' where id=" + dr["id"] + "";
                        {

                            OleDbCommand nw_command = new OleDbCommand(nw_cmd, con);
                            nw_command.ExecuteNonQuery();
                            //MessageBox.Show("ICBS MATCHED Updated");

                        }
                        con.Close();
                        //MessageBox.Show(dr["id"].ToString());

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void matching_SCAN()
        {
            conString();
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT scanned_trans.ID FROM icbs_trans INNER JOIN scanned_trans ON(icbs_trans.trans_code = scanned_trans.trans_code) AND(icbs_trans.amount = scanned_trans.amount) " +
                                   "AND(icbs_trans.acct_num = scanned_trans.acct_num) AND(icbs_trans.acct_name = scanned_trans.acct_name) AND(icbs_trans.trans_date = scanned_trans.trans_date);";
                cmd.Connection = con;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();

                foreach (DataTable dt in ds.Tables)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        con.Open();
                        string nw_cmd = "UPDATE [scanned_trans] SET match_code='R' where id=" + dr["id"] + "";
                        {

                            OleDbCommand nw_command = new OleDbCommand(nw_cmd, con);
                            nw_command.ExecuteNonQuery();
                            //MessageBox.Show("SCAN MATCHED Updated");

                        }
                        con.Close();
                        //MessageBox.Show(dr["id"].ToString());

                    }
                }
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void unmatching_ICBS()
        {
            conString();
            int e;
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT DISTINCT id FROM icbs_trans WHERE NOT EXISTS(SELECT  id FROM scanned_trans WHERE icbs_trans.trans_date = scanned_trans.trans_date and icbs_trans.acct_name = scanned_trans.acct_name and icbs_trans.amount = scanned_trans.amount " +
                                    "and icbs_trans.acct_num = scanned_trans.acct_num and icbs_trans.trans_code = scanned_trans.trans_code);";
                cmd.Connection = con;
                OleDbDataAdapter dau = new OleDbDataAdapter(cmd);
                DataSet dsu = new DataSet();
                dau.Fill(dsu);
                con.Close();

                foreach (DataTable dtu in dsu.Tables)
                {
                    foreach (DataRow dru in dtu.Rows)
                    {
                        
                        con.Open();
                        string nw_cmd2 = "UPDATE [icbs_trans] SET match_code='U' where id=" + dru["id"] + "";
                        {

                            OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                            nw_command2.ExecuteNonQuery();
                            //MessageBox.Show("ICBS UNMATCHED Updated");

                        }
                        con.Close();
                        //MessageBox.Show(dru["id"].ToString());

                    }
                }
            }
            catch (Exception xx)
            {
                //MessageBox.Show(xx.Message);
            }
        }

        private void unmatching_SCAN()
        {
            conString();
            int e;
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "SELECT DISTINCT id FROM scanned_trans WHERE NOT EXISTS(SELECT  id FROM icbs_trans WHERE scanned_trans.trans_date = icbs_trans.trans_date and scanned_trans.acct_name = icbs_trans.acct_name " +
                                    "and scanned_trans.acct_num = icbs_trans.acct_num  and scanned_trans.amount = icbs_trans.amount and scanned_trans.trans_code = icbs_trans.trans_code);";
                cmd.Connection = con;
                OleDbDataAdapter dau = new OleDbDataAdapter(cmd);
                DataSet dsu = new DataSet();
                dau.Fill(dsu);
                con.Close();

                foreach (DataTable dtu in dsu.Tables)
                {
                    foreach (DataRow dru in dtu.Rows)
                    {

                        con.Open();
                        string nw_cmd2 = "UPDATE [scanned_trans] SET match_code='U' where id=" + dru["id"] + "";
                        {

                            OleDbCommand nw_command2 = new OleDbCommand(nw_cmd2, con);
                            nw_command2.ExecuteNonQuery();
                            //MessageBox.Show("SCAN UNMATCHED Updated");

                        }
                        con.Close();
                        //MessageBox.Show(dru["id"].ToString());

                    }
                }
            }
            catch (Exception xx)
            {
                //MessageBox.Show(xx.Message);
            }
        }











    }
}
