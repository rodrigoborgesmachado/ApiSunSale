namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AnexorespostaViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public byte[] Anexo { get; set; }
        public QuestoesViewModel Questao { get; set; }
    }
}
