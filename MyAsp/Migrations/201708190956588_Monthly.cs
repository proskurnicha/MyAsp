namespace MyAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monthly : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE  MembershipTypes  SET Name = 'Weekly' WHERE Id = 4");
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String(nullable: false));

        }

        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "Name", c => c.String());
        }
    }
}
