namespace Arclaunch
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
            this.splitlayout = new System.Windows.Forms.SplitContainer();
            this.serverspnl = new System.Windows.Forms.Panel();
            this.settingspnl = new System.Windows.Forms.Panel();
            this.logpnl = new System.Windows.Forms.Panel();
            this.serversbtn = new System.Windows.Forms.Button();
            this.settingsbtn = new System.Windows.Forms.Button();
            this.logsbtn = new System.Windows.Forms.Button();
            this.serverslbl = new System.Windows.Forms.Label();
            this.settingslbl = new System.Windows.Forms.Label();
            this.logslbl = new System.Windows.Forms.Label();
            this.splitlayout.Panel1.SuspendLayout();
            this.splitlayout.Panel2.SuspendLayout();
            this.splitlayout.SuspendLayout();
            this.serverspnl.SuspendLayout();
            this.settingspnl.SuspendLayout();
            this.logpnl.SuspendLayout();
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
            this.splitlayout.Panel1.Controls.Add(this.logsbtn);
            this.splitlayout.Panel1.Controls.Add(this.settingsbtn);
            this.splitlayout.Panel1.Controls.Add(this.serversbtn);
            // 
            // splitlayout.Panel2
            // 
            this.splitlayout.Panel2.Controls.Add(this.serverspnl);
            this.splitlayout.Panel2.Controls.Add(this.logpnl);
            this.splitlayout.Panel2.Controls.Add(this.settingspnl);
            this.splitlayout.Size = new System.Drawing.Size(670, 376);
            this.splitlayout.SplitterDistance = 192;
            this.splitlayout.TabIndex = 0;
            // 
            // serverspnl
            // 
            this.serverspnl.Controls.Add(this.serverslbl);
            this.serverspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverspnl.Location = new System.Drawing.Point(0, 0);
            this.serverspnl.Name = "serverspnl";
            this.serverspnl.Size = new System.Drawing.Size(474, 376);
            this.serverspnl.TabIndex = 0;
            // 
            // settingspnl
            // 
            this.settingspnl.Controls.Add(this.settingslbl);
            this.settingspnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingspnl.Location = new System.Drawing.Point(0, 0);
            this.settingspnl.Name = "settingspnl";
            this.settingspnl.Size = new System.Drawing.Size(474, 376);
            this.settingspnl.TabIndex = 0;
            // 
            // logpnl
            // 
            this.logpnl.Controls.Add(this.logslbl);
            this.logpnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logpnl.Location = new System.Drawing.Point(0, 0);
            this.logpnl.Name = "logpnl";
            this.logpnl.Size = new System.Drawing.Size(474, 376);
            this.logpnl.TabIndex = 0;
            // 
            // serversbtn
            // 
            this.serversbtn.Location = new System.Drawing.Point(12, 12);
            this.serversbtn.Name = "serversbtn";
            this.serversbtn.Size = new System.Drawing.Size(167, 23);
            this.serversbtn.TabIndex = 0;
            this.serversbtn.Text = "Servers";
            this.serversbtn.UseVisualStyleBackColor = true;
            this.serversbtn.Click += new System.EventHandler(this.serversbtn_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Location = new System.Drawing.Point(13, 41);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(167, 23);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // logsbtn
            // 
            this.logsbtn.Location = new System.Drawing.Point(12, 70);
            this.logsbtn.Name = "logsbtn";
            this.logsbtn.Size = new System.Drawing.Size(167, 23);
            this.logsbtn.TabIndex = 2;
            this.logsbtn.Text = "Logs";
            this.logsbtn.UseVisualStyleBackColor = true;
            this.logsbtn.Click += new System.EventHandler(this.logsbtn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 376);
            this.Controls.Add(this.splitlayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitlayout.Panel1.ResumeLayout(false);
            this.splitlayout.Panel2.ResumeLayout(false);
            this.splitlayout.ResumeLayout(false);
            this.serverspnl.ResumeLayout(false);
            this.serverspnl.PerformLayout();
            this.settingspnl.ResumeLayout(false);
            this.settingspnl.PerformLayout();
            this.logpnl.ResumeLayout(false);
            this.logpnl.PerformLayout();
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
    }
}

