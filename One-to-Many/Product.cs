using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstEF.Models
{
    public class Product
    {
        [Key]
        public int Proid { get; set; }
        public string prodName { get; set; }
        public decimal price { get; set; }
        public int catId { get; set; }
        [ForeignKey("catId")]

        // set Navigation Property

        public Category Category { get; set; }
    }
}
