using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Rocket.Launch.DbEntities.DataContext;
using System.Data.Entity;
using Rocket.Launch.Repository.Base;

namespace Rocket.Launch.Repository.Repositories
{
    public class RocketRepository : IRepository<Rocket.Launch.DbEntities.Entities.Rocket>
    {
        private RocketContext _context;
        private DbSet<Rocket.Launch.DbEntities.Entities.Rocket> _dbSet;

        public RocketRepository()
        { 
            _context = new RocketContext();
            _dbSet = _context.Set<Rocket.Launch.DbEntities.Entities.Rocket>();
        }

        public IEnumerable<Rocket.Launch.DbEntities.Entities.Rocket> Get()
        {
            return _context.Rocket.ToList();
        }

        public Rocket.Launch.DbEntities.Entities.Rocket Get(int id)
        {
            return _context.Rocket.Find(id);
        }

        public void Insert(Rocket.Launch.DbEntities.Entities.Rocket entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(Rocket.Launch.DbEntities.Entities.Rocket entityToUpdate)
        {
            _dbSet.Add(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
