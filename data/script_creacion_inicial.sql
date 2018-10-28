-- Seleccionamos la base
use GD2C2018
go

/*
	Creamos el schema, N antes de un string es para que sea varchar
*/
if not exists(select 1 from sys.schemas where name = 'ESECUELE') 
BEGIN
	EXEC sp_executesql N'CREATE SCHEMA ESECUELE AUTHORIZATION [gd]'
END
go
-- Variables
declare @schema_name varchar(10) = 'ESECUELE'
declare @schema_id int = schema_id(@schema_name)
declare @drop_statement nvarchar(max)

/*
	Borramos todo, se concatenan los alter table en un string y se ejecutan con sp_executesql
*/
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

/*
* --------------------- Creacion de tablas. --------------------------------------
*/

/*
	Rol
	Estado 0 - Habilitado
	Estado 1 - Deshabilitado
*/
create table ESECUELE.Rol(
	rol_id tinyint identity(1,1) primary key,
	rol_nombre varchar(50) not null,
	rol_estado bit not null default 0
)
go

--Funcionalidad
create table ESECUELE.Funcionalidad(
	func_id tinyint identity(1,1) primary key,
	func_nombre varchar(30) not null
)
go

--Funcionalidad_Rol
create table ESECUELE.Funcionalidad_Rol(
	frol_rol_id tinyint,
	frol_func_id tinyint
)
go

/*
	Usuario
	Estado 0 - No habilitado
	Estado 1 - Habilitado
*/
create table ESECUELE.Usuario(
	usr_username varchar(50) primary key,
	usr_pass varbinary(8000) default null,
	usr_estado bit default 1,
	usr_nuevo bit default 1,
	usr_fallas tinyint default 0,
	usr_fecha_creacion datetime default null,
	usr_tipo varchar(7) default null,

	usr_email varchar(50) default null,
	usr_telefono varchar(20) default null,
	usr_direccion varchar(150) default null,
	usr_codigo_postal varchar(10) null
)
go

/*
	Rol_Usuario
	Seleccionado 0 - Este rol no esta siendo usado
	Seleccionado 1 - El usuario esta usando este rol
*/
create table ESECUELE.Rol_Usuario(
	rol_usr_id tinyint,
	rol_usr_username varchar(50),
	rol_usr_seleccionado bit default 0
)
go

--Tarjeta
create table ESECUELE.Tarjeta(
	tarjeta_id int identity(1,1) primary key,
	tarjeta_numero varchar(20),
	tarjeta_tipo varchar(10)
)
go

--Producto
create table ESECUELE.Producto(
	prod_id int identity(1,1) primary key,
	prod_descripcion varchar(50) default null,
	prod_puntos int default null
)
go

--Cliente
create table ESECUELE.Cliente(
	cliente_nombre varchar(50) default null,
	cliente_apellido varchar(50) default null,
	cliente_tipo_doc varchar(10) default null,
	cliente_num_doc varchar(30) default null,
	cliente_cuil varchar(30) default 'cuil',
	cliente_fecha_nacimiento datetime default null,
	cliente_datos_tarjeta int default null,
	cliente_usuario varchar(50)
	constraint PK_Cliente primary key (cliente_tipo_doc, cliente_num_doc, cliente_cuil)
)
go

--Punto
create table ESECUELE.Punto(
	punto_id int identity(1,1) primary key,
	punto_valor int default null,
	punto_usados int default null,
	punto_cliente int default null,
	punto_fecha_vencimiento datetime default null
)
go

--Canje
create table ESECUELE.Canje(
	canje_id int identity(1,1) primary key,
	canje_cliente int default null,
	canje_puntos int default null,
	canje_fecha datetime default null, 
	canje_producto int default null
)
go


--Empresa
create table ESECUELE.Empresa(
	empresa_id int identity(1,1) primary key,
	empresa_razon_social varchar(60) unique default null,
	empresa_ciudad varchar(40) default null,
	empresa_cuit varchar(30) unique default null,
	empresa_usuario varchar(50) default null
)
go

