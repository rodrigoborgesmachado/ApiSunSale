namespace ApiSunSale.Domain.Entities
{
    public class Questoesavaliacao : BaseEntity
    {
        public long Id { get; set; }
        public long Idavaliacao { get; set; }
        public long Idquestao { get; set; }
        public decimal Notaquestao { get; set; }
    }
}
