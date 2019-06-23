using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Rocket.Launch.DbEntities.DataBaseConfiguration
{
    public class RocketConfig : EntityTypeConfiguration<Rocket.Launch.DbEntities.Entities.Rocket>
    {
        public RocketConfig()
        {
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasKey(c => c.Id);           
        }
    }
}
