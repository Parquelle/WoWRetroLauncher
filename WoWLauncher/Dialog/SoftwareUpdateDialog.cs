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
    public partial class SoftwareUpdateDialog : Form
    {
        public SoftwareUpdateDialog()
        {
            InitializeComponent();
        }

        private void SoftwareUpdateDialog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 0, 0);
        }

        private void click_download(object sender, EventArgs e)
        {
            Process.Start("https://parquelle.github.io/WoWRetroLauncher");
        }

        private void click_no(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void SetText(string newVersion)
        {
            label1.Text = String.Format(label1.Text, newVersion, VersionManager.VersionName);
        }
    }
}
