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
  --Agrego tipos por ahora
  select @drop_statement = isnull(@drop_statement, '') +
  ' drop type [' + @schema_name + '].[' + name + '];' + char(13)
  from sys.types
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
	Estado 0 - Deshabilitado
	Estado 1 - Habilitado
*/
create table ESECUELE.Rol(
	rol_id tinyint identity(1,1) primary key,
	rol_nombre varchar(50) not null unique,
	rol_estado bit not null default 1
)
go

--Funcionalidad
create table ESECUELE.Funcionalidad(
	func_id tinyint identity(1,1) primary key,
	func_nombre varchar(30) not null,
	func_desc varchar(50) not null
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
	usr_id int identity(1,1),
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
	rol_usr_rol_id tinyint not null,
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
	cliente_id int identity(1,1),
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
	empresa_id int identity(1,1),
	empresa_razon_social varchar(60),
	empresa_ciudad varchar(40) default null,
	empresa_cuit varchar(30),
	empresa_usuario varchar(50) default null,
	constraint PK_Empresa primary key (empresa_razon_social, empresa_cuit)
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
	publicacion_empresa int default null,
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
	entrada_id int identity(1,1),
	entrada_publicacion int default null,
	entrada_fila char default null,
	entrada_asiento int default null,
	entrada_sin_numerar bit default 0,
	entrada_precio decimal not null,
	entrada_tipo int default null
	constraint PK_Entrada primary key (entrada_publicacion, entrada_fila, entrada_asiento, entrada_tipo)
)
go

--Factura
create table ESECUELE.Factura(
	fact_id int identity(1,1),
	fact_nro int primary key,
	fact_fecha datetime default null,
	fact_empresa int default null,
	fact_estado bit default 0,
	fact_total decimal default null
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
	compra_medio_pago int default 1
)
go

--Medio de pago
create table ESECUELE.Medio_de_Pago(
	medio_pago_id tinyint identity(1,1) primary key,
	medio_pago_descripcion varchar(40) default null
)
go

/*
* --------------------- Fin Creacion de tablas. ----------------------------------
*/

/*
* --------------------- Ingreso valores default ----------------------------------
*/

insert into ESECUELE.Rol (rol_nombre) values
  ('Administrador'),
  ('Cliente'),
  ('Empresa')

-- Ingreso de la cuenta para el administrador general
insert into ESECUELE.Usuario (usr_username, usr_pass) values
  ('admin', hashbytes('SHA2_256', 'w23e'))

-- Se ingresan todas las funcionalidades
insert into ESECUELE.Funcionalidad (func_nombre, func_desc) values
  ('Cliente_Listado', 'Listado de Clientes.'),
  ('Cliente_Registro', 'Registro de Clientes.'),
  ('Comisiones_Detalle', 'Detalle de Comisiones.'),
  ('Empresa_Listado', 'Listado de Empresas.'),
  ('Empresa_Registro', 'Registro de Empresas.'),
  ('Estadisticas', 'Estadisticas.'),
  ('Rol_Listado', 'Listado de Roles.'),
  ('Canje_Puntos', 'Canje de Puntos.'),
  ('Compra', 'Compras.'),
  ('Historial', 'Historial.'),
  ('Publicacion_Detalle', 'Detalle de Publicaciones.'),
  ('Publicacion_Listado', 'Listado de Publicaciones.')
go

-- Ingreso de valores para Funcionalidad - Rol
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,1)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,2)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,3)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,4)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,5)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,6)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,7)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (1,8)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,9)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,10)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,11)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (3,12)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (3,13)

-- Ingreso valores para el administrador greneral
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (1,'admin')
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (2,'admin')
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (3,'admin')

-- Ingreso de medios de pago
insert into ESECUELE.Medio_de_Pago (medio_pago_descripcion) values('EFECTIVO')
insert into ESECUELE.Medio_de_Pago (medio_pago_descripcion) values('T_CREDITO')
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
publicacion_empresa, 
publicacion_estado)

