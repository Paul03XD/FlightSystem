using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Trasy")]
    public class Trasa
    {
        public int? id { get; set; }
        [Column("miejsce_docelowe")]
        public string nazwa { get; set; }
        public Trasa()
        {

        }

        public Trasa(string nazwa_, int l_miejsc_)
        {
            nazwa = nazwa_;
        }
        public override string ToString()
        {
            return String.Format("{0}", nazwa);
        }
    }
}
