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

        private void click_change(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Dispose();
        }

        private void click_no(object sender, EventArgs e)
        {
            Dispose();
        }

        private void PathErrorDialog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 0, 0);
        }
    }
}
