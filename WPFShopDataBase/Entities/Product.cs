using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFShopDataBase.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Discount { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public  Category? Category { get; set; }

        public int Quantity { get; set; }

        public bool IsLnStock { get; set; }

        public ICollection<Shop> Shops { get; set; } = new HashSet<Shop>();
    }
}
