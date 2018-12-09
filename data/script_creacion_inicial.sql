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
  ' drop trigger ['  + @schema_name + '].[' + name + '];' + char(13)
  from sys.objects
  where schema_id = @schema_id
  and type in ('TR')
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
	frol_rol_id tinyint not null,
	frol_func_id tinyint not null
)
go

/*
	Usuario
	Estado 0 - No habilitado
	Estado 1 - Habilitado
	Primer Login 1 --> Necesita cambiar su password
*/
create table ESECUELE.Usuario(
	usr_id int identity(1,1),
	usr_username varchar(50) primary key,
	usr_pass nvarchar(100) default null,
	usr_estado bit default 1,
	usr_primer_login bit default 1,
	usr_fallas tinyint default 0,
	usr_fecha_creacion datetime default null,
	usr_tipo varchar(7) default null,
	usr_email varchar(50) default null,
	usr_telefono varchar(20) default null,
	usr_direccion varchar(150) default null,
	usr_codigo_postal varchar(10) null
)
go

--Rol_Usuario
create table ESECUELE.Rol_Usuario(
	rol_usr_rol_id tinyint not null,
	rol_usr_username varchar(50)
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
	grado_comision numeric(18,2) default null
)
go

--Publicacion
create table ESECUELE.Publicacion(
	publicacion_codigo int identity(1,1),
	publicacion_fecha_inicio datetime default null,
	publicacion_descripcion nvarchar(255) default null,
	publicacion_fecha_evento datetime default null,
	publicacion_rubro int default null,
	publicacion_direccion varchar(50) default null,
	publicacion_grado int default null,
	publicacion_empresa int default null,
	publicacion_estado varchar(10) default null,

	constraint PK_Pub primary key (publicacion_codigo, publicacion_fecha_inicio)
)
go

--Tipo_Entrada
create table ESECUELE.Tipo_Ubicacion(
	tipo_ubicacion_id int identity(1,1) primary key,
	tipo_ubicacion_desc varchar(50) default null
)
go

--Ubicacion
-- Si es sin numerar cant filas estara null
create table ESECUELE.Ubicacion(
	ubicacion_id int identity(1,1) primary key,
	ubicacion_publicacion int not null,
	ubicacion_cant_filas int default null,
	ubicacion_cant_asientos int not null,
	ubicacion_precio numeric(18,2) not null,
	ubicacion_sin_numerar bit default 0, -- 1 Sin numerar , 0 numerada
	ubicacion_asientos_ocupados int not null,
	ubicacion_tipo int not null
)
go

--Entrada
-- Si fila y asiento son null, es una entrada sin numerar
create table ESECUELE.Entrada(
	entrada_id int identity(1,1) primary key,
	entrada_compra int default null,
	entrada_ubicacion int default null,
	entrada_fila int default null,
	entrada_asiento int default null,
)
go

--Factura
create table ESECUELE.Factura(
	fact_id int identity(1,1) primary key,
	fact_fecha datetime default null,
	fact_empresa int default null,
	fact_estado bit default 0,
	fact_total numeric(18,2) default null,
	fact_forma_pago varchar(60) default null
)
go

--Item_Factura
create table ESECUELE.Item_Factura(
	item_id int identity(1,1) primary key,
	item_id_factura int default null,
	item_monto numeric(18,2) default null,
	item_descripcion varchar(50) default null,
	item_cantidad int not null,
	item_entrada int not null
)
go

--Compra
create table ESECUELE.Compra(
	compra_id int identity(1,1) primary key,
	compra_total numeric(18,2) not null,
	compra_cliente int default null,
	compra_fecha datetime default null,
	compra_medio_pago tinyint default null
)
go

--Medio de pago
create table ESECUELE.Medio_de_Pago(
	medio_pago_id tinyint identity(1,1) primary key,
	medio_pago_nro_tarjeta varchar(40) default null
)
go

--alter table ESECUELE.Compra add constraint FK_Comp_MPago foreign key (compra_medio_pago) references ESECUELE.Medio_de_Pago(medio_pago_id)

/*
* --------------------- Fin Creacion de tablas. ----------------------------------
*/

