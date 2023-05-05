using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static WoWRetroLauncher.LauncherButton;
using System.ComponentModel;

namespace WoWRetroLauncher
{

    internal class LauncherLink : LinkLabel
    {
        private string link;

        [Description("Link for the Launcher link"), Category("Data")]
        public String Link
        {
            get => link;
            set => link = value;
        }

        public LauncherLink()
        {
            link = "https://wowhead.com/news";
            this.LinkClicked += new LinkLabelLinkClickedEventHandler(onClick);
        }

        public void onClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link);
        }

        public void SetLink(String link)
        {
            this.link = link;
        }

        public string GetLink()
        {
            return link;
        }

    }
}
