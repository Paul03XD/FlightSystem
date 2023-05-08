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
    public static class Walidacja
    {
        public static bool IsValid(DependencyObject obj)
        {
            return !Validation.GetHasError(obj) &&
            LogicalTreeHelper.GetChildren(obj)
            .OfType<DependencyObject>()
            .All(IsValid);
        }
    }
    public static class Listy
    {
        public static double kursZaKm = 1.28;
        public static List<Klient> klienciList = new List<Klient>();
        public static List<Firma> firmaList = new List<Firma>();
        public static List<Samolot> samolotyList = new List<Samolot>();
        public static List<Lot> lotyList = new List<Lot>();
        public static List<Rezerwacja> rezerwacjeList = new List<Rezerwacja>();
        public static List<Lotnisko> lotniskaList = new List<Lotnisko>();
        public static List<Trasy> trasyList = new List<Trasy>();
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OpenAndViewDB();

        }

        public void OpenAndViewDB()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                Listy.firmaList = _dbContext.Firmy.ToList();
                Listy.klienciList = _dbContext.Klienci.ToList();
                Listy.samolotyList = _dbContext.Samoloty.ToList();
                Listy.lotniskaList = _dbContext.Lotniska.ToList();
                Listy.lotyList = _dbContext.Loty.ToList();
                Listy.rezerwacjeList = _dbContext.Rezerwacje.ToList();
                Listy.trasyList = _dbContext.Trasy.ToList();
            }
        }
            private void Zaloguj(object sender, RoutedEventArgs e)
        {
            Logowanie loguj1 = new Logowanie();
            loguj1.Show();
        }
        private void ZalogujAdmin(object sender, RoutedEventArgs e)
        {
            AdminView admin1 = new AdminView();
            admin1.Show();
        }
        private void Zarejestruj(object sender, RoutedEventArgs e)
        {
            string username, password, imie, nazwisko, wiek, adres, nr_tel, email, id_firmy;
            
        }


        private void DodajLot(object sender, RoutedEventArgs e)
        {
            
     
        }
    }
}
