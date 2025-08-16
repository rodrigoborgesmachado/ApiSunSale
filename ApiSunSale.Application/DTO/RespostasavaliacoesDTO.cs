namespace ApiSunSale.Application.DTO
{
    public class RespostasavaliacoesDTO 
    {
        public long Id { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Updatedon { get; set; }
        public long Createdby { get; set; }
        public long Updatedby { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public long Idresposta { get; set; }
    }
}
