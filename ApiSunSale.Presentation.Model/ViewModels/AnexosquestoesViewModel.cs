namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AnexosquestoesViewModel : BaseViewModel
    {
        public long Idquestao { get; set; }
        public string Link { get; set; }
        public QuestoesViewModel? Questao { get; set; }
    }
}
