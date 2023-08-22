using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WPFShopDataBase.Entities
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }


        public ICollection<Worker> Workers { get; set; }  =new HashSet<Worker>();
    }
}
