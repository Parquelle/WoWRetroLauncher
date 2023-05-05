using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using mshtml;
using System.Media;
using System.Runtime.CompilerServices;

namespace WoWLauncher
{
    public partial class Launcher : Form
    {
        SoundPlayer soundPlayer;

        public Launcher()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            new TextureManager();
            soundPlayer = new SoundPlayer(Properties.Resources.play);

            TextureManager.GetInstance().SetSkin("shadowlands");
            ReloadTextures();

            WebClient client = new WebClient();
            string webData = client.DownloadString("https://www.wowhead.com/news");

            HTMLDocument document = new HTMLDocument();
            IHTMLDocument2 document2 = (IHTMLDocument2) document;
            document2.write(webData);

            int index = 0;
            foreach (IHTMLElement loopList in document.all)
            {
                if (index > 4) break;
                if(loopList.className != null && loopList.className.Equals("news-list") && loopList.getAttribute("data-zaf-dynamic").Equals("list"))
                {
                    foreach(IHTMLElement loopCard in loopList.children)
                    {
                        foreach(IHTMLElement loopChild in loopCard.children)
                        {
                            if(loopChild.className != null && loopChild.className.Equals("news-list-card-teaser-image"))
                            {
                                String imageLink = loopChild.style.backgroundImage.Substring(4);
                                imageLink = imageLink.Substring(0, imageLink.Length - 1);
                                imageLink = imageLink.Replace("?maxHeight=500", "?maxHeight=40");
                                String link = "https://www.wowhead.com" + loopChild.toString().Substring(6);
                                switch (index)
                                {
                                    case 0:
                                        newsTitle1.SetLink(link);
                                        newsImage1.Load(imageLink);
                                        break;
                                    case 1:
                                        newsTitle2.SetLink(link);
                                        newsImage2.Load(imageLink);
                                        break;
                                    case 2:
                                        newsTitle3.SetLink(link);
                                        newsImage3.Load(imageLink);
                                        break;
                                    case 3:
                                        newsTitle4.SetLink(link);
                                        newsImage4.Load(imageLink);
                                        break;
                                    case 4:
                                        newsTitle5.SetLink(link);
                                        newsImage5.Load(imageLink);
                                        break;
                                }
                            }
                            if(loopChild.className != null && loopChild.className.Equals("news-list-card-content"))
                            {
                                foreach(IHTMLElement loopChild2 in loopChild.children)
                                {
                                    if (loopChild2.className != null && loopChild2.className.Equals("heading-size-2"))
                                    {
                                        switch (index)
                                        {
                                            case 0:
                                                newsTitle1.Text = loopChild2.innerText;
                                                break;
                                            case 1:
                                                newsTitle2.Text = loopChild2.innerText;
                                                break;
                                            case 2:
                                                newsTitle3.Text = loopChild2.innerText;
                                                break;
                                            case 3:
                                                newsTitle4.Text = loopChild2.innerText;
                                                break;
                                            case 4:
                                                newsTitle5.Text = loopChild2.innerText;
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                        index++;
                    }
                }
            }
            Debug.Print("Loaded!");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void click_play(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Process.Start("Q:\\Spil\\World of Warcraft\\_retail_\\Wow.exe");
            this.WindowState = FormWindowState.Minimized;
        }

        private void click_bnet(object sender, EventArgs e)
        {
            Process.Start("Q:\\Spil\\World of Warcraft\\World of Warcraft Launcher.exe");
            this.WindowState = FormWindowState.Minimized;
        }

        private void click_store(object sender, EventArgs e)
        {
            Process.Start("https://eu.shop.battle.net/en-gb");
        }

        private void click_official(object sender, EventArgs e)
        {
            Process.Start("worldofwarcraft.com/en-gb/");
        }

        private void click_wowhead(object sender, EventArgs e)
        {
            Process.Start("https://www.wowhead.com/");
        }

        private void click_icyveins(object sender, EventArgs e)
        {
            Process.Start("https://www.icy-veins.com/");
        }

        private void click_raiderio(object sender, EventArgs e)
        {
            Process.Start("https://www.raider.io");
        }

        private void ReloadTextures()
        {
            buttonPlay.onRelease(null, null);
            buttonStore.onRelease(null, null);
            buttonBnet.onRelease(null, null);
            buttonOfficial.onRelease(null, null);
            buttonWowhead.onRelease(null, null);
            buttonIcyveins.onRelease(null, null);
            buttonRaiderio.onRelease(null, null);

            Color linkColor = Color.FromArgb(50, 30, 15);

            if (false)
            {
                BackgroundImage = TextureManager.GetInstance().GetBackground(1);

                newsTitle1.LinkColor = linkColor;
                newsTitle2.LinkColor = linkColor;
                newsTitle3.LinkColor = linkColor;
                newsTitle4.LinkColor = linkColor;
                newsTitle5.LinkColor = linkColor;
            } else
            {
                BackgroundImage = TextureManager.GetInstance().GetBackground(0);

                linkColor = Color.FromArgb(238, 190, 83);

                if(TextureManager.GetInstance().GetCurrentSkin().Contains("wrathofthelichking")) linkColor = Color.FromArgb(223, 225, 230);
                newsTitle1.LinkColor = linkColor;
                newsTitle2.LinkColor = linkColor;
                newsTitle3.LinkColor = linkColor;
                newsTitle4.LinkColor = linkColor;
                newsTitle5.LinkColor = linkColor;
            }
        }

        private void otionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
