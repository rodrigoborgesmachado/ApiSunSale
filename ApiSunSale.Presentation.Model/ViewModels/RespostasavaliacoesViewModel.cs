namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasavaliacoesViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public long Createdby { get; set; }
        public long Updatedby { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public long Idresposta { get; set; }
        public AvaliacaoViewModel Avaliacao { get; set; }
        public QuestoesViewModel Questao { get; set; }
        public RespostasquestoesViewModel Resposta { get; set; }
    }
}
