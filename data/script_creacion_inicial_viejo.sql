-- Select DB
use GD1C2018
go

-- Create schema
if not exists(select * from sys.schemas where name = 'VOX_MACHINA') 
BEGIN
EXEC sp_executesql N'CREATE SCHEMA VOX_MACHINA'
END
--exec sp_executesql 'create schema VOX_MACHINA'
go
-- Vars
declare @schema_name varchar(11) = 'VOX_MACHINA'
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

create table VOX_MACHINA.Hotel (
  id int identity(1,1) primary key,
  name varchar(255), -- Should be not null, but the import data has no hotel name
  mail varchar(255),
  phone int,
  country varchar(255) default 'Argentina', -- Should be a fk to a country table
  date_created datetime default VOX_MACHINA.getCurrentDate(),


  -- Fields from master table
  city varchar(255) not null,
  street varchar(255) not null,
  street_number smallint not null,
  stars_amount tinyint not null,
  stars_recharge numeric(18)
)

create table VOX_MACHINA.UserRole (
  username varchar(50) not null foreign key references VOX_MACHINA.LoginUser,
  role smallint not null foreign key references VOX_MACHINA.Role,
  hotel int foreign key references VOX_MACHINA.Hotel, -- If user is Guest this will be null
  selected bit not null default 0,
  constraint PK_UserRole primary key (username, role, hotel)
)

create table   VOX_MACHINA.HotelClosure (
  hotel int foreign key references VOX_MACHINA.Hotel,
  start_date date not null,
  end_date date not null,
  description ntext, -- TODO: maybe a file?
  constraint HotelClosure_ValidDateRange check (start_date <= end_date)
) -- TODO: Create trigger to check for date range overlapping

create table VOX_MACHINA.RoomType (
  -- Fields from master table
  id smallint primary key,
  description nvarchar(255),
  percentual numeric(18, 2)
)

create table VOX_MACHINA.Room (
  hotel int foreign key references VOX_MACHINA.Hotel,
  disabled bit default 0,
  room_type smallint foreign key references VOX_MACHINA.RoomType,
  constraint PK_Room primary key (hotel, number),

  -- Fields from master table
  number int,
  floor smallint,
  face nvarchar(50)
)

create table VOX_MACHINA.AccommodationType (
  code char(10) primary key,
  state bit default 1,

  -- Fields from master table
  description nvarchar(255),
  price numeric(18, 2)
)

create table VOX_MACHINA.HotelAccommodationType (
  hotel int foreign key references VOX_MACHINA.Hotel,
  code char(10) foreign key references VOX_MACHINA.AccommodationType,
  constraint PK_HotelAccommodationType primary key (hotel, code)
)

create table VOX_MACHINA.ReservationState (
  name varchar(20) primary key,
  description varchar(255)
  )

create table VOX_MACHINA.Guest (
  -- Fields from master table
  mail nvarchar(255) primary key,
  passport numeric(18),
  surname varchar(255),
  name varchar(255),
  birth_date datetime,
  address_street nvarchar(255),
  address_number smallint,
  address_floor tinyint,
  address_apt nvarchar(50),
  nationality nvarchar(255)
)

create table VOX_MACHINA.GuestInconsistencies (
  -- Fields from master table
  mail nvarchar(255),
  passport numeric(18),
  surname varchar(255),
  name varchar(255),
  birth_date datetime,
  address_street nvarchar(255),
  address_number numeric(18),
  address_floor numeric(18),
  address_apt nvarchar(50),
  nationality nvarchar(255)
)

create table VOX_MACHINA.Reservation (
  code uniqueidentifier primary key default newid(),
  date_created datetime not null,
  hotel int not null foreign key references VOX_MACHINA.Hotel,
  state varchar(20) not null foreign key references VOX_MACHINA.ReservationState,
  -- end_date datetime,

  -- Fields from master table
  start_date datetime not null,
  nights_amount smallint not null,
  old_code numeric(18), -- THIS WILL BE DELETED AFTER DATA MIGRATION

  -- Fields from master table (for Stay)
  actual_start_date datetime,
  actual_nights_amount smallint,
  accommomdation_type char(10) not null,

  constraint FK_Reservation_Accommodation
    foreign key (hotel, accommomdation_type)references VOX_MACHINA.HotelAccommodationType
)

create table VOX_MACHINA.ReservationGuest(
  code uniqueidentifier foreign key references VOX_MACHINA.Reservation,
  guest nvarchar(255) foreign key references VOX_MACHINA.Guest,
  constraint PK_ReservationGuest primary key (code, guest)
)