/*
* ------------------------- Creacion de funciones ----------------------------------
*/
create function ESECUELE.GetHash(@password nvarchar(100))
returns nvarchar(100)
as begin
	declare @hash as varbinary(100) = HASHBYTES('SHA2_256', @password );

	declare @result as nvarchar(100) = CONVERT(NVARCHAR(100), @hash, 2);

	return @result;
end
go

create function ESECUELE.LetraANumero(@letra varchar(3))
returns int
as begin
		if @letra = 'A' 
			return 1
		else if @letra = 'B'
			return 2
		else if @letra = 'C'
			return 3
		else if @letra = 'D'
			return 4
		else if @letra = 'E'
			return 5
		else if @letra = 'F'
			return 6
		else if @letra = 'G'
			return 7
		else if @letra = 'H'
			return 8
		else if @letra = 'I'
			return 9
		else if @letra = 'J'
			return 10
		return 0	
end
go

create function ESECUELE.ObtenerClienteId(@dni numeric(18,0))
returns int
as begin
	return 	(select c.cliente_id
			from ESECUELE.Cliente c
			where c.cliente_tipo_doc = 'DNI' and c.cliente_num_doc = @dni)
end
go

/*
* --------------------- Fin Creacion de funciones. ----------------------------------
*/

/*
* --------------------- Ingreso valores default ----------------------------------
*/

insert into ESECUELE.Rol (rol_nombre) values
  ('Administrador'),
  ('Cliente'),
  ('Empresa')

-- Ingreso de la cuenta para el administrador general
insert into ESECUELE.Usuario (usr_username, usr_pass, usr_primer_login) values
  ('admin', ESECUELE.GetHash('w23e'), 0)

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
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,8)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,9)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (2,10)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (3,11)
insert into ESECUELE.Funcionalidad_Rol (frol_rol_id, frol_func_id) values (3,12)

-- Ingreso valores para el administrador greneral
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (1,'admin')
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (2,'admin')
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username) values (3,'admin')

/*-- Ingreso de medios de pago
insert into ESECUELE.Medio_de_Pago (medio_pago_descripcion) values('EFECTIVO')
insert into ESECUELE.Medio_de_Pago (medio_pago_descripcion) values('T_CREDITO')
go
*/
-- Ingreso Rubros
insert into ESECUELE.Rubro (rubro_descripcion) values 
('Teatro'),('Cine'), ('Musical'), ('Deportivo'), ('Conferencia'), ('Festival'), ('Otro')

-- Ingreso Grados
insert into ESECUELE.Grado (grado_descripcion, grado_comision) values
('Alta', 0.30), ('Media', 0.2), ('Baja', 0.1)
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
ESECUELE.GetHash(Espec_Empresa_Cuit),
'Empresa',
Espec_Empresa_Mail,
CONCAT(Espec_Empresa_Dom_Calle, ' ', Espec_Empresa_Nro_Calle, ',',Espec_Empresa_Piso, ',', Espec_Empresa_Depto, ','),
Espec_Empresa_Cod_Postal,
Espec_Empresa_Fecha_Creacion
from gd_esquema.Maestra
-- Fin de Carga de Empresas

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
ESECUELE.GetHash(Cli_Dni),
'Cliente',
Cli_Mail,
concat(Cli_Dom_Calle, ' ', Cli_Nro_Calle, ',', Cli_Piso, ',', Cli_Depto, ','),
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

-- Carga de Espectaculos
SET IDENTITY_INSERT ESECUELE.Publicacion ON
insert into ESECUELE.Publicacion
(publicacion_codigo, 
publicacion_fecha_inicio, 
publicacion_descripcion, 
publicacion_fecha_evento,
publicacion_rubro,
publicacion_empresa, 
publicacion_estado)

select distinct
Espectaculo_Cod, 
Espectaculo_Fecha_Venc,
Espectaculo_Descripcion, 
Espectaculo_Fecha,  
case when Espectaculo_Rubro_Descripcion = '' then 7 end,
(select empresa_id from ESECUELE.Empresa where empresa_usuario = CONCAT('usr_', Espec_Empresa_Cuit)),
Espectaculo_Estado
 from gd_esquema.Maestra
 SET IDENTITY_INSERT ESECUELE.Publicacion OFF
