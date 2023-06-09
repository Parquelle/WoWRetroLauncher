﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoWRetroLauncher
{
    internal class LauncherButton : Button
    {
        private bool hovered = false;
        public enum ButtonType
        {
            SHORT,
            LONG,
            PLAY
        }

        private ButtonType buttonType;

        [Description("Type of Launcher button"), Category("Data")]
        public ButtonType Type
        {
            get => buttonType;
            set => buttonType = value;
        }

        public LauncherButton()
        {

            this.MouseEnter += new EventHandler(onHover);
            this.MouseLeave += new EventHandler(onUnhover);
            this.MouseDown += new MouseEventHandler(onPress);
            this.MouseUp += new MouseEventHandler(onRelease);

            if(TextureManager.GetInstance() != null)
            onRelease(null, null);
        }

        public void SetButtonType(ButtonType buttonType)
        {
            this.buttonType = buttonType;
        }

        public ButtonType GetButtonType()
        {
            return buttonType;
        }

        public void onHover(object sender, EventArgs e)
        {
            hovered = true;
            if (buttonType == ButtonType.PLAY) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetPlayButtonTexture(1);
            if (buttonType == ButtonType.SHORT) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetShortButtonTexture(1);
            if (buttonType == ButtonType.LONG) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetLongButtonTexture(1);
        }

        public void onUnhover(object sender, EventArgs e)
        {
            hovered = false;
            if (buttonType == ButtonType.PLAY) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetPlayButtonTexture(0);
            if (buttonType == ButtonType.SHORT) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetShortButtonTexture(0);
            if (buttonType == ButtonType.LONG) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetLongButtonTexture(0);
        }

        private void onPress(object sender, EventArgs e)
        {
            if (buttonType == ButtonType.PLAY) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetPlayButtonTexture(2);
            if (buttonType == ButtonType.SHORT) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetShortButtonTexture(2);
            if (buttonType == ButtonType.LONG) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetLongButtonTexture(2);
        }

        public void onRelease(object sender, EventArgs e)
        {
            if(!hovered)
            {
                if (buttonType == ButtonType.PLAY) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetPlayButtonTexture(0);
                if (buttonType == ButtonType.SHORT) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetShortButtonTexture(0);
                if (buttonType == ButtonType.LONG) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetLongButtonTexture(0);
            } else
            {
                if (buttonType == ButtonType.PLAY) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetPlayButtonTexture(1);
                if (buttonType == ButtonType.SHORT) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetShortButtonTexture(1);
                if (buttonType == ButtonType.LONG) BackgroundImage = (Bitmap)TextureManager.GetInstance().GetLongButtonTexture(1);
            }
        }
    }
}
