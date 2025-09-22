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

namespace Ariketa_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String select;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comicSans(object sender, RoutedEventArgs e)
        {
            hitza.FontFamily = new FontFamily("Comic Sans MS");
        }
        private void courier(object sender, RoutedEventArgs e)
        {
            hitza.FontFamily = new FontFamily("Courier New");
        }
        private void negrita(object sender, RoutedEventArgs e)
        {
            if (hitza.FontWeight == FontWeights.Bold)
            {
                hitza.FontWeight = FontWeights.Normal;
            }
            else
            {
                hitza.FontWeight = FontWeights.Bold;
            }
        }
        private void tachado(object sender, RoutedEventArgs e)
        {
            if (hitza.TextDecorations == TextDecorations.Strikethrough)
            {
                hitza.TextDecorations = null;
            }
            else
            {
                hitza.TextDecorations = TextDecorations.Strikethrough;
            }
        }
        private void tamainaHanditu(object sender, RoutedEventArgs e)
        {
            hitza.FontSize += 2;
        }
        private void cursiva(object sender, RoutedEventArgs e)
        {
            if (hitza.FontStyle == FontStyles.Italic)
            {
                hitza.FontStyle = FontStyles.Normal;
            }
            else
            {
                hitza.FontStyle = FontStyles.Italic;
            }
        }
        private void subrayado(object sender, RoutedEventArgs e)
        {
            if (hitza.TextDecorations == TextDecorations.Underline)
            {
                hitza.TextDecorations = null;
            }
            else
            {
                hitza.TextDecorations = TextDecorations.Underline;
            }
        }
        private void tamainaTxikitu(object sender, RoutedEventArgs e)
        {
            if (hitza.FontSize > 2)
            {
                hitza.FontSize -= 2;
            }
        }

        private void seleccionarTexto(object sender, RoutedEventArgs e)
        {
            select = Box.SelectedText;
            Info.Content = "Textua " + Box.Text.Length + " karaktere ditu, eta hautatuta dago: " + select;
        }
        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}