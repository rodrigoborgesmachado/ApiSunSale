namespace ApiSunSale.Domain.Entities
{
    public class Anexoresposta : BaseEntity
    {
        public long Id { get; set; }
        public long Idresposta { get; set; }
        public string Link { get; set; }
        public Respostasquestoes? Respostasquestoes { get; set; }
    }
}
