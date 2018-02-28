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
    public partial class Archive_View : Form
    {
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;
        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }
        public Archive_View()
        {
            InitializeComponent();
        }

        private void Archive_View_Load(object sender, EventArgs e)
        {
            try { 
                conString();
                con.Open();
                string cmd = "SELECT * FROM archive_trans";
                {
                    OleDbCommand command = new OleDbCommand(cmd, con);
                    OleDbDataReader rdr = command.ExecuteReader();
                    listview_archive.Items.Clear();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            ListViewItem aa = new ListViewItem(rdr.GetValue(3).ToString());
                            aa.SubItems.Add(DateTime.Parse(rdr.GetValue(2).ToString()).ToString("MM/dd/yyyy"));
                            aa.SubItems.Add(rdr.GetValue(4).ToString());
                            aa.SubItems.Add(rdr.GetValue(5).ToString());
                            aa.SubItems.Add(String.Format("{0:n}", Double.Parse(rdr.GetValue(6).ToString())));
                            aa.SubItems.Add(rdr.GetValue(9).ToString());
                            aa.SubItems.Add(rdr.GetValue(7).ToString());
                            aa.SubItems.Add(rdr.GetValue(10).ToString());
                            listview_archive.Items.Add(aa);
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
    }
}