select distinct
Espectaculo_Cod, 
Espectaculo_Fecha_Venc,
Espectaculo_Descripcion, 
Espectaculo_Fecha,  
Espectaculo_Rubro_Descripcion,
(select empresa_id from ESECUELE.Empresa where empresa_usuario = CONCAT('usr_', Espec_Empresa_Cuit)),
Espectaculo_Estado
 from gd_esquema.Maestra
-- Fin de Carga de Espectaculos

-- Carga de Entradas
insert into ESECUELE.Entrada
(entrada_publicacion,entrada_fila, entrada_asiento, entrada_sin_numerar, entrada_precio, entrada_tipo)
select distinct
Espectaculo_Cod,
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

-- Carga de Compras
insert into ESECUELE.Compra
(compra_entrada,
compra_total,
compra_cliente,
compra_fecha,
compra_cantidad)

select 
(select e.entrada_id from ESECUELE.Entrada e 
where e.entrada_fila = m.Ubicacion_Fila and e.entrada_asiento = m.Ubicacion_Asiento
and e.entrada_publicacion = m.Espectaculo_Cod and e.entrada_tipo = m.Ubicacion_Tipo_Codigo),
(m.Ubicacion_Precio*m.Compra_Cantidad),
(select c.cliente_id from ESECUELE.Cliente c 
where c.cliente_tipo_doc = 'DNI' and c.cliente_cuil = 'cuil' and c.cliente_num_doc = m.Cli_Dni),
m.Compra_Fecha,
m.Compra_Cantidad
from gd_esquema.Maestra m 
where m.Compra_Cantidad is not null and m.Compra_Fecha is not null
-- Fin de Carga de Compras

-- Carga de Facturas
insert into ESECUELE.Factura
(fact_nro,
fact_fecha,
fact_empresa,
fact_total)

select distinct
m.Factura_Nro, 
m.Factura_Fecha, 
(select empresa_id from ESECUELE.Empresa where 
empresa_razon_social = m.Espec_Empresa_Razon_Social and empresa_cuit = m.Espec_Empresa_Cuit),
m.Factura_Total
 from gd_esquema.Maestra m
 where Factura_Nro is not null and Factura_Fecha is not null and Factura_Total is not null
-- Fin de Carga de Facturas

-- Carga de Item_Factura
insert into ESECUELE.Item_Factura
(item_id_factura,
item_cantidad,
item_precio,
item_descripcion,
item_entrada)

select 
distinct
m.Factura_Nro, 
m.Item_Factura_Cantidad, 
m.Item_Factura_Monto, 
Item_Factura_Descripcion,
(select entrada_id from ESECUELE.Entrada where 
entrada_asiento = m.Ubicacion_Asiento and entrada_fila = m.Ubicacion_Fila 
and entrada_publicacion = m.Espectaculo_Cod and entrada_tipo = m.Ubicacion_Tipo_Codigo) from gd_esquema.Maestra m 
where 
m.Item_Factura_Monto is not null and 
m.Item_Factura_Cantidad is not null and 
m.Item_Factura_Descripcion is not null 
-- Fin de Carga de Item_Factura

/*----------------------- Fin Migracion de datos --------------------------------*/

/*--------------------------- Creacion de restricciones -------------------------*/
-- Indices
create unique index index_usr_id on ESECUELE.Usuario(usr_id)
create unique index index_client_id on ESECUELE.Cliente(cliente_id)
create unique index index_empresa_id on ESECUELE.Empresa(empresa_id)
create unique index index_entrada_id on ESECUELE.Entrada(entrada_id)

-- Relacion Rol_Usuario
alter table ESECUELE.Rol_Usuario add constraint FK_RU_RolId foreign key(rol_usr_rol_id) references ESECUELE.Rol(rol_id)
alter table ESECUELE.Rol_Usuario add constraint FK_UsrId foreign key(rol_usr_username) references ESECUELE.Usuario(usr_username)

-- Relacion Funcionalidad_Rol
alter table ESECUELE.Funcionalidad_Rol add constraint FK_FuncId foreign key(frol_func_id) references ESECUELE.Funcionalidad(func_id)
alter table ESECUELE.Funcionalidad_Rol add constraint FK_FR_RolId foreign key(frol_rol_id) references ESECUELE.Rol(rol_id)

