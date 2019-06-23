using Rocket.Launch.DbEntities.DataContext;
using Rocket.Launch.DbEntities.Entities;
using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private RocketContext _context;
        private DbSet<Category> _dbSet;

        public CategoryRepository()
        {
            _context = new RocketContext();
            _dbSet = _context.Set<Category>();
        }

        public IEnumerable<Category> Get()
        {
            return _context.Category.ToList();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }       

        public void Update(Category entityToUpdate)
        {
            throw new NotImplementedException();
        }

        
    }
}
