using Rocket.Launch.Models.Models;
using Rocket.Launch.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Rocket.Launch.DbEntities.DataContext;
using Rocket.Launch.DbEntities.Entities;
using System.Data.Entity;

namespace Rocket.Launch.Repository.Repositories
{
    public class SatellieteRepository : IRepository<Satellite>
    {
        private RocketContext _context;
        private DbSet<Satellite> _dbSet;

        public SatellieteRepository()
        {
            _context = new RocketContext();
            _dbSet = _context.Set<Satellite>();
        }

        public IEnumerable<Satellite> Get()
        {
            return _context.Satellite.ToList();
        }

        public Satellite Get(int id)
        {
            return _context.Satellite.Find(id);
        }

        public void Insert(Satellite entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Satellite entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
