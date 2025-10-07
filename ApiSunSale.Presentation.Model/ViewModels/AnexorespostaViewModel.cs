namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AnexorespostaViewModel : BaseViewModel
    {
        public long Idresposta { get; set; }
        public string Link { get; set; }
        public RespostasquestoesViewModel? Respostasquestoes { get; set; }
    }
}
