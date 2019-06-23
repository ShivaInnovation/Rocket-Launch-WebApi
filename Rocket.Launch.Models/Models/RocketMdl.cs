using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Models.Models
{
    public class RocketMdl
    {
        public int RocketId { get; set; }
        public int RocketNo { get; set; }
        public string RocketName { get; set; }
        public string Path { get; set; }
        public string Destination { get; set; }

        //Navigation Property
        public virtual ICollection<SatelliteMdl> Satellites { get; set; }
    }
}
