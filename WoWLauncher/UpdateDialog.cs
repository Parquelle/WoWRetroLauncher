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
    public partial class UpdateDialog : Form
    {
        private int availableUpdates;
        
        public UpdateDialog()
        {
            InitializeComponent();
        }

        private void updateDialog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 0, 0);
        }

        public void Set(int availableUpdates, List<String> updatesList)
        {
            this.availableUpdates = availableUpdates;
            if (availableUpdates > 1) labelHeader.Text = "You have " + availableUpdates + " updates available on the Battle.net App";
            else  labelHeader.Text = "You have " + availableUpdates + " update available on the Battle.net App";

            labelList.Text = "";
            foreach (string loopUpdate in updatesList) labelList.Text = labelList.Text + "- " + loopUpdate + "\n";
        }

        public int GetAvailableUpdates()
        {
            return this.availableUpdates;
        }

        private void click_yes(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.Path + "\\World of Warcraft Launcher.exe");
            this.WindowState = FormWindowState.Minimized;
        }

        private void click_no(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
