using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.DbEntities.Entities
{
    public class Rocket : BaseEntity
    {
        public Rocket()
        {
            this.Satellites = new HashSet<Satellite>();
        }
        public int RocketNo { get; set; }
        public string RocketName { get; set; }
        public string Path { get; set; }
        public string Destination { get; set; }

        //Navigation Property
        public virtual ICollection<Satellite> Satellites { get; set; }
    }
}
