namespace PracticeEntityFramework2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomersAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomersAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "CustomerAddressId", c => c.Int());
            CreateIndex("dbo.Customers", "CustomerAddressId");
            AddForeignKey("dbo.Customers", "CustomerAddressId", "dbo.CustomersAddresses", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CustomerAddressId", "dbo.CustomersAddresses");
            DropIndex("dbo.Customers", new[] { "CustomerAddressId" });
            DropColumn("dbo.Customers", "CustomerAddressId");
            DropTable("dbo.CustomersAddresses");
        }
    }
}
