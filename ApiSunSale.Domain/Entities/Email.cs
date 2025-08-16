namespace ApiSunSale.Domain.Entities
{
    public class Email 
    {
        public long Codigo { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public byte[] Texto { get; set; }
        public DateTime Dataenvio { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
    }
}
