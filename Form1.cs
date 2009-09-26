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
using System.Text.RegularExpressions;


namespace Arclaunch
{
    public partial class Arclaunch : Form
    {
        #region Variables and imports
        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        const int minsinhour = 60;
        const int secsinmin = 60;
        private int countdowntimer = 86400;
        private const int maxsecsinday = 86400;
        private int restarttimeinsecs;
        
        Hashtable worldservers = new Hashtable();//key will be server name. value will be instance of server class.
        Hashtable logonservers = new Hashtable();
        Hashtable settings = new Hashtable();

        [DllImport("User32")] 
        private static extern int ShowWindow(int hwnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool FreeConsole();
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("Kernel32")]
		private static extern IntPtr GetConsoleWindow();

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
            if (!File.Exists("config.xml"))
            {
                createconfigxml();
            }
            loadsettings();
            loadhashtables();
            addlogonlistbox();
            addworldlistbox();
            hidealltoppanels();
            serverspnl.Show();
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
            if (System.IO.Directory.Exists(settings["defaultpath"].ToString()))
            {
                folderBrowserDialog.SelectedPath = settings["defaultpath"].ToString();
            }
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.defaultpathbox.Text = folderBrowserDialog.SelectedPath;
            }
        }
        private void addsrvbtn_Click(object sender, EventArgs e)
        {
            addsrv addsrv = new addsrv();
            addsrv.setservertype("world");
            addsrv.settings = settings;
            addsrv.ShowDialog();
            Server thisserver = new Server();
            if (addsrv.name != null)
            {
                thisserver.name = addsrv.name;
                thisserver.path = addsrv.path;
                thisserver.pid = 0;
                thisserver.window = 0;
                thisserver.type = "world";
                worldservers.Add(thisserver.name, thisserver);
                addworldlistbox();
            }
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
            stopserver(worldlist.SelectedItem.ToString(), "world");
        }
        private void startworldsrvbtn_Click(object sender, EventArgs e)
        {
            startserver(worldlist.SelectedItem.ToString(), "world");
        }
        private void restartworldsrvbtn_Click(object sender, EventArgs e)
        {
            restartserver(worldlist.SelectedItem.ToString(), "world");
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
            addsrv.settings = settings;
            addsrv.ShowDialog();
            Server thisserver = new Server();
            if(addsrv.name != null)
            {
                thisserver.name = addsrv.name;
                thisserver.path = addsrv.path;
                thisserver.pid = 0;
                thisserver.window = 0;
                thisserver.type = "logon";
                logonservers.Add(thisserver.name, thisserver);
                addlogonlistbox();
            }
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
        private void startlogsrvbtn_Click(object sender, EventArgs e)
        {
            startserver(logonlist.SelectedItem.ToString(), "logon");
        }
        private void stoplogsrvbtn_Click(object sender, EventArgs e)
        {
            stopserver(logonlist.SelectedItem.ToString(), "logon");
        }
        private void restartlogsrvbtn_Click(object sender, EventArgs e)
        {
            restartserver(logonlist.SelectedItem.ToString(), "logon");
        }
        private void worldlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkserverbuttons();
        }
        private void logonlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            checklogbuttons();
        }
        private void autorestartsrvs_CheckedChanged(object sender, EventArgs e)
        {
            if (autorestartsrvs.CheckState.ToString() == "Checked")
            {
                ttrbox.Enabled = true;
                ttrlbl.Enabled = true;
                ttrhelp.Enabled = true;
            }
            else
            {
                ttrbox.Enabled = false;
                ttrlbl.Enabled = false;
                ttrhelp.Enabled = false;
            }
        }
        private void savesettings_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(defaultpathbox.Text.ToString()))
            {
                saveaconfigsetting("defaultpath", defaultpathbox.Text);
            }
            else
            {
                MessageBox.Show("Folder selected is invalid. \n All other settings will be saved.");
            }
            saveaconfigsetting("crashrestart", crashrestart.CheckState.ToString());
            saveaconfigsetting("autorestart", autorestartsrvs.CheckState.ToString());
            saveaconfigsetting("restarttime", ttrbox.Text);
            saveaconfigsetting("hidewindows", hidewndchk.CheckState.ToString());
            MessageBox.Show("Settings Saved!");

            loadsettings();
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            checkserverbuttons();
            checklogbuttons();
            if (settings["autorestart"].ToString() == "Checked")
            {
                counttorestart();
            }
           checkcrashes();
        }
        #region Show and Hide all windows.
        private void showwnds_Click(object sender, EventArgs e)
        {
            foreach (Server myserv in worldservers.Values)
            {
                ShowWindow(myserv.window, SW_SHOW);
            }
            foreach (Server myserv in logonservers.Values)
            {
                ShowWindow(myserv.window, SW_SHOW);
            }
        }
        private void hidewnds_Click(object sender, EventArgs e)
        {
            foreach (Server myserv in worldservers.Values)
            {
                ShowWindow(myserv.window, SW_HIDE);
            }
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
        private void createconfigxml()
        {
            XmlTextWriter xmlWriter = new XmlTextWriter("config.xml", System.Text.Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='utf-8' ");
            xmlWriter.WriteStartElement("Settings");
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
        private void saveaconfigsetting(string name, string value)
        {
            FileStream fs = new FileStream("config.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            fs.Close();
            XmlElement root = xmldoc.DocumentElement;
            XmlNode oldsetting = root.SelectSingleNode("/Settings/Setting[Name='" + name + "']");

            XmlElement newsetting = xmldoc.CreateElement("Setting");
            // First Element - Name created
            XmlElement nameelement = xmldoc.CreateElement("Name");
            // Value given for the first element
            nameelement.InnerText = name;
            // Append the newly created element as a child element
            newsetting.AppendChild(nameelement);

            // Second Element - Path - Created
            XmlElement pathelement = xmldoc.CreateElement("Value");
            // Value given for the second element
            pathelement.InnerText = value;
            // Append the newly created element as a child element
            newsetting.AppendChild(pathelement);
            // New XML element inserted into the document
            //root.ReplaceChild(newsetting, oldsetting);
            try
            {
                root.ReplaceChild(newsetting, oldsetting);
            }
            catch
            {
                xmldoc.DocumentElement.InsertAfter(newsetting, xmldoc.DocumentElement.LastChild);
            }
            // An instance of FileStream class created
            // The first parameter is the path to the XML file
            FileStream fsxml = new FileStream("config.xml", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
            // XML Document Saved
            xmldoc.Save(fsxml);
            fsxml.Close();
            System.Threading.Thread.Sleep(10);
        }
        private void loadsettings()
        {
            settings.Clear();
            FileStream fs = new FileStream(Application.StartupPath + "\\config.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            fs.Close();
            XmlNodeList xmlnode = xmldoc.GetElementsByTagName("Setting");
            int count = 0;
            while (count < xmlnode.Count)
            {
                settings.Add(xmlnode[count].FirstChild.InnerText, xmlnode[count].LastChild.InnerText);
                count++;
            }
            try
            {
                defaultpathbox.Text = settings["defaultpath"].ToString();
            }
            catch
            {
                defaultpathbox.Text = "Enter Path Here";
                settings.Add("defaultpath", "Enter Path Here");
            }
            //check to see if restart on crash is checked
            try
            {
                if (settings["crashrestart"].ToString() == "Checked")
                {
                    crashrestart.CheckState = CheckState.Checked;
                }
                else
                {
                    crashrestart.CheckState = CheckState.Unchecked;
                }
            }
            catch
            {
                crashrestart.CheckState = 0;
                settings.Add("crashrestart", "Unchecked");
            }
            //test to see if autorestart box should be checked
            try
            {
                if (settings["autorestart"].ToString() == "Checked")
                {
                    autorestartsrvs.CheckState = CheckState.Checked;
                }
                else
                {
                    autorestartsrvs.CheckState = CheckState.Unchecked;
                }
            }
            catch
            {
                autorestartsrvs.CheckState = 0;
                settings.Add("autorestart", "Unchecked");
            }
            //set the time to restart box
            try
            {
                ttrbox.Text = settings["restarttime"].ToString();
            }
            catch
            {
            }
            restartinsecs();
            try
            {
                if (settings["hidewindows"].ToString() == "Checked")
                {
                    autorestartsrvs.CheckState = CheckState.Checked;
                }
                else
                {
                    autorestartsrvs.CheckState = CheckState.Unchecked;
                }
            }
            catch
            {
                autorestartsrvs.CheckState = 0;
                settings.Add("hidewindows", "Unchecked");
            }
        }
        private int curtimeinsecs()
        {
            DateTime dt = DateTime.Now;
            int seconds = dt.Second;
            int minutes = dt.Minute;
            int hours = dt.Hour;

            //convert hours to minutes
            hours = hours * minsinhour;
            //add hours minutes to regular minutes
            minutes = minutes + hours;
            //convert minutes to seconds
            minutes = minutes * secsinmin;
            //add minutes secods to regular seconds.
            seconds = minutes + seconds;
            return seconds;
        }
        private void restartinsecs()
        {
            string[] restartime;
            try
            {
                restartime = Regex.Split((string)settings["restarttime"], ":");
                int hours = Convert.ToInt16(restartime[0]);
                int minutes = Convert.ToInt16(restartime[1]);
                hours = hours * minsinhour;
                minutes = minutes + hours;
                restarttimeinsecs = minutes * secsinmin;
            }
            catch
            {
            }

        }
        private void counttorestart()
        {
            if ((countdowntimer - 3) < 0)
            {
                autorestartservers();
            }
            if (restarttimeinsecs < curtimeinsecs())
            {
                int secstoadd = maxsecsinday - curtimeinsecs();
                countdowntimer = secstoadd + restarttimeinsecs;
            }
            else
            {
                countdowntimer = restarttimeinsecs - curtimeinsecs();
            }
        }
        private void checkcrashes()
        {
            Hashtable serverstorestart = new Hashtable();
            foreach (Server thisserv in logonservers.Values)
            {
                if(thisserv.pid != 0)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(thisserv.pid);
                        if ((thisproc.ProcessName != Path.GetFileNameWithoutExtension(thisserv.path)))
                        {
                            serverstorestart.Add("logon:" + thisserv.name, "logon");
                        }
                    }
                    catch
                    {
                        serverstorestart.Add("logon:" + thisserv.name, "logon");
                    }
                }
            }
            foreach (Server thisworldserv in worldservers.Values)
            {
                if (thisworldserv.pid != 0)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(thisworldserv.pid);
                        if ((thisproc.ProcessName != Path.GetFileNameWithoutExtension(thisworldserv.path)))
                        {
                            serverstorestart.Add("world:" + thisworldserv.name, "world");
                        }
                    }
                    catch
                    {
                        serverstorestart.Add("world:" + thisworldserv.name, "world");
                    }
                }
            }
            foreach (string key in serverstorestart.Keys)
            {
                string[] thiskey = Regex.Split(key, ":");
                if (serverstorestart[key].ToString() == "logon")
                {
                    if (settings["crashrestart"].ToString() == "Checked")
                    {
                        startserver(thiskey[1], "logon");
                    }
                    else
                    {
                        Server myserv = (Server)logonservers[thiskey[1]];
                        myserv.pid = 0;
                        myserv.window = 0;
                        logonservers[thiskey[1]] = myserv;
                    }
                }
                else
                {
                    if (settings["crashrestart"].ToString() == "Checked")
                    {
                        startserver(thiskey[1], "world");
                    }
                    else
                    {
                        Server myserv = (Server)worldservers[thiskey[1]];
                        myserv.pid = 0;
                        myserv.window = 0;
                        worldservers[thiskey[1]] = myserv;
                    }
                }
            }
        }
        #endregion 
        #region To stop and start servers
        private void stopserver(string srvtostop, string type)
        {
            if (srvtostop != null)
            {
                Server myserv = null;
                try
                {
                    if (type == "logon")
                    {
                        myserv = (Server)logonservers[srvtostop];
                    }
                    else
                    {
                        myserv = (Server)worldservers[srvtostop];
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Server does not exist!");
                }
                if (myserv != null)
                {
                    try
                    {
                        Process thisproc = Process.GetProcessById(Convert.ToInt32(myserv.pid));
                        //thisproc.Kill();
                        AttachConsole(thisproc.Id);
                        IntPtr handle = GetConsoleWindow();
                        SetForegroundWindow(handle);
                        SendKeys.Send("Shutdown{ENTER}");
                        FreeConsole();
                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Server is not running");
                    }
                    myserv.pid = 0;
                    myserv.window = 0;
                    if (type == "logon")
                    {
                        logonservers[srvtostop] = myserv;
                    }
                    else
                    {
                        worldservers[srvtostop] = myserv;
                    }
                }
            }
            else
            {
                MessageBox.Show("No Server Selected!");
            }
        }
        private void startserver(string srvtostart, string type)
        {
            if (srvtostart != null)
            {
                Server myserv = null;
                try
                {
                    if (type == "logon")
                    {
                        myserv = (Server)logonservers[srvtostart];
                    }
                    else
                    {
                        myserv = (Server)worldservers[srvtostart];
                    }
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
                    System.Threading.Thread.Sleep(500);
                    myserv.window = server.MainWindowHandle.ToInt32();
                    if (settings["hidewindows"].ToString() == "Checked")
                    {
                        ShowWindow(myserv.window, SW_HIDE);
                    }
                    Environment.CurrentDirectory = tempdir;
                    if (type == "logon")
                    {
                        logonservers[srvtostart] = myserv;
                    }
                    else
                    {
                        worldservers[srvtostart] = myserv;
                    }
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
        private void restartserver(string server, string type)
        {
            stopserver(server, type);
            startserver(server, type);
        }
        private void autorestartservers()
        {
            Hashtable serverstorestart = new Hashtable();
            foreach (Server thisserv in logonservers.Values)
            {
                try
                {
                    Process thisproc = Process.GetProcessById(thisserv.pid);
                    if ((thisserv.pid != 0) && (thisproc.ProcessName == Path.GetFileNameWithoutExtension(thisserv.path)))
                    {
                        serverstorestart.Add("logon:"+thisserv.name, "logon");
                    }
                }
                catch
                {

                }
            }
            foreach (Server thisworldserv in worldservers.Values)
            {
                try
                {
                    Process thisworldproc = Process.GetProcessById(thisworldserv.pid);
                    if ((thisworldserv.pid != 0) && (thisworldproc.ProcessName == Path.GetFileNameWithoutExtension(thisworldserv.path)))
                    {
                        serverstorestart.Add("world:"+thisworldserv.name, "world");
                    }
                }
                catch
                {

                }
            }
            foreach (string key in serverstorestart.Keys)
            {
                string[] thiskey = Regex.Split(key, ":");
                if (serverstorestart[key].ToString() == "logon")
                {
                    restartserver(thiskey[1], "logon");
                }
                else
                {
                    restartserver(thiskey[1], "world");
                }
            }
        }
        #endregion

    }
}
