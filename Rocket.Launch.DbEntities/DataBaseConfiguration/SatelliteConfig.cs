using Rocket.Launch.DbEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.DbEntities.DataBaseConfiguration
{
    public class SatelliteConfig : EntityTypeConfiguration<Satellite>
    {
        public SatelliteConfig()
        {
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(c => c.Id);
        }
    }
}
