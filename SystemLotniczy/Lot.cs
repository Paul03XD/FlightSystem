using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    class Lot
    {
        public string klient;
        public string nazwa_samolotu;
        public string miejsce_docelowe;
        public DateTime data_odlotu;
        public double cena;

        public Lot(string klient_, string nazwa_samolotu_, string miejsce_docelowe_, DateTime data_odlotu_, double cena_)
        {
            klient = klient_;
            nazwa_samolotu = nazwa_samolotu_;
            miejsce_docelowe = miejsce_docelowe_;
            data_odlotu = data_odlotu_;
            cena = cena_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", klient, nazwa_samolotu, miejsce_docelowe, data_odlotu, cena);
        }
    }
}