-- Fin de Carga de Espectaculos

-- Carga de Tipos de Ubicaciones
SET IDENTITY_INSERT ESECUELE.Tipo_Ubicacion ON
insert into ESECUELE.Tipo_Ubicacion
(tipo_ubicacion_id, tipo_ubicacion_desc)
select distinct Ubicacion_Tipo_Codigo, Ubicacion_Tipo_Descripcion
from gd_esquema.Maestra
SET IDENTITY_INSERT ESECUELE.Tipo_Ubicacion OFF
-- Fin de Carga de Tipos de Ubicaciones

-- Carga de Ubicaciones
insert into ESECUELE.Ubicacion
(ubicacion_publicacion,ubicacion_tipo,ubicacion_precio, ubicacion_cant_filas, ubicacion_cant_asientos, ubicacion_sin_numerar, ubicacion_asientos_ocupados)
select 
Espectaculo_Cod, 
Ubicacion_Tipo_Codigo,
Ubicacion_Precio, 
count(1), 
count(distinct Ubicacion_Asiento), 
Ubicacion_Sin_numerar,
isnull((select count(distinct b.Ubicacion_Asiento)
		from gd_esquema.Maestra b
		where b.Cli_Dni is not null and b.Espectaculo_Cod = a.Espectaculo_Cod and b.Ubicacion_Tipo_Codigo = a.Ubicacion_Tipo_Codigo
									and b.Ubicacion_Precio = a.Ubicacion_Precio
		group by b.Espectaculo_Cod, b.Ubicacion_Tipo_Codigo, b.Ubicacion_Precio
),0)
from gd_esquema.Maestra a
where Cli_Dni is null
group by Espectaculo_Cod, Ubicacion_Tipo_Codigo, Ubicacion_Precio, Ubicacion_Sin_numerar
order by Espectaculo_Cod
-- Fin de Carga de Ubicaciones

-- Tabla temporal para migracion de compras y entradas
select 
ROW_NUMBER() OVER(order by Compra_Fecha ASC) [compra],
Espectaculo_Cod [publicacion],
Compra_Fecha [compra_fecha],
Compra_Cantidad [compra_cantidad], 
Cli_Dni [cliente_dni],
Ubicacion_Asiento [asiento],
Ubicacion_Fila [fila],
Ubicacion_Sin_numerar [sin_numerar],
Ubicacion_Precio [precio],
Ubicacion_Tipo_Codigo [ubicacion_tipo]
INTO #EntradasTemporales
from gd_esquema.Maestra 
where Cli_Dni is not null and Item_Factura_Monto is null
group by Compra_Fecha,Compra_Cantidad, Ubicacion_Precio, Cli_Dni, Espectaculo_Cod,Ubicacion_Asiento,Ubicacion_Fila,Ubicacion_Sin_numerar,Ubicacion_Precio,Ubicacion_Tipo_Codigo
order by 1 ASC

-- Carga de Compras
insert into ESECUELE.Compra
(	compra_total,
	compra_cliente,
	compra_fecha
)
select
precio * compra_cantidad,
ESECUELE.ObtenerClienteId(cliente_dni),
compra_fecha
from #EntradasTemporales

-- Fin de Carga de Compras

-- Carga Entradas
insert into ESECUELE.Entrada
(entrada_compra,entrada_ubicacion, entrada_fila, entrada_asiento)
select
compra,
(
	select u.ubicacion_id
	from ESECUELE.Ubicacion u
	where u.ubicacion_tipo = t.ubicacion_tipo and u.ubicacion_publicacion = t.publicacion
		and u.ubicacion_precio = t.precio
),
ESECUELE.LetraANumero(fila),
asiento
from #EntradasTemporales t
-- Fin de carga de Entradas

drop table #EntradasTemporales

