using ApiSunSale.Presentation.Model.ViewModels;

namespace ApiSunSale.Presentation.Model.Requests
{
    public class UserRequest
    {
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Datanascimento { get; set; }
        public string? Admin { get; set; }
        public string? Instituicao { get; set; }
        public string Pass { get; set; }
    }
}
