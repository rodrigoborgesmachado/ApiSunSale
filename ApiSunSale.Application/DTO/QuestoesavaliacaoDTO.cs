namespace ApiSunSale.Application.DTO
{
    public class QuestoesavaliacaoDTO 
    {
        public long Id { get; set; }
        public DateTime Createdon { get; set; }
        public long Createdby { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public decimal Notaquestao { get; set; }
    }
}
