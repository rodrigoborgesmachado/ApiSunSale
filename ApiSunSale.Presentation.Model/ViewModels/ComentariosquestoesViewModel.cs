namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ComentariosquestoesViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Comentario { get; set; }
        public long Idusuario { get; set; }
        public long Idquestao { get; set; }
    }
}
