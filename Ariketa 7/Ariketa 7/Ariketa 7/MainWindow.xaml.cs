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

namespace Ariketa_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float zenbaki1;
        float zenbaki2;
        String operadorea;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void sartuBat(object sender, RoutedEventArgs e)
        {
            Button botoia = (Button)sender;
            Pantaia.Text = Pantaia.Text + botoia.Content.ToString();
        }
        private void batuketa(object sender, RoutedEventArgs e)
        {
            zenbaki1 = float.Parse(Pantaia.Text);
            Pantaia.Text = "";
            operadorea = "+";
        }
        private void kenketa (object sender, RoutedEventArgs e)
        {
            zenbaki1 = float.Parse(Pantaia.Text);
            Pantaia.Text = "";
            operadorea = "-";
        }
        private void biderketa(object sender, RoutedEventArgs e)
        {
            zenbaki1 = float.Parse(Pantaia.Text);
            Pantaia.Text = "";
            operadorea = "*";
        }
        private void zatiketa(object sender, RoutedEventArgs e)
        {
            zenbaki1 = float.Parse(Pantaia.Text);
            Pantaia.Text = "";
            operadorea = "/";
        }
        private void ehunekoa(object sender, RoutedEventArgs e)
        {
            zenbaki1 = float.Parse(Pantaia.Text);
            Pantaia.Text = "";
            operadorea = "%";
        }
        private void emaitza(object sender, RoutedEventArgs e)
        {
            zenbaki2 = float.Parse(Pantaia.Text);
            switch (operadorea)
            {
                case "+":
                    Pantaia.Text = (zenbaki1 + zenbaki2).ToString();
                    break;
                case "-":
                    Pantaia.Text = (zenbaki1 - zenbaki2).ToString();
                    break;
                case "*":
                    Pantaia.Text = (zenbaki1 * zenbaki2).ToString();
                    break;
                case "/":
                    Pantaia.Text = (zenbaki1 / zenbaki2).ToString();
                    break;
                case "%":
                    Pantaia.Text = (zenbaki1 % zenbaki2).ToString();
                    break;
            }
        }
        private void garbitu(object sender, RoutedEventArgs e)
        {
            Pantaia.Text = "";
        }
        private void ezabatuBat (object sender, RoutedEventArgs e)
        {
            if (Pantaia.Text.Length > 0)
            {
                Pantaia.Text = Pantaia.Text.Remove(Pantaia.Text.Length - 1, 1);
            }
        }
    }
}