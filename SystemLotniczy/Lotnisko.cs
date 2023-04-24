using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemLotniczy
{
    [Table("Lotniska")]
    public class Lotnisko
    {
        public int? id { get; set; }
        [Column("nazwa_lotniska")]
        public string nazwa_lotniska { get; set; }
        public Lotnisko()
        {

        }
    }
}
