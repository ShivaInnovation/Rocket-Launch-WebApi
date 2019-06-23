using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.Interfaces
{
    public interface IRocketRepository
    {
        Task<IEnumerable<RocketMdl>> GetAsync(
        Expression<Func<RocketMdl, bool>> filter = null,
        Func<IQueryable<RocketMdl>, IOrderedQueryable<RocketMdl>> orderBy = null,
            string includeProperties = "");

        Task InsertAsync(RocketMdl entity);

        Task UpdateAsync(RocketMdl entityToUpdate);
    }
}
