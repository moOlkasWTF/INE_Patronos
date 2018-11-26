namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INITIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RolesId = c.Int(nullable: false),
                        PoliticalPartyId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Age = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PoliticalParty", t => t.PoliticalPartyId, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.RolesId, cascadeDelete: true)
                .Index(t => t.PoliticalPartyId)
                .Index(t => t.RolesId);
            
            CreateTable(
                "dbo.PoliticalParty",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Foundation = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        President = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Governor = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Mayor = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vote",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Candidate", t => t.CandidateId, cascadeDelete: true)
                .Index(t => t.CandidateId);
            
            CreateTable(
                "dbo.Citizen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                        LastNameFather = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        LastNameMother = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Address = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        ElectroKey = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        CURP = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                        BirthDate = c.String(nullable: false, maxLength: 25, unicode: false, storeType: "nvarchar"),
                        YearRegistration = c.String(nullable: false, maxLength: 4, unicode: false, storeType: "nvarchar"),
                        StateProvinceId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        Section = c.String(nullable: false, maxLength: 6, unicode: false, storeType: "nvarchar"),
                        Localization = c.String(nullable: false, maxLength: 1, unicode: false, storeType: "nvarchar"),
                        Issue = c.String(nullable: false, maxLength: 4, unicode: false, storeType: "nvarchar"),
                        Validity = c.String(nullable: false, maxLength: 4, unicode: false, storeType: "nvarchar"),
                        Gender = c.String(nullable: false, maxLength: 1, unicode: false, storeType: "nvarchar"),
                        CIC = c.String(nullable: false, maxLength: 15, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.StateProvince", t => t.StateProvinceId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.StateProvinceId);
            
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateProvinceId = c.Int(nullable: false),
                        CountryRegionId = c.Int(nullable: false),
                        CveEnt = c.String(nullable: false, maxLength: 2, unicode: false, storeType: "nvarchar"),
                        CveCity = c.String(nullable: false, maxLength: 3, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        CveCab = c.String(maxLength: 7, unicode: false, storeType: "nvarchar"),
                        NameCab = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        PTOT = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        PMAS = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        PFEM = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        VTOT = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryRegion", t => t.CountryRegionId, cascadeDelete: true)
                .ForeignKey("dbo.StateProvince", t => t.StateProvinceId, cascadeDelete: true)
                .Index(t => t.CountryRegionId)
                .Index(t => t.StateProvinceId);
            
            CreateTable(
                "dbo.CountryRegion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        FIPS104 = c.String(nullable: false, maxLength: 2, unicode: false, storeType: "nvarchar"),
                        ISO2 = c.String(nullable: false, maxLength: 2, unicode: false, storeType: "nvarchar"),
                        ISO3 = c.String(nullable: false, maxLength: 3, unicode: false, storeType: "nvarchar"),
                        ISON = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Internet = c.String(maxLength: 2, unicode: false, storeType: "nvarchar"),
                        Capital = c.String(maxLength: 25, unicode: false, storeType: "nvarchar"),
                        MapReference = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        NationalitySingular = c.String(maxLength: 35, unicode: false, storeType: "nvarchar"),
                        NationalityPlural = c.String(maxLength: 35, unicode: false, storeType: "nvarchar"),
                        Currency = c.String(maxLength: 30, unicode: false, storeType: "nvarchar"),
                        CurrencyCode = c.String(maxLength: 3, unicode: false, storeType: "nvarchar"),
                        Population = c.Long(nullable: false),
                        Title = c.String(maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Comment = c.String(maxLength: 2048, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StateProvince",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryRegionId = c.Int(nullable: false),
                        CveEnt = c.String(nullable: false, maxLength: 2, unicode: false, storeType: "nvarchar"),
                        Description = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Abrev = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                        CveCab = c.String(maxLength: 7, unicode: false, storeType: "nvarchar"),
                        NameCab = c.String(maxLength: 100, unicode: false, storeType: "nvarchar"),
                        PTOT = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        PMAS = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        PFEM = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                        VTOT = c.String(maxLength: 10, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CountryRegion", t => t.CountryRegionId, cascadeDelete: true)
                .Index(t => t.CountryRegionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citizen", "StateProvinceId", "dbo.StateProvince");
            DropForeignKey("dbo.Citizen", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "StateProvinceId", "dbo.StateProvince");
            DropForeignKey("dbo.City", "CountryRegionId", "dbo.CountryRegion");
            DropForeignKey("dbo.StateProvince", "CountryRegionId", "dbo.CountryRegion");
            DropForeignKey("dbo.Vote", "CandidateId", "dbo.Candidate");
            DropForeignKey("dbo.Candidate", "RolesId", "dbo.Roles");
            DropForeignKey("dbo.Candidate", "PoliticalPartyId", "dbo.PoliticalParty");
            DropIndex("dbo.Citizen", new[] { "StateProvinceId" });
            DropIndex("dbo.Citizen", new[] { "CityId" });
            DropIndex("dbo.City", new[] { "StateProvinceId" });
            DropIndex("dbo.City", new[] { "CountryRegionId" });
            DropIndex("dbo.StateProvince", new[] { "CountryRegionId" });
            DropIndex("dbo.Vote", new[] { "CandidateId" });
            DropIndex("dbo.Candidate", new[] { "RolesId" });
            DropIndex("dbo.Candidate", new[] { "PoliticalPartyId" });
            DropTable("dbo.StateProvince");
            DropTable("dbo.CountryRegion");
            DropTable("dbo.City");
            DropTable("dbo.Citizen");
            DropTable("dbo.Vote");
            DropTable("dbo.Roles");
            DropTable("dbo.PoliticalParty");
            DropTable("dbo.Candidate");
        }
    }
}
