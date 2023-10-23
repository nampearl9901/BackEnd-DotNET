using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Data
{
    [Table("Categorys")]
    public class Categorys
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }

        // Thuộc tính này sẽ chứa danh sách các sản phẩm thuộc danh mục này
        public List<Products> Products { get; set; }
    }
}
