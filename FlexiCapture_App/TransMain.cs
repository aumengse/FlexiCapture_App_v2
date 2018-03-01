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
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to start matching? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
               ScanForm sf = new ScanForm();
               sf.Show();
            }
        }

        
        private void archiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to start archiving? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Archiving_Trans at = new Archiving_Trans();
                at.Show();
            }
           
        }

        private void archivedTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Archive_View av = new Archive_View();
            av.Show();
        }

        private void importedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Imported vi = new View_Imported();
            vi.Show();
        }

        private void matchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matched m = new Matched();
            m.Show();
        }

        private void unmatchedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unmatched_View uv = new Unmatched_View();
            uv.Show();
        }

        private void TransMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to initialize database? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Initialize_DB in_db = new Initialize_DB();
                in_db.Show();
            }
            
        }

        
    }
}
