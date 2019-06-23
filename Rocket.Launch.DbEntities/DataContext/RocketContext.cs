using Rocket.Launch.DbEntities.DataBaseConfiguration;
using Rocket.Launch.DbEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket.Launch.DbEntities.DataContext
{
    public class RocketContext : DbContext
    {
        public RocketContext() : base("RocketConnection")
        {
        }

        public DbSet<Rocket.Launch.DbEntities.Entities.Rocket> Rocket { get; set; }
        public DbSet<Satellite> Satellite { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Satellite>()
            .HasRequired<Rocket.Launch.DbEntities.Entities.Rocket>(s => s.Rocket)
            .WithMany(g => g.Satellites)
            .HasForeignKey<int>(s => s.RocketId);            

            modelBuilder.Configurations.Add(new SatelliteConfig());
            modelBuilder.Configurations.Add(new RocketConfig());

        }
    }
}
