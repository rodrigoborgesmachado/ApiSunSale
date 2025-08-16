namespace ApiSunSale.Application.DTO
{
    public class ProvaDTO 
    {
        public long Codigo { get; set; }
        public string Nomeprova { get; set; }
        public string Local { get; set; }
        public string Tipoprova { get; set; }
        public string Dataaplicacao { get; set; }
        public byte[] Prova { get; set; }
        public byte[] Gabarito { get; set; }
        public string Observacaoprova { get; set; }
        public string Observacaogabarito { get; set; }
        public DateTime Dataregistro { get; set; }
        public string Banca { get; set; }
        public long Updatedby { get; set; }
        public DateTime Updatedon { get; set; }
        public long Createdby { get; set; }
    }
}
