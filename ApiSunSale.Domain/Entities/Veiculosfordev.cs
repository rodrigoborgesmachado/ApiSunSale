namespace ApiSunSale.Domain.Entities
{
    public class Veiculosfordev : BaseEntity
    {
        public long Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Renavam { get; set; }
        public string Placaveiculo { get; set; }
        public string Cor { get; set; }
    }
}
