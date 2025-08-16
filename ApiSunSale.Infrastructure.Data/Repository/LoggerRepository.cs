using Main = ApiSunSale.Domain.Entities.Logger;
using ApiSunSale.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using IMainRepository = ApiSunSale.Domain.Interfaces.Repository.ILoggerRepository;

namespace ApiSunSale.Infrastructure.Data.Repository
{
    public class LoggerRepository : RepositoryBase<Main>, IMainRepository
    {
        public LoggerRepository(ApiSunSaleContext currentContext)
            : base(currentContext)
        {
        }

        public async Task<Main> InsertAsync(string message, long userId)
        {
            var main = new Main(message, userId);

            Add(main);
            await CommitAsync();

            return main;
        }

        public async Task<IEnumerable<Main>> GetAllAsync(string[] include = null)
        {
            return await GetAllAsync(s => 1 == 1, include, orderBy: "Created: Desc");
        }

        public async Task<IEnumerable<Main>> GetAllAsync(string parentCode, string[] include = null)
        {
            return await GetAllAsync(s => 1 == 1, include, orderBy: "Created: Desc");
        }

        public async Task<Main> GetAsync(string code, string[] include = null)
        {
            var query = GetQueryable().Where(p => p.Id.Equals(code));

            if (include != null)
            {
                foreach (var toInclude in include)
                {
                    query = query.Include(toInclude);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<Tuple<int, IEnumerable<Main>>> GetAllPagedAsync(int page, int quantity, DateTime? startDate, DateTime? endDate, string isActive = null, string term = null, string orderBy = null, string[] include = null)
        {
            var query = GetQueryable();

            if (!string.IsNullOrEmpty(term))
            {
                query = query.Where(c => c.Descricao.Contains(term));
            }

            if (startDate != null)
            {
                query = query.Where(o => o.Created >= startDate);
            }
            if (endDate != null)
            {
                query = query.Where(o => o.Created <= endDate);
            }

            var total = await GetAllPagedTotalAsync(query, include);
            var list = await GetAllPagedAsync(query, page, quantity, include, orderBy);

            return Tuple.Create(total, list);
        }
    }
}
