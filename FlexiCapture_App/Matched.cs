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

        public Matched()
        {
            InitializeComponent();
        }
        private void matched_listview_view(string table_name)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM " + table_name + " where match_code <> 'U'";
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

        private void Matched_Load(object sender, EventArgs e)
        {
            matched_listview_view("icbs_trans");
            matched_listview_view("scanned_trans");
        }
        private void undo_force_match(string table_name,string acct_num)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();

                string cmd = "update "+ table_name +" set match_code='U', match_ref = Null where acct_num=" + acct_num + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();
                MessageBox.Show("Undo Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                undo_force_match("scanned_trans", icbs_acct_num);
            }
        }
    }
}
