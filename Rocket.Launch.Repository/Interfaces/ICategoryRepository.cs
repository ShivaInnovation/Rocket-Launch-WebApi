using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryMdl>> GetAsync(
        Expression<Func<CategoryMdl, bool>> filter = null,
        Func<IQueryable<CategoryMdl>, IOrderedQueryable<RocketMdl>> orderBy = null,
            string includeProperties = "");

        Task InsertAsync(CategoryMdl entity);

        Task UpdateAsync(CategoryMdl entityToUpdate);
    }
}
