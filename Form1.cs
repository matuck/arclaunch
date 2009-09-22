using System;
using System.Collections.Generic;
using System.Collections;
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
        #region Variables and imports
        const int serverkeys = 2;
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        Hashtable worldservers = new Hashtable();//key will be server name. value will be instance of server class.
        Hashtable logonservers = new Hashtable();

        [DllImport("User32")] 
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        #endregion
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
            loadhashtables();
            addlogonlistbox();
            addworldlistbox();
            checkserverbuttons();
            checklogbuttons();
            timer1.Enabled = true;
        }

        #region Hide and Show panel
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
        #endregion
        #region Build listboxes
        private void addworldlistbox()
        {
            this.worldlist.Items.Clear();
            foreach (Server myserv in worldservers.Values)
            {
                this.worldlist.Items.Add(myserv.name);
            }
        }
        private void addlogonlistbox()
        {
            this.logonlist.Items.Clear();
            foreach (Server myserv in logonservers.Values)
            {
                this.logonlist.Items.Add(myserv.name);
            }
        }
        #endregion 
        #region Action Functions
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
            Server thisserver = new Server();
            thisserver.name = addsrv.name;
            thisserver.path = addsrv.path;
            thisserver.pid = 0;
            thisserver.window = 0;
            thisserver.type = "world";
            worldservers.Add(thisserver.name, thisserver);
            addworldlistbox();
        }
        private void delworldsrvbtn_Click(object sender, EventArgs e)
        {
            if (worldlist.SelectedItem != null)
            {
                deleteaserver("world", worldlist.SelectedItem.ToString());
                worldservers.Remove(worldlist.SelectedItem.ToString());
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
            if (worldlist.SelectedItem != null)
            {
                Server myserv = null;
                try
                {
                    myserv = (Server)worldservers[worldlist.SelectedItem.ToString()];
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Server does not exist!");
                }
                if (myserv != null)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(myserv.pid);
                        thisproc.Kill();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Server is not running");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Server Selected!");
            }
        }
        private void startworldsrvbtn_Click(object sender, EventArgs e)
        {
            if (worldlist.SelectedItem != null)
            {
                Server myserv = null;
                try
                {
                    myserv = (Server)worldservers[worldlist.SelectedItem.ToString()];
                }
                catch (ArgumentException)
                {
                }
                if (myserv != null)
                {
                    Process server = new Process();
                    server.StartInfo.FileName = myserv.path;
                    string tempdir = Environment.CurrentDirectory;
                    Environment.CurrentDirectory = Path.GetDirectoryName(myserv.path);
                    server.Start();
                    myserv.pid = server.Id;
                    myserv.window = server.MainWindowHandle.ToInt32();
                    Environment.CurrentDirectory = tempdir;
                    worldservers[worldlist.SelectedItem.ToString()] = myserv;
                }
                else
                {
                    MessageBox.Show("Server Doesn't exist. Please delete this server");
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
            Server thisserver = new Server();
            thisserver.name = addsrv.name;
            thisserver.path = addsrv.path;
            thisserver.pid = 0;
            thisserver.window = 0;
            thisserver.type = "logon";
            logonservers.Add(thisserver.name, thisserver);
            addlogonlistbox();
        }
        private void dellogsrvbtn_Click(object sender, EventArgs e)
        {
            if (logonlist.SelectedItem != null)
            {
                deleteaserver("logon", logonlist.SelectedItem.ToString());
                logonservers.Remove(logonlist.SelectedItem.ToString());
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
        private void startlogsrvbtn_Click(object sender, EventArgs e)
        {
            if (logonlist.SelectedItem != null)
            {
                Server myserv = null;
                try
                {
                    myserv = (Server)logonservers[logonlist.SelectedItem.ToString()];
                }
                catch (ArgumentException)
                {
                }
                if (myserv != null)
                {
                    Process server = new Process();
                    server.StartInfo.FileName = myserv.path;
                    string tempdir = Environment.CurrentDirectory;
                    Environment.CurrentDirectory = Path.GetDirectoryName(myserv.path);
                    server.Start();
                    myserv.pid = server.Id;
                    myserv.window = server.MainWindowHandle.ToInt32();
                    Environment.CurrentDirectory = tempdir;
                    logonservers[logonlist.SelectedItem.ToString()] = myserv;
                }
                else
                {
                    MessageBox.Show("Server Doesn't exist. Please delete this server");
                }
            }
            else
            {
                MessageBox.Show("No Server Selected");
            }
        }
        private void stoplogsrvbtn_Click(object sender, EventArgs e)
        {
            if (logonlist.SelectedItem != null)
            {
                Server myserv = null;
                try
                {
                    myserv = (Server)logonservers[logonlist.SelectedItem.ToString()];
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Server does not exist!");
                }
                if (myserv != null)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(myserv.pid);
                        thisproc.Kill();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Server is not running");
                    }
                }
            }
            else
            {
                MessageBox.Show("No Server Selected!");
            }
        }
        private void restartlogsrvbtn_Click(object sender, EventArgs e)
        {
            stoplogsrvbtn_Click(sender, e);
            startlogsrvbtn_Click(sender, e);
        }
        #endregion
        #region Show and Hide all windows.
        private void showwnds_Click(object sender, EventArgs e)
        {
            foreach (Server myserv in worldservers.Values)
            {
                ShowWindow(myserv.window, SW_SHOW);
            }
        }
        private void hidewnds_Click(object sender, EventArgs e)
        {
            foreach (Server myserv in logonservers.Values)
            {
                ShowWindow(myserv.window, SW_HIDE);
            }
        }
        #endregion
        #region Support Functions
        private void createserverxml(string type)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(type + ".xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='utf-8' ");
            xmlWriter.WriteStartElement("Servers");
            xmlWriter.Close();
        }
        private void loadhashtables()
        {
            FileStream fs = new FileStream(Application.StartupPath +"\\world.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            fs.Close();
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Server");
            int count = 0;
            while (count < xmlnode.Count)
            {
                Server myserver = new Server();
                myserver.name = xmlnode[count].FirstChild.InnerText;
                myserver.path = xmlnode[count].LastChild.InnerText;
                string pid = System.IO.File.ReadAllText(Path.GetDirectoryName(myserver.path)+"\\arcemu.pid");
                try
                {
                    Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                    if (thisproc.ProcessName == Path.GetFileNameWithoutExtension(myserver.path))
                    {
                        myserver.pid = Convert.ToInt32(pid);
                        myserver.window = thisproc.MainWindowHandle.ToInt32();
                    }
                    else
                    {
                        myserver.pid = 0;
                    }
                }
                catch
                {
                    myserver.pid = 0;
                }
                myserver.type = "world";
                worldservers.Add(xmlnode[count].FirstChild.InnerText, myserver);
                count++;
            }
            FileStream fslog = new FileStream(Application.StartupPath + "\\logon.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmllogdoc = new XmlDocument();
            xmllogdoc.Load(fslog);
            fslog.Close();
            XmlNodeList xmllognode = xmllogdoc.GetElementsByTagName("Server");
            count = 0;
            while (count < xmllognode.Count)
            {
                Server mylogserver = new Server();
                mylogserver.name = xmllognode[count].FirstChild.InnerText;
                mylogserver.path = xmllognode[count].LastChild.InnerText;
                string pid = System.IO.File.ReadAllText(Path.GetDirectoryName(mylogserver.path) + "\\logonserver.pid");
                try
                {
                    Process thisproc = Process.GetProcessById(Convert.ToInt32(pid));
                    if (thisproc.ProcessName == Path.GetFileNameWithoutExtension(mylogserver.path))
                    {
                        mylogserver.pid = Convert.ToInt32(pid);
                        mylogserver.window = thisproc.MainWindowHandle.ToInt32();
                    }
                    else
                    {
                        mylogserver.pid = 0;
                    }
                }
                catch
                {
                    mylogserver.pid = 0;
                }
                logonservers.Add(mylogserver.name, mylogserver);
                count++;
            }
        }
        private void checklogbuttons()
        {
            if (logonlist.SelectedItem != null)
            {
                Server myserv = (Server)logonservers[logonlist.SelectedItem.ToString()];
                if (myserv.pid != 0)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(myserv.pid));
                        if (thisproc.ProcessName == Path.GetFileNameWithoutExtension(myserv.path))
                        {
                            startlogsrvbtn.Enabled = false;
                            stoplogsrvbtn.Enabled = true;
                            restartlogsrvbtn.Enabled = true;
                        }
                        else
                        {
                            startlogsrvbtn.Enabled = true;
                            stoplogsrvbtn.Enabled = false;
                            restartlogsrvbtn.Enabled = false;
                        }
                    }
                    catch (ArgumentException)
                    {
                        startlogsrvbtn.Enabled = true;
                        stoplogsrvbtn.Enabled = false;
                        restartlogsrvbtn.Enabled = false;
                    }
                }
                else
                {
                    startlogsrvbtn.Enabled = true;
                    stoplogsrvbtn.Enabled = false;
                    restartlogsrvbtn.Enabled = false;
                }

            }
            else
            {
                startlogsrvbtn.Enabled = false;
                stoplogsrvbtn.Enabled = false;
                restartlogsrvbtn.Enabled = false;
            }
        }
        private void checkserverbuttons()
        {
            if (worldlist.SelectedItem != null)
            {
                Server myserv = (Server)worldservers[worldlist.SelectedItem.ToString()];
                if (myserv.pid != 0)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(myserv.pid));
                        if (thisproc.ProcessName == Path.GetFileNameWithoutExtension(myserv.path))
                        {
                            startworldsrvbtn.Enabled = false;
                            stopworldsrvbtn.Enabled = true;
                            restartworldsrvbtn.Enabled = true;
                        }
                        else
                        {
                            startworldsrvbtn.Enabled = true;
                            stopworldsrvbtn.Enabled = false;
                            restartworldsrvbtn.Enabled = false;
                        }
                    }
                    catch (ArgumentException)
                    {
                        startworldsrvbtn.Enabled = true;
                        stopworldsrvbtn.Enabled = false;
                        restartworldsrvbtn.Enabled = false;
                    }
                }
                else
                {
                    startworldsrvbtn.Enabled = true;
                    stopworldsrvbtn.Enabled = false;
                    restartworldsrvbtn.Enabled = false;
                }
                
            }
            else
            {
                startworldsrvbtn.Enabled = false;
                stopworldsrvbtn.Enabled = false;
                restartworldsrvbtn.Enabled = false;
            }
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
        #endregion
    }
}
