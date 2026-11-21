using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// Interaction logic for InvalidGamePathDialog.xaml
    /// </summary>
    public partial class InvalidGamePathDialog : Window
    {
        public InvalidGamePathDialog()
        {
            InitializeComponent();
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
