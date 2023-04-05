using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Loty.xaml
    /// </summary>
    public partial class Loty : Window
    {
        List<Lot> loty = new List<Lot>();
        public Loty()
        {
            InitializeComponent();
            gridLoty.ItemsSource = loty;
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext()) 
            { 
                var lotyList = _dbContext.Loty.ToList(); 
                if (lotyList is not null) 
                { 
                    MessageBox.Show("Baza nie jest pusta"); 
                    lotyList.First().imie = "Kasia"; 
                } 
                else 
                { 
                    MessageBox.Show("Pusta baza"); 
                } 
                _dbContext.Loty.UpdateRange(lotyList); 
                _dbContext.SaveChanges(); 
            }
            loty.Add(new Lot("Paweł", "Jabłoński", "LOT 1", "London", new DateTime(2023,05,02), 233.33));
            loty.Add(new Lot("Kamil", "Nagórski", "RYANAIR", "New York", new DateTime(2023, 07, 22), 173.33));
            loty.Add(new Lot("Marek","Kopczewski", "McDonnell", "Warszawa", new DateTime(2025, 03, 12), 473.33));
        }
    }
}
