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
using SystemLotniczy.Forms;
using SystemLotniczy.Views;

namespace SystemLotniczy.Widoki
{
    /// <summary>
    /// Interaction logic for FirmaView.xaml
    /// </summary>
    public class RezerwacjeFirmy
    {
        public string klient { get; set; }
        public string nazwa_lotniska { get; set; }
        public string nazwa_trasy { get; set; }
        public int dystans { get; set; }
        public DateTime data_odlotu { get; set; }
        public string nazwa_samolotu { get; set; }
        public double cena { get; set; }
    }
    public partial class FirmaView : Window
    {
        Firma firma1 = new Firma();
        List<Klient> pracownicy = new List<Klient>();
        List<RezerwacjeFirmy> rezerwacje = new List<RezerwacjeFirmy>();
        public FirmaView(Firma firma1_)
        {
            InitializeComponent();
            firma1 = firma1_;
            zalogowanyJako.Content = "Zalogowany jako " + firma1.login;
            gridPracownicy.SelectionMode = DataGridSelectionMode.Single;
            gridRezerwacje.SelectionMode = DataGridSelectionMode.Single;
            LoadWorkers();
        }
        public void LoadReserwations()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                rezerwacje.Clear();
                if(gridRezerwacje.Items != null)
                {
                    gridRezerwacje.ItemsSource = null;
                }
                foreach (var pracownik in pracownicy)
                {
                    foreach (var rezerwacjeRow in Listy.rezerwacjeList)
                    {
                        string klient_ = "", lotnisko = "", trasa = "", samolot = "";
                        int dystans_ = 0;
                        DateTime data_wylotu = new DateTime();
                        if (rezerwacjeRow.id_klienta == pracownik.id)
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
                            rezerwacje.Add(new RezerwacjeFirmy() { klient = klient_, nazwa_lotniska = lotnisko, nazwa_trasy = trasa, dystans = dystans_, data_odlotu = data_wylotu, nazwa_samolotu = samolot, cena = rezerwacjeRow.cena });
                        }
                    }
                }



                gridRezerwacje.ItemsSource = rezerwacje;
            }
        }
        public void LoadWorkers()
        {
            pracownicy.Clear();
            if (gridPracownicy.Items != null)
            {
                gridPracownicy.ItemsSource = null;
            }
            foreach (var worker in Listy.klienciList)
            {
                if(worker.id_firmy == firma1.id)
                {
                    pracownicy.Add(worker);
                }
            }
            gridPracownicy.ItemsSource = pracownicy;
            LoadReserwations();
        }
        private void Dodaj_Pracownika(object sender, RoutedEventArgs e)
        {
            DodajPracownika dodajPracownika1 = new DodajPracownika(firma1);
            dodajPracownika1.Show();
            
            dodajPracownika1.Closed += (sender, e) => LoadWorkers();
        }
        private void Kup_Bilet(object sender, RoutedEventArgs e)
        {
            KupBiletFirmy biletView = new KupBiletFirmy(pracownicy);
            biletView.Show();

            biletView.Closed += (sender, e) => LoadReserwations();
        }
        private void Wyloguj(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