-- Relacion Empresa - Usuario
alter table ESECUELE.Empresa add constraint FK_Emp_UserName foreign key (empresa_usuario) references ESECUELE.Usuario(usr_username)

-- Relacion Publicacion -Empresa
alter table ESECUELE.Publicacion add constraint FK_EmpId foreign key (publicacion_empresa) references ESECUELE.Empresa(empresa_id)

-- Relacion Entrada - Tipo_Entrada
alter table ESECUELE.Entrada add constraint FK_Tipo_Entrada foreign key(entrada_tipo) references ESECUELE.Tipo_Entrada(tipo_entrada_id)

-- Relacion Cliente - Usuario
alter table ESECUELE.Cliente add constraint FK_Cli_UserName foreign key (cliente_usuario) references ESECUELE.Usuario(usr_username)

-- Relacion Compra - Cliente
alter table ESECUELE.Compra add constraint FK_Comp_Clie foreign key (compra_cliente) references ESECUELE.Cliente(cliente_id)

-- Relacion Compra - Entrada
alter table ESECUELE.Compra add constraint FK_Comp_Entrada foreign key (compra_entrada) references ESECUELE.Entrada(entrada_id)

-- Relacion Canje - Cliente
alter table ESECUELE.Canje add constraint FK_ClieId foreign key(canje_cliente) references ESECUELE.Cliente(cliente_id)

-- Relacion Canje - Producto
alter table ESECUELE.Canje add constraint FK_ProdId foreign key(canje_producto) references ESECUELE.Producto(prod_id)

-- Relacion Cliente - Tarjeta
alter table ESECUELE.Cliente add constraint FK_TarjId foreign key(cliente_datos_tarjeta) references ESECUELE.Tarjeta(tarjeta_id)

-- Relacion Punto - Cliente
alter table ESECUELE.Punto add constraint FK_P_ClieId foreign key(punto_cliente) references ESECUELE.Cliente(cliente_id)

-- Relacion Factura - Empresa
alter table ESECUELE.Factura add constraint FK_F_EmpId foreign key(fact_empresa) references ESECUELE.Empresa(empresa_id)



go
/*------------------------Fin Creacion de restricciones -------------------------*/


/*--------------------------- Store procedures ----------------------------------*/

create procedure ESECUELE.SeleccionarRol(@username varchar(50), @role tinyint)
as begin
  update ESECUELE.Rol_Usuario
    set rol_usr_seleccionado = case when rol_usr_rol_id = @role then 1 else -1 end
    where rol_usr_username = @username
end
go

create procedure ESECUELE.DeseleccionarRol(@username varchar(50), @role tinyint)
as
begin
  update ESECUELE.Rol_Usuario
    set rol_usr_seleccionado = case when rol_usr_rol_id = @role then 0 else -1 end
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
      from ESECUELE.Rol_Usuario RU left join ESECUELE.Rol R on R.rol_id = RU.rol_usr_rol_id
      where RU.rol_usr_username = @username and R.rol_estado = 1 -- Rol habilitado
    if @count > 1
      set @return_val = @login_exitoso_muchos_roles
    else if @count < 1
		select @return_val = @usuario_no_tiene_roles
	else begin
      exec ESECUELE.SeleccionarRol @username, @role
      set @return_val = @role -- Retorno el unico rol disponible
    end
  end
end
go

create procedure ESECUELE.getFuncionalidades(@role smallint)
as begin
	select F.func_id, F.func_nombre, F.func_desc
	from ESECUELE.Funcionalidad F join ESECUELE.Funcionalidad_Rol FR on FR.frol_func_id = F.func_id
	where FR.frol_rol_id = @role
end
go

create procedure ESECUELE.getFullListFuncionalidad
as begin
	select *
	from ESECUELE.Funcionalidad
end
go

create procedure ESECUELE.getUsuario(@username varchar(50))
as begin
	select * from ESECUELE.Usuario u join ESECUELE.Rol_Usuario r on u.usr_username = r.rol_usr_username
	where u.usr_username = @username
