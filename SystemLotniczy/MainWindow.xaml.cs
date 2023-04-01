using System;
using System.Collections.Generic;
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

namespace SystemLotniczy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Loty loty1 = new Loty();
        public MainWindow()
        {
            InitializeComponent();
            Firma firma1 = new Firma("Mareczek");
            firma1.DodajPracownika("Paweł","Jabłoński",18);
            firma1.DodajPracownika("Kamil", "Nagórski", 16);
            firma1.DodajPracownika("Daniel", "Filipowicz", 17);
            firma1.DodajPracownika("Krystian", "Jaworowski", 18);


            

            listaP.ItemsSource = firma1.pracownicy;
        }

        private void OpenWindowLoty(object sender, RoutedEventArgs e)
        {
            loty1.Show();
        }
    }
}
