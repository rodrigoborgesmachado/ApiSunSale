namespace ApiSunSale.Application.DTO
{
    public class RespostasavaliacoesDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Createdby { get; set; }
        public long Updatedby { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public long Idresposta { get; set; }
        public AvaliacaoDTO Avaliacao { get; set; }
        public QuestoesDTO Questao { get; set; }
        public RespostasquestoesDTO Resposta { get; set; }
    }
}