create table VOX_MACHINA.ReservationRoom (
  reservation uniqueidentifier not null foreign key references VOX_MACHINA.Reservation,
  hotel int not null,
  number int not null,
  constraint FK_ReservationRoom_Room foreign key (hotel, number)references VOX_MACHINA.Room
)

create table VOX_MACHINA.UserReservationModification (
  code uniqueidentifier not null foreign key references VOX_MACHINA.Reservation,
  date datetime not null,
  username varchar(50) foreign key references VOX_MACHINA.LoginUser,

  -- TODO: think about data fields 4 this
  details varchar(255)
)

create table VOX_MACHINA.GuestReservationModification (
  date datetime not null,

  code uniqueidentifier not null,
  guest nvarchar(255),
  constraint FK_GuestReservationModification_ReservationGuest foreign key(code, guest) references VOX_MACHINA.ReservationGuest,

  -- TODO: think about data fields 4 this
  details varchar(255)
)

create table VOX_MACHINA.Consumable (
  -- Fields from master table
  id int not null primary key,
  price money not null,
  description nvarchar(255)
)

create table VOX_MACHINA.ReservationConsumable (
  consumable int not null foreign key references VOX_MACHINA.Consumable,
  reservation uniqueidentifier not null foreign key references VOX_MACHINA.Reservation
)

create table VOX_MACHINA.Receipt (
  reservation uniqueidentifier not null primary key foreign key references VOX_MACHINA.Reservation,

  -- Fields from master table
  id int,
  date datetime not null,
  total money not null
)

create table VOX_MACHINA.ReceiptItem (
  reservation uniqueidentifier not null foreign key references VOX_MACHINA.Receipt,
  consumable int not null foreign key references VOX_MACHINA.Consumable,

  -- Fields from master table
  quantity int,
  price money
)

create table VOX_MACHINA.RoleCapability (
  role smallint not null foreign key references VOX_MACHINA.Role,
  capability smallint not null foreign key references VOX_MACHINA.Capability,
  constraint PK_RoleCapability primary key (role, capability)
)

go

-- Special indexes

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('VOX_MACHINA.UserRole') AND NAME ='IX_SelectedUserRole')
    DROP INDEX IX_SelectedUserRole ON VOX_MACHINA.UserRole;
GO
create unique index IX_SelectedUserRole
  on VOX_MACHINA.UserRole(selected)
  where selected = 1 -- Only one selected Role x User
go

IF EXISTS(SELECT * FROM sys.indexes WHERE object_id = object_id('VOX_MACHINA.UserRole') AND NAME ='IX_UniqueHotelAdmin')
    DROP INDEX IX_UniqueHotelAdmin ON VOX_MACHINA.UserRole;
GO
create unique index IX_UniqueHotelAdmin
  on VOX_MACHINA.UserRole(hotel, role)
  where role = 0 -- Only one admin Role x Hotel
go

-- Stats lists (.13)
-- TODO: Check join order
create view VOX_MACHINA.TopHotelsByCancellations
as
select top 5 Hotel.name, count(code) as cancellations
from VOX_MACHINA.Hotel
join VOX_MACHINA.Reservation on Reservation.hotel = Hotel.id
where Reservation.state = 'cancelled'
group by Hotel.id, Hotel.name
order by cancellations desc
go

create view VOX_MACHINA.TopHotelsByConsumables
as
select top 5 Hotel.name, sum(quantity) as consumables
from VOX_MACHINA.Hotel -- TODO: test join order
join VOX_MACHINA.Reservation on Reservation.hotel = Hotel.id
join VOX_MACHINA.ReceiptItem on ReceiptItem.reservation = Reservation.code
group by Hotel.id, Hotel.name
order by consumables desc
go

create view VOX_MACHINA.TopHotelsByClosureTime
as
select top 5 Hotel.name, sum(datediff(day, HotelClosure.start_date, HotelClosure.end_date)) as days_closed
from Hotel
join HotelClosure on Hotel.id = HotelClosure.hotel
group by Hotel.name, Hotel.id
order by days_closed desc
go

create view VOX_MACHINA.TopOccupiedRooms
as
select top 5 Hotel.name, Room.number, sum(Reservation.nights_amount) as nights_occupied
from VOX_MACHINA.Room
join VOX_MACHINA.Hotel on Room.hotel = Hotel.id
join VOX_MACHINA.ReservationRoom on ReservationRoom.hotel = Room.hotel and ReservationRoom.number = Room.number
join VOX_MACHINA.Reservation on Reservation.code = ReservationRoom.reservation
group by Hotel.name, Room.number
order by nights_occupied desc
go



