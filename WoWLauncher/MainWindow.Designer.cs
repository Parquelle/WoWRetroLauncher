using System.Windows.Forms;
using WoWRetroLauncher;

namespace WoWRetroLauncher
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
            this.optionSkinClass = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarrior = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarriorProtection = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarriorArms = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarriorFury = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPaladin = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPaladinProtection = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPaladinRetribution = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPaladinHoly = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassShaman = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassShamanElemental = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassShamanEnhancement = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassShamanRestoration = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarlock = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarlockDestruction = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarlockAffliction = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassWarlockDemonology = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinMage = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMageArcane = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMageFrost = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMageFire = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPriest = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPriestShadow = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPriestDiscipline = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassPriestHoly = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassRogue = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassRogueAssassination = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassRogueSubtlety = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassRogueOutlaw = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDruid = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDruidGuardian = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDruidFeral = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDruidBalance = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDruidRestoration = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassHunter = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassHunterBeastmastery = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassHunterMarksmanship = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassHunterSurvival = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDeathknight = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDeathknightBlood = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDeathknightFrost = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDeathknightUnholy = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMonk = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMonkBrewmaster = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMonkWindwalker = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassMonkMistweaver = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDemonhunter = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDemonhunterVengeance = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassDemonhunterHavoc = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassEvoker = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassEvokerDevastation = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinClassEvokerPreservation = new System.Windows.Forms.ToolStripMenuItem();
            this.raceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceHuman = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceDwarf = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceNightelf = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceGnome = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceDraenei = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceWorgen = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRacePandarenAlliance = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceDracthyrAlliance = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceOrc = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceUndead = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceTauren = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceTroll = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceBloodelf = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceGoblin = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRacePandarenHorde = new System.Windows.Forms.ToolStripMenuItem();
            this.optionSkinRaceDracthyrHorde = new System.Windows.Forms.ToolStripMenuItem();
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
            this.newsImage1 = new System.Windows.Forms.PictureBox();
            this.newsImage2 = new System.Windows.Forms.PictureBox();
            this.newsImage3 = new System.Windows.Forms.PictureBox();
            this.dropdownVersions = new System.Windows.Forms.ComboBox();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.newsTitle7 = new WoWRetroLauncher.LauncherLink();
            this.newsTitle6 = new WoWRetroLauncher.LauncherLink();
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
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.AutoSize = false;
            this.topBar.BackColor = System.Drawing.Color.Transparent;
            this.topBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.topBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barItemOptions,
            this.barItemInfo});
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Padding = new System.Windows.Forms.Padding(6, 0, 0, 4);
            this.topBar.Size = new System.Drawing.Size(803, 20);
            this.topBar.TabIndex = 1;
            // 
            // barItemOptions
            // 
            this.barItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSetSkin,
            this.optionNewsBackground,
            this.optionSetPath});
            this.barItemOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barItemOptions.Name = "barItemOptions";
            this.barItemOptions.Size = new System.Drawing.Size(61, 16);
            this.barItemOptions.Text = "Options";
            // 
            // optionSetSkin
            // 
            this.optionSetSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSetSkin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClass,
            this.raceToolStripMenuItem,
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
            this.optionSetSkin.ForeColor = System.Drawing.Color.White;
            this.optionSetSkin.Name = "optionSetSkin";
            this.optionSetSkin.Size = new System.Drawing.Size(199, 22);
            this.optionSetSkin.Text = "Set skin";
            // 
            // optionSkinClass
            // 
            this.optionSkinClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClass.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassWarrior,
            this.optionSkinClassPaladin,
            this.optionSkinClassShaman,
            this.optionSkinClassWarlock,
            this.optionSkinMage,
            this.optionSkinClassPriest,
            this.optionSkinClassRogue,
            this.optionSkinClassDruid,
            this.optionSkinClassHunter,
            this.optionSkinClassDeathknight,
            this.optionSkinClassMonk,
            this.optionSkinClassDemonhunter,
            this.optionSkinClassEvoker});
            this.optionSkinClass.ForeColor = System.Drawing.Color.White;
            this.optionSkinClass.Name = "optionSkinClass";
            this.optionSkinClass.Size = new System.Drawing.Size(198, 22);
            this.optionSkinClass.Text = "Class";
            // 
            // optionSkinClassWarrior
            // 
            this.optionSkinClassWarrior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarrior.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassWarriorProtection,
            this.optionSkinClassWarriorArms,
            this.optionSkinClassWarriorFury});
            this.optionSkinClassWarrior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(155)))), ((int)(((byte)(109)))));
            this.optionSkinClassWarrior.Name = "optionSkinClassWarrior";
            this.optionSkinClassWarrior.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassWarrior.Text = "Warrior";
            // 
            // optionSkinClassWarriorProtection
            // 
            this.optionSkinClassWarriorProtection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarriorProtection.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarriorProtection.Name = "optionSkinClassWarriorProtection";
            this.optionSkinClassWarriorProtection.Size = new System.Drawing.Size(127, 22);
            this.optionSkinClassWarriorProtection.Text = "Protection";
            this.optionSkinClassWarriorProtection.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassWarriorArms
            // 
            this.optionSkinClassWarriorArms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarriorArms.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarriorArms.Name = "optionSkinClassWarriorArms";
            this.optionSkinClassWarriorArms.Size = new System.Drawing.Size(127, 22);
            this.optionSkinClassWarriorArms.Text = "Arms";
            this.optionSkinClassWarriorArms.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassWarriorFury
            // 
            this.optionSkinClassWarriorFury.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarriorFury.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarriorFury.Name = "optionSkinClassWarriorFury";
            this.optionSkinClassWarriorFury.Size = new System.Drawing.Size(127, 22);
            this.optionSkinClassWarriorFury.Text = "Fury";
            this.optionSkinClassWarriorFury.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPaladin
            // 
            this.optionSkinClassPaladin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPaladin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassPaladinProtection,
            this.optionSkinClassPaladinRetribution,
            this.optionSkinClassPaladinHoly});
            this.optionSkinClassPaladin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(140)))), ((int)(((byte)(186)))));
            this.optionSkinClassPaladin.Name = "optionSkinClassPaladin";
            this.optionSkinClassPaladin.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassPaladin.Text = "Paladin";
            // 
            // optionSkinClassPaladinProtection
            // 
            this.optionSkinClassPaladinProtection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPaladinProtection.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPaladinProtection.Name = "optionSkinClassPaladinProtection";
            this.optionSkinClassPaladinProtection.Size = new System.Drawing.Size(133, 22);
            this.optionSkinClassPaladinProtection.Text = "Protection";
            this.optionSkinClassPaladinProtection.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPaladinRetribution
            // 
            this.optionSkinClassPaladinRetribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPaladinRetribution.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPaladinRetribution.Name = "optionSkinClassPaladinRetribution";
            this.optionSkinClassPaladinRetribution.Size = new System.Drawing.Size(133, 22);
            this.optionSkinClassPaladinRetribution.Text = "Retribution";
            this.optionSkinClassPaladinRetribution.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPaladinHoly
            // 
            this.optionSkinClassPaladinHoly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPaladinHoly.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPaladinHoly.Name = "optionSkinClassPaladinHoly";
            this.optionSkinClassPaladinHoly.Size = new System.Drawing.Size(133, 22);
            this.optionSkinClassPaladinHoly.Text = "Holy";
            this.optionSkinClassPaladinHoly.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassShaman
            // 
            this.optionSkinClassShaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassShaman.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassShamanElemental,
            this.optionSkinClassShamanEnhancement,
            this.optionSkinClassShamanRestoration});
            this.optionSkinClassShaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(221)))));
            this.optionSkinClassShaman.Name = "optionSkinClassShaman";
            this.optionSkinClassShaman.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassShaman.Text = "Shaman";
            // 
            // optionSkinClassShamanElemental
            // 
            this.optionSkinClassShamanElemental.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassShamanElemental.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassShamanElemental.Name = "optionSkinClassShamanElemental";
            this.optionSkinClassShamanElemental.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassShamanElemental.Text = "Elemental";
            this.optionSkinClassShamanElemental.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassShamanEnhancement
            // 
            this.optionSkinClassShamanEnhancement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassShamanEnhancement.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassShamanEnhancement.Name = "optionSkinClassShamanEnhancement";
            this.optionSkinClassShamanEnhancement.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassShamanEnhancement.Text = "Enhancement";
            this.optionSkinClassShamanEnhancement.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassShamanRestoration
            // 
            this.optionSkinClassShamanRestoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassShamanRestoration.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassShamanRestoration.Name = "optionSkinClassShamanRestoration";
            this.optionSkinClassShamanRestoration.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassShamanRestoration.Text = "Restoration";
            this.optionSkinClassShamanRestoration.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassWarlock
            // 
            this.optionSkinClassWarlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarlock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassWarlockDestruction,
            this.optionSkinClassWarlockAffliction,
            this.optionSkinClassWarlockDemonology});
            this.optionSkinClassWarlock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(136)))), ((int)(((byte)(238)))));
            this.optionSkinClassWarlock.Name = "optionSkinClassWarlock";
            this.optionSkinClassWarlock.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassWarlock.Text = "Warlock";
            // 
            // optionSkinClassWarlockDestruction
            // 
            this.optionSkinClassWarlockDestruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarlockDestruction.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarlockDestruction.Name = "optionSkinClassWarlockDestruction";
            this.optionSkinClassWarlockDestruction.Size = new System.Drawing.Size(140, 22);
            this.optionSkinClassWarlockDestruction.Text = "Destruction";
            this.optionSkinClassWarlockDestruction.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassWarlockAffliction
            // 
            this.optionSkinClassWarlockAffliction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarlockAffliction.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarlockAffliction.Name = "optionSkinClassWarlockAffliction";
            this.optionSkinClassWarlockAffliction.Size = new System.Drawing.Size(140, 22);
            this.optionSkinClassWarlockAffliction.Text = "Affliction";
            this.optionSkinClassWarlockAffliction.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassWarlockDemonology
            // 
            this.optionSkinClassWarlockDemonology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassWarlockDemonology.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassWarlockDemonology.Name = "optionSkinClassWarlockDemonology";
            this.optionSkinClassWarlockDemonology.Size = new System.Drawing.Size(140, 22);
            this.optionSkinClassWarlockDemonology.Text = "Demonology";
            this.optionSkinClassWarlockDemonology.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinMage
            // 
            this.optionSkinMage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinMage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassMageArcane,
            this.optionSkinClassMageFrost,
            this.optionSkinClassMageFire});
            this.optionSkinMage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.optionSkinMage.Name = "optionSkinMage";
            this.optionSkinMage.Size = new System.Drawing.Size(150, 22);
            this.optionSkinMage.Text = "Mage";
            // 
            // optionSkinClassMageArcane
            // 
            this.optionSkinClassMageArcane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMageArcane.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMageArcane.Name = "optionSkinClassMageArcane";
            this.optionSkinClassMageArcane.Size = new System.Drawing.Size(109, 22);
            this.optionSkinClassMageArcane.Text = "Arcane";
            this.optionSkinClassMageArcane.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassMageFrost
            // 
            this.optionSkinClassMageFrost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMageFrost.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMageFrost.Name = "optionSkinClassMageFrost";
            this.optionSkinClassMageFrost.Size = new System.Drawing.Size(109, 22);
            this.optionSkinClassMageFrost.Text = "Frost";
            this.optionSkinClassMageFrost.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassMageFire
            // 
            this.optionSkinClassMageFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMageFire.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMageFire.Name = "optionSkinClassMageFire";
            this.optionSkinClassMageFire.Size = new System.Drawing.Size(109, 22);
            this.optionSkinClassMageFire.Text = "Fire";
            this.optionSkinClassMageFire.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPriest
            // 
            this.optionSkinClassPriest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPriest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassPriestShadow,
            this.optionSkinClassPriestDiscipline,
            this.optionSkinClassPriestHoly});
            this.optionSkinClassPriest.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPriest.Name = "optionSkinClassPriest";
            this.optionSkinClassPriest.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassPriest.Text = "Priest";
            // 
            // optionSkinClassPriestShadow
            // 
            this.optionSkinClassPriestShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPriestShadow.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPriestShadow.Name = "optionSkinClassPriestShadow";
            this.optionSkinClassPriestShadow.Size = new System.Drawing.Size(124, 22);
            this.optionSkinClassPriestShadow.Text = "Shadow";
            this.optionSkinClassPriestShadow.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPriestDiscipline
            // 
            this.optionSkinClassPriestDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPriestDiscipline.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPriestDiscipline.Name = "optionSkinClassPriestDiscipline";
            this.optionSkinClassPriestDiscipline.Size = new System.Drawing.Size(124, 22);
            this.optionSkinClassPriestDiscipline.Text = "Discipline";
            this.optionSkinClassPriestDiscipline.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassPriestHoly
            // 
            this.optionSkinClassPriestHoly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassPriestHoly.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassPriestHoly.Name = "optionSkinClassPriestHoly";
            this.optionSkinClassPriestHoly.Size = new System.Drawing.Size(124, 22);
            this.optionSkinClassPriestHoly.Text = "Holy";
            this.optionSkinClassPriestHoly.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassRogue
            // 
            this.optionSkinClassRogue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassRogue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassRogueAssassination,
            this.optionSkinClassRogueSubtlety,
            this.optionSkinClassRogueOutlaw});
            this.optionSkinClassRogue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(104)))));
            this.optionSkinClassRogue.Name = "optionSkinClassRogue";
            this.optionSkinClassRogue.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassRogue.Text = "Rogue";
            // 
            // optionSkinClassRogueAssassination
            // 
            this.optionSkinClassRogueAssassination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassRogueAssassination.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassRogueAssassination.Name = "optionSkinClassRogueAssassination";
            this.optionSkinClassRogueAssassination.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassRogueAssassination.Text = "Assassination";
            this.optionSkinClassRogueAssassination.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassRogueSubtlety
            // 
            this.optionSkinClassRogueSubtlety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassRogueSubtlety.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassRogueSubtlety.Name = "optionSkinClassRogueSubtlety";
            this.optionSkinClassRogueSubtlety.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassRogueSubtlety.Text = "Subtlety";
            this.optionSkinClassRogueSubtlety.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassRogueOutlaw
            // 
            this.optionSkinClassRogueOutlaw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassRogueOutlaw.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassRogueOutlaw.Name = "optionSkinClassRogueOutlaw";
            this.optionSkinClassRogueOutlaw.Size = new System.Drawing.Size(144, 22);
            this.optionSkinClassRogueOutlaw.Text = "Outlaw";
            this.optionSkinClassRogueOutlaw.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDruid
            // 
            this.optionSkinClassDruid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDruid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassDruidGuardian,
            this.optionSkinClassDruidFeral,
            this.optionSkinClassDruidBalance,
            this.optionSkinClassDruidRestoration});
            this.optionSkinClassDruid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(124)))), ((int)(((byte)(10)))));
            this.optionSkinClassDruid.Name = "optionSkinClassDruid";
            this.optionSkinClassDruid.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassDruid.Text = "Druid";
            // 
            // optionSkinClassDruidGuardian
            // 
            this.optionSkinClassDruidGuardian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDruidGuardian.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDruidGuardian.Name = "optionSkinClassDruidGuardian";
            this.optionSkinClassDruidGuardian.Size = new System.Drawing.Size(134, 22);
            this.optionSkinClassDruidGuardian.Text = "Guardian";
            this.optionSkinClassDruidGuardian.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDruidFeral
            // 
            this.optionSkinClassDruidFeral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDruidFeral.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDruidFeral.Name = "optionSkinClassDruidFeral";
            this.optionSkinClassDruidFeral.Size = new System.Drawing.Size(134, 22);
            this.optionSkinClassDruidFeral.Text = "Feral";
            this.optionSkinClassDruidFeral.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDruidBalance
            // 
            this.optionSkinClassDruidBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDruidBalance.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDruidBalance.Name = "optionSkinClassDruidBalance";
            this.optionSkinClassDruidBalance.Size = new System.Drawing.Size(134, 22);
            this.optionSkinClassDruidBalance.Text = "Balance";
            this.optionSkinClassDruidBalance.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDruidRestoration
            // 
            this.optionSkinClassDruidRestoration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDruidRestoration.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDruidRestoration.Name = "optionSkinClassDruidRestoration";
            this.optionSkinClassDruidRestoration.Size = new System.Drawing.Size(134, 22);
            this.optionSkinClassDruidRestoration.Text = "Restoration";
            this.optionSkinClassDruidRestoration.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassHunter
            // 
            this.optionSkinClassHunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassHunter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassHunterBeastmastery,
            this.optionSkinClassHunterMarksmanship,
            this.optionSkinClassHunterSurvival});
            this.optionSkinClassHunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(211)))), ((int)(((byte)(114)))));
            this.optionSkinClassHunter.Name = "optionSkinClassHunter";
            this.optionSkinClassHunter.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassHunter.Text = "Hunter";
            // 
            // optionSkinClassHunterBeastmastery
            // 
            this.optionSkinClassHunterBeastmastery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassHunterBeastmastery.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassHunterBeastmastery.Name = "optionSkinClassHunterBeastmastery";
            this.optionSkinClassHunterBeastmastery.Size = new System.Drawing.Size(149, 22);
            this.optionSkinClassHunterBeastmastery.Text = "Beast Mastery";
            this.optionSkinClassHunterBeastmastery.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassHunterMarksmanship
            // 
            this.optionSkinClassHunterMarksmanship.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassHunterMarksmanship.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassHunterMarksmanship.Name = "optionSkinClassHunterMarksmanship";
            this.optionSkinClassHunterMarksmanship.Size = new System.Drawing.Size(149, 22);
            this.optionSkinClassHunterMarksmanship.Text = "Marksmanship";
            this.optionSkinClassHunterMarksmanship.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassHunterSurvival
            // 
            this.optionSkinClassHunterSurvival.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassHunterSurvival.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassHunterSurvival.Name = "optionSkinClassHunterSurvival";
            this.optionSkinClassHunterSurvival.Size = new System.Drawing.Size(149, 22);
            this.optionSkinClassHunterSurvival.Text = "Survival";
            this.optionSkinClassHunterSurvival.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDeathknight
            // 
            this.optionSkinClassDeathknight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDeathknight.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassDeathknightBlood,
            this.optionSkinClassDeathknightFrost,
            this.optionSkinClassDeathknightUnholy});
            this.optionSkinClassDeathknight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.optionSkinClassDeathknight.Name = "optionSkinClassDeathknight";
            this.optionSkinClassDeathknight.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassDeathknight.Text = "Death Knight";
            // 
            // optionSkinClassDeathknightBlood
            // 
            this.optionSkinClassDeathknightBlood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDeathknightBlood.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDeathknightBlood.Name = "optionSkinClassDeathknightBlood";
            this.optionSkinClassDeathknightBlood.Size = new System.Drawing.Size(111, 22);
            this.optionSkinClassDeathknightBlood.Text = "Blood";
            this.optionSkinClassDeathknightBlood.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDeathknightFrost
            // 
            this.optionSkinClassDeathknightFrost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDeathknightFrost.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDeathknightFrost.Name = "optionSkinClassDeathknightFrost";
            this.optionSkinClassDeathknightFrost.Size = new System.Drawing.Size(111, 22);
            this.optionSkinClassDeathknightFrost.Text = "Frost";
            this.optionSkinClassDeathknightFrost.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDeathknightUnholy
            // 
            this.optionSkinClassDeathknightUnholy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDeathknightUnholy.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDeathknightUnholy.Name = "optionSkinClassDeathknightUnholy";
            this.optionSkinClassDeathknightUnholy.Size = new System.Drawing.Size(111, 22);
            this.optionSkinClassDeathknightUnholy.Text = "Unholy";
            this.optionSkinClassDeathknightUnholy.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassMonk
            // 
            this.optionSkinClassMonk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMonk.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassMonkBrewmaster,
            this.optionSkinClassMonkWindwalker,
            this.optionSkinClassMonkMistweaver});
            this.optionSkinClassMonk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(152)))));
            this.optionSkinClassMonk.Name = "optionSkinClassMonk";
            this.optionSkinClassMonk.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassMonk.Text = "Monk";
            // 
            // optionSkinClassMonkBrewmaster
            // 
            this.optionSkinClassMonkBrewmaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMonkBrewmaster.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMonkBrewmaster.Name = "optionSkinClassMonkBrewmaster";
            this.optionSkinClassMonkBrewmaster.Size = new System.Drawing.Size(136, 22);
            this.optionSkinClassMonkBrewmaster.Text = "Brewmaster";
            this.optionSkinClassMonkBrewmaster.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassMonkWindwalker
            // 
            this.optionSkinClassMonkWindwalker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMonkWindwalker.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMonkWindwalker.Name = "optionSkinClassMonkWindwalker";
            this.optionSkinClassMonkWindwalker.Size = new System.Drawing.Size(136, 22);
            this.optionSkinClassMonkWindwalker.Text = "Windwalker";
            this.optionSkinClassMonkWindwalker.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassMonkMistweaver
            // 
            this.optionSkinClassMonkMistweaver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassMonkMistweaver.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassMonkMistweaver.Name = "optionSkinClassMonkMistweaver";
            this.optionSkinClassMonkMistweaver.Size = new System.Drawing.Size(136, 22);
            this.optionSkinClassMonkMistweaver.Text = "Mistweaver";
            this.optionSkinClassMonkMistweaver.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDemonhunter
            // 
            this.optionSkinClassDemonhunter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDemonhunter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassDemonhunterVengeance,
            this.optionSkinClassDemonhunterHavoc});
            this.optionSkinClassDemonhunter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(48)))), ((int)(((byte)(201)))));
            this.optionSkinClassDemonhunter.Name = "optionSkinClassDemonhunter";
            this.optionSkinClassDemonhunter.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassDemonhunter.Text = "Demon Hunter";
            // 
            // optionSkinClassDemonhunterVengeance
            // 
            this.optionSkinClassDemonhunterVengeance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDemonhunterVengeance.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDemonhunterVengeance.Name = "optionSkinClassDemonhunterVengeance";
            this.optionSkinClassDemonhunterVengeance.Size = new System.Drawing.Size(130, 22);
            this.optionSkinClassDemonhunterVengeance.Text = "Vengeance";
            this.optionSkinClassDemonhunterVengeance.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassDemonhunterHavoc
            // 
            this.optionSkinClassDemonhunterHavoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassDemonhunterHavoc.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassDemonhunterHavoc.Name = "optionSkinClassDemonhunterHavoc";
            this.optionSkinClassDemonhunterHavoc.Size = new System.Drawing.Size(130, 22);
            this.optionSkinClassDemonhunterHavoc.Text = "Havoc";
            this.optionSkinClassDemonhunterHavoc.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassEvoker
            // 
            this.optionSkinClassEvoker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassEvoker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinClassEvokerDevastation,
            this.optionSkinClassEvokerPreservation});
            this.optionSkinClassEvoker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(126)))));
            this.optionSkinClassEvoker.Name = "optionSkinClassEvoker";
            this.optionSkinClassEvoker.Size = new System.Drawing.Size(150, 22);
            this.optionSkinClassEvoker.Text = "Evoker";
            // 
            // optionSkinClassEvokerDevastation
            // 
            this.optionSkinClassEvokerDevastation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassEvokerDevastation.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassEvokerDevastation.Name = "optionSkinClassEvokerDevastation";
            this.optionSkinClassEvokerDevastation.Size = new System.Drawing.Size(137, 22);
            this.optionSkinClassEvokerDevastation.Text = "Devastation";
            this.optionSkinClassEvokerDevastation.Click += new System.EventHandler(this.click_skin_class);
            // 
            // optionSkinClassEvokerPreservation
            // 
            this.optionSkinClassEvokerPreservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinClassEvokerPreservation.ForeColor = System.Drawing.Color.White;
            this.optionSkinClassEvokerPreservation.Name = "optionSkinClassEvokerPreservation";
            this.optionSkinClassEvokerPreservation.Size = new System.Drawing.Size(137, 22);
            this.optionSkinClassEvokerPreservation.Text = "Perservation";
            this.optionSkinClassEvokerPreservation.Click += new System.EventHandler(this.click_skin_class);
            // 
            // raceToolStripMenuItem
            // 
            this.raceToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.raceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionSkinRaceHuman,
            this.optionSkinRaceDwarf,
            this.optionSkinRaceNightelf,
            this.optionSkinRaceGnome,
            this.optionSkinRaceDraenei,
            this.optionSkinRaceWorgen,
            this.optionSkinRacePandarenAlliance,
            this.optionSkinRaceDracthyrAlliance,
            this.optionSkinRaceOrc,
            this.optionSkinRaceUndead,
            this.optionSkinRaceTauren,
            this.optionSkinRaceTroll,
            this.optionSkinRaceBloodelf,
            this.optionSkinRaceGoblin,
            this.optionSkinRacePandarenHorde,
            this.optionSkinRaceDracthyrHorde});
            this.raceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.raceToolStripMenuItem.Name = "raceToolStripMenuItem";
            this.raceToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.raceToolStripMenuItem.Text = "Race";
            // 
            // optionSkinRaceHuman
            // 
            this.optionSkinRaceHuman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceHuman.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceHuman.Name = "optionSkinRaceHuman";
            this.optionSkinRaceHuman.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceHuman.Text = "Human";
            this.optionSkinRaceHuman.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceDwarf
            // 
            this.optionSkinRaceDwarf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceDwarf.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceDwarf.Name = "optionSkinRaceDwarf";
            this.optionSkinRaceDwarf.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceDwarf.Text = "Dwarf";
            this.optionSkinRaceDwarf.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceNightelf
            // 
            this.optionSkinRaceNightelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceNightelf.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceNightelf.Name = "optionSkinRaceNightelf";
            this.optionSkinRaceNightelf.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceNightelf.Text = "Night Elf";
            this.optionSkinRaceNightelf.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceGnome
            // 
            this.optionSkinRaceGnome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceGnome.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceGnome.Name = "optionSkinRaceGnome";
            this.optionSkinRaceGnome.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceGnome.Text = "Gnome";
            this.optionSkinRaceGnome.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceDraenei
            // 
            this.optionSkinRaceDraenei.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceDraenei.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceDraenei.Name = "optionSkinRaceDraenei";
            this.optionSkinRaceDraenei.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceDraenei.Text = "Draenei";
            this.optionSkinRaceDraenei.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceWorgen
            // 
            this.optionSkinRaceWorgen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceWorgen.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceWorgen.Name = "optionSkinRaceWorgen";
            this.optionSkinRaceWorgen.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceWorgen.Text = "Worgen";
            this.optionSkinRaceWorgen.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRacePandarenAlliance
            // 
            this.optionSkinRacePandarenAlliance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRacePandarenAlliance.ForeColor = System.Drawing.Color.White;
            this.optionSkinRacePandarenAlliance.Name = "optionSkinRacePandarenAlliance";
            this.optionSkinRacePandarenAlliance.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRacePandarenAlliance.Text = "Pandaren (A)";
            this.optionSkinRacePandarenAlliance.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceDracthyrAlliance
            // 
            this.optionSkinRaceDracthyrAlliance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceDracthyrAlliance.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceDracthyrAlliance.Name = "optionSkinRaceDracthyrAlliance";
            this.optionSkinRaceDracthyrAlliance.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceDracthyrAlliance.Text = "Dracthyr (A)";
            this.optionSkinRaceDracthyrAlliance.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceOrc
            // 
            this.optionSkinRaceOrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceOrc.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceOrc.Name = "optionSkinRaceOrc";
            this.optionSkinRaceOrc.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceOrc.Text = "Orc";
            this.optionSkinRaceOrc.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceUndead
            // 
            this.optionSkinRaceUndead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceUndead.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceUndead.Name = "optionSkinRaceUndead";
            this.optionSkinRaceUndead.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceUndead.Text = "Undead";
            this.optionSkinRaceUndead.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceTauren
            // 
            this.optionSkinRaceTauren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceTauren.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceTauren.Name = "optionSkinRaceTauren";
            this.optionSkinRaceTauren.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceTauren.Text = "Tauren";
            this.optionSkinRaceTauren.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceTroll
            // 
            this.optionSkinRaceTroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceTroll.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceTroll.Name = "optionSkinRaceTroll";
            this.optionSkinRaceTroll.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceTroll.Text = "Troll";
            this.optionSkinRaceTroll.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceBloodelf
            // 
            this.optionSkinRaceBloodelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceBloodelf.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceBloodelf.Name = "optionSkinRaceBloodelf";
            this.optionSkinRaceBloodelf.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceBloodelf.Text = "Blood Elf";
            this.optionSkinRaceBloodelf.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceGoblin
            // 
            this.optionSkinRaceGoblin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceGoblin.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceGoblin.Name = "optionSkinRaceGoblin";
            this.optionSkinRaceGoblin.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceGoblin.Text = "Goblin";
            this.optionSkinRaceGoblin.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRacePandarenHorde
            // 
            this.optionSkinRacePandarenHorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRacePandarenHorde.ForeColor = System.Drawing.Color.White;
            this.optionSkinRacePandarenHorde.Name = "optionSkinRacePandarenHorde";
            this.optionSkinRacePandarenHorde.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRacePandarenHorde.Text = "Pandaren (H)";
            this.optionSkinRacePandarenHorde.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinRaceDracthyrHorde
            // 
            this.optionSkinRaceDracthyrHorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinRaceDracthyrHorde.ForeColor = System.Drawing.Color.White;
            this.optionSkinRaceDracthyrHorde.Name = "optionSkinRaceDracthyrHorde";
            this.optionSkinRaceDracthyrHorde.Size = new System.Drawing.Size(140, 22);
            this.optionSkinRaceDracthyrHorde.Text = "Dracthyr (H)";
            this.optionSkinRaceDracthyrHorde.Click += new System.EventHandler(this.click_skin_race);
            // 
            // optionSkinVanilla
            // 
            this.optionSkinVanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinVanilla.ForeColor = System.Drawing.Color.White;
            this.optionSkinVanilla.Name = "optionSkinVanilla";
            this.optionSkinVanilla.Size = new System.Drawing.Size(198, 22);
            this.optionSkinVanilla.Text = "Vanilla";
            this.optionSkinVanilla.Click += new System.EventHandler(this.click_skin_vanilla);
            // 
            // optionSkinTbc
            // 
            this.optionSkinTbc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinTbc.ForeColor = System.Drawing.Color.White;
            this.optionSkinTbc.Name = "optionSkinTbc";
            this.optionSkinTbc.Size = new System.Drawing.Size(198, 22);
            this.optionSkinTbc.Text = "The Burning Crusade";
            this.optionSkinTbc.Click += new System.EventHandler(this.click_skin_tbc);
            // 
            // optionSkinWotlk1
            // 
            this.optionSkinWotlk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinWotlk1.ForeColor = System.Drawing.Color.White;
            this.optionSkinWotlk1.Name = "optionSkinWotlk1";
            this.optionSkinWotlk1.Size = new System.Drawing.Size(198, 22);
            this.optionSkinWotlk1.Text = "Wrath of the Lich King 1";
            this.optionSkinWotlk1.Click += new System.EventHandler(this.click_skin_wotlk1);
            // 
            // optionSkinWotlk2
            // 
            this.optionSkinWotlk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinWotlk2.ForeColor = System.Drawing.Color.White;
            this.optionSkinWotlk2.Name = "optionSkinWotlk2";
            this.optionSkinWotlk2.Size = new System.Drawing.Size(198, 22);
            this.optionSkinWotlk2.Text = "Wrath of the Lich King 2";
            this.optionSkinWotlk2.Click += new System.EventHandler(this.click_skin_wotlk2);
            // 
            // optionSkinCata
            // 
            this.optionSkinCata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinCata.ForeColor = System.Drawing.Color.White;
            this.optionSkinCata.Name = "optionSkinCata";
            this.optionSkinCata.Size = new System.Drawing.Size(198, 22);
            this.optionSkinCata.Text = "Cataclysm";
            this.optionSkinCata.Click += new System.EventHandler(this.click_skin_cata);
            // 
            // optionSkinMop
            // 
            this.optionSkinMop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinMop.ForeColor = System.Drawing.Color.White;
            this.optionSkinMop.Name = "optionSkinMop";
            this.optionSkinMop.Size = new System.Drawing.Size(198, 22);
            this.optionSkinMop.Text = "Mists of Pandaria";
            this.optionSkinMop.Click += new System.EventHandler(this.click_skin_mop);
            // 
            // optionSkinWod
            // 
            this.optionSkinWod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinWod.ForeColor = System.Drawing.Color.White;
            this.optionSkinWod.Name = "optionSkinWod";
            this.optionSkinWod.Size = new System.Drawing.Size(198, 22);
            this.optionSkinWod.Text = "Warlords of Draenor";
            this.optionSkinWod.Click += new System.EventHandler(this.click_skin_wod);
            // 
            // optionSkinLegion
            // 
            this.optionSkinLegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinLegion.ForeColor = System.Drawing.Color.White;
            this.optionSkinLegion.Name = "optionSkinLegion";
            this.optionSkinLegion.Size = new System.Drawing.Size(198, 22);
            this.optionSkinLegion.Text = "Legion";
            this.optionSkinLegion.Click += new System.EventHandler(this.click_skin_legion);
            // 
            // optionSkinBfa
            // 
            this.optionSkinBfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinBfa.ForeColor = System.Drawing.Color.White;
            this.optionSkinBfa.Name = "optionSkinBfa";
            this.optionSkinBfa.Size = new System.Drawing.Size(198, 22);
            this.optionSkinBfa.Text = "Battle for Azeroth";
            this.optionSkinBfa.Click += new System.EventHandler(this.click_skin_bfa);
            // 
            // optionSkinSl
            // 
            this.optionSkinSl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinSl.ForeColor = System.Drawing.Color.White;
            this.optionSkinSl.Name = "optionSkinSl";
            this.optionSkinSl.Size = new System.Drawing.Size(198, 22);
            this.optionSkinSl.Text = "Shadowlands";
            this.optionSkinSl.Click += new System.EventHandler(this.click_skin_sl);
            // 
            // optionSkinDf
            // 
            this.optionSkinDf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSkinDf.ForeColor = System.Drawing.Color.White;
            this.optionSkinDf.Name = "optionSkinDf";
            this.optionSkinDf.Size = new System.Drawing.Size(198, 22);
            this.optionSkinDf.Text = "Dragonflight";
            this.optionSkinDf.Click += new System.EventHandler(this.click_skin_df);
            // 
            // optionNewsBackground
            // 
            this.optionNewsBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionNewsBackground.ForeColor = System.Drawing.Color.White;
            this.optionNewsBackground.Name = "optionNewsBackground";
            this.optionNewsBackground.Size = new System.Drawing.Size(199, 22);
            this.optionNewsBackground.Text = "Show news background";
            this.optionNewsBackground.Click += new System.EventHandler(this.click_news_background);
            // 
            // optionSetPath
            // 
            this.optionSetPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(20)))), ((int)(((byte)(31)))));
            this.optionSetPath.ForeColor = System.Drawing.Color.White;
            this.optionSetPath.Name = "optionSetPath";
            this.optionSetPath.Size = new System.Drawing.Size(199, 22);
            this.optionSetPath.Text = "Set WoW path...";
            this.optionSetPath.Click += new System.EventHandler(this.click_setpath);
            // 
            // barItemInfo
            // 
            this.barItemInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.barItemInfo.Name = "barItemInfo";
            this.barItemInfo.Size = new System.Drawing.Size(40, 16);
            this.barItemInfo.Text = "Info";
            this.barItemInfo.Click += new System.EventHandler(this.click_info);
            // 
            // newsImage1
            // 
            this.newsImage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage1.Location = new System.Drawing.Point(365, 217);
            this.newsImage1.Name = "newsImage1";
            this.newsImage1.Size = new System.Drawing.Size(66, 40);
            this.newsImage1.TabIndex = 3;
            this.newsImage1.TabStop = false;
            // 
            // newsImage2
            // 
            this.newsImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage2.Location = new System.Drawing.Point(365, 270);
            this.newsImage2.Name = "newsImage2";
            this.newsImage2.Size = new System.Drawing.Size(66, 40);
            this.newsImage2.TabIndex = 3;
            this.newsImage2.TabStop = false;
            // 
            // newsImage3
            // 
            this.newsImage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newsImage3.Location = new System.Drawing.Point(365, 325);
            this.newsImage3.Name = "newsImage3";
            this.newsImage3.Size = new System.Drawing.Size(66, 40);
            this.newsImage3.TabIndex = 3;
            this.newsImage3.TabStop = false;
            // 
            // dropdownVersions
            // 
            this.dropdownVersions.BackColor = System.Drawing.Color.Black;
            this.dropdownVersions.DisplayMember = "1";
            this.dropdownVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownVersions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropdownVersions.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.dropdownVersions.ForeColor = System.Drawing.Color.White;
            this.dropdownVersions.FormattingEnabled = true;
            this.dropdownVersions.Items.AddRange(new object[] {
            "Retail",
            "Classic",
            "Classic WOTLK",
            "PTR (Retail)",
            "PTR (Classic)",
            "PTR (Classic WOTLK)"});
            this.dropdownVersions.Location = new System.Drawing.Point(30, 546);
            this.dropdownVersions.Name = "dropdownVersions";
            this.dropdownVersions.Size = new System.Drawing.Size(208, 23);
            this.dropdownVersions.TabIndex = 8;
            this.dropdownVersions.SelectedIndexChanged += new System.EventHandler(this.change_version);
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
            // errorLabel1
            // 
            this.errorLabel1.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.errorLabel1.Location = new System.Drawing.Point(365, 214);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(136, 23);
            this.errorLabel1.TabIndex = 9;
            this.errorLabel1.Text = "Could not load news";
            this.errorLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel1.Visible = false;
            // 
            // errorLabel2
            // 
            this.errorLabel2.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.errorLabel2.Location = new System.Drawing.Point(365, 417);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(136, 23);
            this.errorLabel2.TabIndex = 9;
            this.errorLabel2.Text = "Could not load news";
            this.errorLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorLabel2.Visible = false;
            // 
            // newsTitle7
            // 
            this.newsTitle7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle7.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle7.Font = new System.Drawing.Font("Arial", 8F);
            this.newsTitle7.Link = "https://wowhead.com/news";
            this.newsTitle7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle7.Location = new System.Drawing.Point(366, 474);
            this.newsTitle7.Name = "newsTitle7";
            this.newsTitle7.Size = new System.Drawing.Size(416, 20);
            this.newsTitle7.TabIndex = 4;
            this.newsTitle7.TabStop = true;
            this.newsTitle7.Text = "• ???";
            // 
            // newsTitle6
            // 
            this.newsTitle6.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle6.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle6.Font = new System.Drawing.Font("Arial", 8F);
            this.newsTitle6.Link = "https://wowhead.com/news";
            this.newsTitle6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle6.Location = new System.Drawing.Point(365, 454);
            this.newsTitle6.Name = "newsTitle6";
            this.newsTitle6.Size = new System.Drawing.Size(416, 20);
            this.newsTitle6.TabIndex = 4;
            this.newsTitle6.TabStop = true;
            this.newsTitle6.Text = "• ???";
            // 
            // newsTitle5
            // 
            this.newsTitle5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle5.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle5.Font = new System.Drawing.Font("Arial", 8F);
            this.newsTitle5.Link = "https://wowhead.com/news";
            this.newsTitle5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle5.Location = new System.Drawing.Point(365, 436);
            this.newsTitle5.Name = "newsTitle5";
            this.newsTitle5.Size = new System.Drawing.Size(416, 20);
            this.newsTitle5.TabIndex = 4;
            this.newsTitle5.TabStop = true;
            this.newsTitle5.Text = "• ???";
            // 
            // newsTitle4
            // 
            this.newsTitle4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle4.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle4.Font = new System.Drawing.Font("Arial", 8F);
            this.newsTitle4.Link = "https://wowhead.com/news";
            this.newsTitle4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle4.Location = new System.Drawing.Point(365, 417);
            this.newsTitle4.Name = "newsTitle4";
            this.newsTitle4.Size = new System.Drawing.Size(416, 20);
            this.newsTitle4.TabIndex = 4;
            this.newsTitle4.TabStop = true;
            this.newsTitle4.Text = "• ???";
            // 
            // newsTitle3
            // 
            this.newsTitle3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle3.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle3.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle3.Link = "https://wowhead.com/news";
            this.newsTitle3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle3.Location = new System.Drawing.Point(437, 325);
            this.newsTitle3.Name = "newsTitle3";
            this.newsTitle3.Size = new System.Drawing.Size(318, 40);
            this.newsTitle3.TabIndex = 4;
            this.newsTitle3.TabStop = true;
            this.newsTitle3.Text = "???";
            // 
            // newsTitle2
            // 
            this.newsTitle2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle2.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newsTitle2.Font = new System.Drawing.Font("Arial", 10F);
            this.newsTitle2.Link = "https://wowhead.com/news";
            this.newsTitle2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.newsTitle2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(91)))), ((int)(((byte)(70)))));
            this.newsTitle2.Location = new System.Drawing.Point(438, 271);
            this.newsTitle2.Name = "newsTitle2";
            this.newsTitle2.Size = new System.Drawing.Size(318, 40);
            this.newsTitle2.TabIndex = 4;
            this.newsTitle2.TabStop = true;
            this.newsTitle2.Text = "???";
            // 
            // newsTitle1
            // 
            this.newsTitle1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(164)))));
            this.newsTitle1.BackColor = System.Drawing.Color.Transparent;
            this.newsTitle1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.newsTitle1.Text = "???";
            // 
            // buttonBnet
            // 
            this.buttonBnet.BackColor = System.Drawing.Color.Transparent;
            this.buttonBnet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBnet.BackgroundImage")));
            this.buttonBnet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBnet.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonBnet.FlatAppearance.BorderSize = 0;
            this.buttonBnet.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBnet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonBnet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonBnet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBnet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonBnet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonBnet.Location = new System.Drawing.Point(32, 576);
            this.buttonBnet.Name = "buttonBnet";
            this.buttonBnet.Size = new System.Drawing.Size(159, 27);
            this.buttonBnet.TabIndex = 2;
            this.buttonBnet.TabStop = false;
            this.buttonBnet.Text = "Open battle.net";
            this.buttonBnet.Type = WoWRetroLauncher.LauncherButton.ButtonType.LONG;
            this.buttonBnet.UseVisualStyleBackColor = false;
            this.buttonBnet.Click += new System.EventHandler(this.click_bnet);
            // 
            // buttonOfficial
            // 
            this.buttonOfficial.BackColor = System.Drawing.Color.Transparent;
            this.buttonOfficial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOfficial.BackgroundImage")));
            this.buttonOfficial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOfficial.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOfficial.FlatAppearance.BorderSize = 0;
            this.buttonOfficial.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonOfficial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonOfficial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonOfficial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOfficial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonOfficial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonOfficial.Location = new System.Drawing.Point(544, 539);
            this.buttonOfficial.Name = "buttonOfficial";
            this.buttonOfficial.Size = new System.Drawing.Size(91, 27);
            this.buttonOfficial.TabIndex = 2;
            this.buttonOfficial.TabStop = false;
            this.buttonOfficial.Text = "Official site";
            this.buttonOfficial.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonOfficial.UseVisualStyleBackColor = false;
            this.buttonOfficial.Click += new System.EventHandler(this.click_official);
            // 
            // buttonRaiderio
            // 
            this.buttonRaiderio.BackColor = System.Drawing.Color.Transparent;
            this.buttonRaiderio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRaiderio.BackgroundImage")));
            this.buttonRaiderio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRaiderio.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRaiderio.FlatAppearance.BorderSize = 0;
            this.buttonRaiderio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonRaiderio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonRaiderio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonRaiderio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRaiderio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonRaiderio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonRaiderio.Location = new System.Drawing.Point(353, 572);
            this.buttonRaiderio.Name = "buttonRaiderio";
            this.buttonRaiderio.Size = new System.Drawing.Size(91, 27);
            this.buttonRaiderio.TabIndex = 2;
            this.buttonRaiderio.TabStop = false;
            this.buttonRaiderio.Text = "Raider.IO";
            this.buttonRaiderio.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonRaiderio.UseVisualStyleBackColor = false;
            this.buttonRaiderio.Click += new System.EventHandler(this.click_raiderio);
            // 
            // buttonIcyveins
            // 
            this.buttonIcyveins.BackColor = System.Drawing.Color.Transparent;
            this.buttonIcyveins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIcyveins.BackgroundImage")));
            this.buttonIcyveins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonIcyveins.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonIcyveins.FlatAppearance.BorderSize = 0;
            this.buttonIcyveins.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonIcyveins.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonIcyveins.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonIcyveins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIcyveins.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonIcyveins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonIcyveins.Location = new System.Drawing.Point(450, 572);
            this.buttonIcyveins.Name = "buttonIcyveins";
            this.buttonIcyveins.Size = new System.Drawing.Size(91, 27);
            this.buttonIcyveins.TabIndex = 2;
            this.buttonIcyveins.TabStop = false;
            this.buttonIcyveins.Text = "Icy Veins";
            this.buttonIcyveins.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonIcyveins.UseVisualStyleBackColor = false;
            this.buttonIcyveins.Click += new System.EventHandler(this.click_icyveins);
            // 
            // buttonWowhead
            // 
            this.buttonWowhead.BackColor = System.Drawing.Color.Transparent;
            this.buttonWowhead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWowhead.BackgroundImage")));
            this.buttonWowhead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonWowhead.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonWowhead.FlatAppearance.BorderSize = 0;
            this.buttonWowhead.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonWowhead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonWowhead.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonWowhead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWowhead.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonWowhead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonWowhead.Location = new System.Drawing.Point(544, 572);
            this.buttonWowhead.Name = "buttonWowhead";
            this.buttonWowhead.Size = new System.Drawing.Size(91, 27);
            this.buttonWowhead.TabIndex = 2;
            this.buttonWowhead.TabStop = false;
            this.buttonWowhead.Text = "Wowhead";
            this.buttonWowhead.Type = WoWRetroLauncher.LauncherButton.ButtonType.SHORT;
            this.buttonWowhead.UseVisualStyleBackColor = false;
            this.buttonWowhead.Click += new System.EventHandler(this.click_wowhead);
            // 
            // buttonStore
            // 
            this.buttonStore.BackColor = System.Drawing.Color.Transparent;
            this.buttonStore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStore.BackgroundImage")));
            this.buttonStore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStore.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStore.FlatAppearance.BorderSize = 0;
            this.buttonStore.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.buttonStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(32)))));
            this.buttonStore.Location = new System.Drawing.Point(596, 69);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(159, 27);
            this.buttonStore.TabIndex = 2;
            this.buttonStore.TabStop = false;
            this.buttonStore.Text = "Blizzard Store";
            this.buttonStore.Type = WoWRetroLauncher.LauncherButton.ButtonType.LONG;
            this.buttonStore.UseVisualStyleBackColor = false;
            this.buttonStore.Click += new System.EventHandler(this.click_store);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.BackgroundImage = global::WoWRetroLauncher.Properties.Resources.battleforazeroth_buttonPlay;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.ForeColor = System.Drawing.Color.Black;
            this.buttonPlay.Location = new System.Drawing.Point(651, 524);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(130, 74);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.TabStop = false;
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 621);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.errorLabel1);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.dropdownVersions);
            this.Controls.Add(this.newsTitle7);
            this.Controls.Add(this.newsTitle6);
            this.Controls.Add(this.newsTitle5);
            this.Controls.Add(this.newsTitle4);
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
            this.Text = "World of Warcraft Retro Launcher";
            this.Load += new System.EventHandler(this.OnLoad);
            this.Shown += new System.EventHandler(this.OnShow);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newsImage3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LauncherButton buttonPlay;
        private System.Windows.Forms.MenuStrip topBar;
        private System.Windows.Forms.ToolStripMenuItem barItemOptions;
        private System.Windows.Forms.ToolStripMenuItem barItemInfo;
        private LauncherButton buttonStore;
        private System.Windows.Forms.PictureBox newsImage1;
        private LauncherLink newsTitle1;
        private System.Windows.Forms.PictureBox newsImage2;
        private LauncherLink newsTitle2;
        private System.Windows.Forms.PictureBox newsImage3;
        private LauncherLink newsTitle3;
        private System.Windows.Forms.ToolStripMenuItem optionSetSkin;
        private System.Windows.Forms.ToolStripMenuItem optionSetPath;
        private System.Windows.Forms.ComboBox dropdownVersions;
        private LauncherButton buttonBnet;
        private LauncherLink newsTitle4;
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
        private LauncherLink newsTitle5;
        private LauncherLink newsTitle6;
        private LauncherLink newsTitle7;
        private Label errorLabel1;
        private Label errorLabel2;
        private ToolStripMenuItem raceToolStripMenuItem;
        private ToolStripMenuItem optionSkinRaceHuman;
        private ToolStripMenuItem optionSkinRaceDwarf;
        private ToolStripMenuItem optionSkinRaceNightelf;
        private ToolStripMenuItem optionSkinRaceGnome;
        private ToolStripMenuItem optionSkinRaceDraenei;
        private ToolStripMenuItem optionSkinRaceWorgen;
        private ToolStripMenuItem optionSkinRacePandarenAlliance;
        private ToolStripMenuItem optionSkinRaceDracthyrAlliance;
        private ToolStripMenuItem optionSkinRaceOrc;
        private ToolStripMenuItem optionSkinRaceUndead;
        private ToolStripMenuItem optionSkinRaceTauren;
        private ToolStripMenuItem optionSkinRaceTroll;
        private ToolStripMenuItem optionSkinRaceBloodelf;
        private ToolStripMenuItem optionSkinRaceGoblin;
        private ToolStripMenuItem optionSkinRacePandarenHorde;
        private ToolStripMenuItem optionSkinRaceDracthyrHorde;
        private ToolStripMenuItem optionSkinClass;
        private ToolStripMenuItem optionSkinClassWarrior;
        private ToolStripMenuItem optionSkinClassWarriorProtection;
        private ToolStripMenuItem optionSkinClassWarriorArms;
        private ToolStripMenuItem optionSkinClassWarriorFury;
        private ToolStripMenuItem optionSkinClassPaladin;
        private ToolStripMenuItem optionSkinClassPaladinProtection;
        private ToolStripMenuItem optionSkinClassPaladinRetribution;
        private ToolStripMenuItem optionSkinClassPaladinHoly;
        private ToolStripMenuItem optionSkinClassShaman;
        private ToolStripMenuItem optionSkinClassShamanElemental;
        private ToolStripMenuItem optionSkinClassShamanEnhancement;
        private ToolStripMenuItem optionSkinClassShamanRestoration;
        private ToolStripMenuItem optionSkinClassWarlock;
        private ToolStripMenuItem optionSkinClassWarlockDestruction;
        private ToolStripMenuItem optionSkinClassWarlockAffliction;
        private ToolStripMenuItem optionSkinClassWarlockDemonology;
        private ToolStripMenuItem optionSkinMage;
        private ToolStripMenuItem optionSkinClassMageArcane;
        private ToolStripMenuItem optionSkinClassMageFrost;
        private ToolStripMenuItem optionSkinClassMageFire;
        private ToolStripMenuItem optionSkinClassPriest;
        private ToolStripMenuItem optionSkinClassPriestShadow;
        private ToolStripMenuItem optionSkinClassPriestDiscipline;
        private ToolStripMenuItem optionSkinClassPriestHoly;
        private ToolStripMenuItem optionSkinClassRogue;
        private ToolStripMenuItem optionSkinClassRogueAssassination;
        private ToolStripMenuItem optionSkinClassRogueSubtlety;
        private ToolStripMenuItem optionSkinClassRogueOutlaw;
        private ToolStripMenuItem optionSkinClassDruid;
        private ToolStripMenuItem optionSkinClassDruidGuardian;
        private ToolStripMenuItem optionSkinClassDruidFeral;
        private ToolStripMenuItem optionSkinClassDruidBalance;
        private ToolStripMenuItem optionSkinClassDruidRestoration;
        private ToolStripMenuItem optionSkinClassDeathknight;
        private ToolStripMenuItem optionSkinClassDeathknightBlood;
        private ToolStripMenuItem optionSkinClassDeathknightFrost;
        private ToolStripMenuItem optionSkinClassDeathknightUnholy;
        private ToolStripMenuItem optionSkinClassMonk;
        private ToolStripMenuItem optionSkinClassMonkBrewmaster;
        private ToolStripMenuItem optionSkinClassMonkWindwalker;
        private ToolStripMenuItem optionSkinClassMonkMistweaver;
        private ToolStripMenuItem optionSkinClassDemonhunter;
        private ToolStripMenuItem optionSkinClassDemonhunterVengeance;
        private ToolStripMenuItem optionSkinClassDemonhunterHavoc;
        private ToolStripMenuItem optionSkinClassEvoker;
        private ToolStripMenuItem optionSkinClassEvokerDevastation;
        private ToolStripMenuItem optionSkinClassEvokerPreservation;
        private ToolStripMenuItem optionSkinClassHunter;
        private ToolStripMenuItem optionSkinClassHunterBeastmastery;
        private ToolStripMenuItem optionSkinClassHunterMarksmanship;
        private ToolStripMenuItem optionSkinClassHunterSurvival;
    }
}

