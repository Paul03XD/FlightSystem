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
        public int id_samolotu { get; set; }
        public int id_trasy { get; set; }
        public DateTime data_odlotu { get; set; }

        public Lot()
        {

        }
        public Lot(int id_samolotu_, int id_trasy_, DateTime data_odlotu_)
        {
            id_samolotu = id_samolotu_;
            id_trasy = id_trasy_;
            data_odlotu = data_odlotu_;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2}", id_samolotu, id_trasy, data_odlotu);
        }
    }
}
