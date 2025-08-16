namespace ApiSunSale.Domain.Entities
{
    public class Usuarioconcursando 
    {
        public long Codigo { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
        public string Admin { get; set; }
        public string Bot { get; set; }
    }
}