-- Tabla temporal para migracion de facturas
select
ROW_NUMBER() OVER(order by Compra_Fecha ASC) [entrada],
Factura_Nro [fact_numero],
Item_Factura_Cantidad [item_cant],
Item_Factura_Descripcion [item_desc],
Item_Factura_Monto [item_monto]
into #ItemFacturaTemporales
from gd_esquema.Maestra 
where Item_Factura_Monto is not null
group by Compra_Fecha,Compra_Cantidad, Ubicacion_Precio, Cli_Dni, Espectaculo_Cod,Ubicacion_Asiento,Ubicacion_Fila,Ubicacion_Sin_numerar,Ubicacion_Precio,Ubicacion_Tipo_Codigo,
Factura_Nro,Item_Factura_Cantidad,Item_Factura_Descripcion,Item_Factura_Monto
order by 1 ASC

-- Asignacion de funcionalidades para los usuarios cargados
insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username)
select 2, u.usr_username from ESECUELE.Cliente c join ESECUELE.Usuario u on c.cliente_usuario = u.usr_username

insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username)
select 3, u.usr_username from ESECUELE.Empresa e join ESECUELE.Usuario u on e.empresa_usuario = u.usr_username
-- Fin de asignacion de funcionalidades

-- Carga de Facturas
SET IDENTITY_INSERT ESECUELE.Factura ON
insert into ESECUELE.Factura
(fact_id,
fact_fecha,
fact_empresa,
fact_total,
fact_forma_pago)

select distinct
m.Factura_Nro, 
m.Factura_Fecha, 
(select empresa_id from ESECUELE.Empresa where 
empresa_razon_social = m.Espec_Empresa_Razon_Social and empresa_cuit = m.Espec_Empresa_Cuit),
m.Factura_Total,
m.Forma_Pago_Desc
 from gd_esquema.Maestra m
 where Factura_Nro is not null and Factura_Fecha is not null and Factura_Total is not null
 SET IDENTITY_INSERT ESECUELE.Factura OFF
-- Fin de Carga de Facturas

-- Carga de Item_Factura
insert into ESECUELE.Item_Factura
(item_id_factura,
item_cantidad,
item_monto,
item_descripcion,
item_entrada)
select
fact_numero,
item_cant,
item_monto,
item_desc,
entrada
from #ItemFacturaTemporales
-- Fin de Carga de Item_Factura

drop table #ItemFacturaTemporales

/*----------------------- Fin Migracion de datos --------------------------------*/

/*--------------------------- Creacion de restricciones -------------------------*/
-- Indices
create unique index index_usr_id on ESECUELE.Usuario(usr_id)
create unique index index_client_id on ESECUELE.Cliente(cliente_id)
create unique index index_empresa_id on ESECUELE.Empresa(empresa_id)
create unique index index_entrada_id on ESECUELE.Entrada(entrada_id)

-- Relacion Rol_Usuario
alter table ESECUELE.Rol_Usuario add constraint FK_RU_RolId foreign key(rol_usr_rol_id) references ESECUELE.Rol(rol_id) ON UPDATE CASCADE ON DELETE CASCADE
alter table ESECUELE.Rol_Usuario add constraint FK_UsrId foreign key(rol_usr_username) references ESECUELE.Usuario(usr_username) ON UPDATE CASCADE ON DELETE CASCADE

-- Relacion Funcionalidad_Rol
alter table ESECUELE.Funcionalidad_Rol add constraint FK_FR_FuncId foreign key(frol_func_id) references ESECUELE.Funcionalidad(func_id)
alter table ESECUELE.Funcionalidad_Rol add constraint FK_FR_RolId foreign key(frol_rol_id) references ESECUELE.Rol(rol_id)

-- Relacion Empresa - Usuario
alter table ESECUELE.Empresa add constraint FK_Emp_UserName foreign key (empresa_usuario) references ESECUELE.Usuario(usr_username) ON UPDATE CASCADE ON DELETE CASCADE

-- Relacion Publicacion -Empresa
alter table ESECUELE.Publicacion add constraint FK_EmpId foreign key (publicacion_empresa) references ESECUELE.Empresa(empresa_id) ON UPDATE CASCADE ON DELETE NO ACTION

