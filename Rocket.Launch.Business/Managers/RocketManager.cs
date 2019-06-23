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
    public class RocketManager : BaseManager<IRepository<Rocket.Launch.DbEntities.Entities.Rocket>>, IRocketManager
    {
        public RocketManager(IRepository<Rocket.Launch.DbEntities.Entities.Rocket> repository):base(repository)
        {
        }

        public IEnumerable<DbEntities.Entities.Rocket> GetRockets()
        {
            var r = Repository.Get();
            return r;
        }

        public DbEntities.Entities.Rocket GetRockets(int rocketId)
        {
            var t = Repository.Get(rocketId);
            return t;
        }

        public void Insert(DbEntities.Entities.Rocket entity)
        {
            Repository.Insert(entity);
        }

        public void Update(DbEntities.Entities.Rocket entityToUpdate)
        {
            Repository.Update(entityToUpdate);
        }
    }
}
