namespace ApiSunSale.Application.DTO
{
    public class TipoprovaDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public int Createdby { get; set; }
        public int Updatedby { get; set; }
    }
}