-- Relacion Ubicacion - Tipo_Ubicacion
alter table ESECUELE.Ubicacion add constraint FK_Tipo_Ubicacion foreign key(ubicacion_tipo) references ESECUELE.Tipo_Ubicacion(tipo_ubicacion_id)

-- Relacion Cliente - Usuario
alter table ESECUELE.Cliente add constraint FK_Cli_UserName foreign key (cliente_usuario) references ESECUELE.Usuario(usr_username) ON UPDATE CASCADE ON DELETE CASCADE 

-- Relacion Compra - Cliente
alter table ESECUELE.Compra add constraint FK_Comp_Clie foreign key (compra_cliente) references ESECUELE.Cliente(cliente_id) ON UPDATE CASCADE ON DELETE NO ACTION

-- Relacion Entrada - Compra
alter table ESECUELE.Entrada add constraint FK_Entrada_Compra foreign key (entrada_compra) references ESECUELE.Compra(compra_id)

-- Relacion Compra - Medio de pago
alter table ESECUELE.Compra add constraint FK_Comp_MPago foreign key (compra_medio_pago) references ESECUELE.Medio_de_Pago(medio_pago_id)

-- Relacion Canje - Cliente
alter table ESECUELE.Canje add constraint FK_ClieId foreign key(canje_cliente) references ESECUELE.Cliente(cliente_id)

-- Relacion Canje - Producto
alter table ESECUELE.Canje add constraint FK_ProdId foreign key(canje_producto) references ESECUELE.Producto(prod_id)

-- Relacion Cliente - Tarjeta
alter table ESECUELE.Cliente add constraint FK_TarjId foreign key(cliente_datos_tarjeta) references ESECUELE.Tarjeta(tarjeta_id)

-- Relacion Punto - Cliente
alter table ESECUELE.Punto add constraint FK_P_ClieId foreign key(punto_cliente) references ESECUELE.Cliente(cliente_id)

-- Relacion Factura - Empresa
alter table ESECUELE.Factura add constraint FK_F_EmpId foreign key(fact_empresa) references ESECUELE.Empresa(empresa_id) ON DELETE SET NULL ON UPDATE CASCADE

go
/*------------------------Fin Creacion de restricciones -------------------------*/

/*--------------------------- Store procedures ----------------------------------*/

create procedure ESECUELE.SetFallosEstadoUsuario(@username varchar(50), @estado bit, @fallos tinyint)
as
begin
	  update ESECUELE.Usuario
		set usr_fallas = @fallos, usr_estado= @estado
		where usr_username = @username
end
go

-- Sproc para loguear
-- Cualquier error devuelve SQLexception y -1
-- Si el logueo es correcto y tiene un solo rol, devuelve ese 1, -1 si es primer logueo
-- Si el logueo es correcto y tiene mas de un rol, devuelve 2, -2 si es primer logueo
create procedure ESECUELE.Login(@username varchar(50), @password_input nvarchar(100), @return_val smallint output)
as begin
  declare @estado bit = null
  declare @primer_login bit = null
  declare @password nvarchar(100) = null
  declare @fallos tinyint = null

  select @estado = usr_estado, @fallos = usr_fallas, @password = usr_pass, @primer_login = usr_primer_login
  from ESECUELE.Usuario
  where usr_username = @username

  if( @password is null)
  begin
	raiserror('El usuario no existe.',18,10)
	return
  end
  
  if @estado = 0
  begin
    raiserror('El usuario se encuentra deshabilitado',18,10)
	return
  end

  -- Si el usuario existe, checkeo passwords
  if @password <> @password_input
  begin
    -- Si hay fallo, incremento contador
    set @fallos = @fallos + 1
    update ESECUELE.Usuario
      set usr_fallas = @fallos,
          usr_estado = case when @fallos >= 3  or usr_estado = 0 then 0
                          else 1 end
      where usr_username = @username
	declare @msg NVARCHAR(100)
	if @fallos < 3
		set @msg = formatmessage('Contrase�a incorrecta. Tienes %d intentos restantes.', 3 - @fallos)
	else
		set @msg = 'Su usuario fue deshabilitado.'
    raiserror(@msg, 18, 10)
	return
  end
  else begin
    -- Obtener los roles del usuario
    declare @count smallint
    select @count = count(1)
      from ESECUELE.Rol_Usuario RU join ESECUELE.Rol R on R.rol_id = RU.rol_usr_rol_id
      where RU.rol_usr_username = @username and R.rol_estado = 1 -- Rol habilitado
    if @count = 0
	begin
		raiserror(N'Su usuario no tiene roles asignadoes, comunicarse con el administrador.', 18, 10)
		return
	end

	if @primer_login = 1
		 exec ESECUELE.SetFallosEstadoUsuario @username, 1, 1
	else
		 exec ESECUELE.SetFallosEstadoUsuario @username, 1, 0
   
   if @count > 1
   begin
		if @primer_login = 1
			begin
				set @return_val = -2
				return
			end
		else
			begin
				set @return_val = 2
				return
			end
	end
	else
		begin
			if  @primer_login = 1	
				set @return_val = -1
			else
				set @return_val = 1
			end
		end
