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
        public MainWindow()
        {
            InitializeComponent();
            Firma firma1 = new Firma("Mareczek");
            firma1.DodajPracownika("Paweł","Jabłoński",18);
            firma1.DodajPracownika("Kamil", "Nagórski", 16);


            listaP.ItemsSource = firma1.pracownicy;
        }
    }
}
