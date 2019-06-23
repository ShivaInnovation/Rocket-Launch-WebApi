using Rocket.Launch.DbEntities.Entities;
using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Business.Interfaces
{
    public interface ISatelliteManager
    {
        IEnumerable<Satellite> GetSatellites();        
    }
}
