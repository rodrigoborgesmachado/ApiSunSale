using Main = ApiSunSale.Domain.Entities.Email;

namespace ApiSunSale.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        Task<bool> SendMail(Main entity);
    }
}
