using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Arclaunch
{
    public partial class Arclaunch : Form
    {
        public Arclaunch()
        {
            InitializeComponent();
            addlogonlistbox();
            addworldlistbox();
        }

        private void serversbtn_Click(object sender, EventArgs e)
        {
            hidealltoppanels();
            serverspnl.Show();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            hidealltoppanels();
            settingspnl.Show();
        }

        private void logsbtn_Click(object sender, EventArgs e)
        {
            hidealltoppanels();
            logpnl.Show();
        }
        private void hidealltoppanels()
        {
            serverspnl.Hide();
            settingspnl.Hide();
            logpnl.Hide();
        }
        private string[,] serverarray(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Server");
            string[,] strArray = new string[xmlnode.Count,2];
            int count = 0;;
            while (count < xmlnode.Count)
            {
                strArray[count,0] = xmlnode[count].FirstChild.InnerText;
                strArray[count,1] = xmlnode[count].LastChild.InnerText;
                count++;
            };
            return strArray;
        }
        public void addworldlistbox()
        {
            string[,] servers = this.serverarray("world.xml");
            for (int i = 0; i < servers.Length / 2; i++)
            {
                string s1 = servers[i, 0];
                this.worldlist.Items.Add(s1);
            }
        }
        public void addlogonlistbox()
        {
            string[,] logservers = this.serverarray("logon.xml");
            for (int i = 0; i < logservers.Length / 2; i++)
            {
                string sl1 = logservers[i, 0];
                this.logonlist.Items.Add(sl1);
            }
        }
        private void browsedeflog_Click(object sender, EventArgs e)
        {
            openfiledialog.FileName = "arcemu_logonserver.exe";
            openfiledialog.Filter = "|*.exe";
            if (System.IO.Directory.Exists(global::Arclaunch.Properties.Settings.Default.deflogonsrv) || System.IO.File.Exists(global::Arclaunch.Properties.Settings.Default.deflogonsrv))
            {
                openfiledialog.InitialDirectory = global::Arclaunch.Properties.Settings.Default.deflogonsrv;
            }
            else
            {
                openfiledialog.InitialDirectory = "c:\\";
            }
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                this.defaultlogbox.Text = openfiledialog.FileName;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void delworldsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void stopworldsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void startworldsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void restartworldsrvbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
