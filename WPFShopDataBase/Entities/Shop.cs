using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFShopDataBase.Entities
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        [MaxLength(256)]
        public string Address { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public  City City { get; set; }

        public int? ParkingArea { get; set; }

        public ICollection<Product> Products { get; set; }  = new HashSet<Product>();
        public ICollection<Worker> Workers { get; set; } = new HashSet<Worker>();
    }
}
