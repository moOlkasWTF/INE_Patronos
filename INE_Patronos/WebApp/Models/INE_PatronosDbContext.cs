using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class INE_PatronosDbContext : DbContext
    {

        public INE_PatronosDbContext() : base("INE_PatronosDbContext")
        {
            Database.SetInitializer<INE_PatronosDbContext>(new INE_PatronosDbInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CountryRegion> CountriesRegion { get; set; }
        public DbSet<StateProvince> StatesProvince { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}