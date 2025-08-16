namespace ApiSunSale.Application.DTO
{
    public class QuestoesavaliacaoDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public decimal Notaquestao { get; set; }
    }
}
