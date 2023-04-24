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
        public int id_lotniska { get; set; }
        public int id_trasy { get; set; }
        public int dystans { get; set; }
        public DateTime data_odlotu { get; set; }

        public Lot()
        {

        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", id_samolotu, id_lotniska, dystans, id_trasy, data_odlotu);
        }
    }
}
