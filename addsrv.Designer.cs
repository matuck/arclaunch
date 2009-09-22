namespace Arclaunch
{
    partial class addsrv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addsrv));
            this.srvnamelbl = new System.Windows.Forms.Label();
            this.srvnamebox = new System.Windows.Forms.TextBox();
            this.browsedeflog = new System.Windows.Forms.Button();
            this.srvpathbox = new System.Windows.Forms.TextBox();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.srvpathlbl = new System.Windows.Forms.Label();
            this.addsrvbtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // srvnamelbl
            // 
            this.srvnamelbl.AutoSize = true;
            this.srvnamelbl.BackColor = System.Drawing.Color.Transparent;
            this.srvnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvnamelbl.Location = new System.Drawing.Point(12, 26);
            this.srvnamelbl.Name = "srvnamelbl";
            this.srvnamelbl.Size = new System.Drawing.Size(88, 16);
            this.srvnamelbl.TabIndex = 4;
            this.srvnamelbl.Text = "Server Name";
            // 
            // srvnamebox
            // 
            this.srvnamebox.Location = new System.Drawing.Point(56, 46);
            this.srvnamebox.Name = "srvnamebox";
            this.srvnamebox.Size = new System.Drawing.Size(180, 20);
            this.srvnamebox.TabIndex = 5;
            // 
            // browsedeflog
            // 
            this.browsedeflog.Location = new System.Drawing.Point(197, 153);
            this.browsedeflog.Name = "browsedeflog";
            this.browsedeflog.Size = new System.Drawing.Size(75, 23);
            this.browsedeflog.TabIndex = 7;
            this.browsedeflog.Text = "Browse";
            this.browsedeflog.UseVisualStyleBackColor = true;
            this.browsedeflog.Click += new System.EventHandler(this.browsedeflog_Click);
            // 
            // srvpathbox
            // 
            this.srvpathbox.Location = new System.Drawing.Point(29, 127);
            this.srvpathbox.Name = "srvpathbox";
            this.srvpathbox.Size = new System.Drawing.Size(207, 20);
            this.srvpathbox.TabIndex = 6;
            this.srvpathbox.Click += new System.EventHandler(this.browsedeflog_Click);
            // 
            // srvpathlbl
            // 
            this.srvpathlbl.AutoSize = true;
            this.srvpathlbl.BackColor = System.Drawing.Color.Transparent;
            this.srvpathlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srvpathlbl.Location = new System.Drawing.Point(12, 108);
            this.srvpathlbl.Name = "srvpathlbl";
            this.srvpathlbl.Size = new System.Drawing.Size(90, 16);
            this.srvpathlbl.TabIndex = 8;
            this.srvpathlbl.Text = "Path to server";
            // 
            // addsrvbtn
            // 
            this.addsrvbtn.Location = new System.Drawing.Point(12, 229);
            this.addsrvbtn.Name = "addsrvbtn";
            this.addsrvbtn.Size = new System.Drawing.Size(133, 23);
            this.addsrvbtn.TabIndex = 9;
            this.addsrvbtn.Text = "Add Server";
            this.addsrvbtn.UseVisualStyleBackColor = true;
            this.addsrvbtn.Click += new System.EventHandler(this.addsrvbtn_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(151, 229);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 23);
            this.cancel.TabIndex = 10;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addsrv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addsrvbtn);
            this.Controls.Add(this.srvpathlbl);
            this.Controls.Add(this.browsedeflog);
            this.Controls.Add(this.srvpathbox);
            this.Controls.Add(this.srvnamebox);
            this.Controls.Add(this.srvnamelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "addsrv";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Server type was not set properly";
            this.Load += new System.EventHandler(this.addsrv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label srvnamelbl;
        private System.Windows.Forms.TextBox srvnamebox;
        private System.Windows.Forms.Button browsedeflog;
        private System.Windows.Forms.TextBox srvpathbox;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
        private System.Windows.Forms.Label srvpathlbl;
        private System.Windows.Forms.Button addsrvbtn;
        private System.Windows.Forms.Button cancel;
    }
}