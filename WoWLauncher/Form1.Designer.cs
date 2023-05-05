namespace WoWLauncher
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setGamePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactFoonyWoonyTechnologiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.newsImage1 = new System.Windows.Forms.PictureBox();
            this.newsTitle1 = new System.Windows.Forms.LinkLabel();
            this.newsImage2 = new System.Windows.Forms.PictureBox();
            this.newsTitle2 = new System.Windows.Forms.LinkLabel();
            this.newsImage3 = new System.Windows.Forms.PictureBox();
            this.newsTitle3 = new System.Windows.Forms.LinkLabel();
            this.patchImage = new System.Windows.Forms.PictureBox();
            this.patchTitle = new System.Windows.Forms.LinkLabel();
            this.labelNews = new System.Windows.Forms.Label();
            this.labelPatch = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPlay.BackgroundImage")));
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Gold;
            this.buttonPlay.Location = new System.Drawing.Point(651, 524);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 74);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseMnemonic = false;
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPlay_MouseClick);
            this.buttonPlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPlay_MouseDown);
            this.buttonPlay.MouseEnter += new System.EventHandler(this.buttonPlay_MouseEnter);
            this.buttonPlay.MouseLeave += new System.EventHandler(this.buttonPlay_MouseLeave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.setSkinToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.setSkinToolStripMenuItem.Text = "Set skin...";
            // 
            // setGamePathsToolStripMenuItem
            // 
            this.setGamePathsToolStripMenuItem.Name = "setGamePathsToolStripMenuItem";
            this.setGamePathsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.setGamePathsToolStripMenuItem.Text = "Set game paths...";
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
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.howToUseToolStripMenuItem.Text = "How to use?";
            // 
            // contactFoonyWoonyTechnologiesToolStripMenuItem
            // 
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Name = "contactFoonyWoonyTechnologiesToolStripMenuItem";
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.contactFoonyWoonyTechnologiesToolStripMenuItem.Text = "Contact";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(622, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Blizzard Store";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newsImage1
            // 
            this.newsImage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage1.BackgroundImage")));
            this.newsImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage1.Location = new System.Drawing.Point(376, 186);
            this.newsImage1.Name = "newsImage1";
            this.newsImage1.Size = new System.Drawing.Size(66, 40);
            this.newsImage1.TabIndex = 3;
            this.newsImage1.TabStop = false;
            // 
            // newsTitle1
            // 
            this.newsTitle1.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newsTitle1.LinkColor = System.Drawing.Color.Orange;
            this.newsTitle1.Location = new System.Drawing.Point(448, 186);
            this.newsTitle1.Name = "newsTitle1";
            this.newsTitle1.Size = new System.Drawing.Size(318, 40);
            this.newsTitle1.TabIndex = 4;
            this.newsTitle1.TabStop = true;
            this.newsTitle1.Text = "Embers of Neltharion Goes Live 3 May";
            // 
            // newsImage2
            // 
            this.newsImage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage2.BackgroundImage")));
            this.newsImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage2.Location = new System.Drawing.Point(376, 248);
            this.newsImage2.Name = "newsImage2";
            this.newsImage2.Size = new System.Drawing.Size(66, 40);
            this.newsImage2.TabIndex = 3;
            this.newsImage2.TabStop = false;
            // 
            // newsTitle2
            // 
            this.newsTitle2.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newsTitle2.LinkColor = System.Drawing.Color.Orange;
            this.newsTitle2.Location = new System.Drawing.Point(448, 248);
            this.newsTitle2.Name = "newsTitle2";
            this.newsTitle2.Size = new System.Drawing.Size(318, 40);
            this.newsTitle2.TabIndex = 4;
            this.newsTitle2.TabStop = true;
            this.newsTitle2.Text = "WoWCast Developer Chat";
            // 
            // newsImage3
            // 
            this.newsImage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newsImage3.BackgroundImage")));
            this.newsImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage3.Location = new System.Drawing.Point(376, 314);
            this.newsImage3.Name = "newsImage3";
            this.newsImage3.Size = new System.Drawing.Size(66, 40);
            this.newsImage3.TabIndex = 3;
            this.newsImage3.TabStop = false;
            // 
            // newsTitle3
            // 
            this.newsTitle3.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.newsTitle3.LinkColor = System.Drawing.Color.Orange;
            this.newsTitle3.Location = new System.Drawing.Point(448, 314);
            this.newsTitle3.Name = "newsTitle3";
            this.newsTitle3.Size = new System.Drawing.Size(279, 40);
            this.newsTitle3.TabIndex = 4;
            this.newsTitle3.TabStop = true;
            this.newsTitle3.Text = "Get the Lil\'XT Pet";
            // 
            // patchImage
            // 
            this.patchImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patchImage.BackgroundImage")));
            this.patchImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.patchImage.Location = new System.Drawing.Point(376, 424);
            this.patchImage.Name = "patchImage";
            this.patchImage.Size = new System.Drawing.Size(66, 40);
            this.patchImage.TabIndex = 3;
            this.patchImage.TabStop = false;
            // 
            // patchTitle
            // 
            this.patchTitle.BackColor = System.Drawing.Color.Transparent;
            this.patchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patchTitle.LinkColor = System.Drawing.Color.Orange;
            this.patchTitle.Location = new System.Drawing.Point(448, 424);
            this.patchTitle.Name = "patchTitle";
            this.patchTitle.Size = new System.Drawing.Size(355, 40);
            this.patchTitle.TabIndex = 4;
            this.patchTitle.TabStop = true;
            this.patchTitle.Text = "Dragonflight: Embers of Neltharion Content Update Notes";
            // 
            // labelNews
            // 
            this.labelNews.AutoSize = true;
            this.labelNews.BackColor = System.Drawing.Color.Transparent;
            this.labelNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNews.ForeColor = System.Drawing.Color.Gold;
            this.labelNews.Location = new System.Drawing.Point(371, 141);
            this.labelNews.Name = "labelNews";
            this.labelNews.Size = new System.Drawing.Size(67, 26);
            this.labelNews.TabIndex = 6;
            this.labelNews.Text = "News";
            // 
            // labelPatch
            // 
            this.labelPatch.AutoSize = true;
            this.labelPatch.BackColor = System.Drawing.Color.Transparent;
            this.labelPatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelPatch.ForeColor = System.Drawing.Color.Gold;
            this.labelPatch.Location = new System.Drawing.Point(371, 375);
            this.labelPatch.Name = "labelPatch";
            this.labelPatch.Size = new System.Drawing.Size(127, 26);
            this.labelPatch.TabIndex = 6;
            this.labelPatch.Text = "Patch notes";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(376, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 2);
            this.label7.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(376, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(390, 2);
            this.label8.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Retail",
            "Classic Era",
            "Classic Wrath of the Lich King",
            "Retail (PTR)",
            "Classic Era (PTR)",
            "Classic WOTLK (PTR)"});
            this.comboBox1.Location = new System.Drawing.Point(32, 555);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Orange;
            this.label9.Location = new System.Drawing.Point(29, 535);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Game version";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelPatch);
            this.Controls.Add(this.labelNews);
            this.Controls.Add(this.patchTitle);
            this.Controls.Add(this.patchImage);
            this.Controls.Add(this.newsTitle3);
            this.Controls.Add(this.newsImage3);
            this.Controls.Add(this.newsTitle2);
            this.Controls.Add(this.newsImage2);
            this.Controls.Add(this.newsTitle1);
            this.Controls.Add(this.newsImage1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "World of Warcraft";
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patchImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox newsImage1;
        private System.Windows.Forms.LinkLabel newsTitle1;
        private System.Windows.Forms.PictureBox newsImage2;
        private System.Windows.Forms.LinkLabel newsTitle2;
        private System.Windows.Forms.PictureBox newsImage3;
        private System.Windows.Forms.LinkLabel newsTitle3;
        private System.Windows.Forms.PictureBox patchImage;
        private System.Windows.Forms.LinkLabel patchTitle;
        private System.Windows.Forms.Label labelNews;
        private System.Windows.Forms.Label labelPatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem setSkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setGamePathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactFoonyWoonyTechnologiesToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
    }
}

