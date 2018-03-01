using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexiCapture_App
{
    public partial class view_ICBStrans : Form
    {
        public view_ICBStrans(string[] lines)
        {
            InitializeComponent();
            DateTime date;
            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
                string date_string = DateTime.Parse(col[1]).ToString("MM/dd/yyyy");
                date = DateTime.Parse(date_string);

                var listviewitem = new ListViewItem(col);
                listviewitem.SubItems.Add(col[0].ToString());
                listviewitem.SubItems.Add(date_string.ToString());
                listviewitem.SubItems.Add(col[2].ToString());
                listviewitem.SubItems.Add(col[3].ToString());
                listviewitem.SubItems.Add(col[4].ToString());

                lvw_ICBStrans_.Items.Add(listviewitem);
            }
        }
    }
}
