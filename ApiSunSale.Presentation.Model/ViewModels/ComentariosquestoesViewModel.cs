namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ComentariosquestoesViewModel : BaseViewModel
    {
        
        public string Comentario { get; set; }
        public long Idusuario { get; set; }
        public long Idquestao { get; set; }
        public UsuariosViewModel? Usuario { get; set; }
        public QuestoesViewModel? Questao { get; set; }
    }
}
