namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьВыбраннуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.panelGoTo = new System.Windows.Forms.Panel();
            this.labelGo = new System.Windows.Forms.Label();
            this.pictureBoxGo = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBoxFavorite = new System.Windows.Forms.PictureBox();
            this.pictureBoxForward = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.страницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panelGoTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Location = new System.Drawing.Point(2, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1029, 661);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьВыбраннуюСтраницуToolStripMenuItem,
            this.добавитьСтраницуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(243, 48);
            // 
            // закрытьВыбраннуюСтраницуToolStripMenuItem
            // 
            this.закрытьВыбраннуюСтраницуToolStripMenuItem.Name = "закрытьВыбраннуюСтраницуToolStripMenuItem";
            this.закрытьВыбраннуюСтраницуToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.закрытьВыбраннуюСтраницуToolStripMenuItem.Text = "Закрыть выбранную страницу";
            this.закрытьВыбраннуюСтраницуToolStripMenuItem.Click += new System.EventHandler(this.CloseSelectedPageToolStripMenuItem_Click);
            // 
            // добавитьСтраницуToolStripMenuItem
            // 
            this.добавитьСтраницуToolStripMenuItem.Name = "добавитьСтраницуToolStripMenuItem";
            this.добавитьСтраницуToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.добавитьСтраницуToolStripMenuItem.Text = "Добавить страницу";
            this.добавитьСтраницуToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPageToolStripMenuItem_Click);
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUrl.Location = new System.Drawing.Point(156, 30);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(713, 13);
            this.textBoxUrl.TabIndex = 1;
            this.textBoxUrl.Enter += new System.EventHandler(this.textBoxUrl_Enter);
            this.textBoxUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUrl_KeyDown);
            this.textBoxUrl.Leave += new System.EventHandler(this.textBoxUrl_Leave);
            // 
            // panelGoTo
            // 
            this.panelGoTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGoTo.Controls.Add(this.labelGo);
            this.panelGoTo.Controls.Add(this.pictureBoxGo);
            this.panelGoTo.Location = new System.Drawing.Point(875, 26);
            this.panelGoTo.Name = "panelGoTo";
            this.panelGoTo.Size = new System.Drawing.Size(91, 24);
            this.panelGoTo.TabIndex = 3;
            this.panelGoTo.Click += new System.EventHandler(this.panel1_Click);
            this.panelGoTo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseDown);
            this.panelGoTo.MouseLeave += new System.EventHandler(this.panelGoTo_MouseLeave);
            this.panelGoTo.MouseHover += new System.EventHandler(this.panelGoTo_MouseHover);
            this.panelGoTo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseUp);
            // 
            // labelGo
            // 
            this.labelGo.AutoSize = true;
            this.labelGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelGo.Location = new System.Drawing.Point(3, 5);
            this.labelGo.Name = "labelGo";
            this.labelGo.Size = new System.Drawing.Size(50, 13);
            this.labelGo.TabIndex = 3;
            this.labelGo.Text = "Перейти";
            this.labelGo.Click += new System.EventHandler(this.panel1_Click);
            this.labelGo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseDown);
            this.labelGo.MouseLeave += new System.EventHandler(this.panelGoTo_MouseLeave);
            this.labelGo.MouseHover += new System.EventHandler(this.panelGoTo_MouseHover);
            this.labelGo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseUp);
            // 
            // pictureBoxGo
            // 
            this.pictureBoxGo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxGo.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Right;
            this.pictureBoxGo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxGo.Location = new System.Drawing.Point(59, 2);
            this.pictureBoxGo.Name = "pictureBoxGo";
            this.pictureBoxGo.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxGo.TabIndex = 2;
            this.pictureBoxGo.TabStop = false;
            this.pictureBoxGo.Click += new System.EventHandler(this.panel1_Click);
            this.pictureBoxGo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseDown);
            this.pictureBoxGo.MouseLeave += new System.EventHandler(this.panelGoTo_MouseLeave);
            this.pictureBoxGo.MouseHover += new System.EventHandler(this.panelGoTo_MouseHover);
            this.pictureBoxGo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelGoTo_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(978, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxRefresh.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.refresh;
            this.pictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(120, 28);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxRefresh.TabIndex = 2;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            this.pictureBoxRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseDown);
            this.pictureBoxRefresh.MouseLeave += new System.EventHandler(this.pictureBoxRefresh_MouseLeave);
            this.pictureBoxRefresh.MouseHover += new System.EventHandler(this.pictureBoxRefresh_MouseHover);
            this.pictureBoxRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseUp);
            // 
            // pictureBoxFavorite
            // 
            this.pictureBoxFavorite.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxFavorite.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.favorit1;
            this.pictureBoxFavorite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFavorite.Location = new System.Drawing.Point(84, 28);
            this.pictureBoxFavorite.Name = "pictureBoxFavorite";
            this.pictureBoxFavorite.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxFavorite.TabIndex = 2;
            this.pictureBoxFavorite.TabStop = false;
            this.pictureBoxFavorite.Click += new System.EventHandler(this.pictureBoxFavorite_Click);
            this.pictureBoxFavorite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseDown);
            this.pictureBoxFavorite.MouseLeave += new System.EventHandler(this.pictureBoxRefresh_MouseLeave);
            this.pictureBoxFavorite.MouseHover += new System.EventHandler(this.pictureBoxRefresh_MouseHover);
            this.pictureBoxFavorite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseUp);
            // 
            // pictureBoxForward
            // 
            this.pictureBoxForward.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxForward.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Right;
            this.pictureBoxForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxForward.Location = new System.Drawing.Point(48, 28);
            this.pictureBoxForward.Name = "pictureBoxForward";
            this.pictureBoxForward.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxForward.TabIndex = 2;
            this.pictureBoxForward.TabStop = false;
            this.pictureBoxForward.Click += new System.EventHandler(this.pictureBoxForward_Click);
            this.pictureBoxForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseDown);
            this.pictureBoxForward.MouseLeave += new System.EventHandler(this.pictureBoxRefresh_MouseLeave);
            this.pictureBoxForward.MouseHover += new System.EventHandler(this.pictureBoxRefresh_MouseHover);
            this.pictureBoxForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseUp);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxBack.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Left;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Location = new System.Drawing.Point(12, 28);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(30, 20);
            this.pictureBoxBack.TabIndex = 2;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseDown);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxRefresh_MouseLeave);
            this.pictureBoxBack.MouseHover += new System.EventHandler(this.pictureBoxRefresh_MouseHover);
            this.pictureBoxBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRefresh_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.страницыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // страницыToolStripMenuItem
            // 
            this.страницыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.страницыToolStripMenuItem.Name = "страницыToolStripMenuItem";
            this.страницыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.страницыToolStripMenuItem.Text = "Страницы";
            // 
            // новаяToolStripMenuItem
            // 
            this.новаяToolStripMenuItem.Name = "новаяToolStripMenuItem";
            this.новаяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.новаяToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.новаяToolStripMenuItem.Text = "Новая";
            this.новаяToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPageToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.CloseSelectedPageToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.историяToolStripMenuItem.Text = "История";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.HistoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 651);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelGoTo);
            this.Controls.Add(this.pictureBoxRefresh);
            this.Controls.Add(this.pictureBoxFavorite);
            this.Controls.Add(this.pictureBoxForward);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chromium";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelGoTo.ResumeLayout(false);
            this.panelGoTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxForward;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.PictureBox pictureBoxGo;
        private System.Windows.Forms.Panel panelGoTo;
        private System.Windows.Forms.Label labelGo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBoxFavorite;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem закрытьВыбраннуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСтраницуToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem страницыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
    }
}

