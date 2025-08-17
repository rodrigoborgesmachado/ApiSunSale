namespace ApiSunSale.Application.DTO
{
    public class AnexosquestoesDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Idquestao { get; set; }
        public string Link { get; set; }
        public QuestoesDTO Questao { get; set; }
    }
}
