/****** Script for SelectTopNRows command from SSMS  ******/
use[expenses];
go

select * from [dbo].[AspNetUsers];
select * from [dbo].[Accounts];
select * from [dbo].[ApplicationUsers];
select * from [dbo].[AspNetRoles];
select * from [dbo].[AspNetUserLogins];
select * from [dbo].[AspNetUserRoles];
delete from [dbo].[AspNetUsers];