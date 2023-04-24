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
        static double kursZaKm = 1.28;
        public UserView(Klient user)
        {
            InitializeComponent();
            gridLoty.SelectionMode = DataGridSelectionMode.Single;
            zalogowanyJako.Content = "Zalogowany jako " + user.username;
            OpenDB();
            gridLoty.ItemsSource = lotyView;
        }
        public void OpenDB()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {

                samolotyList = _dbContext.Samoloty.ToList();
                if (samolotyList is not null)
                {
                    Console.WriteLine("Tabela samoloty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                trasyList = _dbContext.Trasy.ToList();
                if (trasyList is not null)
                {
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                lotniskaList = _dbContext.Lotniska.ToList();
                if (lotniskaList is not null)
                {
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }



                lotyList = _dbContext.Loty.ToList();
                if (lotyList is not null)
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
                        lotyView.Add(new ItemDisplay() { nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = lotyRow.dystans, nazwa_samolotu = samolot, data_odlotu = lotyRow.data_odlotu });
                    }

                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }

                gridLoty.ItemsSource = lotyView;
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
            public string nazwa_samolotu { get; set; }
            public string nazwa_lotniska { get; set; }
            public string nazwa_trasy { get; set; }
            public float dystans { get; set; }
            public DateTime data_odlotu { get; set; }

            public override string ToString()
            {
                return String.Format("{0} {1} {2} {3} {4}", nazwa_samolotu, nazwa_lotniska, nazwa_trasy, dystans, data_odlotu);
            }
        }

        private void MoveData(object sender, MouseButtonEventArgs e)
        {
            
            if(gridLoty.SelectedItem is not null)
            {
                var gridLoty_ = gridLoty.SelectedItem.ToString().Split();
                lotniskoTxt.Content = gridLoty_[1];
                trasaTxt.Content = gridLoty_[2];
                dystatsTxt.Content = gridLoty_[3];
                dataWylotuTxt.Content = gridLoty_[4];
                cenaTxt.Content = "Cena za podróż: "+(Int32.Parse(gridLoty_[3])*kursZaKm);
            }
        }

        private void TicketGridCollapse(object sender, RoutedEventArgs e)
        {
            DataGridRow dataRow = (DataGridRow)sender;
            if (dataRow.IsSelected)
            {
                ticketGrid.Visibility = Visibility.Visible;
            }
            else
            {
                ticketGrid.Visibility = Visibility.Collapsed;
            }
        }
    }
}
