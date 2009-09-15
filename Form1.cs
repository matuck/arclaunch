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
        const int serverkeys = 2;
        public Arclaunch()
        {
            InitializeComponent();
            if (!File.Exists("world.xml"))
            {
                createserverxml("world");
            }
            if (!File.Exists("logon.xml"))
            {
                createserverxml("logon");
            }
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
            string[,] strArray = new string[xmlnode.Count,serverkeys];
            int count = 0;
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
            this.worldlist.Items.Clear();
            string[,] servers = this.serverarray(Application.StartupPath + "\\world.xml");
            for (int i = 0; i < servers.Length / serverkeys; i++)
            {
                string s1 = servers[i, 0];
                this.worldlist.Items.Add(s1);
            }
        }
        public void addlogonlistbox()
        {
            this.logonlist.Items.Clear();
            string[,] logservers = this.serverarray(Application.StartupPath +"\\logon.xml");
            for (int i = 0; i < logservers.Length / serverkeys; i++)
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

        private void addsrvbtn_Click(object sender, EventArgs e)
        {
            addsrv addsrv = new addsrv();
            addsrv.setservertype("world");
            addsrv.ShowDialog();
            addworldlistbox();
        }

        private void delworldsrvbtn_Click(object sender, EventArgs e)
        {
            if (worldlist.SelectedItem != null)
            {
                deleteaserver("world", worldlist.SelectedItem.ToString());
                MessageBox.Show(worldlist.SelectedItem.ToString() + " Deleted");
                addworldlistbox();
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }

        private void stopworldsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void startworldsrvbtn_Click(object sender, EventArgs e)
        {
            if (worldlist.SelectedItem != null)
            {
                string[,] servers = serverarray("world.xml");
                bool mytrue = true;
                int i = 0;
                while (mytrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == worldlist.SelectedItem.ToString())
                    {
                        mytrue = false;
                    }
                    if (mytrue)
                    {
                        i++;
                    }
                }
                if (mytrue)
                {
                    MessageBox.Show("Server Doesn't exist. Please delete this server");
                }
                else
                {
                    MessageBox.Show((string)servers[i, 1]);
                }
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }

        private void restartworldsrvbtn_Click(object sender, EventArgs e)
        {

        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            aboutarclaunch about = new aboutarclaunch();
            about.Show();
        }

        private void systrayexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addlogsrvbtn_Click(object sender, EventArgs e)
        {
            addsrv addsrv = new addsrv();
            addsrv.setservertype("logon");
            addsrv.ShowDialog();
            addlogonlistbox();
        }
        private void createserverxml(string type)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(type +".xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='utf-8' ");
            xmlWriter.WriteStartElement("Servers");
            xmlWriter.Close();

        }
        private bool deleteaserver(string type, string name)
        {
            XmlDocument docs = new XmlDocument();

            docs.Load(Application.StartupPath + "\\" + type + ".xml");
            XmlNodeList delnode = docs.SelectNodes("/Servers/Server");
            foreach (XmlNode mynode in delnode)
            {
                if (mynode["Name"].InnerText == name)
                {
                    mynode.ParentNode.RemoveChild(mynode);
                }
            }
            docs.Save(Application.StartupPath + "\\" + type + ".xml");
            return true;
        }

        private void dellogsrvbtn_Click(object sender, EventArgs e)
        {
            if (logonlist.SelectedItem != null)
            {
                deleteaserver("logon", logonlist.SelectedItem.ToString());
                MessageBox.Show(logonlist.SelectedItem.ToString() + " Deleted");
                addlogonlistbox();
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }
    }
}
