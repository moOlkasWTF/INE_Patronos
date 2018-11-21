using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class INE_PatronosDbContext : DbContext
    {

        public INE_PatronosDbContext() : base("INE_PatronosDbContext")
        {
            Database.SetInitializer<INE_PatronosDbContext>(new INE_PatronosDbInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<CountryRegion> CountriesRegion { get; set; }
        public DbSet<StateProvince> StatesProvince { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<PoliticalParty> PoliticalParties { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}