-- Data from text assignment
insert into VOX_MACHINA.IdType (code) values
 ('DNI'),
  ('PPT')

-- There is no 'Guest' role, any user can be a guest
-- If they have no UserRole selected, then they must be considered a guest
insert into VOX_MACHINA.Role (name) values
  ('Administrador General'), -- Name required by assignment
  ('Admistrador'),
  ('Receptionista')

-- Insert the "Guest" role, with forced id 0
-- This is the only role which won't be user assignable, but capabilities for it will
set identity_insert VOX_MACHINA.Role on
insert into VOX_MACHINA.Role(id, name) values (0, 'Invitado')
set identity_insert VOX_MACHINA.Role off

insert into VOX_MACHINA.ReservationState (name) values
  ('new'),
  ('modified'),
  ('cancelled_reception'),
  ('cancelled_guest'),
  ('cancelled_no_show'),
  ('checked_in'),
  ('checked_out')

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

exec VOX_MACHINA.Li 6

-- Data Migration
-- First, the master tables

-- Hotel: name made up from street name, country assumed to be Argentina
insert into VOX_MACHINA.Hotel(name, city, street, street_number, stars_amount, stars_recharge)
select distinct 'Hotel ' + Hotel_Calle + ' ' + cast(Hotel_Nro_Calle as varchar(18)),
  Hotel_Ciudad, Hotel_Calle, Hotel_Nro_Calle, Hotel_CantEstrella, Hotel_Recarga_Estrella
from gd_esquema.Maestra
group by Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_Recarga_Estrella, Hotel_CantEstrella

-- Room Types
insert into VOX_MACHINA.RoomType(id, description, percentual)
select Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
from gd_esquema.Maestra
group by Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual

-- Rooms
insert into VOX_MACHINA.Room(hotel, number, floor, face)
select Hotel.id, Habitacion_Numero, Habitacion_Piso, Habitacion_Frente
from gd_esquema.Maestra
join VOX_MACHINA.Hotel on Hotel.street = Hotel_Calle and Hotel.street_number = Hotel_Nro_Calle
group by Hotel.id, Habitacion_Numero, Habitacion_Piso, Habitacion_Frente

-- Accommodation Types
insert into VOX_MACHINA.AccommodationType(description, price, code)
select Regimen_Descripcion, Regimen_Precio,
row_number() over (order by Regimen_Precio asc) as row
from gd_esquema.Maestra
group by Regimen_Descripcion, Regimen_Precio

-- Hotel Accommodation Types
insert into VOX_MACHINA.HotelAccommodationType
select Hotel.id, code
from gd_esquema.Maestra
join VOX_MACHINA.Hotel on Hotel.street = Hotel_Calle and Hotel.street_number = Hotel_Nro_Calle
join VOX_MACHINA.AccommodationType on AccommodationType.description = Regimen_Descripcion
group by Hotel.id, code, Regimen_Precio, Regimen_Descripcion

-- Users
-- Drop temp table if exists
if object_id('tempdb..#Temp_Clients') is not null drop table #Temp_Clients
go
-- First group clients to a temp table
with Maestra as (
  select Cliente_Nombre, Cliente_Apellido, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso,
         Cliente_Depto, Cliente_Nacionalidad, Cliente_Pasaporte_Nro
  from gd_esquema.Maestra
  group by Cliente_Nombre, Cliente_Apellido, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso,
           Cliente_Depto, Cliente_Nacionalidad, Cliente_Pasaporte_Nro
)
select Maestra.*, alternatives
into #Temp_Clients
from Maestra
join (
  select Cliente_Mail, count(*) as alternatives
  from Maestra
  group by Cliente_Mail
) as Grouped on Grouped.Cliente_Mail = Maestra.Cliente_Mail
-- Now insert with the temp table only the ones with non-conflictive info
insert into VOX_MACHINA.Guest(name, surname, mail, address_street, address_number,
                              address_floor, address_apt, nationality, passport)
select Cliente_Nombre, Cliente_Apellido, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto,
  Cliente_Nacionalidad, Cliente_Pasaporte_Nro
from #Temp_Clients
where alternatives = 1
-- Finally the conflictive ones
insert into VOX_MACHINA.GuestInconsistencies(name, surname, mail, address_street, address_number,
                              address_floor, address_apt, nationality, passport)
