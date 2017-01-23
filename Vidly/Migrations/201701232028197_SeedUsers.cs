namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'85462006-f6d5-46ff-b20c-a89c30d04a79', N'admin@vidly.com', 0, N'AEW4VJMnhswRCalZpyRbUCy+pSkfbPBNZaSSacR6tz1DpuLyIQ2b6AvQqAD9HJ2OCw==', N'f81b071c-ec9e-40ef-ab87-46faa73e88f4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cb7030bc-d384-42b3-a707-28195eb35c62', N'guest@vidly.com', 0, N'AIPqjgxvyUp/P9mh3clc9V1n9o2BiXDN6WDO0MxxtzM3B2Cae+rUCiiQROM/KuYjyA==', N'5581d764-2015-4c66-9e38-39613efde1aa', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'19a223bb-925a-4f00-8fb3-ba119107f1a8', N'CanManageMovies')
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'85462006-f6d5-46ff-b20c-a89c30d04a79', N'19a223bb-925a-4f00-8fb3-ba119107f1a8')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
