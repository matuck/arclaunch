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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Arclaunch
{
    public partial class Arclaunch : Form
    {
        const int serverkeys = 2;
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        [DllImport("User32")] 
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

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
            timer1.Enabled = true;
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
            fs.Close();
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
            string[,] servers = serverarray(Application.StartupPath + "\\world.xml");
            bool istrue = true;
            int i = 0;
            if (worldlist.SelectedItem != null)
            {
                while (istrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == worldlist.SelectedItem.ToString())
                    {
                        istrue = false;
                    }
                    if (istrue)
                    {
                        i++;
                    }
                }

                if (File.Exists(Path.GetDirectoryName(servers[i, 1]) + "\\arcemu.pid"))
                {
                    string pidfile = Path.GetDirectoryName(servers[i, 1]) + "\\arcemu.pid";
                    StreamReader re = File.OpenText(pidfile);
                    string pid = re.ReadLine();
                    re.Close();
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                        thisproc.Kill();
                    }
                    catch (ArgumentException)
                    {

                    }
                }
            }
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
                    Process server = new Process();
                    server.StartInfo.FileName = servers[i, 1];
                    string tempdir = Environment.CurrentDirectory;
                    Environment.CurrentDirectory = Path.GetDirectoryName(servers[i, 1]);
                    server.Start();
                    Environment.CurrentDirectory = tempdir;
                }
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }

        private void restartworldsrvbtn_Click(object sender, EventArgs e)
        {
            stopworldsrvbtn_Click(sender, e);
            startworldsrvbtn_Click(sender, e);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkserverbuttons();
            checklogbuttons();
        }
        private void checkserverbuttons()
        {
            string[,] servers = serverarray(Application.StartupPath+"\\world.xml");
            bool istrue = true;
            int i = 0;
            startworldsrvbtn.Enabled = true;
            stopworldsrvbtn.Enabled = false;
            restartworldsrvbtn.Enabled = false;
            if (worldlist.SelectedItem != null)
            {
                while (istrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == worldlist.SelectedItem.ToString())
                    {
                        istrue = false;
                    }
                    if (istrue)
                    {
                        i++;
                    }
                }
                
                if (File.Exists(Path.GetDirectoryName(servers[i, 1]) + "\\arcemu.pid"))
                {
                    string pidfile = Path.GetDirectoryName(servers[i, 1]) + "\\arcemu.pid";
                    StreamReader re = File.OpenText(pidfile);
                    string pid = re.ReadLine();
                    re.Close();
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                        startworldsrvbtn.Enabled = false;
                        stopworldsrvbtn.Enabled = true;
                        restartworldsrvbtn.Enabled = true;
                    }
                    catch (ArgumentException)
                    {
                        
                    }
                }
            }
        }//end of checkserverbuttons
        private void checklogbuttons()
        {
            string[,] servers = serverarray(Application.StartupPath + "\\logon.xml");
            bool istrue = true;
            int i = 0;
            startlogsrvbtn.Enabled = true;
            stoplogsrvbtn.Enabled = false;
            restartlogsrvbtn.Enabled = false;
            if (logonlist.SelectedItem != null)
            {
                while (istrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == logonlist.SelectedItem.ToString())
                    {
                        istrue = false;
                    }
                    if (istrue)
                    {
                        i++;
                    }
                }

                if (File.Exists(Path.GetDirectoryName(servers[i, 1]) + "\\logonserver.pid"))
                {
                    string pidfile = Path.GetDirectoryName(servers[i, 1]) + "\\logonserver.pid";
                    StreamReader re = File.OpenText(pidfile);
                    string pid = re.ReadLine();
                    re.Close();
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                        startlogsrvbtn.Enabled = false;
                        stoplogsrvbtn.Enabled = true;
                        restartlogsrvbtn.Enabled = true;
                    }
                    catch (ArgumentException)
                    {

                    }
                }
            }
        }//end of checkserverbuttons

        private void startlogsrvbtn_Click(object sender, EventArgs e)
        {
            if (logonlist.SelectedItem != null)
            {
                string[,] servers = serverarray("logon.xml");
                bool mytrue = true;
                int i = 0;
                while (mytrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == logonlist.SelectedItem.ToString())
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
                    Process server = new Process();
                    server.StartInfo.FileName = servers[i, 1];
                    string tempdir = Environment.CurrentDirectory;
                    Environment.CurrentDirectory = Path.GetDirectoryName(servers[i, 1]);
                    server.Start();
                    Environment.CurrentDirectory = tempdir;
                }
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }

        private void stoplogsrvbtn_Click(object sender, EventArgs e)
        {
            string[,] servers = serverarray(Application.StartupPath + "\\logon.xml");
            bool istrue = true;
            int i = 0;
            if (logonlist.SelectedItem != null)
            {
                while (istrue == true && i < (servers.Length / serverkeys))
                {
                    if (servers[i, 0] == logonlist.SelectedItem.ToString())
                    {
                        istrue = false;
                    }
                    if (istrue)
                    {
                        i++;
                    }
                }

                if (File.Exists(Path.GetDirectoryName(servers[i, 1]) + "\\logonserver.pid"))
                {
                    string pidfile = Path.GetDirectoryName(servers[i, 1]) + "\\logonserver.pid";
                    StreamReader re = File.OpenText(pidfile);
                    string pid = re.ReadLine();
                    re.Close();
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                        thisproc.Kill();
                    }
                    catch (ArgumentException)
                    {

                    }
                }
            }
        }

        private void restartlogsrvbtn_Click(object sender, EventArgs e)
        {
            stoplogsrvbtn_Click(sender, e);
            startlogsrvbtn_Click(sender, e);
        }

        private void showwnds_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("world.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            fs.Close();
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Server");
            string[,] servers = new string[xmlnode.Count, serverkeys];
            int count = 0;
            while (count < xmlnode.Count)
            {
                string pidfile = Path.GetDirectoryName(xmlnode[count].LastChild.InnerText) + "\\arcemu.pid";
                StreamReader re = File.OpenText(pidfile);
                string pid = re.ReadLine();
                re.Close();
                Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                int hWnd = thisproc.MainWindowHandle.ToInt32();
                ShowWindow(hWnd, SW_SHOW);
                MessageBox.Show(hWnd.ToString());
                try
                {
                   
                }
                catch (ArgumentException)
                {

                }
                count++;
            }
        }

        private void hidewnds_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("world.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            fs.Close();
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Server");
            string[,] servers = new string[xmlnode.Count, serverkeys];
            int count = 0;
            while (count < xmlnode.Count)
            {
                string pidfile = Path.GetDirectoryName(xmlnode[count].LastChild.InnerText) + "\\arcemu.pid";
                StreamReader re = File.OpenText(pidfile);
                string pid = re.ReadLine();
                re.Close();
                try
                {
                    Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                    int hWnd = thisproc.MainWindowHandle.ToInt32();
                    ShowWindow(hWnd, SW_HIDE);
                }
                catch (ArgumentException)
                {

                }
                count++;
            }
        } 
    }
}
