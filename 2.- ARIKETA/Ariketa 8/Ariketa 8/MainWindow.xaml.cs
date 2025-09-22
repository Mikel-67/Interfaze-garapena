using Microsoft.VisualBasic;
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

namespace Ariketa_8
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

        private void gaurkoData(object sender, RoutedEventArgs e)
        {
            DateTime gaur = DateTime.Now;
            txtOrain.Text = gaur.ToString();

            DateOnly gaurData = DateOnly.FromDateTime(gaur);
            txtGaur.Text = gaurData.ToString();

            TimeOnly ordua = TimeOnly.FromDateTime(gaur);
            txtOrdua.Text = ordua.ToString();

            dataGehitu(sender, e);
            dataDiferentzia(sender, e);
        }
        private void dataGehitu(object sender, RoutedEventArgs e)
        {
            String data = Interaction.InputBox("Sartu data (dd/mm/yyyy):", "Data sartu", "01/01/2024");
            String gehitu = Interaction.InputBox("Sartu gehitu nahi duzun hilabete kopurua:", "Hilabeteak gehitu", "0");

            DateOnly dataObj = DateOnly.Parse(data);
            int gehituInt = int.Parse(gehitu);

            DateOnly dataBerria = dataObj.AddMonths(gehituInt);

            txtDataGehitu.Text = "Hasiera data: " + data + ", Hilabeteak gehitu: " + gehitu + ", Data berria: " + dataBerria;
        }

        private void dataDiferentzia(object sender, RoutedEventArgs e)
        {
            String data1 = Interaction.InputBox("Sartu lehen data (dd/mm/yyyy):", "Lehen data sartu", "01/01/2024");
            String data2 = Interaction.InputBox("Sartu bigarren data (dd/mm/yyyy):", "Bigarren data sartu", "01/01/2024");
            DateOnly dataObj1 = DateOnly.Parse(data1);
            DateOnly dataObj2 = DateOnly.Parse(data2);
            int diferentzia = Math.Abs(dataObj2.DayNumber - dataObj1.DayNumber);
            txtDataDiferentzia.Text = "Lehen data: " + data1 + ", Bigarren data: " + data2 + ", Egunen diferentzia: " + diferentzia;
        }

        private void limpiar(object sender, RoutedEventArgs e)
        {
            txtOrain.Text = "";
            txtGaur.Text = "";
            txtOrdua.Text = "";
            txtDataGehitu.Text = "";
            txtDataDiferentzia.Text = "";
        }
        private void salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}