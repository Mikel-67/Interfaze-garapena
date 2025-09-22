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

namespace Ariketa_6
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

        private void pressEnter(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Bat.Text != "")
                {
                    Bi.Text = Bat.Text;
                    Bat.Text = "";
                }
                else if (Bi.Text != "")
                {
                    Hiru.Text = Bi.Text;
                    Bi.Text = "";
                }
                else if (Hiru.Text != "")
                {
                    Bat.Text = Hiru.Text;
                    Hiru.Text = "";
                }
            }
        }
        private void garbitu(object sender, RoutedEventArgs e)
        {
            Bat.Text = "";
            Bi.Text = "";
            Hiru.Text = "";
        }
        private void exit (object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}