namespace ApiSunSale.Domain.Entities
{
    public class Postagem : BaseEntity
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Descricaoen { get; set; }
        public int Tipopostagem { get; set; }
        public string Capa { get; set; }
        public int Curtidas { get; set; }
    }
}
