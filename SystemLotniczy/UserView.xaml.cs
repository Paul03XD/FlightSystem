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
        List<Klient> klienciList;
        List<Firma> firmaList;
        List<Samolot> samolotyList;
        List<Lot> lotyList;
        List<Lotnisko> lotniskaList;
        List<Rezerwacja> rezerwacjeList;
        List<Trasa> trasyList;
        List<ItemDisplay> lotyView = new List<ItemDisplay>();
        List<ItemDisplay> rezerwacjeView = new List<ItemDisplay>();
        static double kursZaKm = 1.28;

        Klient user;
        public UserView(Klient user_)
        {
            InitializeComponent();
            user = user_;
            gridLoty.SelectionMode = DataGridSelectionMode.Single;
            zalogowanyJako.Content = "Zalogowany jako " + user.username;
            OpenDB();
        }
        public void OpenDB()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {

                samolotyList = _dbContext.Samoloty.ToList();
                klienciList = _dbContext.Klienci.ToList();
                trasyList = _dbContext.Trasy.ToList();
                lotniskaList = _dbContext.Lotniska.ToList();
                rezerwacjeList = _dbContext.Rezerwacje.ToList();
                lotyList = _dbContext.Loty.ToList();




                if (samolotyList is not null && klienciList is not null && trasyList is not null && lotniskaList is not null && rezerwacjeList is not null && lotyList is not null)
                {
                    foreach (var lotyRow in lotyList)
                    {
                        string trasa = "", samolot = "", lotnisko = "";
                        foreach (var trasyRow in trasyList)
                        {
                            if (trasyRow.id == lotyRow.id_trasy)
                            {
                                trasa = trasyRow.nazwa;
                            }
                        }
                        foreach (var samolotyRow in samolotyList)
                        {
                            if (samolotyRow.id == lotyRow.id_samolotu)
                            {
                                samolot = samolotyRow.nazwa;
                            }
                        }
                        foreach (var lotniskaRow in lotniskaList)
                        {
                            if (lotniskaRow.id == lotyRow.id_lotniska)
                            {
                                lotnisko = lotniskaRow.nazwa_lotniska;
                            }
                        }
                        lotyView.Add(new ItemDisplay() { id_lotu = lotyRow.id, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = lotyRow.dystans, nazwa_samolotu = samolot, data_odlotu = lotyRow.data_odlotu });
                    }
                    RezerwacjeRefresh();
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridLoty.ItemsSource = lotyView;
            }
        }
        private void RezerwacjeRefresh() 
        { 
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                rezerwacjeView.Clear();
                if(gridRezerwacje.Items != null)
                {
                    gridRezerwacje.ItemsSource = null;
                }
                foreach(var rezerwacjeRow in rezerwacjeList)
                {
                    string klient_ = "", lotnisko = "", trasa = "", samolot = "";
                    int dystans_ = 0;
                    DateTime data_wylotu = new DateTime();
                    if(rezerwacjeRow.id_klienta == user.id)
                    {
                        foreach (var klienciRow in klienciList)
                        {
                            if (klienciRow.id == rezerwacjeRow.id_klienta)
                            {
                                klient_ = klienciRow.imie + " " + klienciRow.nazwisko;
                            }
                        }
                        foreach (var lotyRow in lotyList)
                        {
                            if (lotyRow.id == rezerwacjeRow.id_lotu)
                            {
                                dystans_ = lotyRow.dystans;
                                data_wylotu = lotyRow.data_odlotu;
                                foreach (var samolotyRow in samolotyList)
                                {
                                    if (samolotyRow.id == lotyRow.id_samolotu)
                                    {
                                        samolot = samolotyRow.nazwa;
                                    }
                                }
                                foreach (var trasyRow in trasyList)
                                {
                                    if (trasyRow.id == lotyRow.id_trasy)
                                    {
                                        trasa = trasyRow.nazwa;
                                    }
                                }
                                foreach (var lotniskaRow in lotniskaList)
                                {
                                    if (lotniskaRow.id == lotyRow.id_lotniska)
                                    {
                                        lotnisko = lotniskaRow.nazwa_lotniska;
                                    }
                                }

                            }
                        }
                        rezerwacjeView.Add(new ItemDisplay2() { klient = klient_, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = dystans_, data_odlotu = data_wylotu, nazwa_samolotu = samolot, cena = dystans_ * kursZaKm });
                    }
                }



                gridRezerwacje.ItemsSource = rezerwacjeView;
            }
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
            public DateTime data_odlotu { get; set; }

            public override string ToString()
            {
                return String.Format("{0} {1} {2} {3} {4} {5}", nazwa_samolotu, nazwa_lotniska, nazwa_trasy, dystans, id_lotu, data_odlotu);
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
                dataWylotuTxt.Content = gridLoty_[5];
                cenaTxt.Content = (Int32.Parse(gridLoty_[3]) * kursZaKm);
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
                if(idTxt.Content is not null)
                {
                    rezerwacjeList.Add(new Rezerwacja((int)user.id, int.Parse((string)idTxt.Content), 0)); //poprawić cenę
                    RezerwacjeRefresh();
                    _dbContext.Rezerwacje.UpdateRange(rezerwacjeList);
                    _dbContext.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Popraw");
                }
            }
        }
    }
}
