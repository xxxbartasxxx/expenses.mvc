/****** Script for SelectTopNRows command from SSMS  ******/
use[expenses];
go

select * from [dbo].[AspNetUserClaims];
select * from [dbo].[Accounts];
select * from [dbo].[ApplicationUsers];
select * from [dbo].[AspNetRoles];
select * from [dbo].[AspNetUserLogins];
select * from [dbo].[AspNetUserRoles];
delete from [dbo].[AspNetUsers];

select
	SYSDATETIME() as [sysdatetime]
	,SYSUTCDATETIME() as [sysutcdatetime]
	,CURRENT_TIMESTAMP as [current_timestamp]
	,GETDATE() as [getdate]
	,GETUTCDATE() as [getutcdate]