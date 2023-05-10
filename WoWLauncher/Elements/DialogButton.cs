using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRetroLauncher
{
    internal class DialogButton : Button
    {
        private bool hovered = false;

        public DialogButton()
        {

            this.MouseEnter += new EventHandler(onHover);
            this.MouseLeave += new EventHandler(onUnhover);
            this.MouseDown += new MouseEventHandler(onPress);
            this.MouseUp += new MouseEventHandler(onRelease);

            onRelease(null, null);
        }

        public void onHover(object sender, EventArgs e)
        {
            hovered = true;
            if(Width < 100) BackgroundImage = Properties.Resources.buttonDialogSmallHover;
            else BackgroundImage = Properties.Resources.buttonDialogHover;
        }

        public void onUnhover(object sender, EventArgs e)
        {
            hovered = false;
            if (Width < 100) BackgroundImage = Properties.Resources.buttonDialogSmall;
            else BackgroundImage = Properties.Resources.buttonDialog;
        }

        private void onPress(object sender, EventArgs e)
        {
            if (Width < 100) BackgroundImage = Properties.Resources.buttonDialogSmallPress;
            else BackgroundImage = Properties.Resources.buttonDialogPress;
        }

        public void onRelease(object sender, EventArgs e)
        {
            if (!hovered) onUnhover(sender, e);
            else onHover(sender, e);
        }
    }
}
