using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace fPlayer_2
{
    public class visualization : IPlugin
    {
        public string name = "Visualization";
        private pluginUI pui;
        public Control getGUI(Player self)
        {
            if (pui != null) return pui;
            else {
                pui = new pluginUI();
                pui.Tag = self;
                return pui;
            }

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
