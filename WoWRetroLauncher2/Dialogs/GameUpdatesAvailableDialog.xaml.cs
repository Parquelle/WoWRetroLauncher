using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static WoWRetroLauncher2.MainWindow;

namespace WoWRetroLauncher2
{
    /// <summary>
    /// Interaction logic for LauncherUpdateAvailableDialog.xaml
    /// </summary>
    public partial class GameUpdatesAvailableDialog : Window
    {
        public GameUpdatesAvailableDialog()
        {
            InitializeComponent();

            TextBlock dialogTitle = ((TextBlock)FindName("DialogTitle"));
            TextBlock newVersions = ((TextBlock)FindName("NewVersions"));

            int availableUpdates = 0;
            foreach(string gameVersionid in MainWindow.GetInstance().GetGameVersions().Keys)
            {
                GameVersion loopVersion = MainWindow.GetInstance().GetGameVersions()[gameVersionid];

                if(loopVersion.liveVersion > loopVersion.version)
                {
                    newVersions.Text += $"{loopVersion.displayName}:  {loopVersion.versionName} >> {loopVersion.liveVersionName}\n";
                    availableUpdates++;
                }
            }

            dialogTitle.Text = String.Format(dialogTitle.Text, availableUpdates);
        }


        public void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayHoverSound(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.Hover).Play();
        }

        private void OpenBnet(object sender, RoutedEventArgs e)
        {
            Process bnet = new Process();
            bnet.StartInfo.FileName = $"{Properties.Settings.Default.gamepath}/World of Warcraft Launcher.exe";
            bnet.Start();

            Close();
        }
    }
}
