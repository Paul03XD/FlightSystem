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
using System.Windows.Shapes;

namespace SystemLotniczy
{
    /// <summary>
    /// Interaction logic for DodajLot.xaml
    /// </summary>
    public partial class DodajLot : Window
    {
        Lot lot1 = new Lot();
        public DodajLot()
        {
            InitializeComponent();
            OpenAndViewDB();
            this.DataContext = lot1;
        }
        public void OpenAndViewDB()
        {
            foreach (var lotnisko in Listy.lotniskaList)
            {
                lotniskoCmbBox.Items.Add(lotnisko.nazwa_lotniska);
            }
            foreach (var trasa in Listy.trasyList)
            {
                miastoCmbBox.Items.Add(trasa.nazwa_miasta + ", " + trasa.adres);
            }
            foreach (var samolot in Listy.samolotyList)
            {
                samolotCmbBox.Items.Add(samolot.nazwa);
            }
        }
        private void Dodaj_Lot(object sender, RoutedEventArgs e)
        {
            if (Walidacja.IsValid(this) && !String.IsNullOrEmpty(lotniskoCmbBox.Text) && !String.IsNullOrEmpty(samolotCmbBox.Text) && !String.IsNullOrEmpty(miastoCmbBox.Text) && !String.IsNullOrEmpty(data_odlotu_DatePicker.Text))
            {
                using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
                {
                    var data_odlotu = data_odlotu_DatePicker.Text.Split("/");
                    lot1.id_lotniska = lotniskoCmbBox.SelectedIndex+1;
                    lot1.id_samolotu = samolotCmbBox.SelectedIndex+1;
                    lot1.id_trasy = miastoCmbBox.SelectedIndex+1;
                    lot1.data_odlotu = new DateTime(int.Parse(data_odlotu[2]), int.Parse(data_odlotu[0]), int.Parse(data_odlotu[1]));
                    Listy.lotyList.Add(lot1);
                    _dbContext.Loty.UpdateRange(Listy.lotyList);
                    _dbContext.SaveChanges();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wprowadź wszystkie dane poprawnie");
            }
        }
    }
}
