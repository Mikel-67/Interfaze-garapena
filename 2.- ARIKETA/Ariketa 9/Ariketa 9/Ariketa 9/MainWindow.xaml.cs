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

namespace Ariketa_9
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

        private void lagunaGehitu(object sender, RoutedEventArgs e)
        {
            if (berria.Text != "")
            {
                lista.Items.Add(berria.Text);
                berria.Clear();
            }
            else
            {
                MessageBox.Show("Mesedez, sartu lagunaren izena.");
            }
        }
        private void lagunaAukeratu(object sender, SelectionChangedEventArgs e)
        {
            if (lista.SelectedItem != null)
            {
                autatuta.Text = lista.SelectedItem.ToString();
            }
        }
        private void lagunaEzabatu(object sender, RoutedEventArgs e)
        {
            if (autatuta.Text != "")
            {
                lista.Items.Remove(lista.SelectedItem);
                autatuta.Clear();
            }
            else
            {
                MessageBox.Show("Mesedez, aukeratu ezabatu nahi duzun laguna.");
            }
        }
        private void lagunZerrendaGarbitu(object sender, RoutedEventArgs e)
        {
            lista.Items.Clear();
            autatuta.Clear();
        }
        private void itxi(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}