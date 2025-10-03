using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Ariketa_12
{
    public partial class MainWindow : Window
    {
        private const double gosariapriv = 3.0;
        private const double bazkariapriv = 9.0;
        private const double afariapriv = 15.5;
        private const double kmpriv = 0.25;
        private const double bidaiapriv = 18.0;
        private const double lanorduapriv = 42.0;

        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += MainWindow_PreviewKeyDown;
        }

        private void MainWindow_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Next);
                UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;
                keyboardFocus?.MoveFocus(tRequest);
                CalculateDiet(null, null);
            }
        }

        private void CalculateDiet(object sender, RoutedEventArgs e)
        {
            int total = 0;
            int bidaiak = 0;
            int dieta = 0;
            int lanord = 0;
            if (gosariaCheck.IsChecked == true)
            {
                total += (int)gosariapriv;
                dieta += (int)gosariapriv;
            }
            if (bazkariaCheck.IsChecked == true)
            {
                total += (int)bazkariapriv;
                dieta += (int)bazkariapriv;
            }
            if (afariaCheck.IsChecked == true)
            {
                total += (int)afariapriv;
                dieta += (int)afariapriv;
            }
            bidaiak += (int)((kmBox.Text == "" ? 0 : double.Parse(kmBox.Text)) * kmpriv);
            bidaiak += (int)((bidaiaBox.Text == "" ? 0 : int.Parse(bidaiaBox.Text)) * bidaiapriv);
            total += bidaiak;
            lanord += (int)((lanorduBox.Text == "" ? 0 : double.Parse(lanorduBox.Text)) * lanorduapriv);
            total += lanord;

            dietaBox.Text = dieta.ToString() + "€";
            bidaiakBox.Text = bidaiak.ToString() + "€";
            lanaBox.Text = lanord.ToString() + "€";
            ResultText.Text = "Totala: " + total.ToString() + "€";

        }

        private void ateraBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void garbituBtn_Click(object sender, RoutedEventArgs e)
        {
            kmBox.Text = "";
            bidaiaBox.Text = "";
            lanorduBox.Text = "";

            dietaBox.Text = "";
            bidaiakBox.Text = "";
            lanaBox.Text = "";
            ResultText.Text = "";

            gosariaCheck.IsChecked = false;
            bazkariaCheck.IsChecked = false;
            afariaCheck.IsChecked = false;
        }
    }
}