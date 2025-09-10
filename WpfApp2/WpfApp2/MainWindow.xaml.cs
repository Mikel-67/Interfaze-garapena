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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StringBuilder frase = new StringBuilder();
        int oraingoa = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Frase(object sender, RoutedEventArgs e)
        {
            frase.Append((TextInputa.Text)+ " ");
            TextInputa.Clear();

            var oraingoBotoia = (Button)this.FindName("Botoi_" + oraingoa);
            oraingoBotoia.IsEnabled = false;

            if (oraingoa < 5)
            {
                var hurrengoBotoia = (Button)this.FindName("Botoi_" + (oraingoa + 1));
                hurrengoBotoia.IsEnabled = true;
                oraingoa++;
            }
            else
            {
                TextInputa.IsEnabled = false;
                Botoi_5.IsEnabled = false;
                Unir.IsEnabled = true;
                oraingoa = 1;
            }
        }

        private void Batu(object sender, RoutedEventArgs e)
        {
            TextInputa.Text = frase.ToString();
            Unir.IsEnabled = false;
        }

        private void clean(object sender, RoutedEventArgs e)
        {
            frase.Clear();
            TextInputa.Clear();
            TextInputa.IsEnabled = true;
            Unir.IsEnabled = false;
            for (int i = 1; i <= 5; i++)
            {
                var botoia = (Button)this.FindName("Botoi_" + i);
                botoia.IsEnabled = (i == 1);
            }
            oraingoa = 1;
        }
        private void exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}