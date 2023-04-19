using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Firmy")]
    public class Firma
    {
        public List<Klient> pracownicy = new List<Klient>();
        public int? id { get; set; }
        [Column("nazwa")]
        public string nazwa { get; set; }
        public string placowka { get; set; }

        public Firma()
        {

        }
        public Firma(string nazwa_, string placowka_)
        {
            nazwa = nazwa_;
            placowka = placowka_;
        }

        public void DodajPracownika(string username_, string password_, string imie, string nazwisko, int wiek, string adres, int nr_tel, string email)
        {
            pracownicy.Add(new Klient(username_, password_, imie, nazwisko, wiek, adres, nr_tel, email));
        }

    }
}
