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
using System.IO;

namespace WoWRetroLauncher
{
    public partial class MainWindow : Form
    {
        private bool showNewsBackground;
        private SoundPlayer soundPlayer;

        private Dictionary<string, string> directories;

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            new TextureManager();
            soundPlayer = new SoundPlayer(Properties.Resources.play);

            directories = new Dictionary<string, string>
            {
                { "Retail", "_retail_" },
                { "Classic", "_classic_era_" },
                { "Classic WOTLK", "_classic_" },
                { "PTR (Retail)", "_ptr_" },
                { "PTR (Classic)", "_classiC_era_ptr_" },
                { "PTR (Classic WOTLK)", "_classic_ptr_" }
            };

            showNewsBackground = Properties.Settings.Default.NewsBackground;
            optionNewsBackground.Checked = showNewsBackground;
            TextureManager.GetInstance().SetSkin(Properties.Settings.Default.Skin);
            ReloadGameData();
            dropdownVersions.Enabled = true;
            if (Properties.Settings.Default.GameVersion != null)
            {
                foreach (string loopItem in dropdownVersions.Items)
                {
                    if (loopItem.Equals(Properties.Settings.Default.GameVersion))
                    {
                        dropdownVersions.SelectedIndex = dropdownVersions.Items.IndexOf(loopItem);
                        break;
                    }
                }
            }
            VerifyGameData();
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

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void change_version(object sender, EventArgs e)
        {
            VerifyGameData();
        }

        private void click_play(object sender, EventArgs e)
        {
            soundPlayer.Play();

            string exeName = "Wow.exe";
            string versionName = dropdownVersions.Items[dropdownVersions.SelectedIndex].ToString();

            if (versionName.Contains("PTR")) exeName = "WowT.exe";
            else if (versionName.Contains("Classic")) exeName = "WowClassic.exe";

            Process.Start("Q:\\Spil\\World of Warcraft\\" + directories[versionName] + "\\" + exeName);
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

            if (!buttonPlay.Enabled) buttonPlay.BackgroundImage = TextureManager.GetInstance().GetPlayButtonTexture(3);

            Color linkColor = Color.FromArgb(50, 30, 15);

            if (showNewsBackground)
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

        private void ReloadGameData()
        {
            string originalItem = null;
            if(dropdownVersions.SelectedIndex != -1)
            {
                originalItem = (string)dropdownVersions.Items[dropdownVersions.SelectedIndex];
            }

            dropdownVersions.Items.Clear();

            foreach(string loopVersion in directories.Keys)
            {
                string exeName = "Wow.exe";
                if (loopVersion.Contains("PTR")) exeName = "WowT.exe";
                else if (loopVersion.Contains("Classic")) exeName = "WowClassic.exe";
                if (File.Exists(Properties.Settings.Default.Path + "/" + directories[loopVersion] +"/" + exeName)) this.dropdownVersions.Items.Add(loopVersion);
            }

            if (dropdownVersions.Items.Count == 0)
            {
                dropdownVersions.Enabled = false;
                new PathErrorDialog().ShowDialog();
            }
            else
            {
                dropdownVersions.Enabled = true;
                if(originalItem != null)
                {
                    foreach (string loopItem in dropdownVersions.Items)
                    {
                        if (loopItem.Equals(originalItem))
                        {
                            dropdownVersions.SelectedIndex = dropdownVersions.Items.IndexOf(loopItem);
                            break;
                        }
                    }
                }
            }

            VerifyGameData();
        }

        private void VerifyGameData()
        {
            if (dropdownVersions.SelectedIndex == -1) buttonPlay.Enabled = false;
            else buttonPlay.Enabled = true;

            ReloadTextures();

            if(dropdownVersions.SelectedIndex != -1)
            {
                Properties.Settings.Default.GameVersion = dropdownVersions.Items[dropdownVersions.SelectedIndex].ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void click_skin_vanilla(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("vanilla");
            ReloadTextures();
        }

        private void click_skin_tbc(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("burningcrusade");
            ReloadTextures();
        }

        private void click_skin_wotlk1(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("wrathofthelichking1");
            ReloadTextures();
        }

        private void click_skin_wotlk2(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("wrathofthelichking2");
            ReloadTextures();
        }

        private void click_skin_cata(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("cataclysm");
            ReloadTextures();
        }

        private void click_skin_mop(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("pandaria");
            ReloadTextures();
        }

        private void click_skin_wod(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("draenor");
            ReloadTextures();
        }

        private void click_skin_legion(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("legion");
            ReloadTextures();
        }

        private void click_skin_bfa(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("battleforazeroth");
            ReloadTextures();
        }

        private void click_skin_sl(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("shadowlands");
            ReloadTextures();
        }

        private void click_skin_df(object sender, EventArgs e)
        {
            TextureManager.GetInstance().SetSkin("dragonflight");
            ReloadTextures();
        }

        private void click_news_background(object sender, EventArgs e)
        {
            showNewsBackground = !showNewsBackground;
            this.optionNewsBackground.Checked = showNewsBackground;

            Properties.Settings.Default.NewsBackground = showNewsBackground;
            Properties.Settings.Default.Save();

            ReloadTextures();
        }

        private void click_setpath(object sender, EventArgs e)
        {
            if (new PathDialog().ShowDialog() == DialogResult.OK)
            {
                ReloadGameData();
                ReloadTextures();
            }
        }

        private void click_info(object sender, EventArgs e)
        {
            new InformationDialog().ShowDialog();
        }
    }
}