--Rubro
create table ESECUELE.Rubro(
	rubro_codigo int identity(1,1) primary key,
	rubro_descripcion varchar(50) default null
)
go

--Grado_Publicacion
create table ESECUELE.Grado(
	grado_id int identity(1,1) primary key,
	grado_descripcion varchar(5) default null,
	grado_comision decimal default null
)
go

--Publicacion
create table ESECUELE.Publicacion(
	publicacion_codigo int,
	publicacion_fecha_inicio datetime default null,
	publicacion_descripcion nvarchar(255) default null,
	publicacion_fecha_publicacion datetime default null,
	publicacion_rubro int default null,
	publicacion_direccion varchar(50) default null,
	publicacion_grado int default null,
	publicacion_usuario varchar(50) default null,
	publicacion_estado varchar(10) default null,

	constraint PK_Pub primary key (publicacion_codigo, publicacion_fecha_inicio)
)
go

--Tipo_Entrada
create table ESECUELE.Tipo_Entrada(
	tipo_entrada_id int identity(1,1) primary key,
	tipo_entrada_desc varchar(50) default null
)
go

--Entrada
create table ESECUELE.Entrada(
	entrada_id int identity(1,1) primary key,
	entrada_publicacion int default null,
	entrada_fila char default null,
	entrada_asiento int default null,
	entrada_sin_numerar bit default 0,
	entrada_precio decimal not null,
	entrada_tipo int default null
)
go

--Factura
create table ESECUELE.Factura(
	fact_id int identity(1,1) primary key,
	fact_nro int default null,
	fact_fecha datetime default null,
	fact_empresa int default null,
	fact_estado bit default 0,
	fact_total decimal default null,
	fact_forma_pago varchar(60) default null
)
go

--Item_Factura
create table ESECUELE.Item_Factura(
	item_id int identity(1,1) primary key,
	item_id_factura int default null,
	item_cantidad int default null,
	item_precio decimal default null,
	item_descripcion varchar(50) default null,
	item_entrada int default null
)
go

--Compra
create table ESECUELE.Compra(
	compra_id int identity(1,1) primary key,
	compra_entrada int default null,
	compra_total decimal not null,
	compra_cliente int default null,
	compra_fecha datetime default null,
	compra_cantidad int default null,
	compra_medio_pago int default null
)
go

/*
* --------------------- Fin Creacion de tablas. ----------------------------------
*/

/*
* --------------------- Ingreso valores default ----------------------------------
*/

insert into ESECUELE.Rol (rol_nombre) values
  ('Administrador General'),
  ('Administrador'),
  ('Cliente'),
  ('Empresa')

-- Ingreso de la cuenta para el administrador general
insert into ESECUELE.Usuario (usr_username, usr_pass) values
  ('admin', hashbytes('SHA2_256', 'w23e'))

-- Se ingresan todas las funcionalidades
insert into ESECUELE.Funcionalidad (func_nombre) values
  ('Gestionar roles'),
  ('Gestionar usuarios'),
  ('Modificar rol')
go

-- Ingreso valores para el administrador greneral
insert into ESECUELE.Rol_Usuario (rol_usr_id, rol_usr_username)
values (0,'admin')

insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id)
select 0, func_id
from ESECUELE.Funcionalidad
go

/*
* --------------------- Fin ingreso valores default ------------------------------
*/

/*--------------------------- Migracion de datos --------------------------------*/
-- Carga de Empresas
insert into ESECUELE.Empresa 
(empresa_razon_social, 
empresa_cuit, 
empresa_usuario)

select distinct 
Espec_Empresa_Razon_Social, 
Espec_Empresa_Cuit, 
CONCAT('usr_', Espec_Empresa_Cuit)
from gd_esquema.Maestra

insert into ESECUELE.Usuario 
(usr_username, 
usr_pass, 
usr_tipo, 
usr_email, 
usr_direccion, 
usr_codigo_postal, 
usr_fecha_creacion)

