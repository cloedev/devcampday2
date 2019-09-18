namespace RespitronDay2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ConsumptionHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumptionDate = c.DateTime(),
                        O2LitersConsumption = c.Int(nullable: false),
                        Patient_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Patient_Id)
                .Index(t => t.Patient_Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        GenderId = c.Int(nullable: false),
                        DateOfBirth = c.DateTime(),
                        DateOfDecease = c.DateTime(),
                        Smoker = c.Boolean(nullable: false),
                        CigarrettesDailyConsumption = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .Index(t => t.GenderId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InternalId = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConsumptionHistories", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Patients", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Patients", "CityId", "dbo.Cities");
            DropIndex("dbo.Patients", new[] { "CityId" });
            DropIndex("dbo.Patients", new[] { "GenderId" });
            DropIndex("dbo.ConsumptionHistories", new[] { "Patient_Id" });
            DropTable("dbo.Genders");
            DropTable("dbo.Patients");
            DropTable("dbo.ConsumptionHistories");
            DropTable("dbo.Cities");
        }
    }
}
