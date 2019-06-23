using Rocket.Launch.Business.Interfaces;
using Rocket.Launch.DbEntities.Entities;
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
    public class RocketController : ApiController
    {
        private IRocketManager _manager;
        public RocketController(IRocketManager manager)
        {
            _manager = manager;
        }

        public IHttpActionResult Get()
        {
            var result = _manager.GetRockets();
            return Ok(result);
        }

        public IHttpActionResult Post(Rocket.Launch.DbEntities.Entities.Rocket rocket)
        {
            //Rocket table
            if (rocket.Id == 0)
            {
                _manager.Insert(rocket);
            }
            else
            {
                _manager.Update(rocket);
            }
            return Ok();
        }
    }
}
