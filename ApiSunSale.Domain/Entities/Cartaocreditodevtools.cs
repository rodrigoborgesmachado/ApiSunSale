namespace ApiSunSale.Domain.Entities
{
    public class Cartaocreditodevtools : BaseEntity
    {
        public long Id { get; set; }
        public string Numerocartao { get; set; }
        public string Datavalidade { get; set; }
        public string Codigoseguranca { get; set; }
        public string Brand { get; set; }
    }
}
