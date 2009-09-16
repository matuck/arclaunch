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
            this.aboutbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logsbtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.serversbtn = new System.Windows.Forms.Button();
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
            this.settingspnl = new System.Windows.Forms.Panel();
            this.browsedeflog = new System.Windows.Forms.Button();
            this.defaultlogbox = new System.Windows.Forms.TextBox();
            this.defaltlgolbl = new System.Windows.Forms.Label();
            this.settingslbl = new System.Windows.Forms.Label();
            this.logpnl = new System.Windows.Forms.Panel();
            this.logslbl = new System.Windows.Forms.Label();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.systraymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.systrayexit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitlayout.Panel1.SuspendLayout();
            this.splitlayout.Panel2.SuspendLayout();
            this.splitlayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.serverspnl.SuspendLayout();
            this.settingspnl.SuspendLayout();
            this.logpnl.SuspendLayout();
            this.systraymenu.SuspendLayout();
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
            this.splitlayout.Panel2.Controls.Add(this.serverspnl);
            this.splitlayout.Panel2.Controls.Add(this.settingspnl);
            this.splitlayout.Panel2.Controls.Add(this.logpnl);
            this.splitlayout.Size = new System.Drawing.Size(670, 374);
            this.splitlayout.SplitterDistance = 192;
            this.splitlayout.TabIndex = 0;
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
            // 
            // stoplogsrvbtn
            // 
            this.stoplogsrvbtn.Location = new System.Drawing.Point(311, 256);
            this.stoplogsrvbtn.Name = "stoplogsrvbtn";
            this.stoplogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.stoplogsrvbtn.TabIndex = 14;
            this.stoplogsrvbtn.Text = "Stop Server";
            this.stoplogsrvbtn.UseVisualStyleBackColor = true;
            // 
            // startlogsrvbtn
            // 
            this.startlogsrvbtn.Location = new System.Drawing.Point(200, 256);
            this.startlogsrvbtn.Name = "startlogsrvbtn";
            this.startlogsrvbtn.Size = new System.Drawing.Size(104, 23);
            this.startlogsrvbtn.TabIndex = 13;
            this.startlogsrvbtn.Text = "Start Server";
            this.startlogsrvbtn.UseVisualStyleBackColor = true;
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
            // settingspnl
            // 
            this.settingspnl.BackColor = System.Drawing.Color.Transparent;
            this.settingspnl.Controls.Add(this.browsedeflog);
            this.settingspnl.Controls.Add(this.defaultlogbox);
            this.settingspnl.Controls.Add(this.defaltlgolbl);
            this.settingspnl.Controls.Add(this.settingslbl);
            this.settingspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingspnl.Location = new System.Drawing.Point(0, 0);
            this.settingspnl.Name = "settingspnl";
            this.settingspnl.Size = new System.Drawing.Size(474, 374);
            this.settingspnl.TabIndex = 0;
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
            // defaultlogbox
            // 
            this.defaultlogbox.Location = new System.Drawing.Point(159, 62);
            this.defaultlogbox.Name = "defaultlogbox";
            this.defaultlogbox.Size = new System.Drawing.Size(207, 20);
            this.defaultlogbox.TabIndex = 3;
            this.defaultlogbox.Text = global::Arclaunch.Properties.Settings.Default.deflogonsrv;
            // 
            // defaltlgolbl
            // 
            this.defaltlgolbl.AutoSize = true;
            this.defaltlgolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaltlgolbl.Location = new System.Drawing.Point(3, 62);
            this.defaltlgolbl.Name = "defaltlgolbl";
            this.defaltlgolbl.Size = new System.Drawing.Size(160, 20);
            this.defaltlgolbl.TabIndex = 2;
            this.defaltlgolbl.Text = "Default Logon Server";
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
            // logpnl
            // 
            this.logpnl.BackColor = System.Drawing.Color.Transparent;
            this.logpnl.Controls.Add(this.logslbl);
            this.logpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpnl.Location = new System.Drawing.Point(0, 0);
            this.logpnl.Name = "logpnl";
            this.logpnl.Size = new System.Drawing.Size(474, 374);
            this.logpnl.TabIndex = 0;
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
            this.splitlayout.Panel1.ResumeLayout(false);
            this.splitlayout.Panel2.ResumeLayout(false);
            this.splitlayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.serverspnl.ResumeLayout(false);
            this.serverspnl.PerformLayout();
            this.settingspnl.ResumeLayout(false);
            this.settingspnl.PerformLayout();
            this.logpnl.ResumeLayout(false);
            this.logpnl.PerformLayout();
            this.systraymenu.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox defaultlogbox;
        private System.Windows.Forms.Label defaltlgolbl;
        private System.Windows.Forms.Button browsedeflog;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
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
    }
}

