namespace ApiSunSale.Domain.Entities
{
    public class Anexosquestoes : BaseEntity
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public string Link { get; set; }
    }
}
