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
            
        }

        public DbSet<City> Citys { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<PoliticalParty> PoliticalPartys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}