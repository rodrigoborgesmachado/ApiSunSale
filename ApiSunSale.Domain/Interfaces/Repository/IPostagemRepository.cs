using Main = ApiSunSale.Domain.Entities.Postagem;

namespace ApiSunSale.Domain.Interfaces.Repository
{
    public interface IPostagemRepository : IRepositoryBase<Main>
    {
        Task<IEnumerable<Main>> GetAllAsync(string[] include = null);
        Task<IEnumerable<Main>> GetAllAsync(string parentCode, string[] include = null);
        Task<Main> GetAsync(string code, string[] include = null);
        Task<Tuple<int, IEnumerable<Main>>> GetAllPagedAsync(int page, int quantity, DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string[] include = null);
    }
}
