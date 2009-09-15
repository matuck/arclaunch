using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;


namespace Arclaunch
{
    public partial class addsrv : Form
    {
        private string servertype;
        public addsrv()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;
        }
        public void setservertype(string type)
        {
            switch (type)
            {
                case "world":
                    this.servertype = type;
                    this.Text = "Add World Server";
                    break;
                case "logon":
                    this.servertype = type;
                    this.Text = "Add Logon Server";
                    break;
                default:
                    this.servertype = null;
                    this.Text = "Server type Wasn't specified";
                    break;
            }
        }
        private void browsedeflog_Click(object sender, EventArgs e)
        {
            if (this.servertype != null && this.servertype == "world" || this.servertype == "logon")
            {
                if (this.servertype == "world")
                {
                    openfiledialog.FileName = "arcemu_world.exe";
                }
                else
                {
                    openfiledialog.FileName = "arcemu_logonserver.exe";
                }
                openfiledialog.Filter = "|*.exe";
                if (Directory.Exists(global::Arclaunch.Properties.Settings.Default.deflogonsrv) || File.Exists(global::Arclaunch.Properties.Settings.Default.deflogonsrv))
                {
                    openfiledialog.InitialDirectory = global::Arclaunch.Properties.Settings.Default.deflogonsrv;
                }
                else
                {
                    openfiledialog.InitialDirectory = "c:\\";
                }
                if (openfiledialog.ShowDialog() == DialogResult.OK)
                {
                    this.srvpathbox.Text = openfiledialog.FileName;
                }
            }
            else 
            {
                MessageBox.Show("Server type was not set properly");
            }
        }

        private void addsrvbtn_Click(object sender, EventArgs e)
        {
            if (this.servertype != null && this.servertype == "world" || this.servertype == "logon")
            {
                FileStream fs = new FileStream(Application.StartupPath + "\\" + this.servertype + ".xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(fs);
                fs.Close();
                //check to see if server name or path exists.
                bool nameexists = false;
                bool pathexists = false;
                bool validpath = false;
                XmlNodeList node = xmldoc.SelectNodes("/Servers/Server");
                foreach (XmlNode mynode in node)
                {
                    if (mynode["Name"].InnerText == srvnamebox.Text)
                    {
                        nameexists = true;
                    }
                    if (mynode["Path"].InnerText == srvpathbox.Text)
                    {
                        pathexists = true;
                    }
                }
                if (File.Exists(srvpathbox.Text))
                {
                    validpath = true;
                }
                if (!nameexists && !pathexists && validpath)
                {
                    XmlElement newserver = xmldoc.CreateElement("Server");
                    // First Element - Name created
                    XmlElement nameelement = xmldoc.CreateElement("Name");
                    // Value given for the first element
                    nameelement.InnerText = srvnamebox.Text;
                    // Append the newly created element as a child element
                    newserver.AppendChild(nameelement);

                    // Second Element - Path - Created
                    XmlElement pathelement = xmldoc.CreateElement("Path");
                    // Value given for the second element
                    pathelement.InnerText = srvpathbox.Text;
                    // Append the newly created element as a child element
                    newserver.AppendChild(pathelement);
                    // New XML element inserted into the document
                    xmldoc.DocumentElement.InsertAfter(newserver, xmldoc.DocumentElement.LastChild);

                    // An instance of FileStream class created
                    // The first parameter is the path to the XML file
                    FileStream fsxml = new FileStream(Application.StartupPath + "\\" + this.servertype + ".xml", FileMode.Truncate, FileAccess.Write, FileShare.ReadWrite);
                    // XML Document Saved
                    xmldoc.Save(fsxml);
                    fsxml.Close();
                    Close();
                }
                else
                {
                    string msg = "";
                    if (nameexists == true)
                    {
                        msg += "The name already exists.  Please choose another. \n";
                    }
                    if (pathexists == true)
                    {
                        msg += "The path already exists.  Please choose another. \n";
                    }
                    if (validpath == false)
                    {
                        msg += "The path entered is invalid. Please correct.";
                    }
                    MessageBox.Show(msg);
                }
            }
            else
            {
                MessageBox.Show("Server type was not set properly");
            }
        }
    }
}
