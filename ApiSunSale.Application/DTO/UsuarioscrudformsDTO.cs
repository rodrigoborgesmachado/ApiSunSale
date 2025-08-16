namespace ApiSunSale.Application.DTO
{
    public class UsuarioscrudformsDTO : BaseDTO
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Administrador { get; set; }
        public string Desenvolvedor { get; set; }
        public string Email { get; set; }
        public long Usuariopai { get; set; }
        public string Nome { get; set; }
    }
}
