namespace ApiSunSale.Domain.Entities
{
    public class Tipoprovaassociado : BaseEntity
    {
        public long Id { get; set; }
        public int Idtipo { get; set; }
        public int Idprova { get; set; }
    }
}
