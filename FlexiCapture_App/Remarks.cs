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
        public string icbs_acct_num = "";
        public string scan_acct_num = "";
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }
        public Remarks()
        {
            InitializeComponent();
        }
        
        private void force_match(string table_name, string acct_num, string remarks, int match_code)
        {

            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                conString();
                con.Open();
                string cmd = "update " + table_name + " set match_code='F', remarks = '"+ remarks +"', match_ref = "+ match_code +" where acct_num='" + acct_num + "'";
                OleDbCommand command = new OleDbCommand(cmd, con);
                OleDbDataReader rdr = command.ExecuteReader();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static int get_id(string acct_num, string table_name)
        {
            int var_id = 0;
            OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
            Conf.conf dbcon;
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
            try
            {
                //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC-23\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                string cmd = "SELECT * FROM " + table_name + " where acct_num = '" + acct_num + "'";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            var_id = Convert.ToInt32(rdr.GetValue(0).ToString());
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return var_id;
        }
        private void btn_remarks_Click(object sender, EventArgs e)
        {
            int scan_id = get_id(scan_acct_num, "scanned_trans");
            int icbs_id = get_id(icbs_acct_num, "icbs_trans");
            force_match("icbs_trans",icbs_acct_num,txt_remarks.Text,scan_id);
            force_match("scanned_trans", scan_acct_num, txt_remarks.Text,icbs_id);
            Unmatched_View uv = new Unmatched_View();
            MessageBox.Show("Force Match Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uv.Unmatched_Icbs_Records.Update();
            //Unmatched_Data ud = new Unmatched_Data();
            //ud.Close();

            uv.Show();
           
            this.Hide();
           
        }

        private void Remarks_Load(object sender, EventArgs e)
        {

        }
    }
}
