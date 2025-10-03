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

namespace Ariketa_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public static String izenapriv { get; set; }
        public static String abizena1priv { get; set; }
        public static String abizena2priv { get; set; }
        public static String dnipriv { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            izenapriv = izenaTextBox.Text;
            abizena1priv = abizena1TextBox.Text;
            abizena2priv = abizena2TextBox.Text;
            dnipriv = dniTextBox.Text;
        }

        private void salirButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void cargarButton_Click(object sender, RoutedEventArgs e)
        {
            VisualizarWindow visualizarWindow = new VisualizarWindow();
            visualizarWindow.Owner = this;
            visualizarWindow.ShowDialog();
        }
    }
}