select distinct 
CONCAT('usr_', Espec_Empresa_Cuit),
(SELECT HASHBYTES('SHA2_256', Espec_Empresa_Cuit)),
'Empresa',
Espec_Empresa_Mail,
CONCAT(Espec_Empresa_Dom_Calle, ' ', Espec_Empresa_Nro_Calle, ', piso ',Espec_Empresa_Piso, ', dpto ', Espec_Empresa_Depto),
Espec_Empresa_Cod_Postal,
Espec_Empresa_Fecha_Creacion
from gd_esquema.Maestra
-- Fin de Carga de Empresas



-- Carga de Espectaculos
insert into ESECUELE.Publicacion
(publicacion_codigo, 
publicacion_fecha_inicio, 
publicacion_descripcion, 
publicacion_fecha_publicacion,
publicacion_rubro, 
publicacion_estado)

select distinct
Espectaculo_Cod, 
Espectaculo_Fecha_Venc,
Espectaculo_Descripcion, 
Espectaculo_Fecha,  
Espectaculo_Rubro_Descripcion,
Espectaculo_Estado
 from gd_esquema.Maestra order by Espectaculo_Cod
-- Fin de Carga de Espectaculos

-- Carga de Entradas
insert into ESECUELE.Entrada
(entrada_fila, entrada_asiento, entrada_sin_numerar, entrada_precio, entrada_tipo)
select distinct
Ubicacion_Fila, 
Ubicacion_Asiento, 
Ubicacion_Sin_numerar, 
Ubicacion_Precio, 
Ubicacion_Tipo_Codigo
from gd_esquema.Maestra
-- Fin de Carga de Entradas

-- Carga de Tipos de Entradas
SET IDENTITY_INSERT ESECUELE.Tipo_Entrada ON;
insert into ESECUELE.Tipo_Entrada
(tipo_entrada_id, tipo_entrada_desc)
select distinct Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion
from gd_esquema.Maestra
SET IDENTITY_INSERT ESECUELE.Tipo_Entrada OFF;
-- Fin de Carga de Tipos de Entradas

-- Carga de Cliente
insert into ESECUELE.Usuario
(usr_username,
usr_pass,
usr_tipo,
usr_email,
usr_direccion,
usr_codigo_postal
)
select distinct
concat('cli_', Cli_Dni),
(SELECT HASHBYTES('SHA2_256', concat('cli_', Cli_Dni))),
'Cliente',
Cli_Mail,
concat(Cli_Dom_Calle, ', ', Cli_Nro_Calle, ', piso ', Cli_Piso, ', ', Cli_Depto),
Cli_Cod_Postal
from gd_esquema.Maestra where Cli_Dni is not null

insert into ESECUELE.Cliente
(cliente_nombre, 
cliente_apellido, 
cliente_tipo_doc, 
cliente_num_doc, 
cliente_fecha_nacimiento,
cliente_usuario)

select distinct
Cli_Nombre,
Cli_Apeliido,
'DNI',
Cli_Dni,
Cli_Fecha_Nac,
concat('cli_', Cli_Dni)
from gd_esquema.Maestra where Cli_Dni is not null
-- Fin de Carga de Cliente




/*----------------------- Fin Migracion de datos --------------------------------*/

/*--------------------------- Creacion de restricciones -------------------------*/
-- Relacion Empresa - Usuario
alter table ESECUELE.Empresa add constraint FK_Emp_UserName foreign key (empresa_usuario) references ESECUELE.Usuario(usr_username)

-- Relacion Publicacion - Usuario
alter table ESECUELE.Publicacion add constraint FK_Pub_UserName foreign key (publicacion_usuario) references ESECUELE.Usuario(usr_username)

-- Relacion Entrada - Tipo_Entrada
alter table ESECUELE.Entrada add constraint FK_Tipo_Entrada foreign key(entrada_tipo) references ESECUELE.Tipo_Entrada(tipo_entrada_id)

