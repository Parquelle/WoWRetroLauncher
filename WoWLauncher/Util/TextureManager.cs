using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher
{
    internal class TextureManager
    {
        private static TextureManager instance;

        private string currentSkin = "vanilla";

        private Bitmap[] background;
        private Bitmap[] btnPlay;
        private Bitmap[] btnShort;
        private Bitmap[] btnLong;

        public TextureManager()
        {
            instance = this;

            background = new Bitmap[2];
            btnPlay = new Bitmap[4];
            btnShort = new Bitmap[3];
            btnLong = new Bitmap[3];
        }

        public void SetSkin(string skin)
        {
            currentSkin = skin;

            if(currentSkin.StartsWith("race") || currentSkin.StartsWith("class"))
            {
                background[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "");
                background[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "2");

                btnPlay[0] = Properties.Resources.battleforazeroth_buttonPlay;
                btnPlay[1] = Properties.Resources.battleforazeroth_buttonPlayHover;
                btnPlay[2] = Properties.Resources.battleforazeroth_buttonPlayPress;
                btnPlay[3] = Properties.Resources.battleforazeroth_buttonPlayDisabled;

                btnShort[0] = Properties.Resources.other_buttonShort;
                btnShort[1] = Properties.Resources.other_buttonShortHover;
                btnShort[2] = Properties.Resources.other_buttonShortPress;

                btnLong[0] = Properties.Resources.other_buttonLong;
                btnLong[1] = Properties.Resources.other_buttonLongHover;
                btnLong[2] = Properties.Resources.other_buttonLongPress;
            } else
            {
                background[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_background");
                background[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_background2");

                btnPlay[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlay");
                btnPlay[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlayHover");
                btnPlay[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlayPress");
                btnPlay[3] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlayDisabled");

                btnShort[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShort");
                btnShort[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShortHover");
                btnShort[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShortPress");

                btnLong[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLong");
                btnLong[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLongHover");
                btnLong[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLongPress");
            }


            if (Properties.Settings.Default.ChangeSkinWithVersion)
            {
                switch (Properties.Settings.Default.GameVersion)
                {
                    case "Retail":
                        Properties.Settings.Default.SkinRetail = currentSkin;
                        break;
                    case "Classic":
                        Properties.Settings.Default.SkinClassicEra = currentSkin;
                        break;
                    case "Wrath of the Lich King":
                        Properties.Settings.Default.SkinClassic = currentSkin;
                        break;
                    case "PTR (Retail)":
                        Properties.Settings.Default.SkinPtr = currentSkin;
                        break;
                    case "PTR2 (Retail)":
                        Properties.Settings.Default.SkinXptr = currentSkin;
                        break;
                    case "PTR (Classic)":
                        Properties.Settings.Default.SkinClassicEraPtr = currentSkin;
                        break;
                    case "PTR (WOTLK)":
                        Properties.Settings.Default.SkinClassicPtr = currentSkin;
                        break;
                }
            } else
            {
            }
            Properties.Settings.Default.Skin = currentSkin;
            Properties.Settings.Default.Save();
        }

        public string GetCurrentSkin()
        {
            return currentSkin;
        }

        public Bitmap GetBackground(int i) { return background[i]; }
        public Bitmap GetPlayButtonTexture(int i) { return btnPlay[i]; }
        public Bitmap GetShortButtonTexture(int i) { return btnShort[i]; }
        public Bitmap GetLongButtonTexture(int i) { return btnLong[i]; }

        public static TextureManager GetInstance() { return instance; }
    }
}
