namespace MyAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: true));
            Sql("UPDATE  Customers  SET BirthDate = '1998/5/16' WHERE Id = 1");
            Sql("UPDATE  Customers SET BirthDate = '1972/11/21' WHERE Id = 3");
        }

        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
