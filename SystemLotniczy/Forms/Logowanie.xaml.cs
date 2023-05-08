using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
using SystemLotniczy.Dodawanie;
using SystemLotniczy.Widoki;

namespace SystemLotniczy
{
    /// <summary>
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public Logowanie()
        {
            InitializeComponent();

        }
        private void ZalogujFirma(object sender, RoutedEventArgs e)
        {
            string login;
            string password;
            if (loginFirmyTxtBox.Text != "")
            {
                login = loginFirmyTxtBox.Text;
                if (!String.IsNullOrEmpty(passFirmyTxtBox.Password))
                {
                    password = passFirmyTxtBox.Password;
                    for (int i = 0; i < Listy.firmaList.Count; i++)
                    {
                        if (Listy.firmaList[i].login == login && Listy.firmaList[i].password == password)
                        {
                            FirmaView firmaView1 = new FirmaView(Listy.firmaList[i]);
                            firmaView1.Show();
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
        private void Zaloguj(object sender, RoutedEventArgs e)
        {
            string login;
            string password;
            if (loginTxtBox.Text != "")
            {
                login = loginTxtBox.Text;
                if (!String.IsNullOrEmpty(passTxtBox.Password))
                {
                    password = passTxtBox.Password;
                    for (int i = 0; i < Listy.klienciList.Count; i++)
                    {
                        if (Listy.klienciList[i].username == login && Listy.klienciList[i].password == password)
                        {
                            UserView userView1 = new UserView(Listy.klienciList[i]);
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

        private void Zarejstruj(object sender, RoutedEventArgs e)
        {
            Rejestracja rejestracja1 = new Rejestracja();
            rejestracja1.Show();
        }
        private void ZarejstrujFirme(object sender, RoutedEventArgs e)
        {
            RejestracjaFirmy rejestracjaFirmy1 = new RejestracjaFirmy();
            rejestracjaFirmy1.Show();
        }
    }
}
