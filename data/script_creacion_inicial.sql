-- Select DB
use GD2C2018
go

-- Create schema
if not exists(select * from sys.schemas where name = 'TRUNCATE') 
BEGIN
EXEC sp_executesql N'CREATE SCHEMA TRUNCATE'
END
--exec sp_executesql 'create schema TRUNCATE'
go
-- Vars
declare @schema_name varchar(11) = 'TRUNCATE'
declare @schema_id int = schema_id(@schema_name)
declare @drop_statement nvarchar(max)

-- Fresh start
select @drop_statement = isnull(@drop_statement, '') +
  ' alter table ['    + @schema_name + '].[' + object_name(parent_object_id) + '] drop constraint [' + name + '];' + char(13)
  from sys.check_constraints
  where schema_id = @schema_id
select @drop_statement = isnull(@drop_statement, '') +
  ' alter table ['    + @schema_name + '].[' + object_name(parent_object_id) + '] drop constraint [' + name + '];' + char(13)
  from sys.foreign_keys
  where schema_id = @schema_id
select @drop_statement = isnull(@drop_statement, '') +
  ' drop procedure [' + @schema_name + '].[' + name + '];' + char(13)
  from sys.procedures
  where schema_id = @schema_id
select @drop_statement = isnull(@drop_statement, '') +
  ' drop view ['      + @schema_name + '].[' + name + '];' + char(13)
  from sys.views
  where schema_id = @schema_id
select @drop_statement = isnull(@drop_statement, '') +
  ' drop table [' + @schema_name + '].[' + name + '];' + char(13)
  from sys.tables
  where schema_id = @schema_id
select @drop_statement = isnull(@drop_statement, '') +
  ' drop function ['  + @schema_name + '].[' + name + '];' + char(13)
  from sys.objects
  where schema_id = @schema_id
  and type in ('FN', 'IF', 'TF')

execute sp_executesql @drop_statement
go


-- Create table to store the current system date
-- We do this here to have access to the function in constraints & defaults
-- This serves as a way to persist env. vars in the db
-- Each one is it's own column, and this table cannot have more than 1 row
create table VOX_MACHINA.EnvironmentVariables(
  -- Lock
  lock int not null default 1 primary key check (lock = 1),

  [current_date] date not null
)
insert into VOX_MACHINA.EnvironmentVariables([current_date])
values (getdate())
go

create function VOX_MACHINA.getCurrentDate()
returns date
as
begin
  declare @date date
  select @date = [current_date]
  from VOX_MACHINA.EnvironmentVariables
  return @date
end
go

create procedure VOX_MACHINA.SetCurrentDate(@date date)
as
begin
  update VOX_MACHINA.EnvironmentVariables
  set [current_date] = @date
  where lock = 1
end
go



-- Main tables

create table VOX_MACHINA.Role (
  id smallint primary key identity (1, 1),
  name varchar(50) not null, -- Not PK to make it easily editable
  state bit not null default 1
)

create table VOX_MACHINA.Capability (
  id smallint primary key identity (1, 1),
  name varchar(50)
)

create table VOX_MACHINA.IdType (
  code char(3) primary key
)

create table VOX_MACHINA.LoginUser ( -- User is a reserved word
  username varchar(50) primary key,
  password binary(32) not null,
  disabled bit default 0, -- Logical deletion

  failed_login_attempts tinyint not null default 0,

  -- Personal info (for admins & receptionists)
  name nvarchar(255),
  surname nvarchar(255),
  mail varchar(255),
  phone int,
  address_street nvarchar(255),
  address_street_number smallint,
  address_floor tinyint,
  address_apt nvarchar(50),
  nationality varchar(255), -- Maybe from a table?
  id_type char(3) foreign key references VOX_MACHINA.IdType,
--   id int unique
)

create table VOX_MACHINA.UserRole (
  username varchar(50) not null foreign key references VOX_MACHINA.LoginUser,
  role smallint not null foreign key references VOX_MACHINA.Role,
  hotel int foreign key references VOX_MACHINA.Hotel, -- If user is Guest this will be null
  selected bit not null default 0,
  constraint PK_UserRole primary key (username, role, hotel)
)

create table VOX_MACHINA.RoleCapability (
  role smallint not null foreign key references VOX_MACHINA.Role,
  capability smallint not null foreign key references VOX_MACHINA.Capability,
  constraint PK_RoleCapability primary key (role, capability)
)

go
insert into VOX_MACHINA.LoginUser (username, password) values
  ('admin', hashbytes('SHA2_256', 'w23e'))

insert into VOX_MACHINA.Capability (name) values
  ('Gestionar roles'),
  ('Gestionar usuarios'),
  ('Realizar reserva'),
  ('Modificar rol de invitados'),
  ('Gestionar hoteles'),
  ('Gestionar habitaciones'),
  ('Gestionar reservas'),
  ('CHECKIN'),
  ('CHECKOUT'),
  ('CONSUMABLE'),
  ('Generar reporte')
go

insert into VOX_MACHINA.RoleCapability (role, capability) values (2, 2)
-- Use previous inserts to automate a bit
insert into VOX_MACHINA.UserRole (username, role, hotel)
select 'admin', 1, Hotel.id
from VOX_MACHINA.Hotel;

insert into VOX_MACHINA.RoleCapability (role, capability)
select 1, Capability.id
from VOX_MACHINA.Capability
go

-- Proceduress

-- Select role
create procedure VOX_MACHINA.SelectUserRole(@username varchar(50), @role smallint, @hotel int)
as begin
  update VOX_MACHINA.UserRole
    set selected = case when (role = @role and hotel = @hotel) then 1 else -1 end
    where username = @username
end
go

