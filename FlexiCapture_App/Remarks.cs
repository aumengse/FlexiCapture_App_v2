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
    public partial class Remarks : Form
    {
        public string acct_num = "";
        public Remarks()
        {
            InitializeComponent();
        }
        private void force_match(string table_name, string acct_num, string remarks)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "update " + table_name + " set match_code='F', remarks = '"+ remarks +"' where acct_num=" + acct_num + "";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_remarks_Click(object sender, EventArgs e)
        {
            
            force_match("icbs_trans",acct_num,txt_remarks.Text);
            force_match("scanned_trans", acct_num, txt_remarks.Text);
            Unmatched_View uv = new Unmatched_View();
            MessageBox.Show("Force Match Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uv.Unmatched_Icbs_Records.Update();
            uv.Show();
            Unmatched_Data ud = new Unmatched_Data();
            ud.Dispose();
            this.Hide();
        }
    }
}
