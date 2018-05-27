namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0c9b9a31-29d3-4d7a-81a7-a57f0ba1f65d', N'admin@vidly.com', 0, N'APzMqdNZK1mTf0e7EUT1bj5YccFp7r1uPg5/1UJHEDYyAuStAyZo4iUPfnY/RF/Vaw==', N'ff53bfb1-ec1a-407e-89a2-885207953460', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'799a4c85-5dc7-498b-8130-0ff4e1e0b4a7', N'guest@vidly.com', 0, N'AEUHNgHXw/QOcSzeC09WyVoBVe3KKhhBmy02Yv1ioVAYzyv7/Emlcip3xoRrH+Q1cw==', N'8e510207-813d-4c2a-93f1-a801f7622416', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f4c47c20-b9d3-44c7-bd21-73a2b4753a05', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0c9b9a31-29d3-4d7a-81a7-a57f0ba1f65d', N'f4c47c20-b9d3-44c7-bd21-73a2b4753a05')
");
        }
        
        public override void Down()
        {
        }
    }
}
