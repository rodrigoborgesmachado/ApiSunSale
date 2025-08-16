namespace ApiSunSale.Application.DTO
{
    public class ContabancofordevDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Contacorrente { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
