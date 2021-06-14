using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class History : Form
    {
        private BindingList<SiteHistoryItem> history;
        private Form1 parent;
        public History()
        {
            InitializeComponent();
        }

        public History(Form1 form, BindingList<SiteHistoryItem> history) : this()
        {
            this.history = history;
            parent = form;

            listBox1.DataSource = this.history;
        }

        private void History_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.HistoryClosing();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                toolStripStatusLabelTime.Text = history[listBox1.SelectedIndex].Date+"";
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                parent.CreateNewPage(history[listBox1.SelectedIndex].Address);
            }
        }
    }
}
