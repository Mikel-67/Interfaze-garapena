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

namespace WPFAriketak
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

        private void Operar(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtPrimerNumero.Text, out int zenbaki1) && 
                int.TryParse(txtSegundoNumero.Text, out int zenbaki2) &&
                int.TryParse(txtTercerNumero.Text, out int zenbaki3) &&
                int.TryParse(txtCuartoNumero.Text, out int zenbaki4)) 
            {
                double emaitza = (zenbaki1 + 2*zenbaki2 + 3*zenbaki3 + 4*zenbaki4)/4;

                txtResultado.Text = emaitza.ToString();
            }
        }

        private void Limpiar(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = "";
            txtPrimerNumero.Text = "";
            txtSegundoNumero.Text = "";
            txtTercerNumero.Text = "";
            txtCuartoNumero.Text = "";
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}