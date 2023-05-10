using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRetroLauncher
{
    public partial class InformationDialog : Form
    {
        public InformationDialog()
        {
            InitializeComponent();
        }

        private void InformationDialog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 0, 0);

            titleLabel.Text = "World of Warcraft Retro Launcher " + VersionManager.VersionName;
        }

        private void click_ok(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
