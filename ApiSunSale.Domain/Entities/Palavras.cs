namespace ApiSunSale.Domain.Entities
{
    public class Palavras : BaseEntity
    {
        public long Id { get; set; }
        public long Nivel { get; set; }
        public string Palavra { get; set; }
    }
}
