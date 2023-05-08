using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace SystemLotniczy
{
    [Table("Klienci")]
    public class Klient : IDataErrorInfo 
    {
        public int? id { get; set; }
        [Column("username")]
        public string username { get; set; }
        public string password { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek { get; set; }
        public string adres { get; set; }
        public string nr_tel { get; set; }
        public string email { get; set; }
        public Nullable<int> id_firmy { get; set; }
        public string Error
        {
            get{
                throw new NotImplementedException();
            }
        }
        public string this[string pole]
        { 
            get
            {
                Regex regUsername = new Regex(@"^([\w0-9]){5,20}$");
                Regex regPassword = new Regex(@"^[\w_.-]{5,20}$");
                Regex regName = new Regex(@"^[\w]*$");
                Regex regSurname = new Regex(@"^[\w]*$");
                Regex regPhoneNumber = new Regex(@"^\+(?:[0-9]•?){6,14}[0-9]$");
                Regex regPhoneNumber2 = new Regex(@"^[0-9]{9,9}$");
                Regex regEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                switch(pole)
                {
                    case "username":
                        foreach (var user in Listy.klienciList)
                        {
                            if (username == user.username)
                            {
                                return "Nazwa użytkownika już istnieje. Wprowadź inną.";
                            }
                        }
                        if (String.IsNullOrEmpty(username))
                            return "Wprowadź nazwę użytkownika";
                        else if (!regUsername.IsMatch(username))
                            return "Nazwa użytkownika musi mieć 5-20 znaków. Dozwolone znaki specjalne: _";
                        break;
                    case "password":
                        if (String.IsNullOrEmpty(password))
                            return "Wprowadź hasło";
                        else if (!regPassword.IsMatch(password))
                            return "Hasło musi mieć 5-20 znaków.";
                        break;
                    case "imie":
                        if (String.IsNullOrEmpty(imie))
                            return "Wprowadź imię.";
                        else if (!regName.IsMatch(imie))
                            return "Wprowadź poprawnie imię.";
                        break;
                    case "nazwisko":
                        if (String.IsNullOrEmpty(nazwisko))
                            return "Wprowadź nazwisko.";
                        else if (!regSurname.IsMatch(nazwisko))
                            return "Wprowadź poprawnie nazwisko.";
                        break;
                    case "wiek":
                        if (wiek < 18)
                            return "Musisz mieć przynajmniej 18 lat.";
                        break;
                    case "adres":
                        if (String.IsNullOrEmpty(adres))
                            return "Wprowadź adres.";
                        break;
                    case "nr_tel":
                        if (String.IsNullOrEmpty(nr_tel))
                            return "Wprowadź numer telefonu.";
                        else if (!regPhoneNumber.IsMatch(nr_tel))
                            if(!regPhoneNumber2.IsMatch(nr_tel))
                                return "Numer telefonu jest niepoprawny.";

                        break;
                    case "email":
                        if (String.IsNullOrEmpty(email))
                            return "Wprowadź adres email.";
                        else if (!regEmail.IsMatch(email))
                            return "Wprowadź prawidłowy adres email.";
                        break;

                }
                return "";
            }
        }
        public Klient()
        {

        }
        public Klient(string username_, string password_, string imie_, string nazwisko_, int wiek_, string adres_, string nr_tel_, string email_)
        {
            username = username_;
            password = password_;
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            adres = adres_;
            nr_tel = nr_tel_;
            email = email_;
            id_firmy = null;
        }
        public Klient(string username_, string password_, string imie_, string nazwisko_, int wiek_, string adres_, string nr_tel_, string email_, int id_firmy_)
        {
            username = username_;
            password = password_;
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            adres = adres_;
            nr_tel = nr_tel_;
            email = email_;
            id_firmy = id_firmy_;
        }
    }
}
