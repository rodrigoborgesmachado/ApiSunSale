namespace ApiSunSale.Domain.Entities
{
    public class Anexoresposta : BaseEntity
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public byte[] Anexo { get; set; }

        public Questoes Questao { get; set; }
    }
}
