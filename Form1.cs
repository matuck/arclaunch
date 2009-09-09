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
    public partial class Arclaunch : Form
    {
        public Arclaunch()
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
    }
}
