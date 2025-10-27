using IBlobStorageService = ApiSunSale.Domain.Interfaces.Services.IBlobStorageService;
using ILoggerService = ApiSunSale.Application.Interfaces.ILoggerAppService;
using IMainRepository = ApiSunSale.Domain.Interfaces.Repository.IPlantasRepository;
using IMainService = ApiSunSale.Application.Interfaces.IPlantasAppService;
using Main = ApiSunSale.Domain.Entities.Plantas;
using MainDTO = ApiSunSale.Application.DTO.PlantasDTO;
using Microsoft.Extensions.Options;
using ApiSunSale.Domain.ModelClasses;
using ApiSunSale.Application.Helpers;
using static ApiSunSale.Infrastructure.CrossCutting.Enums.Enums;

namespace ApiSunSale.Application.Services
{
    public class PlantasAppService : ServiceBase<MainDTO>, IMainService
    {
        private readonly IMainRepository _mainRepository;
        private readonly ILoggerService _loggerService;

        private string[] allowInclude = new string[] { };

        public PlantasAppService(IBlobStorageService blobStorageService, IOptions<Settings> options, IMainRepository mainRepository, ILoggerService loggerService)
            : base(blobStorageService, options)
        {
            _mainRepository = mainRepository;
            _loggerService = loggerService;
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
            await _loggerService.InsertAsync($"Report - Starting GetReport - {this.GetType().Name}");

            var result = await GetAllPagedAsync(1, int.MaxValue, startDate, endDate, isActive, term, orderBy: orderBy, include: include);
            string link = await UploadReport(result.Item3.ToList());

            await _loggerService.InsertAsync($"Report - Finishing GetReport - {this.GetType().Name}");
            return link;
        }

        public async Task<MainDTO> UpdateStatus(Status status, long id)
        {
            var main = await _mainRepository.GetByIdAsync(id);

            if (main == null)
                throw new Exception("Object not found");

            main.IsActive = (byte)(status == Status.IsActive ? 1 : 0);
            main.IsDeleted = (byte)(status == Status.IsDeleted ? 1 : 0);
            _mainRepository.Update(main);

            await _mainRepository.CommitAsync();

            return main.ProjectedAs<MainDTO>();
        }

        public void Dispose()
        {
            _mainRepository.Dispose();
        }
    }
}
