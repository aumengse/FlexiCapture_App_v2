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
    public partial class Impt_ICBSTran : Form
    {
        public Impt_ICBSTran()
        {
            InitializeComponent();
        }

        private void Impt_ICBSTran_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        /**private void import_from_icbs()
        {
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\D\Desktop\System_db.accdb; Persist Security Info=False;");
                con.Open();
                /** string cmd = "INSERT INTO[Scanned_Trans] SELECT* FROM[MS Access; DATABASE =" + tb_data_source.Text + "].[" + tb_table_name.Text + "]";
                 {
                     OleDbCommand command = new OleDbCommand(cmd, con);
                     OleDbDataReader rdr = command.ExecuteReader();
                     MessageBox.Show("Imported");
                 }**/

          /**      string query = "SELECT * INTO [ICBS_Trans] FROM [" + tb_table_name_icbs.Text + "] IN '" + tb_textfile.Text + "'";
                using (OleDbCommand sqlCeCommand = new OleDbCommand(query, con))
                {
                    sqlCeCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }**/
    }
}