end
go

create procedure ESECUELE.cambioPassword(@username varchar(50),@new_password nvarchar(100))
as begin
	update ESECUELE.Usuario
	set usr_pass = @new_password, usr_primer_login = 0
	where usr_username = @username
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

create procedure ESECUELE.getEmpresa(@id int)
as begin
	select * from ESECUELE.Empresa e join ESECUELE.Usuario u on u.usr_username = e.empresa_usuario
	where e.empresa_id = @id
end
go

create procedure ESECUELE.getGrado(@id int)
as begin
	select * from ESECUELE.Grado g
	where g.grado_id = @id
end
go 

create procedure ESECUELE.getEmpresaFromUsername(@username varchar(50))
as begin
	select * from ESECUELE.Empresa e join ESECUELE.Usuario u on u.usr_username = e.empresa_usuario
	where e.empresa_usuario = @username
end
go

create procedure ESECUELE.getPublicacionesFromEmpresa(@id int)
as begin
	select * from ESECUELE.Publicacion where publicacion_empresa = @id
end
go

create procedure ESECUELE.getPublicacion(@idEmpresa int, @codPub int)
as begin
	select * from ESECUELE.Publicacion where publicacion_codigo=@codPub and publicacion_empresa = @idEmpresa
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
								   @usr_pass nvarchar(100),
								   @usr_tipo varchar(7),
								   @usr_email varchar(50),
								   @usr_telefono varchar(20),
								   @usr_direccion varchar(150),
								   @usr_codigo_postal varchar(10),
								   @usr_creacion datetime, 
								   @return_val int output) as
begin 
	begin try
		insert into ESECUELE.Usuario
		(usr_username, usr_pass, usr_estado, usr_primer_login, usr_fecha_creacion, usr_tipo, usr_email, usr_telefono, usr_direccion, usr_codigo_postal) 
		values(@usr_username, @usr_pass, 1, 0, @usr_creacion, @usr_tipo, @usr_email, @usr_telefono, @usr_direccion, @usr_codigo_postal)
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
	if @cliente_cuil not like '%' + @cliente_num_doc + '%'
	begin
		raiserror('El CUIL no coincide con el documento.',18,10)
		return
	end

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
		insert into ESECUELE.Rol_Usuario (rol_usr_rol_id, rol_usr_username)
		select rol_id , @username from ESECUELE.Rol where rol_nombre = @rolName
	end try
	
	begin catch
		throw
	end catch
end
go

