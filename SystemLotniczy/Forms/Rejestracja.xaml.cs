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

namespace SystemLotniczy
{
    /// <summary>
    /// Interaction logic for Rejestracja.xaml
    /// </summary>
    public partial class Rejestracja : Window
    {
        Klient klient1 = new Klient();
        public Rejestracja()
        {
            InitializeComponent();
            this.DataContext = klient1;
            foreach (var firma in Listy.firmaList)
            {
                firmaCmbBox.Items.Add(firma.nazwa);
            }
        }

        private void Rejestruj(object sender, RoutedEventArgs e)
        {
            if (Walidacja.IsValid(this))
            {
                using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
                {
                    if ((bool)firmaCheckBox.IsChecked)
                    {
                        if(!String.IsNullOrEmpty(firmaCmbBox.Text))
                        {
                            klient1.id_firmy = firmaCmbBox.SelectedIndex+1;
                        }
                    }
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

        private void firmaActive(object sender, RoutedEventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            if ((bool)chkBox.IsChecked)
            {
                firmaCmbBox.IsEnabled = true;
            }
            else
            {
                firmaCmbBox.IsEnabled = false;
            }
        }
    }
}
