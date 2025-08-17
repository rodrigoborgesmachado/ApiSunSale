namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class QuestoesavaliacaoViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public decimal Notaquestao { get; set; }
        public AvaliacaoViewModel Avaliacao { get; set; }
        public QuestoesViewModel Questao { get; set; }
    }
}
