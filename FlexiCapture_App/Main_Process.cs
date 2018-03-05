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

namespace FlexiCapture_App_v2
{
    public partial class Main_Process : Form
    {
        public Main_Process()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void Main_Process_Load(object sender, EventArgs e)
        {
            this.Show();
            lbl_warning.Visible = true;
            gb_details.Visible = true;
            
        }

        private void load_progressbar()
        {
            progress_Bar.Minimum = 0;
            progress_Bar.Maximum = 101;
            for (int i = 0; i <= 100; i++)
            {
                progress_Bar.Value = i;
                Thread.Sleep(20);

                if (i == 0)
                {
                    
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_progressbar();
        }
    }
}
