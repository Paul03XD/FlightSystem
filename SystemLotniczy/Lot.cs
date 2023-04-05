using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Loty")]
    public class Lot
    {
        public int? id_lotu { get; set; }
        [Column("imie")]
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string nazwa_samolotu { get; set; }
        public string miejsce_docelowe { get; set; }
        public DateTime data_odlotu { get; set; }
        public double cena { get; set; }

        public Lot()
        {

        }
        public Lot(string imie_, string nazwisko_, string nazwa_samolotu_, string miejsce_docelowe_, DateTime data_odlotu_, double cena_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            nazwa_samolotu = nazwa_samolotu_;
            miejsce_docelowe = miejsce_docelowe_;
            data_odlotu = data_odlotu_;
            cena = cena_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", imie, nazwisko, nazwa_samolotu, miejsce_docelowe, data_odlotu, cena);
        }
    }
}
