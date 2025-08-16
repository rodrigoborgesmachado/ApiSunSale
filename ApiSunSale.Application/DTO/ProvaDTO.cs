namespace ApiSunSale.Application.DTO
{
    public class ProvaDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Nomeprova { get; set; }
        public string Local { get; set; }
        public string Tipoprova { get; set; }
        public string Dataaplicacao { get; set; }
        public string ProvaArquivo { get; set; }
        public string Gabarito { get; set; }
        public string Observacaoprova { get; set; }
        public string Observacaogabarito { get; set; }
        public DateTime Dataregistro { get; set; }
        public string Banca { get; set; }
        public long Updatedby { get; set; }
        public long Createdby { get; set; }
    }
}
