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

namespace SystemLotniczy.Dodawanie
{
    /// <summary>
    /// Interaction logic for RejestracjaFirmy.xaml
    /// </summary>
    public partial class RejestracjaFirmy : Window
    {
        Firma firma1 = new Firma();
        public RejestracjaFirmy()
        {
            InitializeComponent();
            this.DataContext = firma1;
        }
        private void Zarejestruj(object sender, RoutedEventArgs e)
        {
            if (Walidacja.IsValid(this))
            {
                using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
                {
                    Listy.firmaList.Add(firma1);
                    _dbContext.Firmy.UpdateRange(Listy.firmaList);
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
