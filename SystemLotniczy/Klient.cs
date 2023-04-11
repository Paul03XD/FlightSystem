using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Klienci")]
    public class Klient
    {
        public int? id { get; set; }
        [Column("imie")]
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int wiek { get; set; }
        public string adres { get; set; }
        public int nr_tel { get; set; }
        public string email { get; set; }

        public Klient()
        {

        }
        public Klient(string imie_, string nazwisko_, int wiek_, string adres_, int nr_tel_, string email_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            adres = adres_;
            nr_tel = nr_tel_;
            email = email_;
        }
        public override string ToString() 
        { 
            return String.Format("{0} {1} {2} {3} {4} {5}", imie, nazwisko, wiek, adres, nr_tel, email); 
        }
    }
}
