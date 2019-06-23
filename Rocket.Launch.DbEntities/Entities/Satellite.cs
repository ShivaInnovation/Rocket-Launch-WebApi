using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.DbEntities.Entities
{
    public class Satellite : BaseEntity
    {
        public int SatelliteNo { get; set; }
        public string SatelliteName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public int RocketId { get; set; }

        //Navigation Property
        public virtual Rocket Rocket { get; set; }
    }
}
