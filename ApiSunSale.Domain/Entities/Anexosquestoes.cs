namespace ApiSunSale.Domain.Entities
{
    public class Anexosquestoes 
    {
        public long Codigo { get; set; }
        public long Codigoquestao { get; set; }
        public DateTime Dataregistro { get; set; }
        public byte[] Anexo { get; set; }
    }
}
