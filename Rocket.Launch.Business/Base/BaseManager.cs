using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Business.Base
{
    public class BaseManager<T> where T : class
    {
        protected T Repository;

        public BaseManager(T repository)
        {
            this.Repository = repository;
        }
    }
}
