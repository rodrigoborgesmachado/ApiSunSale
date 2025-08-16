namespace ApiSunSale.Domain.Entities
{
    public class Receitas 
    {
        public long Codigo { get; set; }
        public DateTime Dataregistro { get; set; }
        public string Datatransacao { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Valor { get; set; }
        public string Conta { get; set; }
    }
}
