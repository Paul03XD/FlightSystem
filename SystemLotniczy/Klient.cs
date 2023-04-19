using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemLotniczy
{
    [Table("Klienci")]
    public class Klient
    {
        public int? id { get; set; }
        [Column("username")]
        public string username { get; set; }
        public string password { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek { get; set; }
        public string adres { get; set; }
        public int nr_tel { get; set; }
        public string email { get; set; }
        public Nullable<int> id_firmy { get; set; }
        //public string nazwa_firmy { get; set; }

        public Klient()
        {

        }
        public Klient(string username_, string password_, string imie_, string nazwisko_, int wiek_, string adres_, int nr_tel_, string email_)
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
        public Klient(string username_, string password_, string imie_, string nazwisko_, int wiek_, string adres_, int nr_tel_, string email_, int id_firmy_)
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
        public override string ToString()
        {
            List<Firma> firmaList;
            string nazwa_firmy = "";
            using (var _dbContext = new ApplicationDbContextFactory().CreateDbContext())
            {
                firmaList = _dbContext.Firmy.ToList();
                if (firmaList is not null)
                {
                    Console.WriteLine("Tabela firmy git");
                }
                else
                {
                    MessageBox.Show("Pusta tabela");
                }
                for(int i = 0; i < firmaList.Count; i++)
                {
                    if(firmaList[i].id == id_firmy)
                    {
                        nazwa_firmy = firmaList[i].nazwa;
                    }
                }
            }
            return String.Format("{0} {1} {2} {3} {4} {5} {6}", imie, nazwisko, wiek, adres, nr_tel, email); 
        }
    }
}
