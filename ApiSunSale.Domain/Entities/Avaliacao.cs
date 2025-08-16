namespace ApiSunSale.Domain.Entities
{
    public class Avaliacao : BaseEntity
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Orientação { get; set; }
        public string Ispublic { get; set; }
        public string Key { get; set; }
    }
}
