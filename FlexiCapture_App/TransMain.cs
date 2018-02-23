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

    public partial class TransMain : Form
    {

        public TransMain()
        {
            InitializeComponent();
            
            this.CenterToScreen();
           
           
            pnl_info.Hide();
            pnl_main.Hide();
            pnl_info_icbs.Hide();
           
        }


        private void load_data()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM [scanned_trans]";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_data.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(1).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(2).ToString());
                            aa.SubItems.Add(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(4).ToString())));
                            lv_data.Items.Add(aa);
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void load_icbs()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM [icbs_trans]";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    lv_icbs.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(0).ToString());
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
                MessageBox.Show(ex.Message);
            }
            
        }

        private void count_items_scan()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
            con.Open();
            string cmd = "SELECT COUNT(amount) from scanned_trans";
            {
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                rdr.Read();
                lbl_scan_total_items.Text = rdr.GetValue(0).ToString();
                              
            }
            con.Close();

            con.Open();
            string query = "SELECT COUNT(amount) from icbs_trans";
            {
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader rdr = command.ExecuteReader();
                rdr.Read();
                lbl_icbs_total_items.Text = rdr.GetValue(0).ToString();
          
            }
            con.Close(); 
        }

        private void sum_amount()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\TVVS.accdb; Persist Security Info=False;");
            con.Open();
            string cmd = "SELECT SUM(amount) from scanned_trans";
            {
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                rdr.Read();
                lbl_scan_total_amt.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

            }
            con.Close();

            con.Open();
            string query = "SELECT SUM(amount) from icbs_trans";
            {
                OleDbCommand command = new OleDbCommand(query, con);
                OleDbDataReader rdr = command.ExecuteReader();
                rdr.Read();
                lbl_icbs_total_amt.Text = String.Format("{0:n}", Double.Parse(rdr.GetValue(0).ToString()));

            }
            con.Close();

        }
        

        private void Setup_ScanFiles_Click(object sender, EventArgs e)
        {
            pnl_main.Hide();
        }


        private void lv_data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pnl_info.Show();
            
            
        }

        private void lv_icbs_DoubleClick(object sender, EventArgs e)
        {
            pnl_info_icbs.Show();
        }

 

        private void matchedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matched mv = new Matched();
            mv.Show();
        }

        private void lv_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void performMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            ScanForm sf = new ScanForm();
            sf.Show();
        }

        private void importFromScannedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impt_ScanTran st = new Impt_ScanTran();
            st.Show();
        }

        private void importFromICBSTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impt_ICBSTran it = new Impt_ICBSTran();
            it.Show();
        }

        private void TransMain_Load(object sender, EventArgs e)
        {

        }

        private void viewImportedRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_main.Show();
            load_data();
            load_icbs();
            count_items_scan();
            sum_amount();
            lbl_scan_total_items.Visible = true;
            lbl_scan_total_amt.Visible = true;
            lbl_icbs_total_items.Visible = true;
            lbl_icbs_total_amt.Visible = true;

        }

        private void ConfigToolStrip_Click(object sender, EventArgs e)
        {

        }

        private void unmatchedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unmatched_View uv = new Unmatched_View();
            uv.Show();
        }


      
        private void lv_icbs_DoubleClick_1(object sender, EventArgs e)
        {
            pnl_info_icbs.Show();
        }

        private void pnl_info_icbs_Paint_1(object sender, PaintEventArgs e)
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

        private void btn_exit_icbs_Click_1(object sender, EventArgs e)
        {
            pnl_info_icbs.Hide();
        }

        private void lv_data_DoubleClick(object sender, EventArgs e)
        {
            pnl_info.Show();
        }

        private void pnl_info_Paint_1(object sender, PaintEventArgs e)
        {

            if (lv_data.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = lv_data.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                tb_acc_name.Text = lv_data.SelectedItems[0].SubItems[2].Text;
                tb_acc_num.Text = lv_data.SelectedItems[0].SubItems[3].Text;
                tb_transac_date.Text = lv_data.SelectedItems[0].SubItems[1].Text;
                tb_amt.Text = String.Format("{0:n}", Double.Parse(lv_data.SelectedItems[0].SubItems[4].Text));
            }
        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            pnl_info.Hide();
        }
    }
}
