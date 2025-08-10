using System.ComponentModel.DataAnnotations;

namespace CodeFirstEF.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        //Navigation Property

        public IList<Product> Products { get; set; }

    }
}
