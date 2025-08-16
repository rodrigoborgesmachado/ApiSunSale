namespace ApiSunSale.Domain.Entities
{
    public class Respostasquestoes 
    {
        public long Codigo { get; set; }
        public long Codigoquestao { get; set; }
        public DateTime Dataregistro { get; set; }
        public string Textoresposta { get; set; }
        public string Certa { get; set; }
        public string Observacaoresposta { get; set; }
    }
}
