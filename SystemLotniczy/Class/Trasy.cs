using System.ComponentModel.DataAnnotations.Schema;

namespace SystemLotniczy
{
    [Table("Trasy")]
    public class Trasy
    {
        public int? id { get; set; }
        [Column("nazwa_miasta")]
        public string nazwa_miasta { get; set; }
        public string adres { get; set; }
        public Trasy() { }
    }
}