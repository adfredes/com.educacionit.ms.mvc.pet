namespace com.educacionit.ms.pet.dataaccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Street = c.String(maxLength: 50),
                        Zip = c.String(maxLength: 10),
                        Number = c.Int(nullable: false),
                        idCity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.idCity)
                .ForeignKey("dbo.People", t => t.Id, cascadeDelete: true)
                .Index(t => t.Id)
                .Index(t => t.idCity);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IdCountry = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.IdCountry)
                .Index(t => t.IdCountry);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Adoptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdPet = c.Int(nullable: false),
                        IdAdopter = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Adopter", t => t.IdAdopter)
                .ForeignKey("dbo.Pets", t => t.IdPet)
                .Index(t => t.IdPet)
                .Index(t => t.IdAdopter);
            
            CreateTable(
                "dbo.Pets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        IdType = c.Int(nullable: false),
                        IdOwner = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Specie = c.String(),
                        Photo = c.Binary(),
                        Adopted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Owner", t => t.IdOwner)
                .ForeignKey("dbo.PetTypes", t => t.IdType, cascadeDelete: true)
                .Index(t => t.IdType)
                .Index(t => t.IdOwner);
            
            CreateTable(
                "dbo.PetTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Adopter",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Owner", "Id", "dbo.People");
            DropForeignKey("dbo.Adopter", "Id", "dbo.People");
            DropForeignKey("dbo.Adoptions", "IdPet", "dbo.Pets");
            DropForeignKey("dbo.Pets", "IdType", "dbo.PetTypes");
            DropForeignKey("dbo.Pets", "IdOwner", "dbo.Owner");
            DropForeignKey("dbo.Adoptions", "IdAdopter", "dbo.Adopter");
            DropForeignKey("dbo.Addresses", "Id", "dbo.People");
            DropForeignKey("dbo.Addresses", "idCity", "dbo.Cities");
            DropForeignKey("dbo.Cities", "IdCountry", "dbo.Countries");
            DropIndex("dbo.Owner", new[] { "Id" });
            DropIndex("dbo.Adopter", new[] { "Id" });
            DropIndex("dbo.Pets", new[] { "IdOwner" });
            DropIndex("dbo.Pets", new[] { "IdType" });
            DropIndex("dbo.Adoptions", new[] { "IdAdopter" });
            DropIndex("dbo.Adoptions", new[] { "IdPet" });
            DropIndex("dbo.Cities", new[] { "IdCountry" });
            DropIndex("dbo.Addresses", new[] { "idCity" });
            DropIndex("dbo.Addresses", new[] { "Id" });
            DropTable("dbo.Owner");
            DropTable("dbo.Adopter");
            DropTable("dbo.PetTypes");
            DropTable("dbo.Pets");
            DropTable("dbo.Adoptions");
            DropTable("dbo.People");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
