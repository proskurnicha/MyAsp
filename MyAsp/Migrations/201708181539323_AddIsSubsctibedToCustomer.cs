namespace MyAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubsctibedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletters", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribedToNewsletters");
        }
    }
}
