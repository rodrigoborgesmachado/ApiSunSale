using Main = ApiSunSale.Domain.Entities.Metas;
using ApiSunSale.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using IMainRepository = ApiSunSale.Domain.Interfaces.Repository.IMetasRepository;

namespace ApiSunSale.Infrastructure.Data.Repository
{
    public class MetasRepository : RepositoryBase<Main>, IMainRepository
    {
        public MetasRepository(ApiSunSaleContext currentContext)
            : base(currentContext)
        {
        }

        public async Task<IEnumerable<Main>> GetAllAsync(string[] include = null)
        {
            return await GetAllAsync(s => s.IsDeleted.Equals(0), include, orderBy: "Created: Desc");
        }

        public async Task<IEnumerable<Main>> GetAllAsync(string parentCode, string[] include = null)
        {
            return await GetAllAsync(s => s.IsDeleted.Equals(0), include, orderBy: "Created: Desc");
        }

        public async Task<Main> GetAsync(string code, string[] include = null)
        {
            var query = GetQueryable().Where(p => p.Id.Equals(long.Parse(code)));

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

            if (!string.IsNullOrEmpty(isActive))
            {
                Regex regexObj = new Regex(@"[^\d]");

                string isActiveString = regexObj.Replace(isActive, "");

                int isActiveInt32 = 0;

                if (!string.IsNullOrEmpty(isActiveString))
                {
                    isActiveInt32 = Convert.ToInt32(regexObj.Replace(isActive, ""));
                }

                if (isActiveInt32 > 1)
                {
                    isActiveInt32 = 1;
                }

                byte isActiveByte = Convert.ToByte(isActiveInt32);

                query = query.Where(c => c.IsActive.Equals(isActiveByte));
            }

            if (!string.IsNullOrEmpty(term))
            {
                query = query.Where(c => c.Id.Equals(term));
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
