namespace ApiSunSale.Application.DTO
{
    public class RecuperasenhaDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Guid { get; set; }
        public long Userid { get; set; }
        public string Validated { get; set; }
    }
}
