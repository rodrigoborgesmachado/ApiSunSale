using MainDTO = ApiSunSale.Application.DTO.RecuperasenhaDTO;

namespace ApiSunSale.Application.Interfaces
{
    public interface IRecuperasenhaAppService : IDisposable
    {
        Task<IEnumerable<MainDTO>> GetAllAsync(string? include = null);

        Task<MainDTO> GetAsync(string code, string? include = null);

        Task<MainDTO> InsertAsync(MainDTO mainDto);

        Task<MainDTO> UpdateAsync(MainDTO mainDto);

        Task<MainDTO> RemoveAsync(MainDTO mainDto);

        Task<Tuple<int, int, IEnumerable<MainDTO>>> GetAllPagedAsync(int page, int quantity, DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string? include = null);

        Task<string> GetReport(DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string? include = null);
        Task<MainDTO> UpdateStatus(Status status, long id);
    }
}
