using Main = ApiSunSale.Domain.Entities.Email;

namespace ApiSunSale.Domain.Interfaces.Services
{
    public interface ISendGridService
    {
        Task<bool> SendMail(Main entity);
    }
}
