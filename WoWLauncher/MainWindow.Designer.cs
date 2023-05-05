﻿namespace WoWRetroLauncher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.topBar = new System.Windows.Forms.MenuStrip();
            this.barItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSetSkin = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinVanilla = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinTbc = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinWotlk1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinWotlk2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinCata = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinMop = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinWod = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinLegion = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinBfa = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinSl = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinDf = new System.Windows.Forms.ToolStripMenuItem();
            this.optionNewsBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSetPath = new System.Windows.Forms.ToolStripMenuItem();
            this.barItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSoftwareInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.barItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.optionHowTo = new System.Windows.Forms.ToolStripMenuItem();
            this.optionContact = new System.Windows.Forms.ToolStripMenuItem();
            this.newsImage1 = new System.Windows.Forms.PictureBox();
            this.newsImage2 = new System.Windows.Forms.PictureBox();
            this.newsImage3 = new System.Windows.Forms.PictureBox();
            this.dropdownVersions = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newsImage4 = new System.Windows.Forms.PictureBox();
            this.newsImage5 = new System.Windows.Forms.PictureBox();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newsTitle5 = new WoWRetroLauncher.LauncherLink();
            this.newsTitle4 = new WoWRetroLauncher.LauncherLink();
            this.newsTitle3 = new WoWRetroLauncher.LauncherLink();
            this.newsTitle2 = new WoWRetroLauncher.LauncherLink();
            this.newsTitle1 = new WoWRetroLauncher.LauncherLink();
            this.buttonBnet = new WoWRetroLauncher.LauncherButton();
            this.buttonOfficial = new WoWRetroLauncher.LauncherButton();
            this.buttonRaiderio = new WoWRetroLauncher.LauncherButton();
            this.buttonIcyveins = new WoWRetroLauncher.LauncherButton();
            this.buttonWowhead = new WoWRetroLauncher.LauncherButton();
            this.buttonStore = new WoWRetroLauncher.LauncherButton();
            this.buttonPlay = new WoWRetroLauncher.LauncherButton();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage5)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barItemOptions,
            this.barItemInfo,
            this.barItemHelp});
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(803, 24);
            this.topBar.TabIndex = 1;
            this.topBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // barItemOptions
            // 
            this.barItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSetSkin,
            this.optionNewsBackground,
            this.optionSetPath});
            this.barItemOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barItemOptions.Name = "barItemOptions";
            this.barItemOptions.Size = new System.Drawing.Size(61, 20);
            this.barItemOptions.Text = "Options";
            // 
            // optionSetSkin
            // 
            this.optionSetSkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinVanilla,
            this.optionSkinTbc,
            this.optionSkinWotlk1,
            this.optionSkinWotlk2,
            this.optionSkinCata,
            this.optionSkinMop,
            this.optionSkinWod,
            this.optionSkinLegion,
            this.optionSkinBfa,
            this.optionSkinSl,
            this.optionSkinDf});
            this.optionSetSkin.Name = "optionSetSkin";
            this.optionSetSkin.Size = new System.Drawing.Size(200, 22);
            this.optionSetSkin.Text = "Set skin";
            // 
            // optionSkinVanilla
            // 
            this.optionSkinVanilla.Name = "optionSkinVanilla";
            this.optionSkinVanilla.Size = new System.Drawing.Size(201, 22);
            this.optionSkinVanilla.Text = "Vanilla";
            this.optionSkinVanilla.Click += new System.EventHandler(this.click_skin_vanilla);
            // 
            // optionSkinTbc
            // 
            this.optionSkinTbc.Name = "optionSkinTbc";
            this.optionSkinTbc.Size = new System.Drawing.Size(201, 22);
            this.optionSkinTbc.Text = "The Burning Crusade";
            this.optionSkinTbc.Click += new System.EventHandler(this.click_skin_tbc);
            // 
            // optionSkinWotlk1
            // 
            this.optionSkinWotlk1.Name = "optionSkinWotlk1";
            this.optionSkinWotlk1.Size = new System.Drawing.Size(201, 22);
            this.optionSkinWotlk1.Text = "Wrath of the Lich King 1";
            this.optionSkinWotlk1.Click += new System.EventHandler(this.click_skin_wotlk1);
            // 
            // optionSkinWotlk2
            // 
            this.optionSkinWotlk2.Name = "optionSkinWotlk2";
            this.optionSkinWotlk2.Size = new System.Drawing.Size(201, 22);
            this.optionSkinWotlk2.Text = "Wrath of the Lich King 2";
            this.optionSkinWotlk2.Click += new System.EventHandler(this.click_skin_wotlk2);
            // 
            // optionSkinCata
            // 
            this.optionSkinCata.Name = "optionSkinCata";
            this.optionSkinCata.Size = new System.Drawing.Size(201, 22);
            this.optionSkinCata.Text = "Cataclysm";
            this.optionSkinCata.Click += new System.EventHandler(this.click_skin_cata);
            // 
            // optionSkinMop
            // 
            this.optionSkinMop.Name = "optionSkinMop";
            this.optionSkinMop.Size = new System.Drawing.Size(201, 22);
            this.optionSkinMop.Text = "Mists of Pandaria";
            this.optionSkinMop.Click += new System.EventHandler(this.click_skin_mop);
            // 
            // optionSkinWod
            // 
            this.optionSkinWod.Name = "optionSkinWod";
            this.optionSkinWod.Size = new System.Drawing.Size(201, 22);
            this.optionSkinWod.Text = "Warlords of Draenor";
            this.optionSkinWod.Click += new System.EventHandler(this.click_skin_wod);
            // 
            // optionSkinLegion
            // 
            this.optionSkinLegion.Name = "optionSkinLegion";
            this.optionSkinLegion.Size = new System.Drawing.Size(201, 22);
            this.optionSkinLegion.Text = "Legion";
            this.optionSkinLegion.Click += new System.EventHandler(this.click_skin_legion);
            // 
            // optionSkinBfa
            // 
            this.optionSkinBfa.Name = "optionSkinBfa";
            this.optionSkinBfa.Size = new System.Drawing.Size(201, 22);
            this.optionSkinBfa.Text = "Battle for Azeroth";
            // 
            // optionSkinSl
            // 
            this.optionSkinSl.Name = "optionSkinSl";
            this.optionSkinSl.Size = new System.Drawing.Size(201, 22);
            this.optionSkinSl.Text = "Shadowlands";
            this.optionSkinSl.Click += new System.EventHandler(this.click_skin_sl);
            // 
            // optionSkinDf
            // 
            this.optionSkinDf.Name = "optionSkinDf";
            this.optionSkinDf.Size = new System.Drawing.Size(201, 22);
            this.optionSkinDf.Text = "Dragonflight";
            this.optionSkinDf.Click += new System.EventHandler(this.click_skin_df);
            // 
            // optionNewsBackground
            // 
            this.optionNewsBackground.Name = "optionNewsBackground";
            this.optionNewsBackground.Size = new System.Drawing.Size(200, 22);
            this.optionNewsBackground.Text = "Show news background";
            this.optionNewsBackground.Click += new System.EventHandler(this.click_news_background);
            // 
            // optionSetPath
            // 
            this.optionSetPath.Name = "optionSetPath";
            this.optionSetPath.Size = new System.Drawing.Size(200, 22);
            this.optionSetPath.Text = "Set WoW path...";
            this.optionSetPath.Click += new System.EventHandler(this.click_setpath);
            // 
            // barItemInfo
            // 
            this.barItemInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSoftwareInformation});
            this.barItemInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barItemInfo.Name = "barItemInfo";
            this.barItemInfo.Size = new System.Drawing.Size(40, 20);
            this.barItemInfo.Text = "Info";
            // 
            // optionSoftwareInformation
            // 
            this.optionSoftwareInformation.Name = "optionSoftwareInformation";
            this.optionSoftwareInformation.Size = new System.Drawing.Size(186, 22);
            this.optionSoftwareInformation.Text = "Software information";
            // 
            // barItemHelp
            // 
            this.barItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionHowTo,
            this.optionContact});
            this.barItemHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barItemHelp.Name = "barItemHelp";
            this.barItemHelp.Size = new System.Drawing.Size(44, 20);
            this.barItemHelp.Text = "Help";
            // 
            // optionHowTo
            // 
            this.optionHowTo.Name = "optionHowTo";
            this.optionHowTo.Size = new System.Drawing.Size(139, 22);
            this.optionHowTo.Text = "How to use?";
            // 
            // optionContact
            // 
            this.optionContact.Name = "optionContact";
            this.optionContact.Size = new System.Drawing.Size(139, 22);
            this.optionContact.Text = "Contact";
            // 
            // newsImage1
            // 
            this.newsImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage1.BackgroundImage")));
            this.newsImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage1.Location = new System.Drawing.Point(365, 217);
            this.newsImage1.Name = "newsImage1";
            this.newsImage1.Size = new System.Drawing.Size(66, 40);
            this.newsImage1.TabIndex = 3;
            this.newsImage1.TabStop = false;
            // 
            // newsImage2
            // 
            this.newsImage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage2.BackgroundImage")));
            this.newsImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage2.Location = new System.Drawing.Point(365, 270);
            this.newsImage2.Name = "newsImage2";
            this.newsImage2.Size = new System.Drawing.Size(66, 40);
            this.newsImage2.TabIndex = 3;
            this.newsImage2.TabStop = false;
            // 
            // newsImage3
            // 
            this.newsImage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage3.BackgroundImage")));
            this.newsImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage3.Location = new System.Drawing.Point(365, 326);
            this.newsImage3.Name = "newsImage3";
            this.newsImage3.Size = new System.Drawing.Size(66, 40);
            this.newsImage3.TabIndex = 3;
            this.newsImage3.TabStop = false;
            // 
            // dropdownVersions
            // 
            this.dropdownVersions.BackColor = System.Drawing.SystemColors.Menu;
            this.dropdownVersions.DisplayMember = "1";
            this.dropdownVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownVersions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.dropdownVersions.FormattingEnabled = true;
            this.dropdownVersions.Items.AddRange(new object[] {
            "Retail",
            "Classic",
            "Classic WOTLK",
            "Retail (PTR)",
            "Classic Era (PTR)",
            "Classic WOTLK (PTR)"});
            this.dropdownVersions.Location = new System.Drawing.Point(30, 546);
            this.dropdownVersions.Name = "dropdownVersions";
            this.dropdownVersions.Size = new System.Drawing.Size(159, 23);
            this.dropdownVersions.TabIndex = 8;
            this.dropdownVersions.SelectedIndexChanged += new System.EventHandler(this.change_version);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.label9.Location = new System.Drawing.Point(27, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Game version";
            // 
            // newsImage4
            // 
            this.newsImage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage4.BackgroundImage")));
            this.newsImage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage4.Location = new System.Drawing.Point(366, 382);
            this.newsImage4.Name = "newsImage4";
            this.newsImage4.Size = new System.Drawing.Size(66, 40);
            this.newsImage4.TabIndex = 3;
            this.newsImage4.TabStop = false;
            // 
            // newsImage5
            // 
            this.newsImage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage5.BackgroundImage")));
            this.newsImage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage5.Location = new System.Drawing.Point(365, 444);
            this.newsImage5.Name = "newsImage5";
            this.newsImage5.Size = new System.Drawing.Size(66, 40);
            this.newsImage5.TabIndex = 3;
            this.newsImage5.TabStop = false;
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem1.Text = "Info";
            // 
            // newsTitle5
            // 
            this.newsTitle5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle5.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle5.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle5.Link = "https://wowhead.com/news";
            this.newsTitle5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle5.Location = new System.Drawing.Point(437, 444);
            this.newsTitle5.Name = "newsTitle5";
            this.newsTitle5.Size = new System.Drawing.Size(318, 40);
            this.newsTitle5.TabIndex = 4;
            this.newsTitle5.TabStop = true;
            this.newsTitle5.Text = "Get the Lil\'XT Pet";
            // 
            // newsTitle4
            // 
            this.newsTitle4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle4.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle4.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle4.Link = "https://wowhead.com/news";
            this.newsTitle4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle4.Location = new System.Drawing.Point(438, 382);
            this.newsTitle4.Name = "newsTitle4";
            this.newsTitle4.Size = new System.Drawing.Size(317, 40);
            this.newsTitle4.TabIndex = 4;
            this.newsTitle4.TabStop = true;
            this.newsTitle4.Text = "Get the Lil\'XT Pet";
            // 
            // newsTitle3
            // 
            this.newsTitle3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle3.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle3.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle3.Link = "https://wowhead.com/news";
            this.newsTitle3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle3.Location = new System.Drawing.Point(437, 326);
            this.newsTitle3.Name = "newsTitle3";
            this.newsTitle3.Size = new System.Drawing.Size(318, 40);
            this.newsTitle3.TabIndex = 4;
            this.newsTitle3.TabStop = true;
            this.newsTitle3.Text = "Get the Lil\'XT Pet";
            // 
            // newsTitle2
            // 
            this.newsTitle2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle2.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle2.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle2.Link = "https://wowhead.com/news";
            this.newsTitle2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle2.Location = new System.Drawing.Point(438, 271);
            this.newsTitle2.Name = "newsTitle2";
            this.newsTitle2.Size = new System.Drawing.Size(318, 40);
            this.newsTitle2.TabIndex = 4;
            this.newsTitle2.TabStop = true;
            this.newsTitle2.Text = "WoWCast Developer Chat";
            // 
            // newsTitle1
            // 
            this.newsTitle1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle1.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle1.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle1.Link = "https://wowhead.com/news";
            this.newsTitle1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle1.Location = new System.Drawing.Point(438, 218);
            this.newsTitle1.Name = "newsTitle1";
            this.newsTitle1.Size = new System.Drawing.Size(318, 40);
            this.newsTitle1.TabIndex = 4;
            this.newsTitle1.TabStop = true;
            this.newsTitle1.Tag = "https://www.google.com";
            this.newsTitle1.Text = "Embers of Neltharion Goes Live 3 May";
            // 
            // buttonBnet
            // 
            this.buttonBnet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBnet.BackgroundImage")));
            this.buttonBnet.FlatAppearance.BorderSize = 0;
            this.buttonBnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBnet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonBnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonBnet.Location = new System.Drawing.Point(32, 576);
            this.buttonBnet.Name = "buttonBnet";
            this.buttonBnet.Size = new System.Drawing.Size(159, 27);
            this.buttonBnet.TabIndex = 2;
            this.buttonBnet.Text = "Open battle.net";
            this.buttonBnet.Type = WoWRetroLauncher.LauncherButton.ButtonType.LONG;
            this.buttonBnet.UseVisualStyleBackColor = true;
            this.buttonBnet.Click += new System.EventHandler(this.click_bnet);
            // 
            // buttonOfficial
            // 
            this.buttonOfficial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOfficial.BackgroundImage")));
            this.buttonOfficial.FlatAppearance.BorderSize = 0;
            this.buttonOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOfficial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonOfficial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonOfficial.Location = new System.Drawing.Point(544, 539);
            this.buttonOfficial.Name = "buttonOfficial";
            this.buttonOfficial.Size = new System.Drawing.Size(91, 27);
            this.buttonOfficial.TabIndex = 2;
            this.buttonOfficial.Text = "Official site";
            this.buttonOfficial.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonOfficial.UseVisualStyleBackColor = true;
            this.buttonOfficial.Click += new System.EventHandler(this.click_official);
            // 
            // buttonRaiderio
            // 
            this.buttonRaiderio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRaiderio.BackgroundImage")));
            this.buttonRaiderio.FlatAppearance.BorderSize = 0;
            this.buttonRaiderio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRaiderio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonRaiderio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonRaiderio.Location = new System.Drawing.Point(353, 572);
            this.buttonRaiderio.Name = "buttonRaiderio";
            this.buttonRaiderio.Size = new System.Drawing.Size(91, 27);
            this.buttonRaiderio.TabIndex = 2;
            this.buttonRaiderio.Text = "Raider.IO";
            this.buttonRaiderio.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonRaiderio.UseVisualStyleBackColor = true;
            this.buttonRaiderio.Click += new System.EventHandler(this.click_raiderio);
            // 
            // buttonIcyveins
            // 
            this.buttonIcyveins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIcyveins.BackgroundImage")));
            this.buttonIcyveins.FlatAppearance.BorderSize = 0;
            this.buttonIcyveins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcyveins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonIcyveins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonIcyveins.Location = new System.Drawing.Point(450, 572);
            this.buttonIcyveins.Name = "buttonIcyveins";
            this.buttonIcyveins.Size = new System.Drawing.Size(91, 27);
            this.buttonIcyveins.TabIndex = 2;
            this.buttonIcyveins.Text = "Icy Veins";
            this.buttonIcyveins.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonIcyveins.UseVisualStyleBackColor = true;
            this.buttonIcyveins.Click += new System.EventHandler(this.click_icyveins);
            // 
            // buttonWowhead
            // 
            this.buttonWowhead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWowhead.BackgroundImage")));
            this.buttonWowhead.FlatAppearance.BorderSize = 0;
            this.buttonWowhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWowhead.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonWowhead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonWowhead.Location = new System.Drawing.Point(544, 572);
            this.buttonWowhead.Name = "buttonWowhead";
            this.buttonWowhead.Size = new System.Drawing.Size(91, 27);
            this.buttonWowhead.TabIndex = 2;
            this.buttonWowhead.Text = "Wowhead";
            this.buttonWowhead.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonWowhead.UseVisualStyleBackColor = true;
            this.buttonWowhead.Click += new System.EventHandler(this.click_wowhead);
            // 
            // buttonStore
            // 
            this.buttonStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStore.BackgroundImage")));
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonStore.Location = new System.Drawing.Point(596, 79);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(159, 27);
            this.buttonStore.TabIndex = 2;
            this.buttonStore.Text = "Blizzard Store";
            this.buttonStore.Type = WoWRetroLauncher.LauncherButton.ButtonType.LONG;
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.click_store);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlay.Location = new System.Drawing.Point(651, 524);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 74);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Type = WoWRetroLauncher.LauncherButton.ButtonType.PLAY;
            this.buttonPlay.UseMnemonic = false;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.click_play);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.vanilla_background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dropdownVersions);
            this.Controls.Add(this.newsTitle5);
            this.Controls.Add(this.newsTitle4);
            this.Controls.Add(this.newsImage5);
            this.Controls.Add(this.newsImage4);
            this.Controls.Add(this.newsTitle3);
            this.Controls.Add(this.newsImage3);
            this.Controls.Add(this.newsTitle2);
            this.Controls.Add(this.newsImage2);
            this.Controls.Add(this.newsTitle1);
            this.Controls.Add(this.newsImage1);
            this.Controls.Add(this.buttonBnet);
            this.Controls.Add(this.buttonOfficial);
            this.Controls.Add(this.buttonRaiderio);
            this.Controls.Add(this.buttonIcyveins);
            this.Controls.Add(this.buttonWowhead);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.buttonPlay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topBar;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World of Warcraft Retro Launcher V0.4 by Parquelle";
            this.Load += new System.EventHandler(this.OnLoad);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LauncherButton buttonPlay;
        private System.Windows.Forms.MenuStrip topBar;
        private System.Windows.Forms.ToolStripMenuItem barItemOptions;
        private System.Windows.Forms.ToolStripMenuItem barItemInfo;
        private System.Windows.Forms.ToolStripMenuItem barItemHelp;
        private LauncherButton buttonStore;
        private System.Windows.Forms.PictureBox newsImage1;
        private LauncherLink newsTitle1;
        private System.Windows.Forms.PictureBox newsImage2;
        private LauncherLink newsTitle2;
        private System.Windows.Forms.PictureBox newsImage3;
        private LauncherLink newsTitle3;
        private System.Windows.Forms.ToolStripMenuItem optionSetSkin;
        private System.Windows.Forms.ToolStripMenuItem optionSetPath;
        private System.Windows.Forms.ToolStripMenuItem optionSoftwareInformation;
        private System.Windows.Forms.ToolStripMenuItem optionHowTo;
        private System.Windows.Forms.ToolStripMenuItem optionContact;
        private System.Windows.Forms.ComboBox dropdownVersions;
        private System.Windows.Forms.Label label9;
        private LauncherButton buttonBnet;
        private System.Windows.Forms.PictureBox newsImage4;
        private LauncherLink newsTitle4;
        private System.Windows.Forms.PictureBox newsImage5;
        private LauncherLink newsTitle5;
        private LauncherButton buttonWowhead;
        private LauncherButton buttonIcyveins;
        private LauncherButton buttonOfficial;
        private LauncherButton buttonRaiderio;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionSkinVanilla;
        private System.Windows.Forms.ToolStripMenuItem optionSkinTbc;
        private System.Windows.Forms.ToolStripMenuItem optionSkinWotlk1;
        private System.Windows.Forms.ToolStripMenuItem optionSkinWotlk2;
        private System.Windows.Forms.ToolStripMenuItem optionSkinCata;
        private System.Windows.Forms.ToolStripMenuItem optionSkinMop;
        private System.Windows.Forms.ToolStripMenuItem optionSkinWod;
        private System.Windows.Forms.ToolStripMenuItem optionSkinLegion;
        private System.Windows.Forms.ToolStripMenuItem optionSkinBfa;
        private System.Windows.Forms.ToolStripMenuItem optionSkinSl;
        private System.Windows.Forms.ToolStripMenuItem optionSkinDf;
        private System.Windows.Forms.ToolStripMenuItem optionNewsBackground;
    }
}

