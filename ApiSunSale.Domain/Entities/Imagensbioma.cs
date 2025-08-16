namespace ApiSunSale.Domain.Entities
{
    public class Imagensbioma : BaseEntity
    {
        public long Id { get; set; }
        public long Idbioma { get; set; }
        public string Link { get; set; }
    }
}
