namespace Arclaunch
{
    partial class Arclaunch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        ///
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arclaunch));
            this.splitlayout = new System.Windows.Forms.SplitContainer();
            this.hidewnds = new System.Windows.Forms.Button();
            this.showwnds = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logsbtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.serversbtn = new System.Windows.Forms.Button();
            this.logpnl = new System.Windows.Forms.Panel();
            this.logbox = new System.Windows.Forms.RichTextBox();
            this.logslbl = new System.Windows.Forms.Label();
            this.settingspnl = new System.Windows.Forms.Panel();
            this.hidewndchk = new System.Windows.Forms.CheckBox();
            this.hidewindslbl = new System.Windows.Forms.Label();
            this.ttrbox = new System.Windows.Forms.MaskedTextBox();
            this.ttrhelp = new System.Windows.Forms.Label();
            this.ttrlbl = new System.Windows.Forms.Label();
            this.autorestartsrvslbl = new System.Windows.Forms.Label();
            this.autorestartsrvs = new System.Windows.Forms.CheckBox();
            this.crashrestart = new System.Windows.Forms.CheckBox();
            this.crashrestartlbl = new System.Windows.Forms.Label();
            this.savesettings = new System.Windows.Forms.Button();
            this.browsedeflog = new System.Windows.Forms.Button();
            this.defaultpathbox = new System.Windows.Forms.TextBox();
            this.defaltpathlbl = new System.Windows.Forms.Label();
            this.settingslbl = new System.Windows.Forms.Label();
            this.serverspnl = new System.Windows.Forms.Panel();
            this.restartlogsrvbtn = new System.Windows.Forms.Button();
            this.stoplogsrvbtn = new System.Windows.Forms.Button();
            this.startlogsrvbtn = new System.Windows.Forms.Button();
            this.dellogsrvbtn = new System.Windows.Forms.Button();
            this.addlogsrvbtn = new System.Windows.Forms.Button();
            this.restartworldsrvbtn = new System.Windows.Forms.Button();
            this.stopworldsrvbtn = new System.Windows.Forms.Button();
            this.startworldsrvbtn = new System.Windows.Forms.Button();
            this.delworldsrvbtn = new System.Windows.Forms.Button();
            this.addsrvbtn = new System.Windows.Forms.Button();
            this.logonlbl = new System.Windows.Forms.Label();
            this.logonlist = new System.Windows.Forms.ListBox();
            this.worldlbl = new System.Windows.Forms.Label();
            this.worldlist = new System.Windows.Forms.ListBox();
            this.serverslbl = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.systraymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systrayexit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.numlogentrys = new System.Windows.Forms.Label();
            this.maxlogbox = new System.Windows.Forms.NumericUpDown();
            this.whattolog = new System.Windows.Forms.GroupBox();
            this.startupbox = new System.Windows.Forms.CheckBox();
            this.shutdownbox = new System.Windows.Forms.CheckBox();
            this.autorestartbox = new System.Windows.Forms.CheckBox();
            this.crashbox = new System.Windows.Forms.CheckBox();
            this.srvrestartbox = new System.Windows.Forms.CheckBox();
            this.srvstartbox = new System.Windows.Forms.CheckBox();
            this.srvstopbox = new System.Windows.Forms.CheckBox();
            this.splitlayout.Panel1.SuspendLayout();
            this.splitlayout.Panel2.SuspendLayout();
            this.splitlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logpnl.SuspendLayout();
            this.settingspnl.SuspendLayout();
            this.serverspnl.SuspendLayout();
            this.systraymenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxlogbox)).BeginInit();
            this.whattolog.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitlayout
            // 
            this.splitlayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitlayout.Location = new System.Drawing.Point(0, 0);
            this.splitlayout.Name = "splitlayout";
            // 
            // splitlayout.Panel1
            // 
            this.splitlayout.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitlayout.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitlayout.Panel1.BackgroundImage")));
            this.splitlayout.Panel1.Controls.Add(this.hidewnds);
            this.splitlayout.Panel1.Controls.Add(this.showwnds);
            this.splitlayout.Panel1.Controls.Add(this.aboutbtn);
            this.splitlayout.Panel1.Controls.Add(this.pictureBox2);
            this.splitlayout.Panel1.Controls.Add(this.pictureBox1);
            this.splitlayout.Panel1.Controls.Add(this.logsbtn);
            this.splitlayout.Panel1.Controls.Add(this.settingsbtn);
            this.splitlayout.Panel1.Controls.Add(this.serversbtn);
            // 
            // splitlayout.Panel2
            // 
            this.splitlayout.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitlayout.Panel2.BackgroundImage")));
            this.splitlayout.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitlayout.Panel2.Controls.Add(this.settingspnl);
            this.splitlayout.Panel2.Controls.Add(this.logpnl);
            this.splitlayout.Panel2.Controls.Add(this.serverspnl);
            this.splitlayout.Size = new System.Drawing.Size(670, 374);
            this.splitlayout.SplitterDistance = 192;
            this.splitlayout.TabIndex = 0;
            // 
            // hidewnds
            // 
            this.hidewnds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidewnds.BackgroundImage")));
            this.hidewnds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidewnds.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.hidewnds.FlatAppearance.BorderSize = 0;
            this.hidewnds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hidewnds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hidewnds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hidewnds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hidewnds.Location = new System.Drawing.Point(12, 184);
            this.hidewnds.Name = "hidewnds";
            this.hidewnds.Padding = new System.Windows.Forms.Padding(1);
            this.hidewnds.Size = new System.Drawing.Size(167, 23);
            this.hidewnds.TabIndex = 7;
            this.hidewnds.Text = "Hide Windows";
            this.hidewnds.UseVisualStyleBackColor = true;
            this.hidewnds.Click += new System.EventHandler(this.hidewnds_Click);
            // 
            // showwnds
            // 
            this.showwnds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showwnds.BackgroundImage")));
            this.showwnds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showwnds.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.showwnds.FlatAppearance.BorderSize = 0;
            this.showwnds.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showwnds.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showwnds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showwnds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showwnds.Location = new System.Drawing.Point(12, 155);
            this.showwnds.Name = "showwnds";
            this.showwnds.Padding = new System.Windows.Forms.Padding(1);
            this.showwnds.Size = new System.Drawing.Size(167, 23);
            this.showwnds.TabIndex = 6;
            this.showwnds.Text = "Show Windows";
            this.showwnds.UseVisualStyleBackColor = true;
            this.showwnds.Click += new System.EventHandler(this.showwnds_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.BackColor = System.Drawing.Color.Transparent;
            this.aboutbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aboutbtn.BackgroundImage")));
            this.aboutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aboutbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.aboutbtn.FlatAppearance.BorderSize = 0;
            this.aboutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.aboutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aboutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aboutbtn.Location = new System.Drawing.Point(12, 341);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Padding = new System.Windows.Forms.Padding(1);
            this.aboutbtn.Size = new System.Drawing.Size(167, 23);
            this.aboutbtn.TabIndex = 5;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = true;
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // logsbtn
            // 
            this.logsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logsbtn.BackgroundImage")));
            this.logsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logsbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.logsbtn.FlatAppearance.BorderSize = 0;
            this.logsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logsbtn.Location = new System.Drawing.Point(12, 98);
            this.logsbtn.Name = "logsbtn";
            this.logsbtn.Padding = new System.Windows.Forms.Padding(1);
            this.logsbtn.Size = new System.Drawing.Size(167, 23);
            this.logsbtn.TabIndex = 2;
            this.logsbtn.Text = "Logs";
            this.logsbtn.UseVisualStyleBackColor = true;
            this.logsbtn.Click += new System.EventHandler(this.logsbtn_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsbtn.BackgroundImage")));
            this.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.settingsbtn.FlatAppearance.BorderSize = 0;
            this.settingsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settingsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsbtn.Location = new System.Drawing.Point(12, 69);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Padding = new System.Windows.Forms.Padding(1);
            this.settingsbtn.Size = new System.Drawing.Size(167, 23);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // serversbtn
            // 
            this.serversbtn.BackColor = System.Drawing.Color.Transparent;
            this.serversbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serversbtn.BackgroundImage")));
            this.serversbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.serversbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.serversbtn.FlatAppearance.BorderSize = 0;
            this.serversbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.serversbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.serversbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serversbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.serversbtn.Location = new System.Drawing.Point(12, 40);
            this.serversbtn.Name = "serversbtn";
            this.serversbtn.Padding = new System.Windows.Forms.Padding(1);
            this.serversbtn.Size = new System.Drawing.Size(167, 23);
            this.serversbtn.TabIndex = 0;
            this.serversbtn.Text = "Arc Servers";
            this.serversbtn.UseVisualStyleBackColor = true;
            this.serversbtn.Click += new System.EventHandler(this.serversbtn_Click);
            // 
            // logpnl
            // 
            this.logpnl.BackColor = System.Drawing.Color.Transparent;
            this.logpnl.Controls.Add(this.logbox);
            this.logpnl.Controls.Add(this.logslbl);
            this.logpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpnl.Location = new System.Drawing.Point(0, 0);
            this.logpnl.Name = "logpnl";
            this.logpnl.Size = new System.Drawing.Size(474, 374);
            this.logpnl.TabIndex = 0;
            // 
            // logbox
            // 
            this.logbox.Location = new System.Drawing.Point(17, 45);
            this.logbox.Name = "logbox";
            this.logbox.ReadOnly = true;
            this.logbox.Size = new System.Drawing.Size(445, 306);
            this.logbox.TabIndex = 2;
            this.logbox.Text = "";
            // 
            // logslbl
            // 
            this.logslbl.AutoSize = true;
            this.logslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logslbl.Location = new System.Drawing.Point(12, 12);
            this.logslbl.Name = "logslbl";
            this.logslbl.Size = new System.Drawing.Size(59, 25);
            this.logslbl.TabIndex = 1;
            this.logslbl.Text = "Logs";
            // 
            // settingspnl
            // 
            this.settingspnl.BackColor = System.Drawing.Color.Transparent;
            this.settingspnl.Controls.Add(this.whattolog);
            this.settingspnl.Controls.Add(this.maxlogbox);
            this.settingspnl.Controls.Add(this.numlogentrys);
            this.settingspnl.Controls.Add(this.hidewndchk);
            this.settingspnl.Controls.Add(this.hidewindslbl);
            this.settingspnl.Controls.Add(this.ttrbox);
            this.settingspnl.Controls.Add(this.ttrhelp);
            this.settingspnl.Controls.Add(this.ttrlbl);
            this.settingspnl.Controls.Add(this.autorestartsrvslbl);
            this.settingspnl.Controls.Add(this.autorestartsrvs);
            this.settingspnl.Controls.Add(this.crashrestart);
            this.settingspnl.Controls.Add(this.crashrestartlbl);
            this.settingspnl.Controls.Add(this.savesettings);
            this.settingspnl.Controls.Add(this.browsedeflog);
            this.settingspnl.Controls.Add(this.defaultpathbox);
            this.settingspnl.Controls.Add(this.defaltpathlbl);
            this.settingspnl.Controls.Add(this.settingslbl);
            this.settingspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingspnl.Location = new System.Drawing.Point(0, 0);
            this.settingspnl.Name = "settingspnl";
            this.settingspnl.Size = new System.Drawing.Size(474, 374);
            this.settingspnl.TabIndex = 0;
            // 
            // hidewndchk
            // 
            this.hidewndchk.AutoSize = true;
            this.hidewndchk.Location = new System.Drawing.Point(229, 190);
            this.hidewndchk.Name = "hidewndchk";
            this.hidewndchk.Size = new System.Drawing.Size(15, 14);
            this.hidewndchk.TabIndex = 15;
            this.hidewndchk.UseVisualStyleBackColor = true;
            // 
            // hidewindslbl
            // 
            this.hidewindslbl.AutoSize = true;
            this.hidewindslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hidewindslbl.Location = new System.Drawing.Point(5, 184);
            this.hidewindslbl.Name = "hidewindslbl";
            this.hidewindslbl.Size = new System.Drawing.Size(218, 20);
            this.hidewindslbl.TabIndex = 14;
            this.hidewindslbl.Text = "Hide Server Windows on start";
            // 
            // ttrbox
            // 
            this.ttrbox.Location = new System.Drawing.Point(187, 153);
            this.ttrbox.Mask = "00:00";
            this.ttrbox.Name = "ttrbox";
            this.ttrbox.Size = new System.Drawing.Size(47, 20);
            this.ttrbox.TabIndex = 13;
            this.ttrbox.ValidatingType = typeof(System.DateTime);
            // 
            // ttrhelp
            // 
            this.ttrhelp.AutoSize = true;
            this.ttrhelp.Location = new System.Drawing.Point(243, 160);
            this.ttrhelp.Name = "ttrhelp";
            this.ttrhelp.Size = new System.Drawing.Size(123, 13);
            this.ttrhelp.TabIndex = 12;
            this.ttrhelp.Text = "Entrer time in 24H format";
            // 
            // ttrlbl
            // 
            this.ttrlbl.AutoSize = true;
            this.ttrlbl.Location = new System.Drawing.Point(110, 160);
            this.ttrlbl.Name = "ttrlbl";
            this.ttrlbl.Size = new System.Drawing.Size(74, 13);
            this.ttrlbl.TabIndex = 10;
            this.ttrlbl.Text = "Time to restart";
            // 
            // autorestartsrvslbl
            // 
            this.autorestartsrvslbl.AutoSize = true;
            this.autorestartsrvslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autorestartsrvslbl.Location = new System.Drawing.Point(5, 132);
            this.autorestartsrvslbl.Name = "autorestartsrvslbl";
            this.autorestartsrvslbl.Size = new System.Drawing.Size(158, 20);
            this.autorestartsrvslbl.TabIndex = 9;
            this.autorestartsrvslbl.Text = "Auto Restart Servers";
            // 
            // autorestartsrvs
            // 
            this.autorestartsrvs.AutoSize = true;
            this.autorestartsrvs.Location = new System.Drawing.Point(169, 136);
            this.autorestartsrvs.Name = "autorestartsrvs";
            this.autorestartsrvs.Size = new System.Drawing.Size(15, 14);
            this.autorestartsrvs.TabIndex = 8;
            this.autorestartsrvs.UseVisualStyleBackColor = true;
            this.autorestartsrvs.CheckedChanged += new System.EventHandler(this.autorestartsrvs_CheckedChanged);
            // 
            // crashrestart
            // 
            this.crashrestart.AutoSize = true;
            this.crashrestart.Location = new System.Drawing.Point(138, 103);
            this.crashrestart.Name = "crashrestart";
            this.crashrestart.Size = new System.Drawing.Size(15, 14);
            this.crashrestart.TabIndex = 7;
            this.crashrestart.UseVisualStyleBackColor = true;
            // 
            // crashrestartlbl
            // 
            this.crashrestartlbl.AutoSize = true;
            this.crashrestartlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crashrestartlbl.Location = new System.Drawing.Point(4, 101);
            this.crashrestartlbl.Name = "crashrestartlbl";
            this.crashrestartlbl.Size = new System.Drawing.Size(127, 20);
            this.crashrestartlbl.TabIndex = 6;
            this.crashrestartlbl.Text = "Restart on crash";
            // 
            // savesettings
            // 
            this.savesettings.Location = new System.Drawing.Point(188, 328);
            this.savesettings.Name = "savesettings";
            this.savesettings.Size = new System.Drawing.Size(75, 23);
            this.savesettings.TabIndex = 5;
            this.savesettings.Text = "Save";
            this.savesettings.UseVisualStyleBackColor = true;
            this.savesettings.Click += new System.EventHandler(this.savesettings_Click);
            // 
            // browsedeflog
            // 
            this.browsedeflog.Location = new System.Drawing.Point(372, 62);
            this.browsedeflog.Name = "browsedeflog";
            this.browsedeflog.Size = new System.Drawing.Size(75, 23);
            this.browsedeflog.TabIndex = 4;
            this.browsedeflog.Text = "Browse";
            this.browsedeflog.UseVisualStyleBackColor = true;
            this.browsedeflog.Click += new System.EventHandler(this.browsedeflog_Click);
            // 
            // defaultpathbox
            // 
            this.defaultpathbox.Location = new System.Drawing.Point(107, 63);
            this.defaultpathbox.Name = "defaultpathbox";
            this.defaultpathbox.Size = new System.Drawing.Size(259, 20);
            this.defaultpathbox.TabIndex = 3;
            this.defaultpathbox.Click += new System.EventHandler(this.browsedeflog_Click);
            // 
            // defaltpathlbl
            // 
            this.defaltpathlbl.AutoSize = true;
            this.defaltpathlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaltpathlbl.Location = new System.Drawing.Point(3, 62);
            this.defaltpathlbl.Name = "defaltpathlbl";
            this.defaltpathlbl.Size = new System.Drawing.Size(98, 20);
            this.defaltpathlbl.TabIndex = 2;
            this.defaltpathlbl.Text = "Default Path";
            // 
            // settingslbl
            // 
            this.settingslbl.AutoSize = true;
            this.settingslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslbl.Location = new System.Drawing.Point(12, 12);
            this.settingslbl.Name = "settingslbl";
            this.settingslbl.Size = new System.Drawing.Size(90, 25);
            this.settingslbl.TabIndex = 1;
            this.settingslbl.Text = "Settings";
            // 
            // serverspnl
            // 
            this.serverspnl.BackColor = System.Drawing.Color.Transparent;
            this.serverspnl.Controls.Add(this.restartlogsrvbtn);
            this.serverspnl.Controls.Add(this.stoplogsrvbtn);
            this.serverspnl.Controls.Add(this.startlogsrvbtn);
            this.serverspnl.Controls.Add(this.dellogsrvbtn);
            this.serverspnl.Controls.Add(this.addlogsrvbtn);
            this.serverspnl.Controls.Add(this.restartworldsrvbtn);
            this.serverspnl.Controls.Add(this.stopworldsrvbtn);
            this.serverspnl.Controls.Add(this.startworldsrvbtn);
            this.serverspnl.Controls.Add(this.delworldsrvbtn);
            this.serverspnl.Controls.Add(this.addsrvbtn);
            this.serverspnl.Controls.Add(this.logonlbl);
            this.serverspnl.Controls.Add(this.logonlist);
            this.serverspnl.Controls.Add(this.worldlbl);
            this.serverspnl.Controls.Add(this.worldlist);
            this.serverspnl.Controls.Add(this.serverslbl);
            this.serverspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverspnl.Location = new System.Drawing.Point(0, 0);
            this.serverspnl.Name = "serverspnl";
            this.serverspnl.Size = new System.Drawing.Size(474, 374);
            this.serverspnl.TabIndex = 0;
            // 
            // restartlogsrvbtn
            // 
            this.restartlogsrvbtn.Location = new System.Drawing.Point(251, 285);
            this.restartlogsrvbtn.Name = "restartlogsrvbtn";
            this.restartlogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.restartlogsrvbtn.TabIndex = 15;
            this.restartlogsrvbtn.Text = "Restart Server";
            this.restartlogsrvbtn.UseVisualStyleBackColor = true;
            this.restartlogsrvbtn.Click += new System.EventHandler(this.restartlogsrvbtn_Click);
            // 
            // stoplogsrvbtn
            // 
            this.stoplogsrvbtn.Location = new System.Drawing.Point(311, 256);
            this.stoplogsrvbtn.Name = "stoplogsrvbtn";
            this.stoplogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.stoplogsrvbtn.TabIndex = 14;
            this.stoplogsrvbtn.Text = "Stop Server";
            this.stoplogsrvbtn.UseVisualStyleBackColor = true;
            this.stoplogsrvbtn.Click += new System.EventHandler(this.stoplogsrvbtn_Click);
            // 
            // startlogsrvbtn
            // 
            this.startlogsrvbtn.Location = new System.Drawing.Point(200, 256);
            this.startlogsrvbtn.Name = "startlogsrvbtn";
            this.startlogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.startlogsrvbtn.TabIndex = 13;
            this.startlogsrvbtn.Text = "Start Server";
            this.startlogsrvbtn.UseVisualStyleBackColor = true;
            this.startlogsrvbtn.Click += new System.EventHandler(this.startlogsrvbtn_Click);
            // 
            // dellogsrvbtn
            // 
            this.dellogsrvbtn.Location = new System.Drawing.Point(311, 226);
            this.dellogsrvbtn.Name = "dellogsrvbtn";
            this.dellogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.dellogsrvbtn.TabIndex = 12;
            this.dellogsrvbtn.Text = "Delete Server";
            this.dellogsrvbtn.UseVisualStyleBackColor = true;
            this.dellogsrvbtn.Click += new System.EventHandler(this.dellogsrvbtn_Click);
            // 
            // addlogsrvbtn
            // 
            this.addlogsrvbtn.Location = new System.Drawing.Point(201, 227);
            this.addlogsrvbtn.Name = "addlogsrvbtn";
            this.addlogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.addlogsrvbtn.TabIndex = 11;
            this.addlogsrvbtn.Text = "Add Server";
            this.addlogsrvbtn.UseVisualStyleBackColor = true;
            this.addlogsrvbtn.Click += new System.EventHandler(this.addlogsrvbtn_Click);
            // 
            // restartworldsrvbtn
            // 
            this.restartworldsrvbtn.Location = new System.Drawing.Point(251, 147);
            this.restartworldsrvbtn.Name = "restartworldsrvbtn";
            this.restartworldsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.restartworldsrvbtn.TabIndex = 10;
            this.restartworldsrvbtn.Text = "Restart Server";
            this.restartworldsrvbtn.UseVisualStyleBackColor = true;
            this.restartworldsrvbtn.Click += new System.EventHandler(this.restartworldsrvbtn_Click);
            // 
            // stopworldsrvbtn
            // 
            this.stopworldsrvbtn.Location = new System.Drawing.Point(311, 118);
            this.stopworldsrvbtn.Name = "stopworldsrvbtn";
            this.stopworldsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.stopworldsrvbtn.TabIndex = 9;
            this.stopworldsrvbtn.Text = "Stop Server";
            this.stopworldsrvbtn.UseVisualStyleBackColor = true;
            this.stopworldsrvbtn.Click += new System.EventHandler(this.stopworldsrvbtn_Click);
            // 
            // startworldsrvbtn
            // 
            this.startworldsrvbtn.Location = new System.Drawing.Point(200, 118);
            this.startworldsrvbtn.Name = "startworldsrvbtn";
            this.startworldsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.startworldsrvbtn.TabIndex = 8;
            this.startworldsrvbtn.Text = "Start Server";
            this.startworldsrvbtn.UseVisualStyleBackColor = true;
            this.startworldsrvbtn.Click += new System.EventHandler(this.startworldsrvbtn_Click);
            // 
            // delworldsrvbtn
            // 
            this.delworldsrvbtn.Location = new System.Drawing.Point(311, 88);
            this.delworldsrvbtn.Name = "delworldsrvbtn";
            this.delworldsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.delworldsrvbtn.TabIndex = 7;
            this.delworldsrvbtn.Text = "Delete Server";
            this.delworldsrvbtn.UseVisualStyleBackColor = true;
            this.delworldsrvbtn.Click += new System.EventHandler(this.delworldsrvbtn_Click);
            // 
            // addsrvbtn
            // 
            this.addsrvbtn.Location = new System.Drawing.Point(201, 89);
            this.addsrvbtn.Name = "addsrvbtn";
            this.addsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.addsrvbtn.TabIndex = 6;
            this.addsrvbtn.Text = "Add Server";
            this.addsrvbtn.UseVisualStyleBackColor = true;
            this.addsrvbtn.Click += new System.EventHandler(this.addsrvbtn_Click);
            // 
            // logonlbl
            // 
            this.logonlbl.AutoSize = true;
            this.logonlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logonlbl.Location = new System.Drawing.Point(17, 208);
            this.logonlbl.Name = "logonlbl";
            this.logonlbl.Size = new System.Drawing.Size(46, 16);
            this.logonlbl.TabIndex = 5;
            this.logonlbl.Text = "Logon";
            // 
            // logonlist
            // 
            this.logonlist.FormattingEnabled = true;
            this.logonlist.Location = new System.Drawing.Point(17, 227);
            this.logonlist.Name = "logonlist";
            this.logonlist.Size = new System.Drawing.Size(177, 95);
            this.logonlist.TabIndex = 4;
            this.logonlist.SelectedIndexChanged += new System.EventHandler(this.logonlist_SelectedIndexChanged);
            // 
            // worldlbl
            // 
            this.worldlbl.AutoSize = true;
            this.worldlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.worldlbl.Location = new System.Drawing.Point(14, 62);
            this.worldlbl.Name = "worldlbl";
            this.worldlbl.Size = new System.Drawing.Size(44, 16);
            this.worldlbl.TabIndex = 3;
            this.worldlbl.Text = "World";
            // 
            // worldlist
            // 
            this.worldlist.FormattingEnabled = true;
            this.worldlist.Location = new System.Drawing.Point(17, 85);
            this.worldlist.Name = "worldlist";
            this.worldlist.Size = new System.Drawing.Size(177, 108);
            this.worldlist.TabIndex = 2;
            this.worldlist.SelectedIndexChanged += new System.EventHandler(this.worldlist_SelectedIndexChanged);
            // 
            // serverslbl
            // 
            this.serverslbl.AutoSize = true;
            this.serverslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverslbl.Location = new System.Drawing.Point(12, 12);
            this.serverslbl.Name = "serverslbl";
            this.serverslbl.Size = new System.Drawing.Size(86, 25);
            this.serverslbl.TabIndex = 0;
            this.serverslbl.Text = "Servers";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.systraymenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ArcLaucnh";
            this.notifyIcon1.Visible = true;
            // 
            // systraymenu
            // 
            this.systraymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systrayexit});
            this.systraymenu.Name = "systraymenu";
            this.systraymenu.Size = new System.Drawing.Size(93, 26);
            // 
            // systrayexit
            // 
            this.systrayexit.Name = "systrayexit";
            this.systrayexit.Size = new System.Drawing.Size(92, 22);
            this.systrayexit.Text = "Exit";
            this.systrayexit.Click += new System.EventHandler(this.systrayexit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numlogentrys
            // 
            this.numlogentrys.AutoSize = true;
            this.numlogentrys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlogentrys.Location = new System.Drawing.Point(5, 224);
            this.numlogentrys.Name = "numlogentrys";
            this.numlogentrys.Size = new System.Drawing.Size(166, 20);
            this.numlogentrys.TabIndex = 16;
            this.numlogentrys.Text = "Number of log entry\'s :";
            // 
            // maxlogbox
            // 
            this.maxlogbox.Location = new System.Drawing.Point(177, 224);
            this.maxlogbox.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.maxlogbox.Name = "maxlogbox";
            this.maxlogbox.Size = new System.Drawing.Size(120, 20);
            this.maxlogbox.TabIndex = 17;
            this.maxlogbox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // whattolog
            // 
            this.whattolog.Controls.Add(this.srvstopbox);
            this.whattolog.Controls.Add(this.srvstartbox);
            this.whattolog.Controls.Add(this.srvrestartbox);
            this.whattolog.Controls.Add(this.crashbox);
            this.whattolog.Controls.Add(this.autorestartbox);
            this.whattolog.Controls.Add(this.shutdownbox);
            this.whattolog.Controls.Add(this.startupbox);
            this.whattolog.Location = new System.Drawing.Point(34, 247);
            this.whattolog.Name = "whattolog";
            this.whattolog.Size = new System.Drawing.Size(381, 75);
            this.whattolog.TabIndex = 18;
            this.whattolog.TabStop = false;
            this.whattolog.Text = "What to log";
            // 
            // startupbox
            // 
            this.startupbox.AutoSize = true;
            this.startupbox.Checked = true;
            this.startupbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.startupbox.Location = new System.Drawing.Point(8, 15);
            this.startupbox.Name = "startupbox";
            this.startupbox.Size = new System.Drawing.Size(60, 17);
            this.startupbox.TabIndex = 0;
            this.startupbox.Text = "Startup";
            this.startupbox.UseVisualStyleBackColor = true;
            // 
            // shutdownbox
            // 
            this.shutdownbox.AutoSize = true;
            this.shutdownbox.Checked = true;
            this.shutdownbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shutdownbox.Location = new System.Drawing.Point(8, 38);
            this.shutdownbox.Name = "shutdownbox";
            this.shutdownbox.Size = new System.Drawing.Size(74, 17);
            this.shutdownbox.TabIndex = 1;
            this.shutdownbox.Text = "Shutdown";
            this.shutdownbox.UseVisualStyleBackColor = true;
            // 
            // autorestartbox
            // 
            this.autorestartbox.AutoSize = true;
            this.autorestartbox.Checked = true;
            this.autorestartbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autorestartbox.Location = new System.Drawing.Point(86, 13);
            this.autorestartbox.Name = "autorestartbox";
            this.autorestartbox.Size = new System.Drawing.Size(77, 17);
            this.autorestartbox.TabIndex = 2;
            this.autorestartbox.Text = "Autorestart";
            this.autorestartbox.UseVisualStyleBackColor = true;
            // 
            // crashbox
            // 
            this.crashbox.AutoSize = true;
            this.crashbox.Checked = true;
            this.crashbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.crashbox.Location = new System.Drawing.Point(86, 36);
            this.crashbox.Name = "crashbox";
            this.crashbox.Size = new System.Drawing.Size(64, 17);
            this.crashbox.TabIndex = 3;
            this.crashbox.Text = "Crashes";
            this.crashbox.UseVisualStyleBackColor = true;
            // 
            // srvrestartbox
            // 
            this.srvrestartbox.AutoSize = true;
            this.srvrestartbox.Checked = true;
            this.srvrestartbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srvrestartbox.Location = new System.Drawing.Point(169, 13);
            this.srvrestartbox.Name = "srvrestartbox";
            this.srvrestartbox.Size = new System.Drawing.Size(97, 17);
            this.srvrestartbox.TabIndex = 4;
            this.srvrestartbox.Text = "Server Restart ";
            this.srvrestartbox.UseVisualStyleBackColor = true;
            // 
            // srvstartbox
            // 
            this.srvstartbox.AutoSize = true;
            this.srvstartbox.Checked = true;
            this.srvstartbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srvstartbox.Location = new System.Drawing.Point(169, 38);
            this.srvstartbox.Name = "srvstartbox";
            this.srvstartbox.Size = new System.Drawing.Size(87, 17);
            this.srvstartbox.TabIndex = 5;
            this.srvstartbox.Text = "Server Starts";
            this.srvstartbox.UseVisualStyleBackColor = true;
            // 
            // srvstopbox
            // 
            this.srvstopbox.AutoSize = true;
            this.srvstopbox.Checked = true;
            this.srvstopbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.srvstopbox.Location = new System.Drawing.Point(272, 13);
            this.srvstopbox.Name = "srvstopbox";
            this.srvstopbox.Size = new System.Drawing.Size(87, 17);
            this.srvstopbox.TabIndex = 6;
            this.srvstopbox.Text = "Server Stops";
            this.srvstopbox.UseVisualStyleBackColor = true;
            // 
            // Arclaunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(670, 374);
            this.Controls.Add(this.splitlayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(686, 412);
            this.MinimumSize = new System.Drawing.Size(686, 412);
            this.Name = "Arclaunch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ArcLaunch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arclaunch_FormClosed);
            this.splitlayout.Panel1.ResumeLayout(false);
            this.splitlayout.Panel2.ResumeLayout(false);
            this.splitlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logpnl.ResumeLayout(false);
            this.logpnl.PerformLayout();
            this.settingspnl.ResumeLayout(false);
            this.settingspnl.PerformLayout();
            this.serverspnl.ResumeLayout(false);
            this.serverspnl.PerformLayout();
            this.systraymenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxlogbox)).EndInit();
            this.whattolog.ResumeLayout(false);
            this.whattolog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitlayout;
        private System.Windows.Forms.Button logsbtn;
        private System.Windows.Forms.Button settingsbtn;
        private System.Windows.Forms.Button serversbtn;
        private System.Windows.Forms.Panel serverspnl;
        private System.Windows.Forms.Panel settingspnl;
        private System.Windows.Forms.Panel logpnl;
        private System.Windows.Forms.Label serverslbl;
        private System.Windows.Forms.Label logslbl;
        private System.Windows.Forms.Label settingslbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox defaultpathbox;
        private System.Windows.Forms.Label defaltpathlbl;
        private System.Windows.Forms.Button browsedeflog;
        private System.Windows.Forms.Label logonlbl;
        private System.Windows.Forms.Label worldlbl;
        private System.Windows.Forms.Button restartworldsrvbtn;
        private System.Windows.Forms.Button stopworldsrvbtn;
        private System.Windows.Forms.Button startworldsrvbtn;
        private System.Windows.Forms.Button delworldsrvbtn;
        private System.Windows.Forms.Button addsrvbtn;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button restartlogsrvbtn;
        private System.Windows.Forms.Button stoplogsrvbtn;
        private System.Windows.Forms.Button startlogsrvbtn;
        private System.Windows.Forms.Button dellogsrvbtn;
        private System.Windows.Forms.Button addlogsrvbtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip systraymenu;
        private System.Windows.Forms.ToolStripMenuItem systrayexit;
        private System.Windows.Forms.ListBox worldlist;
        private System.Windows.Forms.ListBox logonlist;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button hidewnds;
        private System.Windows.Forms.Button showwnds;
        private System.Windows.Forms.Button savesettings;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckBox crashrestart;
        private System.Windows.Forms.Label crashrestartlbl;
        private System.Windows.Forms.Label autorestartsrvslbl;
        private System.Windows.Forms.CheckBox autorestartsrvs;
        private System.Windows.Forms.Label ttrhelp;
        private System.Windows.Forms.Label ttrlbl;
        private System.Windows.Forms.MaskedTextBox ttrbox;
        private System.Windows.Forms.CheckBox hidewndchk;
        private System.Windows.Forms.Label hidewindslbl;
        private System.Windows.Forms.RichTextBox logbox;
        private System.Windows.Forms.NumericUpDown maxlogbox;
        private System.Windows.Forms.Label numlogentrys;
        private System.Windows.Forms.GroupBox whattolog;
        private System.Windows.Forms.CheckBox shutdownbox;
        private System.Windows.Forms.CheckBox startupbox;
        private System.Windows.Forms.CheckBox srvstopbox;
        private System.Windows.Forms.CheckBox srvstartbox;
        private System.Windows.Forms.CheckBox srvrestartbox;
        private System.Windows.Forms.CheckBox crashbox;
        private System.Windows.Forms.CheckBox autorestartbox;
    }
}

