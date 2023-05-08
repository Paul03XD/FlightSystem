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
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : Window
    {

        public AdminView()
        {
            InitializeComponent();
            OpenAndViewDB();

        }
        private void Dodaj_Lot(object sender, RoutedEventArgs e)
        {
            DodajLot DodajLot1 = new DodajLot();
            DodajLot1.Show();
        }
        public void OpenAndViewDB()
        {

            gridFirmy.ItemsSource = Listy.firmaList;
            gridKlienci.ItemsSource = Listy.klienciList;
            gridSamoloty.ItemsSource = Listy.samolotyList;
            gridRezerwacje.ItemsSource = Listy.rezerwacjeList;
        }
    }
}
