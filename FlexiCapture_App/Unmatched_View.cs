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

namespace FlexiCapture_App
{
    public partial class Unmatched_View : Form
    {

        public static string acct_name = "";
        int total_amount = 0;
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }
        public Unmatched_View()
        {
            InitializeComponent();
        }

        private void Unmatched_Icbs_Records_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Unmatched_Trans_Records_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Unmatched_Data ud = new Unmatched_Data();
                ud.txt_icbs_acct_name.Text = Unmatched_Icbs_Records.CheckedItems[0].SubItems[2].Text;
                ud.txt_icbs_acct_num.Text = Unmatched_Icbs_Records.CheckedItems[0].SubItems[3].Text;
                ud.txt_icbs_date.Text = Unmatched_Icbs_Records.CheckedItems[0].SubItems[1].Text;
                ud.txt_icbs_amount.Text = Unmatched_Icbs_Records.CheckedItems[0].SubItems[4].Text;
                ud.txt_scan_acct_name.Text = Unmatched_Scanned_Records.CheckedItems[0].SubItems[2].Text;
                ud.txt_scan_acct_num.Text = Unmatched_Scanned_Records.CheckedItems[0].SubItems[3].Text;
                ud.txt_scan_date.Text = Unmatched_Scanned_Records.CheckedItems[0].SubItems[1].Text;
                ud.txt_scan_amount.Text = Unmatched_Scanned_Records.CheckedItems[0].SubItems[4].Text;
                ud.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Please Select Record To Verify","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void unmatched_icbs_view()
        {
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                conString();
                con.Open();
                string cmd = "SELECT * FROM icbs_trans where match_code = 'U'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    Unmatched_Icbs_Records.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem();
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            Unmatched_Icbs_Records.Items.Add(aa);
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
        private void unmatched_trans_view()
        {
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                conString();
                con.Open();
                string cmd = "SELECT * FROM scanned_trans where match_code = 'U'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    Unmatched_Scanned_Records.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem();
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            Unmatched_Scanned_Records.Items.Add(aa);
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
        private static string amount_sum(string table_name)
        {
            string amount = "";
            OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
            Conf.conf dbcon;
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();

            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                //conString();
                con.Open();
                string cmd = "SELECT sum(amount) FROM " + table_name + " where match_code = 'U'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    {
                        amount = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return amount;
        }
        private static string items_counter(string table_name)
        {
            string items = "";
            OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
            Conf.conf dbcon;
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                //conString();
                con.Open();
                string cmd = "SELECT COUNT(acct_name) FROM " + table_name +" where match_code = 'U'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    rdr.Read();
                    items = rdr.GetValue(0).ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return items;
        }
        private void Unmatched_View_Load(object sender, EventArgs e)
        {
            string icbs_items = items_counter("icbs_trans");
            string icbs_sum = amount_sum("icbs_trans");
            lbl_icbs_value_items.Text = icbs_items;
            lbl_icbs_total_amount.Text = icbs_sum;

            string scan_items = items_counter("scanned_trans");
            string scan_sum = amount_sum("scanned_trans");
            lbl_scan_value_items.Text = scan_items;
            lbl_scan_total_amount.Text = scan_sum;

            unmatched_icbs_view();
            unmatched_trans_view();
            Unmatched_Icbs_Records.Refresh();
        }
    }
}
