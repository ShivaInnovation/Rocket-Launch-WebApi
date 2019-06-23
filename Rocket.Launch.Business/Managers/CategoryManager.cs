using Rocket.Launch.Business.Base;
using Rocket.Launch.Business.Interfaces;
using Rocket.Launch.DbEntities.Entities;
using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Business.Managers
{
    public class CategoryManager : BaseManager<IRepository<Category>>, ICategoryManager
    {
        public CategoryManager(IRepository<Category> repository) : base(repository)
        {
        }

        public IEnumerable<Category> GetCategories()
        {
            var c = Repository.Get();
            return c;
        }
       
    }
}
