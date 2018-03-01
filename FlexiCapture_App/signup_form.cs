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
    public partial class signup_form : Form
    {
        public signup_form()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {   
            Application.Exit();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lemuel\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();

                string select = string.Format("select * from user_login where username = '{0}'", this.txt_user.Text);
                OleDbCommand cmd = new OleDbCommand(select, con);
                OleDbDataReader read = cmd.ExecuteReader();
                int count = 0;
                while (read.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username must be unique", "Flexi Capture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txt_pass.Text != txt_pass2.Text)
                    {
                        MessageBox.Show("Password is not matched", "Flexi Capture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (txt_firstname.Text == "" || txt_lastname.Text == "" || txt_middlename.Text == "" || txt_user.Text == "" || txt_pass.Text == "" || txt_pass2.Text == "")
                    {
                        MessageBox.Show("Please Fill up the empty fields", "Flexi Capture", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        string insert = "insert into user_login (first_name, middle_name, last_name, username, pass_word) values ('" + txt_firstname.Text + "', '" + txt_middlename.Text + "', '" + txt_lastname.Text + "', '" + txt_user.Text + "', '" + txt_pass.Text + "')";
                        OleDbCommand commmand = new OleDbCommand(insert, con);
                        OleDbDataReader basa = commmand.ExecuteReader();
                        MessageBox.Show("Succesfully Signed up");
                        con.Close();

                        Login_form login = new Login_form();
                        login.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbn_back_Click(object sender, EventArgs e)
        {
            Login_form login = new Login_form();
            login.Show();
            Hide();
        }
    }
}
