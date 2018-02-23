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
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
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
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
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
        private void Unmatched_View_Load(object sender, EventArgs e)
        {
            unmatched_icbs_view();
            unmatched_trans_view();
            Unmatched_Icbs_Records.Refresh();
        }
    }
}
