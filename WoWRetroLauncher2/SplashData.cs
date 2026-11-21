using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoWRetroLauncher2
{
    public class SplashData
    {
        public List<Splash> splashes {  get; set; }
    }

    public class Splash
    {
        public string id { get; set; }
        public string name {  get; set; }
        public string background { get; set; }
        public string foreground { get; set; }
        public string text { get; set; }
        public bool seasonal { get; set; }
        public string[] tags { get; set; }
    }
}
