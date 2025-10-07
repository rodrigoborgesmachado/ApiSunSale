namespace ApiSunSale.Application.DTO
{
    public class AnexorespostaDTO : BaseDTO
    {
        public long Idresposta { get; set; }
        public string Link { get; set; }
        public RespostasquestoesDTO? Respostasquestoes { get; set; }
    }
}
