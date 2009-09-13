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
        public addsrv()
        {
            InitializeComponent();
        }

        public bool addnewserverdialog()
        {
            this.Show();

            return true;
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
                this.srvpathbox.Text = openfiledialog.FileName;
            }
        }

        private void addsrvbtn_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("world.xml", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(fs);
            XmlElement newserver = xmldoc.CreateElement("Server");

            // First Element - Book - Created
            XmlElement nameelement = xmldoc.CreateElement("Name");
            // Value given for the first element
            nameelement.InnerText = srvnamebox.Text;
            // Append the newly created element as a child element
            newserver.AppendChild(nameelement);


            // Second Element - Publisher - Created
            XmlElement pathelement = xmldoc.CreateElement("Path");
            // Value given for the second element
            pathelement.InnerText = srvpathbox.Text;
            // Append the newly created element as a child element
            newserver.AppendChild(pathelement);

            // New XML element inserted into the document
            xmldoc.DocumentElement.InsertAfter(newserver,
                                               xmldoc.DocumentElement.LastChild);

            // An instance of FileStream class created
            // The first parameter is the path to the XML file - Catalog.xml

            FileStream fsxml = new FileStream("world.xml", FileMode.Truncate,
                                              FileAccess.Write,
                                              FileShare.ReadWrite);

            // XML Document Saved
            xmldoc.Save(fsxml);
            
            Close();
        }
    }
}
