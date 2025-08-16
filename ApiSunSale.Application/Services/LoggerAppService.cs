using IBlobStorageService = ApiSunSale.Domain.Interfaces.Services.IBlobStorageService;
using IMainRepository = ApiSunSale.Domain.Interfaces.Repository.ILoggerRepository;
using IMainService = ApiSunSale.Application.Interfaces.ILoggerAppService;
using Main = ApiSunSale.Domain.Entities.Logger;
using MainDTO = ApiSunSale.Application.DTO.LoggerDTO;
using Microsoft.Extensions.Options;
using ApiSunSale.Domain.ModelClasses;
using ApiSunSale.Application.Helpers;

namespace ApiSunSale.Application.Services
{
    public class LoggerAppService : ServiceBase<MainDTO>, IMainService
    {
        private readonly IMainRepository _mainRepository;

        private string[] allowInclude = new string[] { };

        public LoggerAppService(IBlobStorageService blobStorageService, IOptions<Settings> options, IMainRepository mainRepository)
            : base(blobStorageService, options)
        {
            _mainRepository = mainRepository;
        }

        public async Task<MainDTO> InsertAsync(Exception ex)
        {
            var main = new Main(ex);

            _mainRepository.Add(main);
            await _mainRepository.CommitAsync();
            return main.ProjectedAs<MainDTO>();
        }

        public async Task<MainDTO> InsertAsync(string message)
        {
            return await InsertAsync(message, 1);
        }

        public async Task<MainDTO> InsertAsync(string message, long userId)
        {
            var main = new Main(message, userId);

            _mainRepository.Add(main);
            await _mainRepository.CommitAsync();

            return main.ProjectedAs<MainDTO>(); ;
        }

        public async Task<IEnumerable<MainDTO>> GetAllAsync(string? include = null)
        {
            var list = await _mainRepository.GetAllAsync(IncludesMethods.GetIncludes(include, allowInclude));
            return list.ProjectedAsCollection<MainDTO>();
        }

        public async Task<IEnumerable<MainDTO>> GetAllAsync(string parentCode, string? include = null)
        {
            var list = await _mainRepository.GetAllAsync(parentCode, IncludesMethods.GetIncludes(include, allowInclude));
            return list.ProjectedAsCollection<MainDTO>();
        }

        public async Task<MainDTO> GetAsync(string code, string? include = null)
        {
            var result = await _mainRepository.GetAsync(code, IncludesMethods.GetIncludes(include, allowInclude));
            return result.ProjectedAs<MainDTO>();
        }

        public async Task<Tuple<int, int, IEnumerable<MainDTO>>> GetAllPagedAsync(int page, int quantity, DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string? include = null)
        {
            var tuple = await _mainRepository.GetAllPagedAsync(page, quantity, startDate, endDate, isActive, term, orderBy, IncludesMethods.GetIncludes(include, allowInclude));

            var total = tuple.Item1;
            var pages = (int)Math.Ceiling((double)total / quantity);

            var list = tuple.Item2.ProjectedAsCollection<MainDTO>();

            return Tuple.Create(total, pages, list);
        }

        public async Task<MainDTO> InsertAsync(MainDTO mainDto)
        {
            var main = mainDto.ProjectedAs<Main>();

            _mainRepository.Add(main);
            await _mainRepository.CommitAsync();

            return main.ProjectedAs<MainDTO>();
        }

        public async Task<MainDTO> UpdateAsync(MainDTO mainDto)
        {
            var main = mainDto.ProjectedAs<Main>();
            main.Updated = DateTime.UtcNow;

            _mainRepository.Update(main);
            await _mainRepository.CommitAsync();

            return main.ProjectedAs<MainDTO>();
        }

        public async Task<MainDTO> RemoveAsync(MainDTO mainDto)
        {
            var main = mainDto.ProjectedAs<Main>();

            _mainRepository.Remove(main);
            await _mainRepository.CommitAsync();

            return main.ProjectedAs<MainDTO>();
        }

        public async Task<string> GetReport(DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string? include = null)
        {
            var result = await GetAllPagedAsync(1, int.MaxValue, startDate, endDate, isActive, term, orderBy: orderBy, include: include);
            string link = await UploadReport(result.Item3.ToList());
            return link;
        }

        public void Dispose()
        {
            _mainRepository.Dispose();
        }
    }
}
