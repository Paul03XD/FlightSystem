using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SystemLotniczy
{
    [Table("Loty")]
    public class Lot : IDataErrorInfo
    {
        public int? id { get; set; }
        public int id_samolotu { get; set; }
        public int id_lotniska { get; set; }
        public int id_trasy { get; set; }
        public int dystans { get; set; }
        public DateTime data_odlotu { get; set; }

        public Lot()
        {
            data_odlotu = DateTime.Now;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4}", id_samolotu, id_lotniska, id_trasy, dystans, data_odlotu);
        }
        public string Error
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public string this[string pole]
        {
            get
            {
                switch (pole)
                {
                    case "dystans":
                        if (dystans <= 0)
                            return "Wprowadź dystans.";
                        break;
                }
                return "";
            }
        }
    }
}
