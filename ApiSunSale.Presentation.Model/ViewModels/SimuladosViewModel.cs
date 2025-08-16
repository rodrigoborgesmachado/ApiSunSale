namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class SimuladosViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Respostas { get; set; }
        public long Idusuario { get; set; }
        public long Idprova { get; set; }
        public int Quantidadequestoes { get; set; }
        public int Quantidadecertas { get; set; }
        public int Tempo { get; set; }
    }
}
