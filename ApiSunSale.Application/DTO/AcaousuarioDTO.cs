namespace ApiSunSale.Application.DTO
{
    public class AcaousuarioDTO : BaseDTO
    {
        public long Id { get; set; }
        public long Idusuario { get; set; }
        public string Acao { get; set; }
        public UsuariosDTO Usuario { get; set; }
    }
}
