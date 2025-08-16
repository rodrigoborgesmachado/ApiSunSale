namespace ApiSunSale.Application.DTO
{
    public class AnexorespostaDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public byte[] Anexo { get; set; }
    }
}