create procedure VOX_MACHINA.DeactiveUserRole(@username varchar(50), @role smallint, @hotel int)
as
begin
  update VOX_MACHINA.UserRole
    set selected = case when role = @role and hotel = @hotel then 0 else -1 end
    where username = @username
end
go

-- Login Procedure
-- Returns -1 if login failed, the user is disabled
-- Returns -2 if password incorrect
-- Returns -3 if user doesnt exist
-- Returns -4 if no user has no roles assigned( dont know if can happen)
-- 0 if the login succeeded but there are many roles to choose from, or
-- positive integers if there was only one role and was automatically assigned
create procedure VOX_MACHINA.Login(@username varchar(50), @plain_password varchar(100), @return_val int output)
as begin
  print 'login ' + @username + ', pw: ' + @plain_password;
  declare @disabled bit = null
  declare @password binary(32) = null
  declare @failed_attempts tinyint = null

  select @disabled = L.disabled, @failed_attempts = L.failed_login_attempts, @password = L.password
  from VOX_MACHINA.LoginUser L
  where L.username = @username

  -- The user was already disabled or it doesn't exist
  if @disabled = 1
  begin
    select @return_val = -1
	return
  end
  if @password is null
  begin
	select @return_val = -3
	return
  end

  -- User exists and is not disabled, hash pw and check if it matches
  if @password <> hashbytes('SHA2_256', @plain_password) begin
    -- Increment failed attempts by 1, return fail
    select @failed_attempts = @failed_attempts + 1
    update VOX_MACHINA.LoginUser
      set failed_login_attempts = @failed_attempts,
          disabled = case when @failed_attempts >= 3  or disabled = 1 then 1
                          else 0 end
      where username = @username
    select @return_val = -2
  end
  else begin
    -- Clean failed login attempts
    update VOX_MACHINA.LoginUser
      set failed_login_attempts = 0
      where username = @username

    -- Get role list for user
    declare @hotel int
    declare @role smallint
    declare @count smallint
    select @count = count(role), @role = max(role), @hotel = max(hotel)
      from UserRole left join Role on Role.id = UserRole.role
      where username = @username and Role.state = 1
    if @count > 1
      select @return_val = 0
    else if @count < 1
		select @return_val = -4
	else begin
      exec SelectUserRole @username, @role, @hotel
      select @return_val = @role
    end
  end
end
go

create procedure VOX_MACHINA.CleanAndEnableUser(@username varchar(50))
as
begin
	  update VOX_MACHINA.LoginUser
		set failed_login_attempts = 0, disabled= 0
		where username = @username
end
go

create procedure VOX_MACHINA.ListCapabilities
as
begin
	Select C.id, C.name
	from VOX_MACHINA.Capability C
end
go

create procedure VOX_MACHINA.ListCapabilitiesFromRole(@role smallint)
as
begin
	select C.id, C.name
	from VOX_MACHINA.Capability C join VOX_MACHINA.RoleCapability RC on RC.capability = C.id
	where RC.role = @role
end
go

create procedure VOX_MACHINA.CreateRole(@name varchar(50), @return_val smallint output)
as
begin
	insert into VOX_MACHINA.Role (name) values(@name)
	select @return_val = R.id from VOX_MACHINA.Role R where R.name = @name
end
go

create procedure VOX_MACHINA.IsNewRole(@name varchar(50), @return_val int output)
as
begin
	if exists(select * from VOX_MACHINA.Role R where R.name = @name)
		select @return_val = 0
	else
		select @return_val = 1
end
go

create procedure VOX_MACHINA.InsertGuestCapability(@cap int)
as
begin
	insert into VOX_MACHINA.RoleCapability (role, capability) values (0, @cap)
end
go

create procedure VOX_MACHINA.InsertNewRoleWithCapability(@role varchar(50), @cap int)
as
begin
	declare @id int
	begin try
		begin transaction
			if not exists(select * from VOX_MACHINA.Role R where R.name = @role)
				insert into VOX_MACHINA.Role (name) values(@role)
			select @id = R.id from VOX_MACHINA.Role R where R.name = @role
			insert into VOX_MACHINA.RoleCapability values (@id, @cap)
		commit
	end try
	begin catch
		raiserror('Error al insertar valores en la tabla de funcionalidades por rol.',16,1)
		rollback
		if exists(select * from VOX_MACHINA.Role R where R.name = @role)
			exec VOX_MACHINA.DeleteRole @id
		return
	end catch
end
go

-- Used only when failure at RoleCreation
create procedure VOX_MACHINA.DeleteRole(@roleId int)
as
begin
	delete VOX_MACHINA.RoleCapability where role = @roleId
	delete VOX_MACHINA.Role where id = @roleId
end
go

create procedure VOX_MACHINA.EnableRole(@role varchar(50))
as
begin
	update VOX_MACHINA.Role set state = 1 where name = @role
end
go

create procedure VOX_MACHINA.DisableRole(@role varchar(50))
as
begin
	update VOX_MACHINA.Role set state = 1 where name = @role
end
go

create procedure VOX_MACHINA.ChangeRoleName(@role varchar(50), @name varchar(50))
as
begin
	update VOX_MACHINA.Role set name = @name where name = @role
end
go

create procedure VOX_MACHINA.DeleteCapabilityFromRole(@role varchar(50), @cap int)
as
begin
	declare @id int
	begin try
		begin transaction
			if not exists(select * from VOX_MACHINA.Role R where R.name = @role)
				insert into VOX_MACHINA.Role (name) values(@role)
			select @id = R.id from VOX_MACHINA.Role R where R.name = @role
			delete VOX_MACHINA.RoleCapability where role = @role and capability = @cap
		commit
	end try
	begin catch
		raiserror('Error al borrar funcionalidad.',16,1)
		rollback
	end catch
end
go