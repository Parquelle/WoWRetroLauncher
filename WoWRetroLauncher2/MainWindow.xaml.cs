using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using System.Xml.Serialization;
using WoWRetroLauncher2;
using WoWRetroLauncher2.Properties;
using static WoWRetroLauncher2.MainWindow;

namespace WoWRetroLauncher2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, GameVersion> gameVersions;

        /*private Dictionary<string, Splash> splashes = new Dictionary<string, Splash>
        {
            { "default", new Splash("lake", "murloc", "happyrelease") },
            { "stitches", new Splash("duskwood", "stitches") },
            { "hogger", new Splash("gnollcamp", "hogger") },
            { "darkportal", new Splash("darkportal", "empty") },
            { "dwarf", new Splash("mountains", "dwarf") },
            { "orc", new Splash("durotar", "orc") },
            { "murlocs", new Splash("lake", "murloc") },
            { "razorfen", new Splash("razorfen", "quillboar") },
            { "barrens", new Splash("barrens", "tallstrider") },
            { "ragefire", new Splash("ragefire", "moltenelemental") },
            { "shadowfang", new Splash("shadowfang", "worgen") },
            { "stranglethorn", new Splash("stranglethorn", "raptor") },
            { "peasant", new Splash("loggingcamp", "peasant") },
            { "teldrassil", new Splash("teldrassil", "ancient") },
            { "dunmorogh", new Splash("dunmorogh", "mountaineer") },
            { "voidwalker", new Splash("rune", "voidwalker") },
            { "innkeeper", new Splash("goldshireinn", "innkeeper") },
            { "pumpkin", new Splash("pumpkinpatch", "pumpkin") },
            { "graveyard", new Splash("graveyard", "spirithealer") },
            { "undercity", new Splash("undercity", "deathguard") },
            { "undercity2", new Splash("undercity", "deathguardf") },
            { "ghoul", new Splash("deathknell", "ghoul") },
            { "skeleton", new Splash("skeletonhouse", "skeleton") },
            { "slime", new Splash("slime", "slime") },
            { "throneroom", new Splash("throneroom", "empty") },
            { "winterveil", new Splash("winterveil", "winterhelper", "winterveil") }
        };*/

        public static int versionNumber = 10;
        public static string versionName = "2.0.0";

        private Splash currentSplash;
        private SplashData splashData;
        private OnlineSplashData cachedSplash;

        private string selectedVersion;
        private float lastPlay;

        private static MainWindow instance;

        private SoundPlayer soundPlayer;
        public MainWindow()
        {
            if (instance == null)
                instance = this;

            gameVersions = new Dictionary<string, GameVersion>
            {
                {"_retail_", new GameVersion("_retail_", "Retail", "Wow.exe", "wow") },
                {"_classic_era_", new GameVersion("_classic_era_", "Classic", "WowClassic.exe", "wow_classic_era") },
                {"_classic_", new GameVersion("_classic_", "MoP Classic", "WowClassic.exe", "wow_classic") },
                {"_anniversary_", new GameVersion("_anniversary_", "TBC Anniversary", "WowClassic.exe", "wow_anniversary") },
                {"_forever_", new GameVersion("_forever_", "Forever", "Wow.exe", "wowf") },
                {"_ptr_", new GameVersion("_ptr_", "PTR: Retail", "WowT.exe", "wowt") },
                {"_xptr_", new GameVersion("_xptr_", "PTR: Retail 2", "WowT.exe", "wowxptr") },
                {"_classic_era_ptr_", new GameVersion("_classic_era_ptr_", "PTR: Classic", "WowClassicT.exe", "wow_classic_ptr") },
                {"_classic_ptr_", new GameVersion("_classic_ptr_", "PTR: MoP Classic", "WowClassicT.exe", "wow_classic_era_ptr") },
            };

            InitializeComponent();

            soundPlayer = new SoundPlayer();

            ValidateGameVersions();
            splashData = JsonSerializer.Deserialize<SplashData>(Encoding.UTF8.GetString(Properties.Resources.Splashes));
            if(Properties.Settings.Default.randomSplashes)
                ApplySplash(splashData.splashes[new Random().Next(0, splashData.splashes.Count)]);
            else
                ApplySplash(splashData.splashes.Find(x => x.id.Equals(Properties.Settings.Default.selectedSplash)));
            Properties.Settings.Default.SettingsLoaded += OnSettingsLoad;

            AssignButton("LinkBnet", OpenBnet);
            AssignButton("LinkNews", OpenNews);
            AssignButton("LinkSupport", OpenSupport);
            AssignButton("LinkForums", OpenForums);
            AssignButton("LinkArmory", OpenArmory);
            AssignMenuButton("MenuOptions", OpenSettings);
            AssignDropdown("GameVersions", OnVersionSelect);


            CheckConnection();

            GetBlizzardNewsData();
            GetBlizzardTrackerData();
            GetWowheadNewsData();
        }

        private async void CheckConnection()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.google.com");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                if (Properties.Settings.Default.checkUpdatesOnStartup)
                {
                    CheckForSoftwareUpdates(false);
                }
                GetOnlineSplashInformation();
            } catch(Exception e)
            {
                if(Properties.Settings.Default.warnOnNoConnection)
                {
                    if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogError).Play();
                    NoConnectionWarning dialog = new NoConnectionWarning();
                    dialog.Owner = this;
                    dialog.ShowDialog();
                    if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogClose).Play();
                }
            }
        }

        public async void GetOnlineSplashInformation()
        {
            using(StreamReader r = new StreamReader("splash.json"))
            {
                string json = r.ReadToEnd();
                OnlineSplashData data = JsonSerializer.Deserialize<OnlineSplashData>(json);

                cachedSplash = data;
            }

            // Reload splash
            ApplySplash(currentSplash);
        }

        private async void CheckForSoftwareUpdates(bool showUpToDateDialog)
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/Parquelle/WoWRetroLauncher/refs/heads/master/docs/version.html");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Window dialog = new LauncherUpdateUnavailableDialog();
                if (versionNumber < int.Parse(responseBody.Split("\n")[0]))
                {
                    dialog = new LauncherUpdateAvailableDialog();
                    if (Properties.Settings.Default.playSound) new SoundPlayer(Properties.Resources.DialogOpen).Play();
                    dialog.Owner = this;
                    dialog.ShowDialog();
                } else if(showUpToDateDialog)
                {
                    if (Properties.Settings.Default.playSound) new SoundPlayer(Properties.Resources.DialogOpen).Play();
                    dialog.Owner = this;
                    dialog.ShowDialog();
                    if (Properties.Settings.Default.playSound) new SoundPlayer(Properties.Resources.DialogClose).Play();
                }
            } catch(HttpRequestException e)
            {
                if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogOpen).Play();
                NoConnectionWarning dialog = new NoConnectionWarning();
                dialog.Owner = this;
                dialog.ShowDialog();
                if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogClose).Play();
            }
        }

        private async void GetBlizzardNewsData()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://news.blizzard.com/en-gb/api/news/blizzard?feedCxpProductIds[]=blt2caca37e42f19839");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                BlizzardNewsObject data = JsonSerializer.Deserialize<BlizzardNewsObject>(responseBody);

                for (int i = 1; i < 5; i++)
                {
                    Hyperlink hyperLink = new Hyperlink();
                    hyperLink.NavigateUri = new Uri(data.feed.contentItems[i - 1].properties.newsUrl);
                    hyperLink.Inlines.Add(data.feed.contentItems[i - 1].properties.title);
                    hyperLink.RequestNavigate += OnHyperlinkClick;
                    ((TextBlock)FindName($"News1_{i}")).Text = "";
                    ((TextBlock)FindName($"News1_{i}")).Inlines.Add(hyperLink);
                }
            }
            catch
            {
                ((TextBlock)FindName("News1_1")).Text = "Error loading news";
            }
        }

        private async void GetBlizzardTrackerData()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://eu.forums.blizzard.com/en/wow/groups/blizzard-tracker/posts.json");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                BlizzardTrackerObject data = JsonSerializer.Deserialize<BlizzardTrackerObject>(responseBody);

                int _postIndex = 0;
                for (int i = 1; i < 5; i++)
                {
                    if (data.posts[_postIndex].user_title.Equals("Blizzard News") || data.posts[_postIndex].topic_title.Contains("Hotfixes"))
                    {
                        i--;
                        _postIndex++;
                        continue;
                    }
                    Hyperlink hyperLink = new Hyperlink();
                    hyperLink.NavigateUri = new Uri($"https://eu.forums.blizzard.com/en/wow/{data.posts[_postIndex].url}");
                    hyperLink.Inlines.Add(data.posts[_postIndex].topic_title);
                    hyperLink.RequestNavigate += OnHyperlinkClick;
                    hyperLink.Style = FindResource("BlizzLink") as Style;
                    ((TextBlock)FindName($"News2_{i}")).Text = "";
                    ((TextBlock)FindName($"News2_{i}")).Inlines.Add(hyperLink);
                    _postIndex++;
                }
            } catch {
                ((TextBlock)FindName("News2_1")).Text = "Error loading news";
            }
        }

        private async void GetWowheadNewsData()
        {
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.wowhead.com/news/rss/all-wow");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                XmlSerializer serializer = new XmlSerializer(typeof(WowheadNewsObject));
                using (StringReader reader = new StringReader(responseBody))
                {
                    WowheadNewsObject data = (WowheadNewsObject)serializer.Deserialize(reader);

                    for (int i = 1; i < 5; i++)
                    {
                        Hyperlink hyperLink = new Hyperlink();
                        hyperLink.NavigateUri = new Uri(data.Channel.Item[i - 1].Link);
                        hyperLink.Inlines.Add(data.Channel.Item[i - 1].Title);
                        hyperLink.RequestNavigate += OnHyperlinkClick;
                        ((TextBlock)FindName($"News3_{i}")).Text = "";
                        ((TextBlock)FindName($"News3_{i}")).Inlines.Add(hyperLink);
                    }
                }
            }
            catch
            {
                ((TextBlock)FindName("News3_1")).Text = "Error loading news";
            }
        }

        private void OnHyperlinkClick(object sender, RequestNavigateEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = e.Uri.ToString();
            process.Start();
        }

        private void AssignButton(string buttonName, RoutedEventHandler function)
        {
            ((Button)FindName(buttonName)).Click += function;
        }

        private void AssignMenuButton(string buttonName, RoutedEventHandler function)
        {
            ((MenuItem)FindName(buttonName)).Click += function;
        }

        private void AssignDropdown(string dropdownName, SelectionChangedEventHandler function)
        {
            ((ComboBox)FindName(dropdownName)).SelectionChanged += function;
        }

        private void OnVersionSelect(object sender, SelectionChangedEventArgs e)
        {
            selectedVersion = gameVersions.First(x => x.Value.displayName == ((ComboBox)FindName("GameVersions")).SelectedValue.ToString()).Key;

            ((TextBlock)FindName("VersionLabel")).Text = gameVersions[selectedVersion].versionName;

            if (gameVersions[selectedVersion].version >= gameVersions[selectedVersion].liveVersion)
            {
                ((Button)FindName("Play")).IsEnabled = true;
                ((TextBlock)FindName("VersionWarning")).Text = "";
            }
            else
            {
                ((Button)FindName("Play")).IsEnabled = false;
                ((TextBlock)FindName("VersionWarning")).Text = "(UPDATE REQUIRED)";
            }

            Properties.Settings.Default.version = selectedVersion;
            Properties.Settings.Default.Save();
        }

        private void OpenSettings(object sender, RoutedEventArgs e)
        {
            var window = new LauncherSettingsWindow();
            window.Owner = this;
            window.ShowDialog();

            soundPlayer = new SoundPlayer(Properties.Resources.SettingsClose);
            if (Properties.Settings.Default.interfaceSounds) soundPlayer.Play();
        }

        public static MainWindow GetInstance() { return instance; }

        private void OnSettingsLoad(object sender, SettingsLoadedEventArgs e)
        {
            ValidateGameVersions();
        }

        public Dictionary<string, GameVersion> GetGameVersions()
        {
            return gameVersions;
        }

        private void ValidateGameVersions()
        {
            ((ComboBox)FindName("GameVersions")).Items.Clear();
            if (Properties.Settings.Default.gamepath.Length > 0)
            {
                foreach (string loopVersion in gameVersions.Keys)
                {
                    if (File.Exists($"{Properties.Settings.Default.gamepath}/{loopVersion}/{gameVersions[loopVersion].executableName}"))
                    {
                        ((ComboBox)FindName("GameVersions")).Items.Add(gameVersions[loopVersion].displayName);
                        GameVersion _version = gameVersions[loopVersion];
                        _version.found = true;
                        _version.versionName = FileVersionInfo.GetVersionInfo($"{Properties.Settings.Default.gamepath}/{loopVersion}/{_version.executableName}").FileVersion;
                        _version.version = int.Parse(_version.versionName.Replace(".", ""));

                        gameVersions[loopVersion] = _version;
                    }
                }
            }

            if(((ComboBox)FindName("GameVersions")).Items.Count > 0)
            {
                ((ComboBox)FindName("GameVersions")).IsEnabled = true;

                if(Properties.Settings.Default.version.Length > 0)
                {
                    if(((ComboBox)FindName("GameVersions")).Items.Contains(gameVersions[Properties.Settings.Default.version].displayName))
                    {
                        ((ComboBox)FindName("GameVersions")).SelectedValue = gameVersions[Properties.Settings.Default.version].displayName;
                        selectedVersion = Properties.Settings.Default.version;
                        ((Button)FindName("Play")).IsEnabled = true;

                        ((TextBlock)FindName("VersionLabel")).Text = gameVersions[selectedVersion].versionName;
                    }
                }
            }

            CheckForGameUpdates();
        }

        private void EnterGame(object sender, RoutedEventArgs e)
        {
            if (Environment.TickCount - lastPlay < 5000)
                return;

            if (Properties.Settings.Default.playSound) new SoundPlayer(Properties.Resources.Play).Play();
            lastPlay = Environment.TickCount;


            string _executable = "Wow.exe";
            if (selectedVersion.Contains("_ptr_") && selectedVersion.Contains("_classic_")) _executable = "WowClassicT.exe";
            else if (selectedVersion.Contains("_ptr_")) _executable = "WowT.exe";
            else if (selectedVersion.Contains("_classic_")) _executable = "WowClassic.exe";

            Process game = new Process();
            game.StartInfo.FileName = $"{Properties.Settings.Default.gamepath}/{selectedVersion}/{_executable}";
            game.Start();

            this.WindowState = WindowState.Minimized;
        }

        private void OpenBnet(object sender, RoutedEventArgs e)
        {
            Process bnet = new Process();
            bnet.StartInfo.FileName = $"{Properties.Settings.Default.gamepath}/World of Warcraft Launcher.exe";
            bnet.Start();
        }

        private void PlayLightButtonSound(object sender, EventArgs e) 
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.ButtonClickLight).Play();
        }

        private void PlayButtonSound(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.ButtonClick).Play();
        }

        private void PlayHoverSound(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.Hover).Play();
        }

        private void OpenInfo(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogOpen).Play();
            InfoDialog dialog = new InfoDialog();
            dialog.Owner = this;
            dialog.ShowDialog();
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogClose).Play();
        }

        private void OpenGithub(object sender, RoutedEventArgs e) { OpenLink("https://parquelle.github.io/WoWRetroLauncher"); }
        private void OpenNews(object sender, RoutedEventArgs e) { OpenLink("https://worldofwarcraft.blizzard.com/en-gb/news"); }
        private void OpenSupport(object sender, RoutedEventArgs e) { OpenLink("https://battle.net/support"); }
        private void OpenForums(object sender, RoutedEventArgs e) { OpenLink("https://eu.forums.blizzard.com/en/wow"); }
        private void OpenArmory(object sender, RoutedEventArgs e) { OpenLink("https://worldofwarcraft.blizzard.com/en-gb/worldsoul/eu/armory"); }

        private void OpenLink(string link)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = link;
            process.Start();
        }

        private async void ManuallyCheckForUpdates(object sender, RoutedEventArgs e)
        {
            CheckForSoftwareUpdates(true);
        }


        private async void CheckForGameUpdates()
        {
            HttpClient client = new HttpClient();
            try
            {
                int availableUpdates = 0;
                foreach (string loopVersionId in gameVersions.Keys)
                {
                    GameVersion loopVersion = gameVersions[loopVersionId];
                    if (!loopVersion.found) continue;

                    HttpResponseMessage response = await client.GetAsync($"https://blizztrack.com/api/manifest/{loopVersion.versionApiId}/versions");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    GameVersionObject data = JsonSerializer.Deserialize<GameVersionObject>(responseBody);

                    GameVersion _version = loopVersion;
                    _version.liveVersion = int.Parse(data.result.data[1].version_name.Replace(".", ""));
                    _version.liveVersionName = data.result.data[1].version_name;
                    gameVersions[loopVersionId] = _version;

                    if (gameVersions[loopVersionId].liveVersion > gameVersions[loopVersionId].version)
                    {
                        availableUpdates++;

                        if (selectedVersion == loopVersionId)
                        {
                            ((Button)FindName("Play")).IsEnabled = false;
                            ((TextBlock)FindName("VersionWarning")).Text = "(UPDATE REQUIRED)";
                        }
                    }

                }


                if(Properties.Settings.Default.warnOnOutdatedGame)
                {
                    if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogUpdate).Play();
                    GameUpdatesAvailableDialog dialog = new GameUpdatesAvailableDialog();
                    dialog.Owner = this;
                    dialog.ShowDialog();
                    if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogClose).Play();
                }
            } catch(Exception e)
            {

            }
        }

        public void ApplySplash(Splash splash)
        {
            currentSplash = splash;

            ((System.Windows.Controls.Image)FindName("SplashText")).Source = new BitmapImage(new Uri($"Resources/Splashes/Texts/{splash.text}.png", UriKind.Relative));
            ((System.Windows.Controls.Image)FindName("SplashBackground")).Source = new BitmapImage(new Uri($"Resources/Splashes/Backgrounds/{splash.background}.png", UriKind.Relative));
            ((System.Windows.Controls.Image)FindName("SplashForeground")).Source = new BitmapImage(new Uri($"Resources/Splashes/Foregrounds/{splash.foreground}.png", UriKind.Relative));

            if(cachedSplash != null)
                TryApplyOnlineSpash();
        }

        private void TryApplyOnlineSpash()
        {
            if (currentSplash.seasonal && !cachedSplash.overwriteSeasonals) return;

            // If text exists AND text is allowed AND either it can overwrite, or it can't overwrite but there is no text already anyway
            bool textAllowed = Properties.Settings.Default.allowDeveloperSplashText && (cachedSplash.overwriteText || currentSplash.text.Equals("empty"));
            bool imageAllowed = cachedSplash.hasImage && Properties.Settings.Default.allowDeveloperSplashImages;

            // If text is ok AND either it doesn't need an image, or it does but there is an image anyway
            if (textAllowed && (!cachedSplash.requireImage || imageAllowed))
            {
                ((System.Windows.Controls.Image)FindName("SplashText")).Source = new BitmapImage(cachedSplash.emptyText ? new Uri($"Resources/Splashes/Texts/empty.png", UriKind.Relative) : new Uri(cachedSplash.textLink));

                if (imageAllowed)
                {
                    ((System.Windows.Controls.Image)FindName("SplashBackground")).Source = new BitmapImage(new Uri(cachedSplash.backgroundLink));
                    ((System.Windows.Controls.Image)FindName("SplashForeground")).Source = new BitmapImage(cachedSplash.emptyForeground ? new Uri($"Resources/Splashes/Foregrounds/empty.png", UriKind.Relative) : new Uri(cachedSplash.foregroundLink));
                }
            }
        }

        public SplashData GetLoadedSplashData()
        {
            return splashData;
        }

        public struct GameVersion
        {
            public string id;
            public string displayName;
            public int version = 0;
            public string versionName = "";
            public int liveVersion = 0;
            public string liveVersionName = "";

            public string executableName;

            public string versionApiId;

            public bool found = false;

            public GameVersion(string id, string displayName, string executableName,  string versionApiId)
            {
                this.id = id;
                this.displayName = displayName;
                this.executableName = executableName;
                this.versionApiId = versionApiId;
            }
        }
    }
}