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
        private OleDbConnection con = new OleDbConnection(); //Initialize OleDBConnection
        private Conf.conf dbcon;

        public TransMain()
        {
            InitializeComponent();
            
            this.CenterToScreen();
 
        }

        private void conString()
        {
            con = new OleDbConnection();
            dbcon = new Conf.conf();
            con.ConnectionString = dbcon.getConnectionString();
        }

        private void scannedFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impt_ScanTran st = new Impt_ScanTran();
            st.Show();
        }

        private void iCBSFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Impt_ICBSTran it = new Impt_ICBSTran();
            it.Show();
        }

        private void matchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScanForm sf = new ScanForm();
            sf.Show();
        }

        private void importedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Imported vi = new View_Imported();
            vi.Show();
        }

        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archiving_Trans at = new Archiving_Trans();
            at.Show();
        }
    }
}
