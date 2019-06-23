using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.Interfaces
{
    public interface ISatelliteRepository
    {
        Task<IEnumerable<SatelliteMdl>> GetAsync(
       Expression<Func<SatelliteMdl, bool>> filter = null,
       Func<IQueryable<SatelliteMdl>, IOrderedQueryable<SatelliteMdl>> orderBy = null,
           string includeProperties = "");

        Task InsertAsync(SatelliteMdl entity);

        Task UpdateAsync(SatelliteMdl entityToUpdate);
    }
}
