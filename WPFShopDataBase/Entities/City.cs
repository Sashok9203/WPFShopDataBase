using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFShopDataBase.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public  Country Country {get;set;}

        public ICollection<Shop> Shops { get; set; }  = new HashSet<Shop>();
    }
}