select Cliente_Nombre, Cliente_Apellido, Cliente_Mail, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto,
  Cliente_Nacionalidad, Cliente_Pasaporte_Nro
from #Temp_Clients
where alternatives <> 1
go
-- Drop the temp table
drop table #Temp_Clients
go
-- If there is no Stay associated, we mark the reservation as cancelled,
-- otherwise we assume the guest stayed and checked out
with Reservations as (
  select *, row_number() over (
    partition by Reserva_Codigo
    order by (case when Estadia_Cant_Noches is not null then 0 else 1 end) asc) as proc_stay
  from gd_esquema.Maestra
)
insert into VOX_MACHINA.Reservation(code, old_code, date_created, hotel, state, start_date, nights_amount,
                                    actual_start_date, actual_nights_amount, accommomdation_type)
select newid() as code, Reserva_Codigo, VOX_MACHINA.getCurrentDate() as date_created, Hotel.id as hotel,
       (case when Estadia_Fecha_Inicio is null then 'cancelled_no_show' else 'checked_out' end) as state,
       Reserva_Fecha_Inicio, Reserva_Cant_Noches, Estadia_Fecha_Inicio, Estadia_Cant_Noches, AccommodationType.code as accomodation_type
from Reservations
join VOX_MACHINA.Hotel on Hotel.street = Hotel_Calle and Hotel.street_number = Hotel_Nro_Calle
join VOX_MACHINA.AccommodationType on AccommodationType.price = Regimen_Precio
where proc_stay = 1
go

-- Reservations x Guests
insert into VOX_MACHINA.ReservationGuest(code, guest)
select Reservation.code, Guest.mail
from gd_esquema.Maestra
join VOX_MACHINA.Reservation on old_code = Reserva_Codigo
join VOX_MACHINA.Guest on Guest.mail = Cliente_Mail
group by Guest.mail, Reservation.code
go

-- Receipts
insert into VOX_MACHINA.Receipt(reservation, id, date, total)
select code, Factura_Nro, Factura_Fecha, Factura_Total
from gd_esquema.Maestra
join VOX_MACHINA.Reservation on old_code = Reserva_Codigo
where Reserva_Codigo is not null
  and Factura_Nro is not null
group by code, Factura_Nro, Factura_Fecha, Factura_Total
go

-- Consumables
-- Fields Item_Factura_Monto and Consumible_Precio are reversed
insert into VOX_MACHINA.Consumable(id, price, description)
select Consumible_Codigo, Item_Factura_Monto, Consumible_Descripcion
from gd_esquema.Maestra
where Consumible_Codigo is not null
group by Consumible_Codigo, Item_Factura_Monto, Consumible_Descripcion
go

-- Consumables x Reservations
-- Aux numbers cte to repeat the consumables * quantity
-- noinspection SqlResolve
with E00(N) as (select 1 union all select 1),
     E02(N) as (select 1 from E00 a, E00 b),
     E04(N) as (select 1 from E02 a, E02 b),
     E08(N) as (select 1 from E04 a, E04 b),
     ResConsumables as (
      select Consumible_Codigo, code, Item_Factura_Cantidad
      from gd_esquema.Maestra
      join VOX_MACHINA.Reservation on old_code = Reserva_Codigo
      where Reserva_Codigo is not null and Consumible_Codigo is not null
      group by code, Consumible_Codigo, Item_Factura_Cantidad
)
insert into VOX_MACHINA.ReservationConsumable(consumable, reservation)
select Consumible_Codigo, code
from ResConsumables
cross apply (
  select top (cast(Item_Factura_Cantidad as int)) N from E08
) as Numbers
go
-- Consumables x Receipts
insert into VOX_MACHINA.ReceiptItem(reservation, consumable, quantity, price)
select code, Consumible_Codigo, Item_Factura_Cantidad, Consumible_Precio
from gd_esquema.Maestra
join VOX_MACHINA.Reservation on old_code = Reserva_Codigo
where Reserva_Codigo is not null and Consumible_Codigo is not null
group by code, Consumible_Codigo, Item_Factura_Cantidad, Consumible_Precio
go




-- Use previous inserts to automate a bit
insert into VOX_MACHINA.UserRole (username, role, hotel)
select 'admin', 1, Hotel.id
from VOX_MACHINA.Hotel;

insert into VOX_MACHINA.RoleCapability (role, capability)
select 1, Capability.id
from VOX_MACHINA.Capability
go

--Add guest capabilities

insert into VOX_MACHINA.RoleCapability (role, capability)
values( 0, 3)
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