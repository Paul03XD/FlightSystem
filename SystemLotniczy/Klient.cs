using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    class Klient
    {
        string imie;
        string nazwisko;
        int wiek;

        public Klient(string imie_, string nazwisko_, int wiek_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            wiek = wiek_;
        }
        public override string ToString() 
        { 
            return String.Format(imie+" "+nazwisko+" "+wiek.ToString()); 
        }
    }
}
