using Rocket.Launch.Business.Interfaces;
using Rocket.Launch.Dto;
using Rocket.Launch.Models.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Rocket.Launch.WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        private ICategoryManager _manager;
        public CategoryController(ICategoryManager manager)
        {
            _manager = manager;
        }

        public IHttpActionResult Get()
        {
            var result = _manager.GetCategories();
            return Ok(result);
        }
    }
}
