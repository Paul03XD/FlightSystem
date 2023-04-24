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
        List<Rezerwacja> rezerwacjeList;
        List<Trasa> trasyList;
        List<ItemDisplay> lotyView = new List<ItemDisplay>();
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



                lotyList = _dbContext.Loty.ToList();
                if (lotyList is not null)
                {
                    foreach (var lotyRow in lotyList)
                    {
                        string trasa = "", samolot = "";
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
                        lotyView.Add(new ItemDisplay() { nazwa_trasy = trasa, nazwa_samolotu = samolot, data_odlotu = lotyRow.data_odlotu });
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
        private void dateZmien(object sender, SelectionChangedEventArgs e)
        {
            CollectionView widok = (CollectionView)CollectionViewSource.GetDefaultView(gridLoty.ItemsSource);
            widok.Filter = FiltrUzytkownika2;

        }
        private bool FiltrUzytkownika2(object item)
        {
            if (String.IsNullOrEmpty(trasyTxtBox.Text))
                return true;
            else
                return ((item as ItemDisplay).data_odlotu.ToString().IndexOf(data_odlotuDP.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }
        public class ItemDisplay
        {
            public string nazwa_samolotu { get; set; }
            public string nazwa_trasy { get; set; }
            public DateTime data_odlotu { get; set; }

            public override string ToString()
            {
                return String.Format("{0} {1} {2}", nazwa_samolotu, nazwa_trasy, data_odlotu);
            }
        }

        private void MoveData(object sender, MouseButtonEventArgs e)
        {
            if(gridLoty.SelectedItem is not null)
            {
                trasyTxtBox.Text = gridLoty.SelectedItem.ToString().Split(' ')[1];
                data_odlotuDP.Text = gridLoty.SelectedItem.ToString().Split(' ')[2];
            }
        }
    }
}
