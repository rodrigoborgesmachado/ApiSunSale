namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class VerboconjugadoViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Idverbo { get; set; }
        public string Presente { get; set; }
        public string Preteritoimperfeito { get; set; }
        public string Preteritoperfeito { get; set; }
        public string Preteritomaisqueperfeito { get; set; }
        public string Futurodopresente { get; set; }
        public string Futurodopreterito { get; set; }
        public string Pronome { get; set; }
    }
}
