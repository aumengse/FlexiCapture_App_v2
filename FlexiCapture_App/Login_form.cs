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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Lemuel\Desktop\TVVS.accdb; Persist Security Info=False;");
                con.Open();
                
                string select = string.Format("select * from user_login where username = '{0}' and pass_word = '{1}'", this.txt_username.Text, this.txt_password.Text);
                OleDbCommand cmd = new OleDbCommand(select, con);
                OleDbDataReader read = cmd.ExecuteReader();

                int count = 0;
                while (read.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    con.Close();
                    TransMain main = new TransMain();
                    main.Show();
                    Hide();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and Password. Access Denied", "Flexi Capture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Text = "Username";
                    txt_password.Text = "Password";
                    txt_username.ForeColor = Color.Silver;
                    txt_password.ForeColor = Color.Silver;
                    txt_password.UseSystemPasswordChar = false;
                }
                else
                {
                    MessageBox.Show("Incorrect Username/Password", "Flexi Capture", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Text = "Password";
                    txt_username.Text = "Username";
                    txt_username.ForeColor = Color.Silver;
                    txt_password.ForeColor = Color.Silver;
                    txt_password.UseSystemPasswordChar = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Silver;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
                txt_password.UseSystemPasswordChar = false;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            link_signup.Select();
        }

        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup_form signup = new signup_form();
            signup.Show();
            Hide();
        }
    }
}
