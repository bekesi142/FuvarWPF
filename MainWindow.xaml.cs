using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dolgozat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<fuvar> feladatok = new List<fuvar>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            utazasok_szama.Content = feladatok.Count;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bizonyos_taxi_infoja.Content = feladatok.FindAll(x => x.Taxi_id == 6185).Sum(x => x.Viteldij+x.Borravalo) + "$-t fizettek " + feladatok.Select(x => x.Taxi_id = 6185).Count() + " fuvar alatt"; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            megtett_ut_mennyisege.Content = feladatok.Sum(x => x.Tavolsag*1.6) + "km";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            fizetesi_modok.Content = feladatok.Select(x => x.Fizetes_modja == "bankkártya").Count() + "bankkártyával" + feladatok.Select(x => x.Fizetes_modja == "vitatott").Count() + "vitatott" + feladatok.Select(x => x.Fizetes_modja == "készpénz").Count() + "készpénzzel" + feladatok.Select(x => x.Fizetes_modja == "ingyenes").Count() + "ingyen" + feladatok.Select(x => x.Fizetes_modja == "ismeretlen").Count() + "ingyen"; 
        }
    }

    public void Filebeolvasas(string fajlneve)
    {
        List<fuvar> feladatok = new List<fuvar>();

        foreach (var sor in File.ReadAllLines("fuvar.csv").Skip(1))
        {
            int taxi_id = int.Parse(sor.Split(";")[0]);
            string indulas = sor.Split(";")[1];
            int idotartam = int.Parse(sor.Split(";")[2]);
            int tavolsag = int.Parse(sor.Split(";")[3]);
            int viteldij = int.Parse(sor.Split(";")[4]);
            int borravalo = int.Parse(sor.Split(";")[5]);
            string fizetes_modja = sor.Split(";")[6];          
            feladatok.Add(new fuvar(taxi_id, indulas, idotartam, tavolsag, viteldij, borravalo, fizetes_modja));
        }

    }

}
