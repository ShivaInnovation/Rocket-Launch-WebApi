using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Dto
{
    public class SatelliteDTO
    {
        public int Id { get; set; }
        public int SatelliteNo { get; set; }
        public string SatelliteName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        //public int RocketId { get; set; }
    }
}
