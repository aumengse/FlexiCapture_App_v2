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
    public partial class View_Imported : Form
    {
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;

        public View_Imported()
        {
            InitializeComponent();
        }

        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }


        private void View_Imported_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            load_scan();
            load_icbs();
            count_items();
            count_breakdown();
            sum_amount();
            sum_breakdown();
        }


        private void load_scan()
        {
            try
            {
                conString();
                con.Open();
                string cmd = "SELECT * FROM [scanned_trans] where match_code is Null;";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_scanned.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(5).ToString());
                            if (!string.IsNullOrWhiteSpace(rdr.GetValue(1).ToString()))
                            {
                                aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            }
                            else
                            {
                                aa.SubItems.Add("");

                            }
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            lv_scanned.Items.Add(aa);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);

            }
        }
        private void load_icbs()
        {
            try
            {
                conString();
                con.Open();
                string cmd = "SELECT * FROM [icbs_trans] where match_code is Null;";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_icbs.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(5).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            lv_icbs.Items.Add(aa);
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void filtering_data(string table_name, string tran_code)
        {
            try
            {
                conString();
                con.Open();
                string cmd = "SELECT * FROM " + table_name + " where trans_code = '" + tran_code + "'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    if (table_name == "icbs_trans")
                    {
                        lv_icbs.Items.Clear();
                    }
                    else
                    {
                        lv_scanned.Items.Clear();
                    }
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(5).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));

                            if (table_name == "icbs_trans")
                            {
                                lv_icbs.Items.Add(aa);
                            }
                            else
                            {
                                lv_scanned.Items.Add(aa);
                            }
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void count_items()
        {
            conString();
            try
            {
                con.Open();
                string cmd = "SELECT COUNT(id) from scanned_trans where match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_total_items.Text = rdr.GetValue(0).ToString();

                }
                con.Close();

                con.Open();
                string query = "SELECT COUNT(id) from icbs_trans where match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(query, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_total_items.Text = rdr.GetValue(0).ToString();

                }
                con.Close();
            }
            catch
            {
                
            }

        }

        private void count_breakdown()
        {
            try
            {
                con.Open();
                string scan_depo_count = "SELECT COUNT(id) from scanned_trans where trans_code='DEPO' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(scan_depo_count, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_depo_count.Text = rdr.GetValue(0).ToString();

                }
                con.Close();
                con.Open();
                string scan_wdl_count = "SELECT COUNT(id) from scanned_trans where trans_code='WDL' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(scan_wdl_count, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_wdl_count.Text = rdr.GetValue(0).ToString();

                }
                con.Close();

                con.Open();
                string icbs_depo_count = "SELECT COUNT(id) from icbs_trans where trans_code='DEPO' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(icbs_depo_count, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_depo_count.Text = rdr.GetValue(0).ToString();

                }
                con.Close();

                con.Open();
                string icbs_wdl_count = "SELECT COUNT(id) from icbs_trans where trans_code='WDL' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(icbs_wdl_count, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_wdl_count.Text = rdr.GetValue(0).ToString();

                }
                con.Close();
            }
            catch
            {

            }
        }

        private void sum_amount()
        {
            conString();

            try
            {
                con.Open();
                string cmd = "SELECT SUM(amount) from scanned_trans where match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_total_amt.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();

                con.Open();
                string query = "SELECT SUM(amount) from icbs_trans where match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(query, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_total_amt.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("No Results found");

            }


        }

        private void sum_breakdown()
        {
            try
            {
                con.Open();
                string scan_depo = "SELECT SUM(amount) from scanned_trans where trans_code='DEPO' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(scan_depo, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_total_depo.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();

                con.Open();
                string icbs_depo = "SELECT SUM(amount) from icbs_trans where trans_code='DEPO' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(icbs_depo, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_total_depo.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();

                con.Open();
                string scan_wdl = "SELECT SUM(amount) from scanned_trans where trans_code='WDL' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(scan_wdl, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_scan_total_depo.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();

                con.Open();
                string icbs_wdl = "SELECT SUM(amount) from icbs_trans where trans_code='WDL' and match_code is Null";
                {
                    OleDbCommand command = new OleDbCommand(icbs_wdl, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    lbl_icbs_total_depo.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

                }
                con.Close();

            }
            catch
            {

            }

        }



        private void pnl_scanned_Paint(object sender, PaintEventArgs e)
        {
            if (lv_scanned.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_scanned.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                tb_acc_name.Text = lv_scanned.SelectedItems[0].SubItems[2].Text;
                tb_acc_num.Text = lv_scanned.SelectedItems[0].SubItems[3].Text;
                tb_transac_date.Text = lv_scanned.SelectedItems[0].SubItems[1].Text;
                tb_amt.Text = String.Format("{0:n}", Double.Parse(lv_scanned.SelectedItems[0].SubItems[4].Text));
            }
        }

        private void pnl_icbs_Paint(object sender, PaintEventArgs e)
        {
            if (lv_icbs.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_icbs.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                tb_acc_name_icbs.Text = lv_icbs.SelectedItems[0].SubItems[2].Text;
                tb_acc_num_icbs.Text = lv_icbs.SelectedItems[0].SubItems[3].Text;
                tb_transac_date_icbs.Text = lv_icbs.SelectedItems[0].SubItems[1].Text;
                tb_amt_icbs.Text = String.Format("{0:n}", Double.Parse(lv_icbs.SelectedItems[0].SubItems[4].Text));
            }
        }

        private void lv_data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnl_scanned.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            pnl_scanned.Hide();
        }

        private void lv_icbs_DoubleClick(object sender, EventArgs e)
        {
            pnl_icbs.Show();
        }

        private void btn_exit_icbs_Click(object sender, EventArgs e)
        {
            pnl_icbs.Hide();
        }

        private void cmb_scan_trans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_scan_trans.Text == "Deposits")
            {
                filtering_data("scanned_trans", "DEPO");
            }
            else if (cmb_scan_trans.Text == "Withdrawals")
            {
                filtering_data("scanned_trans", "WDL");
            }
            else
            {

            }
        }

        private void cmb_icbs_trans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_icbs_trans.Text == "Deposits")
            {
                filtering_data("icbs_trans", "DEPO");
            }
            else if (cmb_icbs_trans.Text == "Withdrawals")
            {
                filtering_data("icbs_trans", "WDL");
            }
            else
            {

            }
        }
    }
}
