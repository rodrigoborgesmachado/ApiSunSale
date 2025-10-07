namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class EmailViewModel : BaseViewModel
    {
        public string? Destinatario { get; set; }
        public string? Assunto { get; set; }
        public string Texto { get; set; }
        public string? Status { get; set; }
        public string? Observacao { get; set; }
    }
}
