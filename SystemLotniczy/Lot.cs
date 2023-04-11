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
        public int? id { get; set; }
        public string miejsce_docelowe { get; set; }
        public DateTime data_odlotu { get; set; }

        public Lot()
        {

        }
        public Lot(string miejsce_docelowe_, DateTime data_odlotu_)
        {
            miejsce_docelowe = miejsce_docelowe_;
            data_odlotu = data_odlotu_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", miejsce_docelowe, data_odlotu);
        }
    }
}
