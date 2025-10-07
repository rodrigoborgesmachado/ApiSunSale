namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class RespostasusuariosViewModel : BaseViewModel
    {
        
        public long Idusuario { get; set; }
        public long Idresposta { get; set; }
        public long Idquestao { get; set; }
        public UsuariosViewModel Usuario { get; set; }
        public RespostasquestoesViewModel Resposta { get; set; }
        public QuestoesViewModel Questao { get; set; }
    }
}
