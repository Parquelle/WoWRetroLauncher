using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRetroLauncher
{
    public class LauncherMenuRenderer : ToolStripProfessionalRenderer
    {
        public LauncherMenuRenderer() : base(new LauncherMenuColors()) { }
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Color.White;
            base.OnRenderArrow(e);
        }
    }

    public class LauncherMenuColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(112, 112, 122); }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuBorder
        {
            get { return Color.FromArgb(52, 52, 52); }
        }
        public override Color ToolStripDropDownBackground
        {
            get { return Color.FromArgb(14, 20, 31); }
        }
        public override Color ImageMarginGradientBegin
        {
            get { return Color.FromArgb(14, 20, 31); }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return Color.FromArgb(14, 20, 31); }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return Color.FromArgb(14, 20, 31); }
        }
    }
}
