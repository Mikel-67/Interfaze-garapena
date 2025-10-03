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

namespace Ariketa_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Atera_Click (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //Ariketak esaten du textu guztiarentzat egitea baino hau autatutakorako bailo du
        public void Moztu_Click (object sender, RoutedEventArgs e)
        {
            txtEditor.Cut();
        }
        public void Kopiatu_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Copy();
        }
        public void Itsasi_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Paste();
        }
        public void Ezabatu_Click(Object sender, RoutedEventArgs e)
        {
            txtEditor.Text = "";
        }
        //Ariketan esaten duen kodearekin saiatu naiz baina ez du funtzionatzen eta hau erabili dut
        public void Arial_Click(Object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Arial");
        }
        public void Courier_Click(Object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Courier New");
        }
        public void Impact_Click(Object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Impact");
        }
        public void Symbol_Click(Object sender, RoutedEventArgs e)
        {
            txtEditor.FontFamily = new FontFamily("Symbol");
        }
    }
}