end
go 

create procedure ESECUELE.getCliente(@id int)
as begin
	select * from ESECUELE.Cliente c join ESECUELE.Usuario u on u.usr_username = c.cliente_usuario
	where c.cliente_id = @id
end
go 

create procedure ESECUELE.getRol(@id tinyint)
as begin
	select * from ESECUELE.Rol r where r.rol_id = @id
end
go 

create procedure ESECUELE.SaveRol( @rol_nombre_nuevo varchar(50), @return_val smallint output)
as begin
	begin try
		insert into Rol(rol_nombre, rol_estado)
		values(@rol_nombre_nuevo,1)
		select @return_val = rol_id from ESECUELE.Rol where rol_nombre = @rol_nombre_nuevo
	end try
	begin catch
		declare @msg VARCHAR(100)
		set @msg = formatmessage('El rol %s ya existe.', @rol_nombre_nuevo)
		raiserror(@msg,18,9)
	end catch
end
go

CREATE TYPE ESECUELE.FuncRolType AS TABLE
(
    frol_rol_id tinyint,
    frol_func_id tinyint
);
go

create procedure ESECUELE.SaveRolFuncionalidades( @func_nuevo_rol as ESECUELE.FuncRolType readonly)
as begin
	begin try
	insert into Funcionalidad_Rol(frol_rol_id,frol_func_id) select frol_rol_id, frol_func_id from @func_nuevo_rol
	end try
	begin catch
		raiserror('Error insercion de funcionalidad_rol', 18, 10)
	end catch
end
go

create procedure ESECUELE.DeleteRol( @rol_id smallint)
as begin
	update ESECUELE.Rol set rol_estado = 0 where rol_id = @rol_id
end
go

create procedure ESECUELE.HabilitarRol( @rol_id smallint)
as begin
	update ESECUELE.Rol set rol_estado = 1 where rol_id = @rol_id
end
go

create procedure ESECUELE.SaveUsuario(@usr_username varchar(50), 
								   @usr_pass varchar(50),
								   @usr_tipo varchar(7),
								   @usr_email varchar(50),
								   @usr_telefono varchar(20),
								   @usr_direccion varchar(150),
								   @usr_codigo_postal varchar(10), 
								   @return_val int output) as
begin 
	begin try
		declare @encryptedPass varbinary(8000);
		set @encryptedPass = (SELECT HASHBYTES('SHA2_256', @usr_pass));  
		insert into ESECUELE.Usuario
		(usr_username, usr_pass, usr_estado, usr_nuevo, usr_fecha_creacion, usr_tipo, usr_email, usr_telefono, usr_direccion, usr_codigo_postal) 
		values(@usr_username, @encryptedPass, 1, 0, getdate(), @usr_tipo, @usr_email, @usr_telefono, @usr_direccion, @usr_codigo_postal)
		set @return_val = (SELECT SCOPE_IDENTITY())
	end try
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.SaveEmpresa(@empresa_razon_social varchar(60), 
								   @empresa_ciudad varchar(40),
								   @empresa_cuit varchar(30),
								   @empresa_usuario varchar(50)) as
begin 
	begin try
		insert into ESECUELE.Empresa
		(empresa_razon_social, empresa_ciudad, empresa_cuit, empresa_usuario) 
		values(@empresa_razon_social, @empresa_ciudad, @empresa_cuit, @empresa_usuario)
	end try
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.SaveCliente(@cliente_nombre varchar(50), 
								   @cliente_apellido varchar(50),
								   @cliente_tipo_doc varchar(10),
								   @cliente_num_doc varchar(30),
								   @cliente_cuil varchar(30),
								   @cliente_fecha_nacimiento datetime,
								   @cliente_usuario varchar(50)) as
