namespace ApiSunSale.Domain.Entities
{
    public class Despesas 
    {
        public long Codigo { get; set; }
        public DateTime Datainsercao { get; set; }
        public string Datadespesa { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Valor { get; set; }
        public string Conta { get; set; }
    }
}
