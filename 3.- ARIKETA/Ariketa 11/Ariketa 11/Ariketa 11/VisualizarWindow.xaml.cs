using System.Windows;

namespace Ariketa_11
{
    public partial class VisualizarWindow : Window
    {
        public VisualizarWindow()
        {
            InitializeComponent();
            izenaText.Text = $"{MainWindow.izenapriv}";
            abizena1Text.Text = $"{MainWindow.abizena1priv}";
            abizena2Text.Text = $"{MainWindow.abizena2priv}";
            dniText.Text = $"{MainWindow.dnipriv}";
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}