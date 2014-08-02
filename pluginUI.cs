using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fPlayer_2
{
    public partial class pluginUI : UserControl
    {
        public pluginUI()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visualization plug-in 1.0.\r\nCopright (c) 2014, MSS Software & Services.\r\nThis program is free software, you can redistribute it\r\nunder the terms of the GNU General Public License, version 3 or (at your option) any later version.\r\nShould you have not received the GNU General Public License along with this plugin,\r\nvisit http://www.gnu.org/licenses/.");
        }

        private void pluginUI_Load(object sender, EventArgs e)
        {
            visualizationPlugin.visualizationUI vui = new visualizationPlugin.visualizationUI();
            vui.WindowState = FormWindowState.Maximized;
            vui.Tag = this.Tag;
            vui.Show();
        }

        private void pluginUI_Click(object sender, EventArgs e)
        {
            pluginUI_Load(sender, e);
        }

        private void appTitle_Click(object sender, EventArgs e)
        {
            pluginUI_Load(sender, e);
        }

        private void clicktoreturnlbl_Click(object sender, EventArgs e)
        {
            pluginUI_Load(sender, e);
        }

        private void keytip_Click(object sender, EventArgs e)
        {
            pluginUI_Load(sender, e);
        }

        
    }
}
