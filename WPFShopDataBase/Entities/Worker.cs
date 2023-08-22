using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFShopDataBase.Entities
{
    public class Worker
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(56)]
        public string Name { get; set; }

        [MaxLength(56)]
        public string Surname { get; set; }

        public decimal Salary { get; set; }

        [MaxLength(56)]
        public string Email { get; set; }

        [MaxLength(18)]
        public string PhoneNumber { get; set; }

        [ForeignKey("Position")]
        public int PositionId { get; set; }

        public Position Position { get; set; }

        [ForeignKey("Shop")]
        public int ShopId { get; set; }

        public Shop Shop { get; set; }

        [NotMapped]
        public string FullName => Name + " " + Surname;
    }
}
