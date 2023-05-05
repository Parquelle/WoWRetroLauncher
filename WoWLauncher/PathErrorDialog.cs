using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRetroLauncher
{
    public partial class PathErrorDialog : Form
    {
        public PathErrorDialog()
        {
            InitializeComponent();
        }

        private void click_okay(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
