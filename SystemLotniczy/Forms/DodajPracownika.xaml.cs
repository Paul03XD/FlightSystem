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

namespace SystemLotniczy.Forms
{
    /// <summary>
    /// Interaction logic for DodajPracownika.xaml
    /// </summary>
    public partial class DodajPracownika : Window
    {
        Klient klient1 = new Klient();
        Firma firma1 = new Firma();
        public DodajPracownika(Firma firma1_)
        {
            firma1 = firma1_;
            InitializeComponent();
            this.DataContext = klient1;
        }
        private void Rejestruj(object sender, RoutedEventArgs e)
        {
            if (Walidacja.IsValid(this))
            {
                using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
                {
                    klient1.id_firmy = firma1.id;
                    Listy.klienciList.Add(klient1);
                    _dbContext.Klienci.UpdateRange(Listy.klienciList);
                    _dbContext.SaveChanges();
                }
                Close();
            }
            else
            {
                MessageBox.Show("Wprowadź wszystkie dane poprawnie");
            }
        }
    }
}
