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

        public DbSet<City> Citys { get; set; }
        public DbSet<CountryRegion> CountriesRegions { get; set; }
        public DbSet<StateProvince> StatesProvinces { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<PoliticalParty> PoliticalPartys { get; set; }
        public DbSet<Roles> Roless { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}