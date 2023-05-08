using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : Window
    {
        List<ItemDisplay> lotyView = new List<ItemDisplay>();
        List<ItemDisplay> rezerwacjeView = new List<ItemDisplay>();

        Klient user;
        public UserView(Klient user_)
        {
            InitializeComponent();
            user = user_;
            gridLoty.SelectionMode = DataGridSelectionMode.Single;
            gridRezerwacje.SelectionMode = DataGridSelectionMode.Single;
            zalogowanyJako.Content = "Zalogowany jako " + user.username;
            LotyRefresh();
        }
        public void LotyRefresh()
        {
            lotyView.Clear();
            if (gridLoty.Items != null)
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



                            
                    lotyView.Add(new ItemDisplay() { id_lotu = lotyRow.id, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = lotyRow.dystans, nazwa_samolotu = samolot, data_odlotu = lotyRow.data_odlotu, ilosc_wolnych_miejsc = ilosc_wolnych_miejsc_ });
                }
                RezerwacjeRefresh();
            }
            else
            {
                MessageBox.Show("Pusta tabela");
            }
            gridLoty.ItemsSource = lotyView;
        }
        private void RezerwacjeRefresh() 
        { 
            rezerwacjeView.Clear();
            if(gridRezerwacje.Items != null)
            {
                gridRezerwacje.ItemsSource = null;
            }
            foreach(var rezerwacjeRow in Listy.rezerwacjeList)
            {
                string klient_ = "", lotnisko = "", trasa = "", samolot = "";
                int dystans_ = 0;
                DateTime data_wylotu = new DateTime();
                if(rezerwacjeRow.id_klienta == user.id)
                {
                    foreach (var klienciRow in Listy.klienciList)
                    {
                        if (klienciRow.id == rezerwacjeRow.id_klienta)
                        {
                            klient_ = klienciRow.imie + " " + klienciRow.nazwisko;
                        }
                    }
                    foreach (var lotyRow in Listy.lotyList)
                    {
                        if (lotyRow.id == rezerwacjeRow.id_lotu)
                        {
                            dystans_ = lotyRow.dystans;
                            data_wylotu = lotyRow.data_odlotu;
                            foreach (var samolotyRow in Listy.samolotyList)
                            {
                                if (samolotyRow.id == lotyRow.id_samolotu)
                                {
                                    samolot = samolotyRow.nazwa;
                                }
                            }
                            foreach (var trasyRow in Listy.lotniskaList)
                            {
                                if (trasyRow.id == lotyRow.id_trasy)
                                {
                                    trasa = trasyRow.miasto;
                                }
                            }
                            foreach (var lotniskaRow in Listy.lotniskaList)
                            {
                                if (lotniskaRow.id == lotyRow.id_lotniska)
                                {
                                    lotnisko = lotniskaRow.nazwa_lotniska;
                                }
                            }

                        }
                    }
                    rezerwacjeView.Add(new ItemDisplay2() { klient = klient_, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = dystans_, data_odlotu = data_wylotu, nazwa_samolotu = samolot, cena = rezerwacjeRow.cena});
                }
            }



            gridRezerwacje.ItemsSource = rezerwacjeView;
            
        }

        private void lotyZmien(object sender, TextChangedEventArgs e)
        {
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(gridLoty.ItemsSource);
            widok.Filter = FiltrUzytkownika;

        }
        private bool FiltrUzytkownika(object item)
        {
            if (String.IsNullOrEmpty(trasyTxtBox.Text))
                return true;
            else
                return ((item as ItemDisplay).nazwa_trasy.IndexOf(trasyTxtBox.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        public class ItemDisplay
        {
            public int? id_lotu { get; set; }
            public string nazwa_samolotu { get; set; }
            public string nazwa_lotniska { get; set; }
            public string nazwa_trasy { get; set; }
            public float dystans { get; set; }
            public int ilosc_wolnych_miejsc { get; set; }
            public DateTime data_odlotu { get; set; }

            public override string ToString()
            {
                return String.Format("{0} {1} {2} {3} {4} {5} {6}", nazwa_samolotu, nazwa_lotniska, nazwa_trasy, dystans, id_lotu, ilosc_wolnych_miejsc, data_odlotu);
            }
        }
        
        public class ItemDisplay2 : ItemDisplay
        {
            public string klient { get; set; }
            public double cena { get; set; }
            public override string ToString()
            {
                return String.Format("{0} {1} {2} {3} {4} {5} {6}", klient, nazwa_lotniska, nazwa_trasy, dystans, data_odlotu, nazwa_samolotu, cena);
            }
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
                cenaTxt.Content = (int.Parse(gridLoty_[3])*Listy.kursZaKm).ToString();
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
                int ilosc_wolnych_miejsc = 0;
                if (iloscMiejscTxt.Content is not null)
                {
                    ilosc_wolnych_miejsc = int.Parse((string)iloscMiejscTxt.Content);
                }
                if (ilosc_wolnych_miejsc >= 1)
                {
                    if (idTxt.Content is not null)
                    {
                        Listy.rezerwacjeList.Add(new Rezerwacja((int)user.id, int.Parse((string)idTxt.Content), Convert.ToDouble(cenaTxt.Content))); //poprawić cenę
                        LotyRefresh();
                        _dbContext.Rezerwacje.UpdateRange(Listy.rezerwacjeList);
                        _dbContext.SaveChanges();
                        MessageBox.Show("Zakup udany!");
                    }
                    else
                    {
                        MessageBox.Show("Popraw");
                    }
                }
                else
                {
                    MessageBox.Show("Brak miejsc");
                }
            }
        }

        private void Wyloguj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
