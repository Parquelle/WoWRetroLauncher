namespace WoWLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.topBar = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGamePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFoonyWoonyTechnologiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newsImage1 = new System.Windows.Forms.PictureBox();
            this.newsImage2 = new System.Windows.Forms.PictureBox();
            this.newsImage3 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.newsImage4 = new System.Windows.Forms.PictureBox();
            this.newsImage5 = new System.Windows.Forms.PictureBox();
            this.newsTitle5 = new WoWLauncher.LauncherLink();
            this.newsTitle4 = new WoWLauncher.LauncherLink();
            this.newsTitle3 = new WoWLauncher.LauncherLink();
            this.newsTitle2 = new WoWLauncher.LauncherLink();
            this.newsTitle1 = new WoWLauncher.LauncherLink();
            this.buttonBnet = new WoWLauncher.LauncherButton();
            this.buttonOfficial = new WoWLauncher.LauncherButton();
            this.buttonRaiderio = new WoWLauncher.LauncherButton();
            this.buttonIcyveins = new WoWLauncher.LauncherButton();
            this.buttonWowhead = new WoWLauncher.LauncherButton();
            this.buttonStore = new WoWLauncher.LauncherButton();
            this.buttonPlay = new WoWLauncher.LauncherButton();
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
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(803, 24);
            this.topBar.TabIndex = 1;
            this.topBar.Text = "menuStrip1";
            this.topBar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSkinToolStripMenuItem,
            this.setGamePathsToolStripMenuItem});
            this.optionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // setSkinToolStripMenuItem
            // 
            this.setSkinToolStripMenuItem.Name = "setSkinToolStripMenuItem";
            this.setSkinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSkinToolStripMenuItem.Text = "Set skin...";
            // 
            // setGamePathsToolStripMenuItem
            // 
            this.setGamePathsToolStripMenuItem.Name = "setGamePathsToolStripMenuItem";
            this.setGamePathsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setGamePathsToolStripMenuItem.Text = "Set WoW path...";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareInformationToolStripMenuItem});
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // softwareInformationToolStripMenuItem
            // 
            this.softwareInformationToolStripMenuItem.Name = "softwareInformationToolStripMenuItem";
            this.softwareInformationToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.softwareInformationToolStripMenuItem.Text = "Software information";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseToolStripMenuItem,
            this.contactFoonyWoonyTechnologiesToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.howToUseToolStripMenuItem.Text = "How to use?";
            // 
            // contactFoonyWoonyTechnologiesToolStripMenuItem
            // 
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Name = "contactFoonyWoonyTechnologiesToolStripMenuItem";
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Text = "Contact";
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
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Retail",
            "Classic",
            "Classic WOTLK",
            "Retail (PTR)",
            "Classic Era (PTR)",
            "Classic WOTLK (PTR)"});
            this.comboBox1.Location = new System.Drawing.Point(30, 546);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.buttonBnet.Type = WoWLauncher.LauncherButton.ButtonType.LONG;
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
            this.buttonOfficial.Type = WoWLauncher.LauncherButton.ButtonType.SHORT;
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
            this.buttonRaiderio.Type = WoWLauncher.LauncherButton.ButtonType.SHORT;
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
            this.buttonIcyveins.Type = WoWLauncher.LauncherButton.ButtonType.SHORT;
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
            this.buttonWowhead.Type = WoWLauncher.LauncherButton.ButtonType.SHORT;
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
            this.buttonStore.Location = new System.Drawing.Point(624, 77);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(159, 27);
            this.buttonStore.TabIndex = 2;
            this.buttonStore.Text = "Blizzard Store";
            this.buttonStore.Type = WoWLauncher.LauncherButton.ButtonType.LONG;
            this.buttonStore.UseVisualStyleBackColor = true;
            this.buttonStore.Click += new System.EventHandler(this.click_store);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPlay.Location = new System.Drawing.Point(651, 524);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 74);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Type = WoWLauncher.LauncherButton.ButtonType.PLAY;
            this.buttonPlay.UseMnemonic = false;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.click_play);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.topBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topBar;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World of Warcraft";
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
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private LauncherButton buttonStore;
        private System.Windows.Forms.PictureBox newsImage1;
        private LauncherLink newsTitle1;
        private System.Windows.Forms.PictureBox newsImage2;
        private LauncherLink newsTitle2;
        private System.Windows.Forms.PictureBox newsImage3;
        private LauncherLink newsTitle3;
        private System.Windows.Forms.ToolStripMenuItem setSkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGamePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactFoonyWoonyTechnologiesToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}

