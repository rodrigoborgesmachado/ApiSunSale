namespace ApiSunSale.Domain.Entities
{
    public class Tipoprova : BaseEntity
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }
}
