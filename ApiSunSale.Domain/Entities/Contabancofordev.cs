namespace ApiSunSale.Domain.Entities
{
    public class Contabancofordev : BaseEntity
    {
        public long Id { get; set; }
        public string Contacorrente { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
