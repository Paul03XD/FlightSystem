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
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        List<Klient> klienciList;
        public Logowanie(List<Klient> klienciList_, List<Firma> firmaList)
        {
            InitializeComponent();
            klienciList = klienciList_;
            foreach(Firma firma in firmaList)
            {
                firmaCmbBox.Items.Add(firma.nazwa);
            }
        }
        private void Zaloguj(object sender, RoutedEventArgs e)
        {
            string login;
            string password;
            if (loginTxtBox.Text != "")
            {
                login = loginTxtBox.Text;
                if (passTxtBox.Text != "")
                {
                    password = passTxtBox.Text;
                    for (int i = 0; i < klienciList.Count; i++)
                    {
                        if (klienciList[i].username == login && klienciList[i].password == password)
                        {
                            UserView userView1 = new UserView(klienciList[i]);
                            userView1.Show();
                            Close();
                            return;
                        }
                    }
                    MessageBox.Show("Niepoprawny login lub hasło");
                }
                else
                {
                    MessageBox.Show("Wprowadź hasło");
                }
            }
            else
            {
                MessageBox.Show("Wprowadź login");
            }
        }

        private void firmaActive(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if ((bool)checkBox.IsChecked)
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
