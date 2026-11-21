using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher2
{
    internal class OnlineSplashData
    {
        public string backgroundLink {  get; set; }
        public string foregroundLink { get; set; }
        public string textLink { get; set; }
        public bool emptyForeground { get; set; }
        public bool emptyText { get; set; }
        public bool hasImage { get; set; }
        public bool requireImage { get; set; }
        public bool overwriteSeasonals { get; set; }
        public bool overwriteText { get; set; }
    }
}
