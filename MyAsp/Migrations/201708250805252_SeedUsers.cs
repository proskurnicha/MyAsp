namespace MyAsp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3c907380-af46-4b88-9a2a-f27c8764d558', N'admin@gmail.com', 0, N'ABKKb0pXUJ1XV2IK1Aosct0hvE2RdfktJX+douV32gIF3hIfWGg5U9P8aKU3CWyaRw==', N'7e048bc5-a730-4dae-819d-59607e567e09', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6b7b7830-3aa1-402d-a29e-12229a9512e1', N'proskurnicha@gmail.com', 0, N'AOmU3KDScDjzJsdvlgFQb+bNzYCYGt7eJqbZ5G85g2C6N2KJxnvmRmnRtKKnIML8LA==', N'4749a673-092d-46cc-830d-9aee1417a841', NULL, 0, 0, NULL, 1, 0, N'proskurnicha@gmail.com')
            INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b3c3be8e-8e77-4f88-885a-bf59c55801d9', N'guest@gmail.com', 0, N'AHCyl/dp2AphVSaHj5JUupachqAnIm0snljNZ9yHzE89L8CrZ1aHtrCC/kV8cXdY4A==', N'e4367704-14c5-420e-9314-604e51d2e549', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')
            INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'846c4dc3-4c18-48e3-93c0-7e977f4a08f9', N'CanManageMovie')
            INSERT INTO[dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES(N'3c907380-af46-4b88-9a2a-f27c8764d558', N'846c4dc3-4c18-48e3-93c0-7e977f4a08f9')
           ");
        }

        public override void Down()
        {
        }
    }
}
