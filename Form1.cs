using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arclaunch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void serversbtn_Click(object sender, EventArgs e)
        {
            hidealltoppanels();
            serverspnl.Show();
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            hidealltoppanels();
            settingsbtn.Show();
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
    }
}
