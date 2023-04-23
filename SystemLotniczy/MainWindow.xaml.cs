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
        List<Klient> klienciList;
        List<Firma> firmaList;
        List<Samolot> samolotyList;
        List<Lot> lotyList;
        List<Rezerwacja> rezerwacjeList;
        public MainWindow()
        {
            InitializeComponent();
            OpenAndViewDB();

        }

        private void Zaloguj(object sender, RoutedEventArgs e)
        {
            Logowanie loguj1 = new Logowanie(klienciList, firmaList);
            loguj1.Show();
        }
        private void Zarejestruj(object sender, RoutedEventArgs e)
        {
            string username, password, imie, nazwisko, wiek, adres, nr_tel, email, id_firmy;
            
        }


        private void DodajLot(object sender, RoutedEventArgs e)
        {
            
        }
        public void OpenAndViewDB()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                firmaList = _dbContext.Firmy.ToList();
                if (firmaList is not null)
                {
                    Console.WriteLine("Tabela firmy git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridFirmy.ItemsSource = firmaList;

                klienciList = _dbContext.Klienci.ToList();
                if (klienciList is not null)
                {
                    Console.WriteLine("Tabela klienci git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridKlienci.ItemsSource = klienciList;


                samolotyList = _dbContext.Samoloty.ToList();
                if (samolotyList is not null)
                {
                    Console.WriteLine("Tabela samoloty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridSamoloty.ItemsSource = samolotyList;


                lotyList = _dbContext.Loty.ToList();
                if (lotyList is not null)
                {
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridLoty.ItemsSource = lotyList;


                rezerwacjeList = _dbContext.Rezerwacje.ToList();
                if (rezerwacjeList is not null)
                {
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridRezerwacje.ItemsSource = rezerwacjeList;

                List<Trasa> trasyList = _dbContext.Trasy.ToList();
                if (trasyList is not null)
                {
                    foreach(var trasyRow in trasyList)
                    {
                        trasyCmbBox.Items.Add(trasyRow.nazwa);
                    }
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }

            }
        }
    }
}
