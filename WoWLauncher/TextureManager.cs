using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWLauncher
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
            btnPlay = new Bitmap[3];
            btnShort = new Bitmap[3];
            btnLong = new Bitmap[3];
        }

        public void SetSkin(string skin)
        {
            currentSkin = skin;

            background[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_background");
            background[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_background2");

            btnPlay[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlay");
            btnPlay[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlayHover");
            btnPlay[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonPlayPress");

            btnShort[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShort");
            btnShort[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShortHover");
            btnShort[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonShortPress");

            btnLong[0] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLong");
            btnLong[1] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLongHover");
            btnLong[2] = (Bitmap)Properties.Resources.ResourceManager.GetObject(currentSkin + "_buttonLongPress");
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
