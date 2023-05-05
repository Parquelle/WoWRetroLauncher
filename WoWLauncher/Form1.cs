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

namespace WoWLauncher
{
    public partial class MainFrame : Form
    {
        SoundPlayer soundPlayer;
        bool hovered = false;

        Bitmap play;
        Bitmap playHover;
        Bitmap playPress;
        public MainFrame()
        {
            InitializeComponent();
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            soundPlayer = new SoundPlayer(Properties.Resources.play);
            play = Properties.Resources.playbuttonNelf;
            playHover = Properties.Resources.playbuttonNelfHover;
            playPress = Properties.Resources.playbuttonNelfPress;

            WebClient client = new WebClient();
            string webData = client.DownloadString("https://www.wowhead.com/news");

            HTMLDocument document = new HTMLDocument();
            IHTMLDocument2 document2 = (IHTMLDocument2) document;
            document2.write(webData);

            int index = 0;
            foreach (IHTMLElement loopTest in document.all) {
                if (index > 2) break;
                if(loopTest.className != null && loopTest.className.Equals("news-list-card"))
                {
                    foreach(IHTMLElement loopTitle in loopTest.all)
                    {
                        if (loopTitle.tagName.Equals("A") && loopTitle.className == null && loopTitle.getAttribute("rel") == null)
                        {
                            switch(index)
                            {
                                case 0:
                                    newsTitle1.Text = loopTitle.innerText;
                                    break;
                                case 1:
                                    newsTitle2.Text = loopTitle.innerText;
                                    break;
                                case 2:
                                    newsTitle3.Text = loopTitle.innerText;
                                    break;
                            }

                            index++;
                        }
                    }
                }
            }
            Debug.Print("Loaded!");

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = playHover;
            hovered = true;
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = play;
            hovered = false;
        }

        private void buttonPlay_MouseDown(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = playPress;
        }

        private void buttonPlay_MouseClick(object sender, EventArgs e)
        {
            soundPlayer.Play();
            Process.Start("Q:\\Spil\\World of Warcraft\\_retail_\\Wow.exe");
            this.WindowState = FormWindowState.Minimized;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void minimize()
        {

        }
    }
}
