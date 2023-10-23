using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Data
{
    [Table("Products")]
        public class Products
        {
            [Key]
            public int ProductId { get; set; }
            [MaxLength(100)]
            public string ProductName { get; set; }
            public string? ProductDescription { get; set; }
            [Range(0, double.MaxValue)]
            public double Price { get; set; }
            public string ImageUrl { get; set; }
            [ Range(0, 100)]
            public int Quantity { get; set; }

            public int CategoryId { get; set; } // Khóa ngoại

            public Categorys Category { get; set; }
        }
}
