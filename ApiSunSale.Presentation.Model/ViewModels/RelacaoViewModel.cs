namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RelacaoViewModel 
    {
        public long Codigo { get; set; }
        public long Codigoprojeto { get; set; }
        public long Tabelaorigem { get; set; }
        public long Campoorigem { get; set; }
        public long Tabeladestino { get; set; }
        public long Campodestino { get; set; }
        public string Cardinalidadeorigem { get; set; }
        public string Cardinalidadedestino { get; set; }
        public string Foreingkey { get; set; }
    }
}
