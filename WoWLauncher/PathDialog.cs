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
    public partial class PathDialog : Form
    {
        public PathDialog()
        {
            InitializeComponent();

            fieldPath.Text = Properties.Settings.Default.Path;
        }

        private void click_browse(object sender, EventArgs e)
        {
            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                fieldPath.Text = folderBrowser.SelectedPath;
            }
        }

        private void click_save(object sender, EventArgs e)
        {
            Properties.Settings.Default.Path = fieldPath.Text;
            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void PathDialog_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 0, 0);
        }
    }
}
