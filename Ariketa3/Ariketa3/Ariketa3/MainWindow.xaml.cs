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

namespace Ariketa3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int posizioa = 1;
        int[] zenbakianum ;

        public MainWindow()
        {
            InitializeComponent();
            zenbakianum = new int[4];
        }

        private void gordezenbakia(object sender, RoutedEventArgs e)
        {
            if (posizioa >= 4)
            {
                zenbakianum[posizioa - 1] = int.Parse(inputa.Text);
                int emaitza = (zenbakianum[0] + (zenbakianum[0]*zenbakianum[1]) + (zenbakianum[1] * zenbakianum[2]) + (zenbakianum[2]*zenbakianum[3]))/4;
                inputa.Text = emaitza.ToString();
                inputa.IsReadOnly = true;
                hitza.Content = "Emaitza";
                AkzioBotoia.Content = "Garbitu";
                posizioa = 0;
            }else if (posizioa == 0)
            {
                posizioa = 1;
                inputa.Clear();
                inputa.IsReadOnly = false;
                hitza.Content = "Zenbakia " + posizioa;
                AkzioBotoia.Content = "Siguiente";
            }
            else
            {
                zenbakianum[posizioa-1] = int.Parse(inputa.Text);
                posizioa++;
                inputa.Clear();
                hitza.Content = "Zenbakia " + posizioa;
            }
        }
        private void itxi(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}