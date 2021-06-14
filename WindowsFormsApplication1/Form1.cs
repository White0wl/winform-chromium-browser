using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        //------------------------------style----------------------------------//
        private void pictureBoxRefresh_MouseHover(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBoxRefresh_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BackColor = Color.LightGray;
        }
        private void pictureBoxRefresh_MouseLeave(object sender, EventArgs e)
        {

            PictureBox p = sender as PictureBox;
            p.BorderStyle = BorderStyle.None;
            p.BackColor = Color.WhiteSmoke;
        }
        private void pictureBoxRefresh_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BackColor = Color.WhiteSmoke;
        }
        private void panelGoTo_MouseHover(object sender, EventArgs e)
        {
            labelGo.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxGo.BorderStyle = BorderStyle.FixedSingle;
        }
        private void panelGoTo_MouseLeave(object sender, EventArgs e)
        {
            labelGo.BorderStyle = BorderStyle.None;
            pictureBoxGo.BorderStyle = BorderStyle.None;
            labelGo.BackColor = Color.WhiteSmoke;
            pictureBoxGo.BackColor = Color.WhiteSmoke;
        }
        private void panelGoTo_MouseUp(object sender, MouseEventArgs e)
        {
            labelGo.BackColor = Color.WhiteSmoke;
            pictureBoxGo.BackColor = Color.WhiteSmoke;
        }
        private void panelGoTo_MouseDown(object sender, MouseEventArgs e)
        {
            labelGo.BackColor = Color.LightGray;
            pictureBoxGo.BackColor = Color.LightGray;
        }
        private void textBoxUrl_Enter(object sender, EventArgs e)
        {
            textBoxUrl.BorderStyle = BorderStyle.FixedSingle;
            textBoxUrl.ForeColor = Color.Black;
        }
        private void textBoxUrl_Leave(object sender, EventArgs e)
        {
            textBoxUrl.BorderStyle = BorderStyle.None;
            textBoxUrl.ForeColor = Color.Gray;
            if (tabControl1.SelectedIndex != -1)
            {
                textBoxUrl.Text = browserPages[tabControl1.SelectedIndex].Address;
            }
        }
        //---------------------------------------------------------------------//


        List<ChromiumWebBrowser> browserPages;
        Dictionary<string, string> favorits;
        BindingList<SiteHistoryItem> history;
        string buff;
        private bool historyEnable;

        public Form1()
        {
            history = new BindingList<SiteHistoryItem>();
            historyEnable = false;
            buff = "";
            InitializeComponent();
            InitializeChrome();
            InitializeFavorites();
        }

        private void InitializeFavorites()
        {
            favorits = new Dictionary<string, string>();
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists("favorites.txt"))
            {
                using (Stream s = new FileStream("favorites.txt", FileMode.Open, FileAccess.Read))
                {
                    favorits = formatter.Deserialize(s) as Dictionary<string, string>;
                    if (favorits.Count > 0)
                        AddFromToolStrip();
                }
            }
            else
            {
                File.Create("favorites.txt");
            }
        }

        private void AddFromToolStrip()
        {
            foreach(var item in favorits)
            {
                toolStrip1.Items.Add(item.Key);
                toolStrip1.Items[toolStrip1.Items.Count - 1].Click += ToolStripItem_Click;
                toolStrip1.Items[toolStrip1.Items.Count - 1].DoubleClickEnabled = true;
                toolStrip1.Items[toolStrip1.Items.Count - 1].DoubleClick += ToolStripItem_DoubleClick;
            }
        }

        private void InitializeChrome()
        {
            CefSettings sett = new CefSettings();
            Cef.Initialize(sett);
            browserPages = new List<ChromiumWebBrowser>();
            CreateNewPage();
        }

        public void CreateNewPage(string address = "google.com")
        {
            browserPages.Add(new ChromiumWebBrowser(address));
            browserPages.Last().Dock = DockStyle.Fill;
            browserPages.Last().TitleChanged += Browser_TitleChanged;
            browserPages.Last().AddressChanged += Browser_AddressChanged;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.TabPages[tabControl1.TabPages.Count - 1].Controls.Add(browserPages.Last());


            pictureBoxBack.Enabled = browserPages[tabControl1.SelectedIndex].CanGoBack;
            pictureBoxForward.Enabled = browserPages[tabControl1.SelectedIndex].CanGoForward;
        }

        private void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            if (tabControl1.SelectedIndex != -1)
                textBoxUrl.Text = browserPages[tabControl1.SelectedIndex].Address;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            ChromiumWebBrowser send = sender as ChromiumWebBrowser;
            if (buff != send.Address)
            {
                history.Add(new SiteHistoryItem(send.Address, e.Title, DateTime.Now));
                buff = send.Address;
            }
            else
                buff = "";
            send.Parent.Text = e.Title;
            pictureBoxBack.Enabled = browserPages[tabControl1.SelectedIndex].CanGoBack;
            pictureBoxForward.Enabled = browserPages[tabControl1.SelectedIndex].CanGoForward;
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (Stream s = new FileStream("favorites.txt", FileMode.Open, FileAccess.Write))
            {
                formatter.Serialize(s, favorits);                
            }
            Cef.Shutdown();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            browserPages[tabControl1.SelectedIndex].Load(textBoxUrl.Text);
        }

        private void CloseSelectedPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idx = tabControl1.SelectedIndex;

            tabControl1.TabPages.Remove(tabControl1.TabPages[idx]);
            browserPages.Remove(browserPages[idx]);
        }

        private void pictureBoxFavorite_Click(object sender, EventArgs e)
        {
            if (!favorits.ContainsKey(tabControl1.SelectedTab.Text))
            {
                toolStrip1.Items.Add(tabControl1.SelectedTab.Text);
                toolStrip1.Items[toolStrip1.Items.Count - 1].Click += ToolStripItem_Click;
                toolStrip1.Items[toolStrip1.Items.Count - 1].DoubleClickEnabled = true;
                toolStrip1.Items[toolStrip1.Items.Count - 1].DoubleClick += ToolStripItem_DoubleClick;
                favorits.Add(tabControl1.SelectedTab.Text, browserPages[tabControl1.SelectedIndex].Address);
            }
        }

        private void ToolStripItem_DoubleClick(object sender, EventArgs e)
        {
            string key = (sender as ToolStripItem).Text;
            favorits.Remove(key);
            toolStrip1.Items.Remove(sender as ToolStripItem);
        }

        private void ToolStripItem_Click(object sender, EventArgs e)
        {
            string key = (sender as ToolStripItem).Text;
            if (tabControl1.TabCount == 0)
            {
                CreateNewPage(favorits[key]);
            }
            else
            {
                browserPages[tabControl1.SelectedIndex].Load(favorits[key]);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                pictureBoxBack.Enabled = browserPages[tabControl1.SelectedIndex].CanGoBack;
                pictureBoxForward.Enabled = browserPages[tabControl1.SelectedIndex].CanGoForward;
                textBoxUrl.Text = browserPages[tabControl1.SelectedIndex].Address;
            }
            else
                CreateNewPage();
        }

        private void CreateNewPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewPage();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
                browserPages[tabControl1.SelectedIndex].Load(browserPages[tabControl1.SelectedIndex].Address);
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                browserPages[tabControl1.SelectedIndex].Back();
            }
            pictureBoxBack.Enabled = browserPages[tabControl1.SelectedIndex].CanGoBack;
            pictureBoxForward.Enabled = browserPages[tabControl1.SelectedIndex].CanGoForward;
        }

        private void pictureBoxForward_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != -1)
            {
                browserPages[tabControl1.SelectedIndex].Forward();
            }
            pictureBoxBack.Enabled = browserPages[tabControl1.SelectedIndex].CanGoBack;
            pictureBoxForward.Enabled = browserPages[tabControl1.SelectedIndex].CanGoForward;
        }

        private void textBoxUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                panel1_Click(sender, e);
        }

        private void HistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!historyEnable)
            {
                History FormHistory = new History(this, history);
                FormHistory.Show();
                historyEnable = true;
            }
        }

        public void HistoryClosing()
        {
            historyEnable = false;
        }
    }
}
