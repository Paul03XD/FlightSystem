using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Samoloty")]
    public class Samolot
    {
        public int? id { get; set; }
        [Column("nazwa")]
        public string nazwa { get; set; }
        public int l_miejsc { get; set; }
        public Samolot()
        {

        }

        public Samolot(string nazwa_, int l_miejsc_)
        {
            nazwa = nazwa_;
            l_miejsc = l_miejsc_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", nazwa, l_miejsc);
        }
    }
}
