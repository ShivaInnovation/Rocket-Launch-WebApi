using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Repository.Interfaces
{
    public interface IRepository<TModel>
    {
        //Task<IEnumerable<TModel>> GetAsync(Expression<Func<TModel, bool>> filter = null,
        //Func<IQueryable<TModel>, IOrderedQueryable<TModel>> orderBy = null,
        //   string includeProperties = "");
        IEnumerable<TModel> Get();
        TModel Get(int id);
        void Insert(TModel entity);
        void Update(TModel entityToUpdate);
    }
}
