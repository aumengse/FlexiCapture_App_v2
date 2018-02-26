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
    public partial class Matched : Form
    {
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;
        public Matched()
        {
            InitializeComponent();
        }
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }
        private void matched_listview_view(string table_name, string op, string match_code_value)
        {
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                conString();
                con.Open();
                string cmd = "SELECT * FROM " + table_name + " where match_code "+ op +" '"+ match_code_value +"'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    if (table_name == "icbs_trans")
                    {
                        Matched_Icbs_Records.Items.Clear();
                    }
                    else
                    {
                        Matched_Trans_Records.Items.Clear();
                    }
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem();
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            if (table_name == "icbs_trans")
                            {
                                Matched_Icbs_Records.Items.Add(aa);
                            }
                            else
                            {
                                Matched_Trans_Records.Items.Add(aa);
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
                string cmd = "SELECT sum(amount) FROM " + table_name + " where match_code <> 'U'";
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
                //Matched.conString();
                con.Open();
                string cmd = "SELECT COUNT(acct_name) FROM " + table_name + " where match_code <> 'U'";
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
        private void Matched_Load(object sender, EventArgs e)
        {
            matched_listview_view("icbs_trans","<>","U");
            matched_listview_view("scanned_trans","<>","U");
            if (Matched_Icbs_Records.Items.Count > 0)
            {
                string icbs_items = items_counter("icbs_trans");
                string icbs_sum = amount_sum("icbs_trans");
                lbl_icbs_value_items.Text = icbs_items;
                lbl_icbs_total_amount.Text = icbs_sum;
            }

            if (Matched_Trans_Records.Items.Count > 0)
            {
                string scan_items = items_counter("scanned_trans");
                string scan_sum = amount_sum("scanned_trans");
                lbl_scan_value_items.Text = scan_items;
                lbl_scan_total_amount.Text = scan_sum;
            }

        }
        private void undo_force_match(string table_name,string acct_num)
        {

            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                conString();
                con.Open();

                string cmd = "update "+ table_name +" set match_code='U', match_ref = Null, remarks = Null where acct_num=" + acct_num + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();
                if (table_name == "icbs_trans")
                {
                    MessageBox.Show("Undo Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string icbs_acct_num = Matched_Icbs_Records.CheckedItems[0].SubItems[3].Text;
            string scan_acct_num = Matched_Trans_Records.CheckedItems[0].SubItems[3].Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Undo this Data? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                undo_force_match("icbs_trans", icbs_acct_num);
                undo_force_match("scanned_trans", scan_acct_num);
                
                matched_listview_view("icbs_trans","<>","U");
                matched_listview_view("scanned_trans","<>","U");

                if (Matched_Icbs_Records.Items.Count > 0)
                {
                    string icbs_items = items_counter("icbs_trans");
                    string icbs_sum = amount_sum("icbs_trans");
                    lbl_icbs_value_items.Text = icbs_items;
                    lbl_icbs_total_amount.Text = icbs_sum;
                }
                
                if(Matched_Trans_Records.Items.Count > 0)
                {
                    string scan_items = items_counter("scanned_trans");
                    string scan_sum = amount_sum("scanned_trans");
                    lbl_scan_value_items.Text = scan_items;
                    lbl_scan_total_amount.Text = scan_sum;
                }
                
            }
        }

        private void match_icbs_filter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (match_icbs_filter.Text == "Regular Match")
            {
                matched_listview_view("icbs_trans", "=", "R");
            }
            else if (match_icbs_filter.Text == "Force Match")
            {
                matched_listview_view("icbs_trans", "=", "F");
            }
            else
            {
                matched_listview_view("icbs_trans", "<>", "U");
            }
        }

        private void match_scan_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (match_scan_filter.Text == "Regular Match")
            {
                matched_listview_view("scanned_trans", "=", "R");
            }
            else if (match_scan_filter.Text == "Force Match")
            {
                matched_listview_view("scanned_trans", "=", "F");
            }
            else
            {
                matched_listview_view("scanned_trans", "<>", "U");
            }
        }
    }
}
