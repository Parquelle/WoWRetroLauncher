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

namespace WoWRetroLauncher2
{
    /// <summary>
    /// Interaction logic for LauncherUpdateAvailableDialog.xaml
    /// </summary>
    public partial class LauncherUpdateAvailableDialog : Window
    {
        public LauncherUpdateAvailableDialog()
        {
            InitializeComponent();

            LoadSoftwareUpdateData();
        }

        private async void LoadSoftwareUpdateData()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://raw.githubusercontent.com/Parquelle/WoWRetroLauncher/refs/heads/master/docs/version.html");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            ((TextBlock)FindName("MyVersion")).Text += $" {MainWindow.versionName}";
            ((TextBlock)FindName("NewVersion")).Text += $" {responseBody.Split("\n")[1]}";
        }

        public void OpenGithub(object sender, RoutedEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://parquelle.github.io/WoWRetroLauncher";
            process.Start();
        }

        public void Close(object sender, EventArgs e)
        {
            Close();
        }

        private void PlayHoverSound(object sender, MouseEventArgs e)
        {
            if (Properties.Settings.Default.interfaceSounds) new SoundPlayer(Properties.Resources.Hover).Play();
        }
    }
}
