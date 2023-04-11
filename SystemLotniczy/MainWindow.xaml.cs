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
        //List<Klient> klienciList;
        //List<Samolot> samolotyList;
        //List<Lot> lotyList;
        public MainWindow()
        {
            InitializeComponent();
            OpenDB();
        }

        public void OpenDB()
        {
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                List<Klient> klienciTb = _dbContext.Klienci.ToList();
                if (klienciTb is not null)
                {
                    foreach (var klienciRow in klienciTb)
                    {
                        //klienciList.Add(new Klient(klienciRow.imie,klienciRow.nazwisko,klienciRow.wiek,klienciRow.adres,klienciRow.nr_tel,klienciRow.email));
                    }
                    Console.WriteLine("Tabela klienci git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridKlienci.ItemsSource = klienciTb;


                List<Samolot> samolotyTb = _dbContext.Samoloty.ToList();
                if (samolotyTb is not null)
                {
                    foreach (var SamolotyRow in samolotyTb)
                    {
                    }
                    Console.WriteLine("Tabela samoloty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridSamoloty.ItemsSource = samolotyTb;


                List<Lot> lotyTb = _dbContext.Loty.ToList();
                if (lotyTb is not null)
                {
                    foreach (var lotyRow in lotyTb)
                    {
                    }
                    Console.WriteLine("Tabela loty git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                gridLoty.ItemsSource = lotyTb;
            }
        }
    }
}
