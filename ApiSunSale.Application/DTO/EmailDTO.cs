namespace ApiSunSale.Application.DTO
{
    public class EmailDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Destinatario { get; set; }
        public string Assunto { get; set; }
        public string Texto { get; set; }
        public string Status { get; set; }
        public string Observacao { get; set; }
    }
}
