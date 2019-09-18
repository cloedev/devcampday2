namespace RespitronDay2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ConsumptionHistories", "Patient_Id", "dbo.Patients");
            DropIndex("dbo.ConsumptionHistories", new[] { "Patient_Id" });
            RenameColumn(table: "dbo.ConsumptionHistories", name: "Patient_Id", newName: "PatientId");
            AlterColumn("dbo.ConsumptionHistories", "PatientId", c => c.Int(nullable: false));
            CreateIndex("dbo.ConsumptionHistories", "PatientId");
            AddForeignKey("dbo.ConsumptionHistories", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ConsumptionHistories", "PatientId", "dbo.Patients");
            DropIndex("dbo.ConsumptionHistories", new[] { "PatientId" });
            AlterColumn("dbo.ConsumptionHistories", "PatientId", c => c.Int());
            RenameColumn(table: "dbo.ConsumptionHistories", name: "PatientId", newName: "Patient_Id");
            CreateIndex("dbo.ConsumptionHistories", "Patient_Id");
            AddForeignKey("dbo.ConsumptionHistories", "Patient_Id", "dbo.Patients", "Id");
        }
    }
}
