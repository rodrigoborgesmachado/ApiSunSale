using System.ComponentModel.DataAnnotations;

namespace ApiSunSale.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public byte IsActive { get; set; }
        public byte IsDeleted { get; set; }
    }
}
