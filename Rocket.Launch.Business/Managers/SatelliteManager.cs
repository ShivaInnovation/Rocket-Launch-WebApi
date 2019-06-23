using Rocket.Launch.Business.Base;
using Rocket.Launch.Business.Interfaces;
using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Launch.DbEntities.Entities;

namespace Rocket.Launch.Business.Managers
{
    public class SatelliteManager : BaseManager<IRepository<Satellite>>, ISatelliteManager
    {
        public SatelliteManager(IRepository<Satellite> repository) : base(repository)
        {
        }

        public IEnumerable<Satellite> GetSatellites()
        {
            var t = Repository.Get();
            return t;
        }
    }
}
