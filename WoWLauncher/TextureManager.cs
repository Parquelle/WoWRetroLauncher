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

        private Bitmap[] btnPlay;
        private Bitmap[] btnShort;
        private Bitmap[] btnLong;

        public TextureManager()
        {
            instance = this;

            btnPlay = new Bitmap[3];
            btnPlay[0] = Properties.Resources.playbuttonNelf;
            btnPlay[1] = Properties.Resources.playbuttonNelfHover;
            btnPlay[2] = Properties.Resources.playbuttonNelfPress;

            btnShort = new Bitmap[3];
            btnShort[0] = Properties.Resources.buttonShort;
            btnShort[1] = Properties.Resources.buttonShortHover;
            btnShort[2] = Properties.Resources.buttonShortPress;

            btnLong = new Bitmap[3];
            btnLong[0] = Properties.Resources.buttonLong;
            btnLong[1] = Properties.Resources.buttonLongHover;
            btnLong[2] = Properties.Resources.buttonLongPress;
        }
        public Bitmap getPlayButtonTexture(int i) { return btnPlay[i]; }
        public Bitmap getShortButtonTexture(int i) { return btnShort[i]; }
        public Bitmap getLongButtonTexture(int i) { return btnLong[i]; }

        public static TextureManager GetInstance() { return instance; }
    }
}
