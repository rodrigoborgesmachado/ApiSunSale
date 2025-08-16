namespace ApiSunSale.Presentation.Model.ViewModels
{
    public class AvaliacaoViewModel 
    {
        public long Id { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Updatedon { get; set; }
        public long Createdby { get; set; }
        public long Updatedby { get; set; }
        public string Nome { get; set; }
        public string Orientação { get; set; }
        public string Ispublic { get; set; }
        public string Key { get; set; }
    }
}
