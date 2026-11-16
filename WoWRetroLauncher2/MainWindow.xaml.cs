using System.Text;
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

namespace WoWRetroLauncher2b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*
            string wowheadUrl = "https://www.wowhead.com/news/rss/all-wow";
            XmlReader r = XmlReader.Create(wowheadUrl);
            XmlSerializer s = new XmlSerializer(typeof(string));
            Console.WriteLine(s.Deserialize(r));*/
        }
    }
}