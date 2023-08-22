using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPFShopDataBase.Entities
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}