-- Relacion Cliente - Usuario
alter table ESECUELE.Cliente add constraint FK_Cli_UserName foreign key (cliente_usuario) references ESECUELE.Usuario(usr_username)
go
/*------------------------Fin Creacion de restricciones -------------------------*/


/*--------------------------- Store procedures ----------------------------------*/

create procedure ESECUELE.SeleccionarRol(@username varchar(50), @role tinyint)
as begin
  update ESECUELE.Rol_Usuario
    set rol_usr_seleccionado = case when rol_usr_id = @role then 1 else -1 end
    where rol_usr_username = @username
end
go

create procedure ESECUELE.DeseleccionarRol(@username varchar(50), @role tinyint)
as
begin
  update ESECUELE.Rol_Usuario
    set rol_usr_seleccionado = case when rol_usr_id = @role then 0 else -1 end
    where rol_usr_username = @username
end
go

create procedure ESECUELE.LimpiarHabilitarUsuario(@username varchar(50))
as
begin
	  update ESECUELE.Usuario
		set usr_fallas = 0, usr_estado= 1
		where usr_username = @username
end
go

-- Sproc para loguear
-- Returns -1 if login failed, the user is disabled
-- Returns -2 if password incorrect
-- Returns -3 if user doesnt exist
-- Returns -4 if no user has no roles assigned( dont know if can happen)
-- 0 if the login succeeded but there are many roles to choose from, or
-- positive integers if there was only one role and was automatically assigned
create procedure ESECUELE.Login(@username varchar(50), @plain_password varchar(100), @return_val smallint output)
as begin
  declare @estado bit = null
  declare @password binary(32) = null
  declare @fallos tinyint = null

  declare @usuario_no_habilitado smallint
  declare @password_incorrecto smallint
  declare @usuario_no_existe smallint
  declare @usuario_no_tiene_roles smallint
  declare @login_exitoso_muchos_roles smallint

  set @usuario_no_habilitado = -1
  set @password_incorrecto = -2
  set @usuario_no_existe = -3
  set @usuario_no_tiene_roles = -4
  set @login_exitoso_muchos_roles = -5

  select @estado = usr_estado, @fallos = usr_fallas, @password = usr_pass
  from ESECUELE.Usuario
  where usr_username = @username

  if @estado = 0
  begin
    select @return_val = @usuario_no_habilitado
	return
  end
  if @password is null
  begin
	select @return_val = @usuario_no_existe
	return
  end

  -- Si el usuario existe, checkeo passwords
  if @password <> hashbytes('SHA2_256', @plain_password)
  begin
    -- Si hay fallo, incremento
    set @fallos = @fallos + 1
    update ESECUELE.Usuario
      set usr_fallas = @fallos,
          usr_estado = case when @fallos >= 3  or usr_estado = 0 then 0
                          else 1 end
      where usr_username = @username
    set @return_val = @password_incorrecto
  end
  else begin
    -- Como el login fue exitoso, limpiar los logueos fallidos
    exec ESECUELE.LimpiarHabilitarUsuario @username

    -- Obtener los roles del usuario
    declare @role smallint
    declare @count smallint
    select @count = count(R.rol_id), @role = max(R.rol_id)
      from ESECUELE.Rol_Usuario RU left join ESECUELE.Rol R on R.rol_id = RU.rol_usr_id
      where RU.rol_usr_username = @username and R.rol_estado = 1 -- Rol habilitado
    if @count > 1
      set @return_val = @login_exitoso_muchos_roles
    else if @count < 1
		select @return_val = @usuario_no_tiene_roles
	else begin
      exec SeleccionarRol @username, @role
      set @return_val = @role -- Retorno el unico rol disponible
    end
  end
end
go

create procedure ESECUELE.ListarFuncionalidades(@role smallint)
as begin
	select F.func_id, F.func_nombre
	from ESECUELE.Funcionalidad F join ESECUELE.Funcionalidad_Rol FR on FR.frol_func_id = F.func_id
	where FR.frol_rol_id = @role
end
go
