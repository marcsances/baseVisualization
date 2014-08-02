using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace visualizationPlugin
{
    public partial class visualizationUI : Form
    {
        public visualizationUI()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    Close();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
