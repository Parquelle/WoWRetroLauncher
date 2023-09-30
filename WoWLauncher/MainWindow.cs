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
using static System.Windows.Forms.LinkLabel;
using System.Security.Policy;
using System.Drawing.Drawing2D;
using System.Reflection;

namespace WoWRetroLauncher
{
    public partial class MainWindow : Form
    {
        private bool showNewsBackground;
        private SoundPlayer soundPlayer;
        private UpdateDialog updateDialog;
        private SoftwareUpdateDialog softwareUpdateDialog;

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
                { "Wrath of the Lich King", "_classic_" },
                { "PTR (Retail)", "_ptr_" },
                { "PTR2 (Retail)", "_xptr_" },
                { "PTR (Classic)", "_classic_era_ptr_" },
                { "PTR (Classic WOTLK)", "_classic_ptr_" }
            };

            topBar.Renderer = new LauncherMenuRenderer();

            showNewsBackground = Properties.Settings.Default.NewsBackground;
            optionNewsBackground.Checked = showNewsBackground;
            TextureManager.GetInstance().SetSkin(Properties.Settings.Default.Skin);
            ReloadTextures();

            WebClient client = new WebClient();
            CheckSoftwareUpdates(client);
            CheckGameUpdates(client);
            try
            {
                LoadNews(client);
            } catch(WebException ex)
            {
                newsTitle1.Visible = false;
                newsTitle2.Visible = false;
                newsTitle3.Visible = false;
                newsTitle4.Visible = false;
                newsTitle5.Visible = false;
                newsTitle6.Visible = false;
                newsTitle7.Visible = false;
                newsImage1.Visible = false;
                newsImage2.Visible = false;
                newsImage3.Visible = false;
                errorLabel1.Visible = true;
                errorLabel2.Visible = true;
            }

        }
        private void OnShow(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GameVersion != null)
            {

                foreach (string loopItem in dropdownVersions.Items)
                {
                    if (loopItem.ToString().Equals(Properties.Settings.Default.GameVersion))
                    {
                        dropdownVersions.SelectedIndex = dropdownVersions.Items.IndexOf(loopItem);
                        break;
                    }
                }
            }
            ReloadGameData();

            if (softwareUpdateDialog != null) softwareUpdateDialog.ShowDialog();
            if (updateDialog != null && updateDialog.GetAvailableUpdates() > 0) updateDialog.ShowDialog();
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
                newsTitle6.LinkColor = linkColor;
                newsTitle7.LinkColor = linkColor;
            }
            else
            {
                BackgroundImage = TextureManager.GetInstance().GetBackground(0);

                linkColor = Color.FromArgb(238, 190, 83);

                if (TextureManager.GetInstance().GetCurrentSkin().Contains("wrathofthelichking")) linkColor = Color.FromArgb(223, 225, 230);
                newsTitle1.LinkColor = linkColor;
                newsTitle2.LinkColor = linkColor;
                newsTitle3.LinkColor = linkColor;
                newsTitle4.LinkColor = linkColor;
                newsTitle5.LinkColor = linkColor;
                newsTitle6.LinkColor = linkColor;
                newsTitle7.LinkColor = linkColor;
            }
        }

        // Checks game path
        private void ReloadGameData()
        {
            string originalItem = null;
            if (dropdownVersions.SelectedIndex != -1)
            {
                originalItem = (string)dropdownVersions.Items[dropdownVersions.SelectedIndex];
            }

            dropdownVersions.Items.Clear();

            foreach (string loopVersion in directories.Keys)
            {
                string exeName = "Wow.exe";
                if (directories[loopVersion].Contains("ptr") && directories[loopVersion].Contains("classic")) exeName = "WowClassicT.exe";
                else if (directories[loopVersion].Contains("ptr")) exeName = "WowT.exe";
                else if (directories[loopVersion].Contains("classic")) exeName = "WowClassic.exe";
                if (File.Exists(Properties.Settings.Default.Path + "/" + directories[loopVersion] + "/" + exeName)) this.dropdownVersions.Items.Add(loopVersion);
            }

            if (dropdownVersions.Items.Count == 0)
            {
                dropdownVersions.Enabled = false;
                VerifyGameData();
                if (new PathErrorDialog().ShowDialog() == DialogResult.OK)
                {
                    if (new PathDialog().ShowDialog() == DialogResult.OK)
                    {
                        ReloadGameData();
                        ReloadTextures();
                    }
                }
            }
            else
            {
                dropdownVersions.Enabled = true;
                if (originalItem != null)
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
                else dropdownVersions.SelectedIndex = 0;

                VerifyGameData();
            }
        }

        private void VerifyGameData()
        {
            if (dropdownVersions.SelectedIndex == -1) buttonPlay.Enabled = false;
            else buttonPlay.Enabled = true;

            ReloadTextures();
        }

        private void change_version(object sender, EventArgs e)
        {
            VerifyGameData();

            if (dropdownVersions.SelectedIndex != -1)
            {
                Properties.Settings.Default.GameVersion = dropdownVersions.Items[dropdownVersions.SelectedIndex].ToString();
                Properties.Settings.Default.Save();
            }
        }

        private void click_play(object sender, EventArgs e)
        {
            soundPlayer.Play();

            string exeName = "Wow.exe";
            string versionName = dropdownVersions.Items[dropdownVersions.SelectedIndex].ToString();

            if (directories[versionName].Contains("ptr") && directories[versionName].Contains("classic")) exeName = "WowClassicT.exe";
            else if (directories[versionName].Contains("ptr")) exeName = "WowT.exe";
            else if (directories[versionName].Contains("classic")) exeName = "WowClassic.exe";

            Process.Start(Properties.Settings.Default.Path + "\\" + directories[versionName] + "\\" + exeName);
            this.WindowState = FormWindowState.Minimized;
            System.Threading.Thread.Sleep(10000);
            this.Close();
        }

        private void click_bnet(object sender, EventArgs e)
        {
            Process.Start(Properties.Settings.Default.Path + "\\World of Warcraft Launcher.exe");
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

        private void CheckSoftwareUpdates(WebClient client)
        {
            string webData = client.DownloadString("https://parquelle.github.io/WoWRetroLauncher/version");

            int newVersion = int.Parse(webData.Split('\n')[0]);
            string newVersionName = webData.Split('\n')[1];

            if (newVersion > VersionManager.VersionNumber)
            {
                softwareUpdateDialog = new SoftwareUpdateDialog();
                softwareUpdateDialog.SetText(newVersionName);
            }
        }

        private void CheckGameUpdates(WebClient client)
        {
            int availableUpdates = 0;
            List<string> updatesList = new List<string>();

            foreach (string loopVersion in directories.Keys)
            {
                string exeName = "Wow.exe";
                if (directories[loopVersion].Contains("ptr") && directories[loopVersion].Contains("classic")) exeName = "WowClassicT.exe";
                else if (directories[loopVersion].Contains("ptr")) exeName = "WowT.exe";
                else if (directories[loopVersion].Contains("classic")) exeName = "WowClassic.exe";

                if (!File.Exists(Properties.Settings.Default.Path + "/" + directories[loopVersion] + "/" + exeName)) continue;

                string newestVersion = GetVersion(client, loopVersion);
                string userVersion = FileVersionInfo.GetVersionInfo(Properties.Settings.Default.Path + "/" + directories[loopVersion] + "/" + exeName).FileVersion;

                string[] splitNewestVersion = newestVersion.Split('.');
                string[] splitUserVersion = userVersion.Split('.');

                if (int.Parse(splitNewestVersion[0]) > int.Parse(splitUserVersion[0]))
                {
                    availableUpdates++;
                    updatesList.Add(loopVersion + "  (" + userVersion + "   >>   " + newestVersion + ")");
                }
                else if (int.Parse(splitNewestVersion[1]) > int.Parse(splitUserVersion[1]))
                {
                    availableUpdates++;
                    updatesList.Add(loopVersion + "  (" + userVersion + "   >>   " + newestVersion + ")");
                }
                else if (int.Parse(splitNewestVersion[2]) > int.Parse(splitUserVersion[2]))
                {
                    availableUpdates++;
                    updatesList.Add(loopVersion + "  (" + userVersion + "   >>   " + newestVersion + ")");
                }
                else if (int.Parse(splitNewestVersion[3]) > int.Parse(splitUserVersion[3]))
                {
                    availableUpdates++;
                    updatesList.Add(loopVersion + "  (" + userVersion + "   >>   " + newestVersion + ")");
                }
            }

            if (availableUpdates > 0)
            {
                updateDialog = new UpdateDialog();
                updateDialog.Set(availableUpdates, updatesList);
            }
        }

        private string GetVersion(WebClient client, string gameVersion)
        {
            string link = "";

            if (gameVersion.Equals("Retail")) link = "https://blizztrack.com/view/wow?type=versions";
            else if (gameVersion.Equals("Classic")) link = "https://blizztrack.com/view/wow_classic_era?type=versions";
            else if (gameVersion.Equals("Wrath of the Lich King")) link = "https://blizztrack.com/view/wow_classic?type=versions";
            else if (gameVersion.Equals("PTR (Retail)")) link = "https://blizztrack.com/view/wowt?type=versions";
            else if (gameVersion.Equals("PTR2 (Retail)")) link = "https://blizztrack.com/view/wowxptr?type=versions";
            else if (gameVersion.Equals("PTR (Classic)")) link = "https://blizztrack.com/view/wow_classic_era_ptr?type=versions";
            else if (gameVersion.Equals("PTR (Classic WOTLK)")) link = "https://blizztrack.com/view/wow_classic_ptr?type=versions";

            string webData = client.DownloadString(link);

            HTMLDocument document = new HTMLDocument();
            IHTMLDocument2 document2 = (IHTMLDocument2)document;
            document2.write(webData);

            bool elementReached = false;
            string version = "";
            foreach (IHTMLElement loopElement in document.all)
            {
                if (loopElement.tagName.Equals("LI"))
                {
                    if (loopElement.innerText.Contains("Europe account.battle.net")) elementReached = true;
                    else if (elementReached)
                    {
                        version = loopElement.innerText.Split('\r')[0];
                        version = version.Substring(0, version.Length - 1);
                        break;
                    }
                }
            }
            return version;
        }

        private void LoadNews(WebClient client)
        {
            string webData = client.DownloadString("https://news.blizzard.com/en-gb/world-of-warcraft");

            HTMLDocument document = new HTMLDocument();
            IHTMLDocument2 document2 = (IHTMLDocument2)document;
            document2.write(webData);

            int index = 0;
            foreach (IHTMLElement loopElement in document.all)
            {
                if (index > 2) break;
                if (loopElement.className != null && loopElement.className.Equals("ArticleList"))
                {
                    foreach (IHTMLElement loopArticle in loopElement.children)
                    {
                        if (index > 2) break;
                        foreach (IHTMLElement loopItem in loopArticle.all)
                        {
                            if (loopItem.className != null)
                            {
                                if (loopItem.className.Equals("ArticleListItem-image"))
                                {
                                    string imageLink = "http://" + loopItem.style.backgroundImage.Substring(6);
                                    imageLink = imageLink.Substring(0, imageLink.Length - 1);
                                    Bitmap image = new Bitmap(new WebClient().OpenRead(imageLink));
                                    switch (index)
                                    {
                                        case 0:
                                            newsImage1.BackgroundImage = image;
                                            break;
                                        case 1:
                                            newsImage2.BackgroundImage = image;
                                            break;
                                        case 2:
                                            newsImage3.BackgroundImage = image;
                                            break;
                                    }
                                }
                                else if (loopItem.className.Equals("ArticleListItem-title"))
                                {
                                    string link = "";
                                    foreach (IHTMLElement loopChild in loopItem.children)
                                    {
                                        if (loopChild.innerText.Equals(loopItem.innerText)) link = "https://news.blizzard.com" + loopChild.toString().Substring(6);
                                    }
                                    switch (index)
                                    {
                                        case 0:
                                            newsTitle1.Text = loopItem.innerText;
                                            newsTitle1.SetLink(link);
                                            break;
                                        case 1:
                                            newsTitle2.Text = loopItem.innerText;
                                            newsTitle2.SetLink(link);
                                            break;
                                        case 2:
                                            newsTitle3.Text = loopItem.innerText;
                                            newsTitle3.SetLink(link);
                                            break;
                                    }
                                }
                            }
                        }
                        index++;
                    }
                }
            }

            webData = client.DownloadString("https://www.wowhead.com/news");

            document = new HTMLDocument();
            document2 = (IHTMLDocument2)document;
            document2.write(webData);

            index = 0;
            foreach (IHTMLElement loopList in document.all)
            {
                if (index > 3) break;
                if (loopList.className != null && loopList.className.Equals("news-list") && loopList.getAttribute("data-zaf-dynamic").Equals("list"))
                {
                    foreach (IHTMLElement loopCard in loopList.children)
                    {
                        foreach (IHTMLElement loopChild in loopCard.children)
                        {
                            if (loopChild.className != null && loopChild.className.Equals("news-list-card-teaser-image"))
                            {
                                String link = "https://wowhead.com/" + loopChild.toString().Substring(6);
                                switch (index)
                                {
                                    case 0:
                                        newsTitle4.SetLink(link);
                                        break;
                                    case 1:
                                        newsTitle5.SetLink(link);
                                        break;
                                    case 2:
                                        newsTitle6.SetLink(link);
                                        break;
                                    case 3:
                                        newsTitle7.SetLink(link);
                                        break;
                                }
                            }
                            if (loopChild.className != null && loopChild.className.Equals("news-list-card-content"))
                            {
                                foreach (IHTMLElement loopChild2 in loopChild.children)
                                {
                                    if (loopChild2.className != null && loopChild2.className.Equals("heading-size-2"))
                                    {
                                        switch (index)
                                        {
                                            case 0:
                                                newsTitle4.Text = "• " + loopChild2.innerText;
                                                break;
                                            case 1:
                                                newsTitle5.Text = "• " + loopChild2.innerText;
                                                break;
                                            case 2:
                                                newsTitle6.Text = "• " + loopChild2.innerText;
                                                break;
                                            case 3:
                                                newsTitle7.Text = "• " + loopChild2.innerText;
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

        private void click_skin_race(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem)) return;

            string selectedRace = ((ToolStripMenuItem)sender).Name.Substring(14);
            
            TextureManager.GetInstance().SetSkin("race_" + selectedRace.ToLower());
            ReloadTextures();
        }

        private void click_skin_class(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem)) return;

            //optionSkinClassWarriorProtection

            string selectedClass = ((ToolStripMenuItem)sender).Name.Substring(15);

            TextureManager.GetInstance().SetSkin("class_" + selectedClass.ToLower());
            ReloadTextures();
        }
    }
}
