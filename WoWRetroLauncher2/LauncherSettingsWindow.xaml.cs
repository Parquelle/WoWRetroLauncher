using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WoWRetroLauncher2
{
    /// <summary>
    /// Interaction logic for LauncherSettings.xaml
    /// </summary>

    public partial class LauncherSettingsWindow : Window
    {
        private bool hasOpened;
        public LauncherSettingsWindow()
        {
            InitializeComponent();

            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.SettingsOpen).Play();

            if (Properties.Settings.Default.gamepath.Length > 0)
            {
                ((TextBox) FindName("DatapathField")).Text = Properties.Settings.Default.gamepath;
            }


            SplashData data = JsonSerializer.Deserialize<SplashData>(Encoding.UTF8.GetString(Properties.Resources.Splashes));
            foreach (Splash loopSplash in data.splashes)
            {
                ((ComboBox)FindName("SplashDropdown")).Items.Add(loopSplash.name);
            }
            ((ComboBox)FindName("SplashDropdown")).SelectedValue = data.splashes.Find(x => x.id.Equals(Properties.Settings.Default.selectedSplash)).name;


            ((System.Windows.Controls.Image)FindName("Header")).MouseDown += OnMouseDownHeader;
            ((CheckBox)FindName("InterfaceSounds")).IsChecked = Properties.Settings.Default.interfaceSounds;
            ((CheckBox)FindName("InterfaceSounds")).Checked += ToggleInterfaceSounds;
            ((CheckBox)FindName("InterfaceSounds")).Unchecked += ToggleInterfaceSounds;

            ((CheckBox)FindName("PlaySound")).IsChecked = Properties.Settings.Default.playSound;
            ((CheckBox)FindName("PlaySound")).Checked += TogglePlaySound;
            ((CheckBox)FindName("PlaySound")).Unchecked += TogglePlaySound;

            ((CheckBox)FindName("CheckUpdatesOnStartup")).IsChecked = Properties.Settings.Default.checkUpdatesOnStartup;
            ((CheckBox)FindName("CheckUpdatesOnStartup")).Checked += ToggleCheckUpdatesOnStartup;
            ((CheckBox)FindName("CheckUpdatesOnStartup")).Unchecked += ToggleCheckUpdatesOnStartup;

            ((CheckBox)FindName("WarnOnOutdatedGame")).IsChecked = Properties.Settings.Default.warnOnOutdatedGame;
            ((CheckBox)FindName("WarnOnOutdatedGame")).Checked += ToggleWarnOnOutdatedGame;
            ((CheckBox)FindName("WarnOnOutdatedGame")).Unchecked += ToggleWarnOnOutdatedGame;

            ((CheckBox)FindName("WarnOnNoConnection")).IsChecked = Properties.Settings.Default.warnOnNoConnection;
            ((CheckBox)FindName("WarnOnNoConnection")).Checked += ToggleWarnOnNoConnection;
            ((CheckBox)FindName("WarnOnNoConnection")).Unchecked += ToggleWarnOnNoConnection;

            ((CheckBox)FindName("RandomSplashes")).IsChecked = Properties.Settings.Default.randomSplashes;
            ((CheckBox)FindName("RandomSplashes")).Checked += ToggleRandomSplashes;
            ((CheckBox)FindName("RandomSplashes")).Unchecked += ToggleRandomSplashes;

            ((ComboBox)FindName("SplashDropdown")).SelectionChanged += OnSplashSelect;
            ((ComboBox)FindName("SplashDropdown")).IsEnabled = !Properties.Settings.Default.randomSplashes;
        }

        private void ToggleRandomSplashes(object sender, RoutedEventArgs e)
        {
            bool _randomSplashes = ((CheckBox)FindName("RandomSplashes")).IsChecked.Value;
            Properties.Settings.Default.randomSplashes = _randomSplashes;
            Properties.Settings.Default.Save();

            ((ComboBox)FindName("SplashDropdown")).IsEnabled = !Properties.Settings.Default.randomSplashes;
        }

        private void OnSplashSelect(object sender, SelectionChangedEventArgs e)
        {
            Splash _selectedSplash = MainWindow.GetInstance().GetLoadedSplashData().splashes.Find(x => x.name.Equals(((ComboBox)FindName("SplashDropdown")).SelectedValue.ToString()));
            MainWindow.GetInstance().ApplySplash(_selectedSplash);

            Properties.Settings.Default.selectedSplash = _selectedSplash.id;
            Properties.Settings.Default.Save();
        }

        private void ToggleWarnOnOutdatedGame(object sender, RoutedEventArgs e)
        {
            bool _warnOnOutdatedGame = ((CheckBox)FindName("WarnOnOutdatedGame")).IsChecked.Value;
            Properties.Settings.Default.warnOnOutdatedGame = _warnOnOutdatedGame;
            Properties.Settings.Default.Save();
        }

        private void ToggleWarnOnNoConnection(object sender, RoutedEventArgs e)
        {
            bool _warnOnNoConnection = ((CheckBox)FindName("WarnOnNoConnection")).IsChecked.Value;
            Properties.Settings.Default.warnOnNoConnection = _warnOnNoConnection;
            Properties.Settings.Default.Save();
        }

        private void ToggleCheckUpdatesOnStartup(object sender, RoutedEventArgs e)
        {
            bool _enableCheckUpdatesOnStartup = ((CheckBox)FindName("CheckUpdatesOnStartup")).IsChecked.Value;
            Properties.Settings.Default.checkUpdatesOnStartup = _enableCheckUpdatesOnStartup;
            Properties.Settings.Default.Save();
        }

        private void ToggleInterfaceSounds(object sender, RoutedEventArgs e)
        {
            bool _enableInterfaceSounds = ((CheckBox)FindName("InterfaceSounds")).IsChecked.Value;
            Properties.Settings.Default.interfaceSounds = _enableInterfaceSounds;
            Properties.Settings.Default.Save();
        }

        private void TogglePlaySound(object sender, RoutedEventArgs e)
        {
            bool _enablePlaySound = ((CheckBox)FindName("PlaySound")).IsChecked.Value;
            Properties.Settings.Default.playSound = _enablePlaySound;
            Properties.Settings.Default.Save();
        }

        private void OnMouseDownHeader(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        public void LoadDatapath(object sender, EventArgs e)
        {
            OpenFolderDialog dialog = new OpenFolderDialog();
            var result = dialog.ShowDialog();
            if (result.ToString().Equals("True"))
            {
                bool _anyGameFound = false;
                string _path = dialog.FolderName;
                foreach (string loopVersion in MainWindow.GetInstance().GetGameVersions().Keys)
                {
                    string _executable = "Wow.exe";
                    if (loopVersion.Contains("_ptr_") && loopVersion.Contains("_classic_")) _executable = "WowClassicT.exe";
                    else if (loopVersion.Contains("_ptr_")) _executable = "WowT.exe";
                    else if (loopVersion.Contains("_classic_")) _executable = "WowClassic.exe";

                    if (File.Exists($"{_path}/{loopVersion}/{_executable}"))
                    {
                        _anyGameFound = true;
                        break;
                    }
                }

                if (_anyGameFound)
                {
                    ((TextBox) FindName("DatapathField")).Text = _path;
                    Properties.Settings.Default.gamepath = _path;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    if(Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogError).Play();
                    var errorDialog = new InvalidGamePathDialog();
                    errorDialog.Owner = this;
                    errorDialog.ShowDialog();

                    if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.DialogClose).Play();
                }
            }
        }

        public void Close(object sender, EventArgs e)
        {
            Close();
        }

        public void PlayLightButtonSound(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.ButtonClickLight).Play();
        }

        private void OnTabSwitch(object sender, SelectionChangedEventArgs e)
        {
            if (!hasOpened)
            {
                hasOpened = true;
                return;
            }
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.ButtonClick).Play();
        }

        private void OnCheck(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.ButtonClickLight).Play();
        }
    }
}
