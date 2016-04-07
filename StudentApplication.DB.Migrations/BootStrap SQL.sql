-- bootstrap script for Padca.Woodgrove application
-- Please run before attempting to start the application
------ uncomment next few lines if you'd *really* like to recreate the database
-- use master;
-- go
-- ALTER DATABASE  [Woodgrove]
-- SET SINGLE_USER
-- WITH ROLLBACK IMMEDIATE
-- drop database [Woodgrove]
-- go
------ normal creation after here
use master;
go
if not exists (select name from master..syslogins where name = 'StudentWeb')
    begin
        create login StudentWeb with password = 'P4$$w0rd';
    end;
go


if not exists (select name from master..sysdatabases where name = 'Student')
begin
create database Student
end;
GO

use Student
if not exists (select * from sysusers where name = 'StudentWeb')
begin
create user StudentWeb
	for login StudentWeb
	with default_schema = dbo
end;
GO
grant connect to StudentWeb
go
exec sp_addrolemember N'db_datareader', N'StudentWeb';
go
exec sp_addrolemember N'db_datawriter', N'StudentWeb';
go
exec sp_addrolemember N'db_owner', N'StudentWeb';
GO
use master;
GO

