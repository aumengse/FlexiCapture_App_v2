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
    public partial class Unmatched_Data : Form
    {
        public Unmatched_Data()
        {
            InitializeComponent();
        }

        private void Unmatched_Data_Load(object sender, EventArgs e)
        {
           
        }
        private void scanned_force_match()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "update scanned_trans set match_code='F' where acct_num=" + txt_scan_acct_num.Text + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void icbs_force_match()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "update icbs_trans set match_code='F' where acct_num=" + txt_icbs_acct_num.Text + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_force_match_Click(object sender, EventArgs e)
        {
            Unmatched_View uv = new Unmatched_View();
            uv.Hide();
            scanned_force_match();
            icbs_force_match();
            MessageBox.Show("Force Match Successful", "Information", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            uv.Unmatched_Icbs_Records.Update();
            uv.Show();
            this.Hide();
            
        }
    }
}
