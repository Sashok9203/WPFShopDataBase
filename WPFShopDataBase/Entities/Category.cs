using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPFShopDataBase.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
