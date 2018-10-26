namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class SeedUsers : DbMigration
	{
		public override void Up()
		{

			Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1dae6053-5769-4ae7-9dfb-b38b640df930', N'guest@vidly.com', 0, N'AJiKxeEHZqsW1bfBOZ8oYLetKVBFxC+Rx6+V1Z8p5mqjYWa94yodmICKy+8rMoysWg==', N'17928cf4-f544-4d0f-9bcc-154ff64bf125', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'289fd8b4-24cf-4f37-bbeb-997efe254aaf', N'admin@vidly.com', 0, N'APlhHTV1mykccJ8QC7v4R6lw4OdCXKFiJ2tvaol+RdGdut5ppsNZxI8HkAz5AJbsxg==', N'd23d0308-b599-4920-8e3c-7ca7fade7a57', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'662b2ca5-2679-4004-8468-350d47a229c3', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'289fd8b4-24cf-4f37-bbeb-997efe254aaf', N'662b2ca5-2679-4004-8468-350d47a229c3')
");
		}
		
		public override void Down()
		{
		}
	}
}
