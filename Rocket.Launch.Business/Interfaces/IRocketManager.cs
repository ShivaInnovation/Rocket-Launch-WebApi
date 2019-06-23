using Rocket.Launch.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Business.Interfaces
{
    public interface IRocketManager
    {
        IEnumerable<Rocket.Launch.DbEntities.Entities.Rocket> GetRockets();
        Rocket.Launch.DbEntities.Entities.Rocket GetRockets(int rocketId);
        void Insert(Rocket.Launch.DbEntities.Entities.Rocket entity);
        void Update(Rocket.Launch.DbEntities.Entities.Rocket entityToUpdate);
    }
}
