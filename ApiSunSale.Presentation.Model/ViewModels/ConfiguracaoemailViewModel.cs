namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class ConfiguracaoemailViewModel 
    {
        public long Codigo { get; set; }
        public string Emailremetente { get; set; }
        public string Smtpclient { get; set; }
        public long Porta { get; set; }
        public string Emailcredencial { get; set; }
        public string Senhacredencial { get; set; }
    }
}
