using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.Dto
{
    public class RocketDTO
    {
        public int RocketId { get; set; }
        public int RocketNo { get; set; }
        public string RocketName { get; set; }
        public string Path { get; set; }
        public string Destination { get; set; }
    }
}