begin 
	begin try
		insert into ESECUELE.Cliente
		(cliente_nombre, cliente_apellido, cliente_tipo_doc, cliente_num_doc, cliente_cuil, cliente_fecha_nacimiento, cliente_usuario) 
		values(@cliente_nombre, @cliente_apellido, @cliente_tipo_doc, @cliente_num_doc, @cliente_cuil, @cliente_fecha_nacimiento, @cliente_usuario)
	end try
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.DeleteUsuario(@usr_id int) as
begin
	begin try
		delete from ESECUELE.Usuario where usr_id = @usr_id
	end try
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.SaveRolUsuario(@rolName varchar(20), @username varchar(40)) as
begin
	begin try
		insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username, rol_usr_seleccionado)
		select rol_id , @username, 1 from ESECUELE.Rol where rol_nombre = @rolName
	end try
	
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.SearchClients(@nombre varchar(50) = null, 
							  @apellido varchar(50) = null, 
							  @dni varchar(30) = null, 
							  @email varchar(50) = null)
as
begin
	declare @where bit
	set @where = 0
	declare @query nvarchar(500);
	set @query = N'select * from ESECUELE.Cliente c join ESECUELE.Usuario u on c.cliente_usuario = u.usr_username';

	if @nombre is not null or  @apellido is not null or @dni is not null or @email is not null
	begin
		set @query = @query + ' where '
		if @nombre is not null 
		begin
			set @query = @query + 'c.cliente_nombre like ''%'	+ @nombre + '%'''
			set @where = 1
		end

		if @apellido is not null 
		begin
			if @where = 0
				begin
					set @query = @query + 'c.cliente_apellido like ''%'	+ @apellido + '%'''
					set @where = 1
				end
			else set @query = @query + ' and c.cliente_apellido like ''%'	+ @apellido + '%'''
		end

		if @dni is not null 
		begin
			if @where = 0
				begin
					set @query = @query + 'c.cliente_num_doc like ''%'	+ @dni + '%'''
					set @where = 1
				end
			else set @query = @query + ' and c.cliente_num_doc like ''%'	+ @dni + '%'''
		end

		if @email is not null 
		begin
			if @where = 0
				begin
					set @query = @query + 'u.usr_email like ''%'	+ @email + '%'''
					set @where = 1
				end
			else set @query = @query + ' and u.usr_email like ''%' + @email + '%'''
		end
	end

	exec sp_executesql @query
end
go

create procedure ESECUELE.ChangeClientStatus(@id int) as
begin
	begin try
		declare @currentStatus bit
		declare @username varchar(50)
		
		select @currentStatus = u.usr_estado, @username = u.usr_username 
		from ESECUELE.Usuario u join ESECUELE.Cliente c 
		on u.usr_username = c.cliente_usuario where c.cliente_id = @id
		
		declare @newStatus bit
		
		if @currentStatus = 1 
			set @newStatus = 0
		else 
			set @newStatus = 1

		update ESECUELE.Usuario set usr_estado = @newStatus where usr_username = @username
	end try
	begin catch
		throw
	end catch
end

CREATE TYPE ESECUELE.FunConCamnbios AS TABLE
(
    frol_rol_id tinyint,
    frol_func_id tinyint,
	fun_estado tinyint
);
go

create procedure ESECUELE.ActualizarFuncionalidades( @funs_con_cambios as ESECUELE.FunConCamnbios readonly)
as begin
	declare @Nuevo tinyint
	declare @rol_id tinyint
    declare @func_id tinyint
	declare @estado tinyint
	set @Nuevo = 2
	declare funcionalidades cursor for(  select N.frol_rol_id, N.frol_func_id, N.fun_estado from @funs_con_cambios N )
	begin try
		open funcionalidades
		fetch next from funcionalidades into @rol_id, @func_id, @estado
		while @@FETCH_STATUS = 0
			begin
				if(@estado = @Nuevo)
					insert into Funcionalidad_Rol values( @rol_id, @func_id )
				else
					delete from Funcionalidad_Rol where frol_rol_id = @rol_id and frol_func_id = @func_id

				fetch next from funcionalidades into @rol_id, @func_id, @estado
			end
		close funcionalidades
		deallocate funcionalidades
	end try
	begin catch
		raiserror('Error actualizacion de funcionalidades', 18, 10)
	end catch
end
go