namespace ApiSunSale.Domain.Entities
{
    public class Email : BaseEntity
    {
        public long Id { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
    }
}
