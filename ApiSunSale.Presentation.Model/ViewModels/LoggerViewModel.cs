namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class LoggerViewModel : BaseViewModel
    {
        public long Id { get; set; }
        public string Message { get; set; }
        public long Adminid { get; set; }
        public string Classname { get; set; }
        public string Methodname { get; set; }
        public string Methodsignature { get; set; }
        public string Methodparameters { get; set; }
        public string Stacktrace { get; set; }
    }
}
