using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    class Klient
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string data { get; set; }
        public string miejsce { get; set; }
        int wiek;

        public Klient(string imie_, string nazwisko_, int wiek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
            data = "3.04.2023";
            miejsce = "Londyn";
        }
        public override string ToString() 
        { 
            return String.Format("{0} {1} {2} {3}", imie, nazwisko, data, miejsce); 
        }
    }
}
