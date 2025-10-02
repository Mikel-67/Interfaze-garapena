using System.Windows;
using System.Windows.Controls;

namespace Ariketa_10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBoxSelect(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    img2.Visibility = Visibility.Collapsed;
                    img3.Visibility = Visibility.Collapsed;
                    img1.Visibility = Visibility.Visible;
                    break;
                case 1:
                    img1.Visibility = Visibility.Collapsed;
                    img3.Visibility = Visibility.Collapsed;
                    img2.Visibility = Visibility.Visible;
                    break;
                case 2:
                    img1.Visibility = Visibility.Collapsed;
                    img2.Visibility = Visibility.Collapsed;
                    img3.Visibility = Visibility.Visible;
                    break;
                default:
                    img3.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void checkBox_erakutsi(object sender, RoutedEventArgs e)
        {
            if (sender == Check4)
                img4.Visibility = Visibility.Visible;
            else if (sender == Check5)
                img5.Visibility = Visibility.Visible;
            else if (sender == Check6)
                img6.Visibility = Visibility.Visible;
        }

        private void checkBox_izkutatu(object sender, RoutedEventArgs e)
        {
            if (sender == Check4)
                img4.Visibility = Visibility.Hidden;
            else if (sender == Check5)
                img5.Visibility = Visibility.Hidden;
            else if (sender == Check6)
                img6.Visibility = Visibility.Hidden;
        }
    }
}