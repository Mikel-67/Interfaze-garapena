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

namespace Ariketa_4
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

        private void password(object sender, RoutedEventArgs e)
        {
            if (pasahitza.Password == "1234" && User.Text == "Mikel")
            {
                emaitza.Content = "Ongi etorri sistemara";
            }
            else
            {
                emaitza.Content = "Identifikatu gabeko erabiltzailea";
            }
        }
        private void limpiar(object sender, RoutedEventArgs e)
        {
            pasahitza.Clear();
            User.Clear();
            emaitza.Content = "";
        }

        private void salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}