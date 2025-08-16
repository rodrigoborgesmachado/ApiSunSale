namespace ApiSunSale.Domain.Entities
{
    public class Respostasusuarios : BaseEntity
    {
        public long Id { get; set; }
        public long Idusuario { get; set; }
        public long Idresposta { get; set; }
        public long Idquestao { get; set; }
    }
}
