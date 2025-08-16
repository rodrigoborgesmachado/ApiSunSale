namespace ApiSunSale.Domain.Entities
{
    public class Recuperasenha : BaseEntity
    {
        public long Id { get; set; }
        public string Guid { get; set; }
        public long Userid { get; set; }
        public string Validated { get; set; }
    }
}
