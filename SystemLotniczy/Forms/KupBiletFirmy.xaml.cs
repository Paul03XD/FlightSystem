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

namespace SystemLotniczy.Views
{
    /// <summary>
    /// Interaction logic for KupBiletFirmy.xaml
    /// </summary>
    public class ItemDisplay
    {
        public int? id_lotu { get; set; }
        public int ilosc_wolnych_miejsc { get; set; }
        public string nazwa_samolotu { get; set; }
        public string nazwa_lotniska { get; set; }
        public string nazwa_trasy { get; set; }
        public float dystans { get; set; }
        public DateTime data_odlotu { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6}", nazwa_samolotu, nazwa_lotniska, nazwa_trasy, dystans, id_lotu, ilosc_wolnych_miejsc, data_odlotu);
        }
    }
    public partial class KupBiletFirmy : Window
    {
        List<ItemDisplay> lotyView = new List<ItemDisplay>();
        List<Klient> pracownicy = new List<Klient>();
        public KupBiletFirmy(List<Klient> pracownicy_)
        {
            InitializeComponent();
            LoadFlights();
            gridLoty.SelectionMode = DataGridSelectionMode.Single;
            pracownicy = pracownicy_;
        }
        public void LoadFlights()
        {
            lotyView.Clear();
            if(gridLoty.Items != null)
            {
                gridLoty.ItemsSource = null;
            }
            if (Listy.samolotyList is not null && Listy.klienciList is not null && Listy.lotniskaList is not null && Listy.rezerwacjeList is not null && Listy.lotyList is not null)
            {
                foreach (var lotyRow in Listy.lotyList)
                {
                    string samolot = "", lotnisko = "", trasa = "";
                    int ilosc_miejsc = 0, ilosc_zajetych_miejsc = 0;
                    foreach (var trasyRow in Listy.lotniskaList)
                    {
                        if (trasyRow.id == lotyRow.id_trasy)
                        {
                            trasa = trasyRow.miasto;
                        }
                    }
                    foreach (var samolotyRow in Listy.samolotyList)
                    {
                        if (samolotyRow.id == lotyRow.id_samolotu)
                        {
                            ilosc_miejsc = samolotyRow.l_miejsc;

                            foreach (var rezerwacja in Listy.rezerwacjeList)
                            {
                                if (rezerwacja.id_lotu == lotyRow.id)
                                {
                                    ilosc_zajetych_miejsc++;
                                }
                            }

                            samolot = samolotyRow.nazwa;
                        }
                    }
                    int ilosc_wolnych_miejsc_ = ilosc_miejsc - ilosc_zajetych_miejsc;
                    foreach (var lotniskaRow in Listy.lotniskaList)
                    {
                        if (lotniskaRow.id == lotyRow.id_lotniska)
                        {
                            lotnisko = lotniskaRow.nazwa_lotniska;
                        }
                    }
                    lotyView.Add(new ItemDisplay() { id_lotu = lotyRow.id, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = lotyRow.dystans, nazwa_samolotu = samolot, ilosc_wolnych_miejsc = ilosc_wolnych_miejsc_, data_odlotu = lotyRow.data_odlotu });
                }
            }
            else
            {
                MessageBox.Show("Pusta tabela");
            }
            gridLoty.ItemsSource = lotyView;
        }

        private void TicketGridCollapse(object sender, RoutedEventArgs e)
        {
            DataGridRow dataRow = (DataGridRow)sender;
            if (dataRow.IsSelected)
            {

                var gridLoty_ = gridLoty.CurrentItem.ToString().Split();
                lotniskoTxt.Content = gridLoty_[1];
                trasaTxt.Content = gridLoty_[2];
                dystatsTxt.Content = gridLoty_[3];
                idTxt.Content = gridLoty_[4];
                iloscMiejscTxt.Content = gridLoty_[5];
                dataWylotuTxt.Content = gridLoty_[6];

                cenaTxt.Content = (int.Parse(gridLoty_[3]) * Listy.kursZaKm).ToString();
                ticketGrid.Visibility = Visibility.Visible;
            }
            else
            {
                ticketGrid.Visibility = Visibility.Collapsed;
            }
        }

        private void KupBilet(object sender, RoutedEventArgs e)
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                if(iloscMiejscTxt.Content is not null)
                {

                    if (int.Parse((string)iloscMiejscTxt.Content) >= pracownicy.Count)
                    {
                        if (idTxt.Content is not null)
                        {
                            foreach (var pracownik in pracownicy)
                            {
                                Listy.rezerwacjeList.Add(new Rezerwacja((int)pracownik.id, int.Parse((string)idTxt.Content), Convert.ToDouble(cenaTxt.Content))); //poprawić cenę
                            }
                            _dbContext.Rezerwacje.UpdateRange(Listy.rezerwacjeList);
                            _dbContext.SaveChanges();
                            MessageBox.Show("Zakup udany!");
                            LoadFlights();
                        }
                        else
                        {
                            MessageBox.Show("Popraw");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Za mało wolnych miejsc. Wymagana liczba miejsc: "+pracownicy.Count);
                    }
                }
            }
        }
        private void Zamknij(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
