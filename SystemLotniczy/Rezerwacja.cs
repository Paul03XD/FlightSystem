using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Rezerwacje")]
    public class Rezerwacja
    {
        public int? id { get; set; }
        [Column("id_klienta")]
        public int id_klienta { get; set; }
        public int id_lotu { get; set; }
        public double cena { get; set; }

        public Rezerwacja()
        {

        }
        public Rezerwacja(int id_klienta_, int id_lotu_, double cena_)
        {
            id_klienta = id_klienta_;
            id_lotu = id_lotu_;
            cena = cena_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", id_klienta, id_lotu, cena);
        }
    }
}