create procedure ESECUELE.SearchAllCliente(@nombre varchar(50) = null, 
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

create procedure ESECUELE.SearchAllEmpresa(@razon_social varchar(60) = null,
							  @cuit varchar(30) = null, 
							  @email varchar(50) = null)
as
begin
	declare @where bit
	set @where = 0
	declare @query nvarchar(500);
	set @query = N'select * from ESECUELE.Empresa e join ESECUELE.Usuario u on e.empresa_usuario = u.usr_username';

	if @razon_social is not null or  @cuit is not null or @email is not null
	begin
		set @query = @query + ' where '
		if @razon_social is not null 
		begin
			set @query = @query + 'e.empresa_razon_social like ''%'	+ @razon_social + '%'''
			set @where = 1
		end

		if @cuit is not null 
		begin
			if @where = 0
				begin
					set @query = @query + 'e.empresa_cuit like ''%'	+ @cuit + '%'''
					set @where = 1
				end
			else set @query = @query + ' and e.empresa_cuit like ''%'	+ @cuit + '%'''
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


create procedure ESECUELE.UpdateCliente(@id int, @nombre varchar(50), @apellido varchar(50), @tipoDoc varchar(10),
@numDoc varchar(30), @cuil varchar(30), @fechaNac datetime, @usuario varchar(50)) as
begin
	update ESECUELE.Cliente set 
		cliente_nombre=@nombre, 
		cliente_apellido=@apellido, 
		cliente_tipo_doc=@tipoDoc,
		cliente_num_doc=@numDoc,
		cliente_cuil=@cuil,
		cliente_fecha_nacimiento=@fechaNac,
		cliente_usuario=@usuario
		where cliente_id=@id
end
go

create procedure ESECUELE.UpdateEmpresa(@id int, @razonSocial varchar(60), @ciudad varchar(40), @cuit varchar(30),
	@usuario varchar(50)) as
begin
	update ESECUELE.Empresa set 
		empresa_ciudad=@ciudad,
		empresa_cuit=@cuit,
		empresa_razon_social=@razonSocial,
		empresa_usuario=@usuario
		where empresa_id=@id
end
go

create procedure ESECUELE.updatePassUsuario(@id int, @usr_pass nvarchar(100)) as
begin
	update ESECUELE.Usuario set usr_pass = @usr_pass where usr_id = @id;
end
go

create procedure ESECUELE.UpdateUsuario(@id int, @username varchar(50), @email varchar(50),
@telefono varchar(20), @direccion varchar(150), @cp varchar(10)) as
begin
	update ESECUELE.Usuario set 
		usr_username=@username,
		usr_email=@email,
		usr_telefono=@telefono,
		usr_direccion=@direccion,
		usr_codigo_postal=@cp
		where usr_id=@id
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
go

create procedure ESECUELE.borrarCliente(@id int) as
begin
	delete from ESECUELE.Cliente where cliente_id = @id
end
go

create procedure ESECUELE.ChangeEmpresaStatus(@id int) as
begin
	begin try
		declare @currentStatus bit
		declare @username varchar(50)
		
		select @currentStatus = u.usr_estado, @username = u.usr_username 
		from ESECUELE.Usuario u join ESECUELE.Empresa e 
		on u.usr_username = e.empresa_usuario where e.empresa_id = @id
		
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
go

create procedure ESECUELE.borrarEmpresa(@id int) as
begin
	delete from ESECUELE.Empresa where empresa_id = @id
end
go

CREATE TYPE ESECUELE.FunConCambios AS TABLE
(
    frol_rol_id tinyint,
    frol_func_id tinyint,
	fun_estado tinyint
);
go

create procedure ESECUELE.ActualizarFuncionalidades( @funs_con_cambios as ESECUELE.FunConCambios readonly)
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

create procedure ESECUELE.getRubro as
begin
	select * from ESECUELE.Rubro
end
go

create procedure ESECUELE.getAllGrado as
begin
	select * from ESECUELE.Grado
end
go

create procedure ESECUELE.SearchPagedPublicacion(@offset int, @items int) as
begin
	select *, COUNT(*) OVER() from ESECUELE.Publicacion
	order by publicacion_codigo DESC
	offset @offset rows fetch next @items rows only
end
go

create procedure ESECUELE.SearchPagedPublicacionByEmpresa(@idEmpresa int, @offset int, @items int) as
begin
	select *, COUNT(*) OVER() from ESECUELE.Publicacion where publicacion_empresa = @idEmpresa 
	order by publicacion_codigo DESC
	offset @offset rows fetch next @items rows only
end
go

create procedure ESECUELE.SearchAllPublicacionActivaValida(
							@categorias varchar(255) = null,
							@descripcion varchar(255) = null, 
							@fechaInicio datetime = null,
							@fechaFin datetime = null,
							@fechaActual datetime = null)
as
begin
	declare @query nvarchar(500);
	set @query = N'select * from ESECUELE.Publicacion p left join ESECUELE.Rubro r on p.publicacion_rubro = r.rubro_codigo
														left join ESECUELE.Grado g on p.publicacion_grado = g.grado_id';

	if @categorias is not null or  @descripcion is not null or @fechaInicio is not null or @fechaFin is not null
	begin
		set @query = @query + ' where p.publicacion_estado = ''Publicada'' and cast(' + convert(varchar(25),@fechaActual,121) 
							+ ') between(p.publicacion_fecha_inicio, p.publicacion_fecha_evento)'

		if @descripcion is not null 
		begin
			set @query = @query + ' and p.publicacion_descripcion like ''%'	+ @descripcion + '%'''
		end

		if @categorias is not null 
		begin
			set @query = @query + ' and p.publicacion_rubro in ' + @categorias
		end

		if @fechaInicio is not null 
		begin
			 set @query = @query + ' and p.publicacion_fecha_inicio >= ' + @fechaInicio
		end

		if @fechaFin is not null 
		begin
			 set @query = @query + ' and p.publicacion_fecha_evento <=' + @fechaFin
		end
	end
	set @query = @query + ' order by p.publicacion_grado asc, p.publicacion_descripcion desc'
	exec sp_executesql @query
end
go

create procedure ESECUELE.SearchPagedPublicacionesParaCompra(
							@categorias varchar(255) = null,
							@descripcion varchar(255) = null, 
							@fechaInicio datetime = null,
							@fechaFin datetime = null,
							@fechaActual datetime = null,
							@offset int,
							@items int)
as
begin
	declare @query nvarchar(500);
	set @query = N'select *, COUNT(*) OVER() from ESECUELE.Publicacion p left join ESECUELE.Rubro r on p.publicacion_rubro = r.rubro_codigo
														left join ESECUELE.Grado g on p.publicacion_grado = g.grado_id';

	if @categorias is not null or  @descripcion is not null or @fechaInicio is not null or @fechaFin is not null
	begin
		set @query = @query + ' where p.publicacion_estado = ''Publicada'' and cast(' + convert(varchar(25),@fechaActual,121) 
							+ ') between(p.publicacion_fecha_inicio, p.publicacion_fecha_evento)'

		if @descripcion is not null 
		begin
			set @query = @query + ' and p.publicacion_descripcion like ''%'	+ @descripcion + '%'''
		end

		if @categorias is not null
		begin
			set @query = @query + ' and p.publicacion_rubro in ' + @categorias
		end

		if @fechaInicio is not null 
		begin
			 set @query = @query + ' and p.publicacion_fecha_inicio >= ' + @fechaInicio
		end

		if @fechaFin is not null 
		begin
			 set @query = @query + ' and p.publicacion_fecha_evento <=' + @fechaFin
		end
	end
	set @query = 
	concat(@query, ' order by p.publicacion_grado asc, p.publicacion_descripcion desc 
							offset ', @offset,' rows fetch next ',@items,' rows only')

	exec sp_executesql @query
end
go

create procedure ESECUELE.GetUbicaciones(@publicacion_codigo int)
as begin
	select ubicacion_id, ubicacion_publicacion, ubicacion_tipo, tipo_ubicacion_desc, ubicacion_sin_numerar,
	ubicacion_cant_filas, ubicacion_cant_asientos, ubicacion_precio, ubicacion_asientos_ocupados
	from ESECUELE.Ubicacion join ESECUELE.Tipo_Ubicacion on ubicacion_tipo = tipo_ubicacion_id
	where ubicacion_publicacion = @publicacion_codigo
	order by ubicacion_precio
end
go

create procedure ESECUELE.GetEntradasVendidas(@publicacion_codigo int)
as begin
	select * from ESECUELE.Entrada join ESECUELE.Ubicacion on entrada_ubicacion = ubicacion_id
	where ubicacion_publicacion = @publicacion_codigo
end
go