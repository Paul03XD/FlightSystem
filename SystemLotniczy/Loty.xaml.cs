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
        List<Klient> klienci = new List<Klient>();
        public Loty()
        {
            InitializeComponent();
            gridLoty.ItemsSource = klienci;
            klienci.Add(new Klient("Paweł", "Jabłoński", 18));
            klienci.Add(new Klient("Kamil", "Nagórski", 16));
            klienci.Add(new Klient("Daniel", "Filipowicz", 17));
            klienci.Add(new Klient("Krystian", "Jaworowski", 18));
        }
    }
}
