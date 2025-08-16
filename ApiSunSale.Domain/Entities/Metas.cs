namespace ApiSunSale.Domain.Entities
{
    public class Metas : BaseEntity
    {
        public long Id { get; set; }
        public string Meta { get; set; }
        public string Email { get; set; }
        public DateTime Dataobjetivo { get; set; }
    }
}
