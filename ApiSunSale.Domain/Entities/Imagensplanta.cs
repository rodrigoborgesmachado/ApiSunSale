namespace ApiSunSale.Domain.Entities
{
    public class Imagensplanta : BaseEntity
    {
        public long Id { get; set; }
        public long Idplanta { get; set; }
        public string Link { get; set; }
    }
}
