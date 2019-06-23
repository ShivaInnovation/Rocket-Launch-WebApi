using Rocket.Launch.DbEntities.Entities;
using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using Rocket.Launch.Repository.Repositories;
using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.DependencyResolution
{
    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            For<IRepository<Rocket.Launch.DbEntities.Entities.Rocket>>().Use<RocketRepository>();
            For<IRepository<Satellite>>().Use<SatellieteRepository>();
            For<IRepository<Category>>().Use<CategoryRepository>();
        }
    }
}
