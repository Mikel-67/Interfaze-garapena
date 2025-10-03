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

namespace Ariketa13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Keyboard shortcuts
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Cut, Moztu_Click));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Copy, Kopiatu_Click));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, Itsasi_Click));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Delete, Ezabatu_Click));
        }

        private void Moztu_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Cut();
        }

        private void Kopiatu_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Copy();
        }

        private void Itsasi_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.Paste();
        }

        private void Ezabatu_Click(object sender, RoutedEventArgs e)
        {
            txtEditor.SelectedText = ""; // Delete selection or nothing
        }

        private void Arial_Click(object sender, RoutedEventArgs e)
        {
            ChangeFontFamily("Arial");
        }

        private void Courier_Click(object sender, RoutedEventArgs e)
        {
            ChangeFontFamily("Courier New");
        }

        private void Impact_Click(object sender, RoutedEventArgs e)
        {
            ChangeFontFamily("Impact");
        }

        private void Symbol_Click(object sender, RoutedEventArgs e)
        {
            ChangeFontFamily("Symbol");
        }

        private void ChangeFontFamily(string fontFamily)
        {
            txtEditor.FontFamily = new FontFamily(fontFamily);
        }
    }
}