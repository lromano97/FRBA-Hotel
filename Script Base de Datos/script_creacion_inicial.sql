                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              USE [GD1C2018]

SET QUOTED_IDENTIFIER OFF

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'CAIA_UNLIMITED')
BEGIN
EXEC ('CREATE SCHEMA [CAIA_UNLIMITED] AUTHORIZATION [gd]')
END

--Provisorio

if OBJECT_ID('[CAIA_UNLIMITED].[Rol_X_Usuario]', 'U') is not null
drop table CAIA_UNLIMITED.Rol_X_Usuario
go

if OBJECT_ID('[CAIA_UNLIMITED].[Funcionalidad_X_Rol]', 'U') is not null
drop table CAIA_UNLIMITED.Funcionalidad_X_Rol
go

if OBJECT_ID('[CAIA_UNLIMITED].[Regimen_X_Hotel]', 'U') is not null
drop table CAIA_UNLIMITED.Regimen_X_Hotel
go

if OBJECT_ID('[CAIA_UNLIMITED].[Usuario_X_Hotel]', 'U') is not null
drop table CAIA_UNLIMITED.Usuario_X_Hotel
go

if OBJECT_ID('[CAIA_UNLIMITED].[Reserva_X_Huesped]', 'U') is not null
drop table CAIA_UNLIMITED.Reserva_X_Huesped
go

if OBJECT_ID('[CAIA_UNLIMITED].[Consumible_X_Estadia]', 'U') is not null
drop table CAIA_UNLIMITED.Consumible_X_Estadia
go

if OBJECT_ID('[CAIA_UNLIMITED].[Mantenimiento]', 'U') is not null
drop table CAIA_UNLIMITED.Mantenimiento
go

if OBJECT_ID('[CAIA_UNLIMITED].[Item_Factura]', 'U') is not null
drop table CAIA_UNLIMITED.Item_Factura
go

if OBJECT_ID('[CAIA_UNLIMITED].[Factura]', 'U') is not null
drop table CAIA_UNLIMITED.Factura
go

if OBJECT_ID('[CAIA_UNLIMITED].[Estadia]', 'U') is not null
drop table CAIA_UNLIMITED.Estadia
go

if OBJECT_ID('[CAIA_UNLIMITED].[Reserva]', 'U') is not null
drop table CAIA_UNLIMITED.Reserva
go

if OBJECT_ID('[CAIA_UNLIMITED].[Huesped]', 'U') is not null
drop table CAIA_UNLIMITED.Huesped
go

if OBJECT_ID('[CAIA_UNLIMITED].[Usuario]', 'U') is not null
drop table CAIA_UNLIMITED.Usuario
go

if OBJECT_ID('[CAIA_UNLIMITED].[Habitacion]', 'U') is not null
drop table CAIA_UNLIMITED.Habitacion
go

if OBJECT_ID('[CAIA_UNLIMITED].[Hotel]', 'U') is not null
drop table CAIA_UNLIMITED.Hotel
go

if OBJECT_ID('[CAIA_UNLIMITED].[Tipo_Habitacion]', 'U') is not null
drop table CAIA_UNLIMITED.Tipo_Habitacion
go

if OBJECT_ID('[CAIA_UNLIMITED].[Rol]', 'U') is not null
drop table CAIA_UNLIMITED.Rol
go

if OBJECT_ID('[CAIA_UNLIMITED].[Funcionalidad]', 'U') is not null
drop table CAIA_UNLIMITED.Funcionalidad
go

if OBJECT_ID('[CAIA_UNLIMITED].[Regimen]', 'U') is not null
drop table CAIA_UNLIMITED.Regimen
go

if OBJECT_ID('[CAIA_UNLIMITED].[Direccion]', 'U') is not null
drop table CAIA_UNLIMITED.Direccion
go

if OBJECT_ID('[CAIA_UNLIMITED].[Estado_Reserva]', 'U') is not null
drop table CAIA_UNLIMITED.Estado_Reserva
go

if OBJECT_ID('[CAIA_UNLIMITED].[Pago]', 'U') is not null
drop table CAIA_UNLIMITED.Pago
go

if OBJECT_ID('[CAIA_UNLIMITED].[Consumible]', 'U') is not null
drop table CAIA_UNLIMITED.Consumible
go

create table CAIA_UNLIMITED.Mantenimiento(
	mant_fecha_inicio datetime not null,
	mant_fecha_fin datetime not null,
	mant_descripcion nvarchar(255) not null,
	hote_id numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Hotel(
	hote_id numeric(18,0) identity(0,1) not null,
	hote_nombre nvarchar(255),
	hote_cant_estrellas numeric(18,0) not null,
	hote_recarga_estrella numeric(18,0),
	hote_habilitado bit not null,
	hote_fecha_creacion datetime,
	hote_mail nvarchar(255),
	hote_fecha_inicio datetime,
	hote_fecha_fin datetime,
	dire_id numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Regimen(
	regi_codigo numeric(18,0) identity(0,1) not null,
	regi_descripcion nvarchar(255) not null,
	regi_precio_base numeric(18,2) not null,
	regi_estado bit not null
)
go

create table CAIA_UNLIMITED.Usuario(
	usur_username nvarchar(255) not null,
	usur_password nvarchar(255) not null,
	usur_nombre nvarchar(255),
	usur_apellido nvarchar(255),
	usur_documento_tipo nvarchar(3),
	usur_documento numeric(18,0),
	usur_mail nvarchar(255),
	usur_nacimiento datetime,
	usur_habilitado bit not null,
	usur_intentos numeric(18,0) not null,
	dire_id numeric(18,0)
)
go

create table CAIA_UNLIMITED.Direccion(
	dire_id numeric(18,0) identity(0,1) not null,
	dire_telefono nvarchar(20),
	dire_dom_calle nvarchar(255) not null,
	dire_nro_calle numeric(18,0) not null,
	dire_piso numeric(18,0),
	dire_dpto nvarchar(50),
	dire_ciudad nvarchar(255),
	dire_pais nvarchar(255)
)
go

create table CAIA_UNLIMITED.Huesped(
	hues_mail nvarchar(255) not null,
	hues_nombre nvarchar(255) not null,
	hues_apellido nvarchar(255) not null,
	hues_documento numeric(18,0) not null,
	hues_nacionalidad nvarchar(255) not null,
	hues_nacimiento datetime not null,
	hues_documento_tipo nvarchar(3) not null,
	hues_habilitado bit not null,
	dire_id numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Reserva(
	rese_codigo numeric(18,0) not null,
	rese_fecha_realizacion datetime not null,
	rese_fecha_desde datetime not null,
	rese_cantidad_noches numeric(18,0) not null,
	esre_codigo numeric(18,0),
	hote_id numeric(18,0) not null,
	habi_numero numeric(18,0) not null,
	regi_codigo numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Estado_Reserva(
	esre_codigo numeric(18,0) identity(0,1) not null,
	esre_detalle nvarchar(255) not null
)
go

create table CAIA_UNLIMITED.Pago(
	pago_codigo numeric(18,0) identity(0,1) not null,
	pago_monto numeric(18,2) not null,
	pago_nombre nvarchar(255),
	pago_apellido nvarchar(255),
	pago_nro_tarjeta nvarchar(20),
	pago_codigo_seguridad nvarchar(4),
	pago_banco nvarchar(20),
	pago_fecha_vencimiento datetime
)
go

create table CAIA_UNLIMITED.Rol(
	rol_codigo numeric(18,0) identity(0,1) not null,
	rol_nombre nvarchar(255) not null,
	rol_estado bit not null
)
go

create table CAIA_UNLIMITED.Funcionalidad(
	func_codigo numeric(18,0) identity(0,1) not null,
	func_detalle nvarchar(255) not null
)
go

create table CAIA_UNLIMITED.Habitacion(
	hote_id numeric(18,0) not null,
	habi_numero numeric(18,0) not null,
	habi_piso numeric(18,0) not null,
	habi_frente nvarchar(50) not null,
	habi_descripcion nvarchar(255),
	habi_habilitado bit not null,
	thab_codigo numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Tipo_Habitacion(
	thab_codigo numeric(18,0) not null,
	thab_descripcion nvarchar(255) not null,
	thab_porcentual numeric(18,2) not null
)
go

create table CAIA_UNLIMITED.Estadia(
	esta_codigo numeric(18,0) identity(0,1) not null,
	esta_fecha_inicio datetime not null,
	esta_cantidad_noches numeric(18,0) not null,
	rese_codigo numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Factura(
	fact_nro numeric(18,0) not null,
	fact_fecha datetime not null,
	fact_total numeric(18,2) not null,
	esta_codigo numeric(18,0) not null,
	pago_codigo numeric(18,0) null,
	hues_mail nvarchar(255) null,
	hues_documento numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Item_Factura(
	item_cantidad numeric(18,0) not null,
	item_monto numeric(18,2) not null,
	fact_nro numeric(18,0) not null,
	cons_codigo numeric(18,0)
)
go

create table CAIA_UNLIMITED.Consumible(
	cons_codigo numeric(18,0) not null,
	cons_descripcion nvarchar(255) not null,
	cons_precio numeric(18,2) not null
)
go

create table CAIA_UNLIMITED.Rol_X_Usuario(
	rol_usur_codigo numeric(18,0) not null,
	rol_usur_username nvarchar(255) not null
)
go

create table CAIA_UNLIMITED.Funcionalidad_X_Rol(
	func_rol_codigo_rol numeric(18,0) not null,
	func_rol_codigo_func numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Regimen_X_Hotel(
	regi_hote_codigo numeric(18,0) not null,
	regi_hote_id numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Usuario_X_Hotel(
	usur_hote_username nvarchar(255) not null,
	usur_hote_id numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Reserva_X_Huesped(
	rese_hues_codigo numeric(18,0) not null,
	rese_hues_mail nvarchar(255) not null,
	rese_hues_documento numeric(18,0) not null
)
go

create table CAIA_UNLIMITED.Consumible_X_Estadia(
	cons_esta_codigo_cons numeric(18,0) not null,
	cons_esta_codigo_esta numeric(18,0) not null
)
go

alter table CAIA_UNLIMITED.Direccion
	add constraint PK_Direccion primary key (dire_id)
go

alter table CAIA_UNLIMITED.Hotel
	add constraint PK_Hotel primary key (hote_id),
	constraint FK_Hotel_Direccion foreign key (dire_id)
	references CAIA_UNLIMITED.Direccion (dire_id)
go

alter table CAIA_UNLIMITED.Regimen 
	add constraint PK_Regimen primary key (regi_codigo)
go

alter table CAIA_UNLIMITED.Tipo_Habitacion
	add constraint PK_Tipo_Habitacion primary key (thab_codigo)
go

alter table CAIA_UNLIMITED.Habitacion
	add constraint PK_Habitacion primary key (hote_id, habi_numero),
	constraint FK_Habitacion_Hotel foreign key (hote_id)
	references CAIA_UNLIMITED.Hotel (hote_id),
	constraint FK_Habitacioin_Tipo foreign key (thab_codigo)
	references CAIA_UNLIMITED.Tipo_Habitacion (thab_codigo)
go

alter table CAIA_UNLIMITED.Rol
	add constraint PK_Rol primary key (rol_codigo)
go

alter table CAIA_UNLIMITED.Funcionalidad
	add constraint PK_Funcionalidad primary key (func_codigo)
go

alter table CAIA_UNLIMITED.Usuario 
	add constraint PK_Usuario primary key (usur_username),
	constraint FK_Usuario_Direccion foreign key (dire_id)
	references CAIA_UNLIMITED.Direccion (dire_id)
go

alter table CAIA_UNLIMITED.Huesped
	add constraint PK_Huesped primary key (hues_mail, hues_documento),
	constraint FK_Huespedo_Direccion foreign key (dire_id)
	references CAIA_UNLIMITED.Direccion (dire_id)
go

alter table CAIA_UNLIMITED.Estado_Reserva
	add constraint PK_Estado_Reserva primary key (esre_codigo)
go

alter table CAIA_UNLIMITED.Reserva
	add constraint PK_Reserva primary key (rese_codigo),
	constraint FK_Reserva_Estado foreign key (esre_codigo)
	references CAIA_UNLIMITED.Estado_Reserva (esre_codigo),
	constraint FK_Reserva_Habitacion foreign key (hote_id, habi_numero)
	references CAIA_UNLIMITED.Habitacion (hote_id, habi_numero),
	constraint FK_Reserva_Regimen foreign key (regi_codigo)
	references CAIA_UNLIMITED.Regimen (regi_codigo)
	on update cascade
go

alter table CAIA_UNLIMITED.Estadia
	add constraint PK_Estadia primary key (esta_codigo),
	constraint FK_Estadia_Reserva foreign key (rese_codigo)
	references CAIA_UNLIMITED.Reserva (rese_codigo)
go

alter table CAIA_UNLIMITED.Consumible
	add constraint PK_Consumible primary key (cons_codigo)
go

alter table CAIA_UNLIMITED.Pago
	add constraint PK_Pago primary key (pago_codigo)
go

alter table CAIA_UNLIMITED.Factura
	add constraint PK_Factura primary key (fact_nro),
	constraint FK_Factura_Estadia foreign key (esta_codigo)
	references CAIA_UNLIMITED.Estadia (esta_codigo),
	constraint FK_Factura_Pago foreign key (pago_codigo)
	references CAIA_UNLIMITED.Pago (pago_codigo),
	constraint FK_Factura_Huesped foreign key (hues_mail, hues_documento)
	references CAIA_UNLIMITED.Huesped (hues_mail, hues_documento)
go

alter table CAIA_UNLIMITED.Item_Factura
	add constraint FK_Item_Factura_Factura foreign key (fact_nro)
	references CAIA_UNLIMITED.Factura (fact_nro),
	constraint FK_Item_Factuta_Consumible foreign key (cons_codigo)
	references CAIA_UNLIMITED.Consumible (cons_codigo)
go

alter table CAIA_UNLIMITED.Mantenimiento
	add constraint FK_Mantenimiento_Hotel foreign key (hote_id)
	references CAIA_UNLIMITED.Hotel (hote_id)
go

alter table CAIA_UNLIMITED.Rol_X_Usuario
	add constraint PK_Rol_X_Usuario primary key (rol_usur_codigo, rol_usur_username),
	constraint FK_RolUsuario_Rol foreign key (rol_usur_codigo)
	references CAIA_UNLIMITED.Rol (rol_codigo),
	constraint FK_RolUsuario_Usur foreign key (rol_usur_username)
	references CAIA_UNLIMITED.Usuario (usur_username)
go

alter table CAIA_UNLIMITED.Funcionalidad_X_Rol
	add constraint PK_Funcionalidad_X_Rol primary key (func_rol_codigo_rol, func_rol_codigo_func),
	constraint FK_FuncionalidadRol_Rol foreign key (func_rol_codigo_rol)
	references CAIA_UNLIMITED.Rol (rol_codigo),
	constraint FK_FuncionalidadRol_Func foreign key (func_rol_codigo_func)
	references CAIA_UNLIMITED.Funcionalidad (func_codigo)
go

alter table CAIA_UNLIMITED.Regimen_X_Hotel
	add constraint PK_Regimen_X_Hotel primary key (regi_hote_id, regi_hote_codigo),
	constraint FK_RegimenHotel_Regi foreign key (regi_hote_codigo)
	references CAIA_UNLIMITED.Regimen (regi_codigo),
	constraint FK_RegimenHotel_Hote foreign key (regi_hote_id)
	references CAIA_UNLIMITED.Hotel (hote_id)
go

alter table CAIA_UNLIMITED.Usuario_X_Hotel
	add constraint PK_Usuario_X_Hotel primary key (usur_hote_username, usur_hote_id),
	constraint FK_UsuarioHotel_Usur foreign key (usur_hote_username)
	references CAIA_UNLIMITED.Usuario (usur_username),
	constraint FK_UsuarioHotel_Hote foreign key (usur_hote_id)
	references CAIA_UNLIMITED.Hotel (hote_id)
go

alter table CAIA_UNLIMITED.Reserva_X_Huesped
	add constraint PK_Reserva_X_Huesped primary key (rese_hues_codigo, rese_hues_mail, rese_hues_documento),
	constraint FK_ReservaHuesped_Rese foreign key (rese_hues_codigo)
	references CAIA_UNLIMITED.Reserva (rese_codigo),
	constraint FK_ReservaHuesped_Hues foreign key (rese_hues_mail, rese_hues_documento)
	references CAIA_UNLIMITED.Huesped (hues_mail, hues_documento)
go

alter table CAIA_UNLIMITED.Consumible_X_Estadia
	add constraint PK_Consumible_X_Estadia primary key (cons_esta_codigo_cons, cons_esta_codigo_esta),
	constraint FK_ConsumibleEstadia_Cons foreign key (cons_esta_codigo_cons)
	references CAIA_UNLIMITED.Consumible (cons_codigo),
	constraint FK_ConsumibleEstadia_Esta foreign key (cons_esta_codigo_esta)
	references CAIA_UNLIMITED.Estadia (esta_codigo)
go

--Consumibles
insert into CAIA_UNLIMITED.Consumible (cons_codigo, cons_descripcion, cons_precio)
select distinct Consumible_Codigo, Consumible_Descripcion, Consumible_Precio from gd_esquema.Maestra
where Consumible_Codigo is not null

--Regimen
insert into CAIA_UNLIMITED.Regimen (regi_descripcion, regi_precio_base, regi_estado)
select distinct Regimen_Descripcion, Regimen_Precio, 1 from gd_esquema.Maestra

--Direccion
insert into CAIA_UNLIMITED.Direccion (dire_dom_calle, dire_ciudad, dire_nro_calle)
select distinct Hotel_Calle, Hotel_Ciudad, Hotel_Nro_Calle from gd_esquema.Maestra

insert into CAIA_UNLIMITED.Direccion (dire_dom_calle, dire_nro_calle, dire_dpto, dire_piso)
select distinct Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Depto, Cliente_Piso from gd_esquema.Maestra

--Tipo_Habitacion
insert into CAIA_UNLIMITED.Tipo_Habitacion (thab_codigo, thab_descripcion, thab_porcentual)
select distinct Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual
from gd_esquema.Maestra

--Hotel
insert into CAIA_UNLIMITED.Hotel (hote_cant_estrellas, hote_recarga_estrella, hote_habilitado, dire_id)
select distinct Hotel_CantEstrella, Hotel_Recarga_Estrella, 1, dire_id
from gd_esquema.Maestra join CAIA_UNLIMITED.Direccion on (Hotel_Calle = dire_dom_calle and
															Hotel_Ciudad = dire_ciudad and
															Hotel_Nro_Calle = dire_nro_calle)

--Habitacion
insert into CAIA_UNLIMITED.Habitacion (habi_numero, habi_piso, habi_frente, hote_id, thab_codigo, habi_habilitado)
select distinct Habitacion_Numero, Habitacion_Piso, Habitacion_Frente, hote_id, thab_codigo, 1
from gd_esquema.Maestra join CAIA_UNLIMITED.Tipo_Habitacion on (thab_codigo = Habitacion_Tipo_Codigo and
																thab_descripcion = Habitacion_Tipo_Descripcion and
																thab_porcentual = Habitacion_Tipo_Porcentual)
						join CAIA_UNLIMITED.Direccion D on (dire_ciudad = Hotel_Ciudad and
															dire_dom_calle = Hotel_Calle and
															dire_nro_calle = Hotel_Nro_Calle)
						join CAIA_UNLIMITED.Hotel H on (H.dire_id = D.dire_id) 

--Reserva
insert into CAIA_UNLIMITED.Reserva (rese_codigo, rese_fecha_realizacion, rese_fecha_desde, rese_cantidad_noches, hote_id, habi_numero, regi_codigo)
select distinct Reserva_Codigo, Reserva_Fecha_Inicio, Reserva_Fecha_Inicio, Reserva_Cant_Noches, H.hote_id, habi_numero, L.regi_codigo
from gd_esquema.Maestra join CAIA_UNLIMITED.Direccion D on (Hotel_Calle = dire_dom_calle and
															Hotel_Nro_Calle = dire_nro_calle and
															Hotel_Ciudad = dire_ciudad)
						join CAIA_UNLIMITED.Hotel H on (H.dire_id = D.dire_id)
						join CAIA_UNLIMITED.Habitacion R on (H.hote_id  = R.hote_id and
															Habitacion_Numero = habi_numero)
						join CAIA_UNLIMITED.Regimen L on (regi_descripcion = Regimen_Descripcion)

--Estadia
insert into CAIA_UNLIMITED.Estadia (esta_fecha_inicio, esta_cantidad_noches, rese_codigo)
select distinct Estadia_Fecha_Inicio, Estadia_Cant_Noches, rese_codigo
from gd_esquema.Maestra join CAIA_UNLIMITED.Reserva on (Reserva_Codigo = rese_codigo)
where Estadia_Cant_Noches is not null and Estadia_Cant_Noches is not null



--Huesped
insert into CAIA_UNLIMITED.Huesped (hues_mail, hues_nombre, hues_apellido, hues_documento, hues_documento_tipo, 
											hues_nacimiento, hues_nacionalidad, hues_habilitado, dire_id)
select distinct Cliente_Mail, Cliente_Nombre, Cliente_Apellido, Cliente_Pasaporte_Nro, 'PAS', Cliente_Fecha_Nac, Cliente_Nacionalidad, 1, dire_id
from gd_esquema.Maestra join CAIA_UNLIMITED.Direccion on (dire_dom_calle = Cliente_Dom_Calle and
															dire_nro_calle = Cliente_Nro_Calle and
															dire_piso = Cliente_Piso and
															dire_dpto = Cliente_Depto)

--Factura
insert into CAIA_UNLIMITED.Factura (fact_nro, fact_fecha, fact_total, esta_codigo, hues_documento, hues_mail)
select Factura_Nro, Factura_Fecha, sum(Factura_Total), esta_codigo, hues_documento, hues_mail
from gd_esquema.Maestra join CAIA_UNLIMITED.Reserva R on (Reserva_Codigo = rese_codigo)
						join CAIA_UNLIMITED.Estadia E on (R.rese_codigo = E.rese_codigo)
						join CAIA_UNLIMITED.Huesped on (hues_documento = Cliente_Pasaporte_Nro and
														hues_mail = Cliente_Mail)
where Factura_Nro is not null
group by Factura_Nro, Factura_Fecha, esta_codigo, hues_documento, hues_mail

--Item_Factura
insert into CAIA_UNLIMITED.Item_Factura (item_cantidad, item_monto, fact_nro, cons_codigo)
select Item_Factura_Cantidad, Item_Factura_Monto, Factura_Nro, Consumible_Codigo
from gd_esquema.Maestra


--Regimen por Hotel
insert into CAIA_UNLIMITED.Regimen_X_Hotel(regi_hote_codigo, regi_hote_id)
select distinct regi_codigo, hote_id
from CAIA_UNLIMITED.Regimen join gd_esquema.Maestra on (regi_descripcion = Regimen_Descripcion and
														regi_precio_base = Regimen_Precio)
							join CAIA_UNLIMITED.Direccion D on (Hotel_Calle = dire_dom_calle and
																Hotel_Ciudad = dire_ciudad and
																Hotel_Nro_Calle = dire_nro_calle)
							join CAIA_UNLIMITED.Hotel H on (H.dire_id = D.dire_id)


--Consumible por estadia
insert into CAIA_UNLIMITED.Consumible_X_Estadia (cons_esta_codigo_cons, cons_esta_codigo_esta)
select distinct cons_codigo, esta_codigo
from CAIA_UNLIMITED.Consumible join gd_esquema.Maestra on (Consumible_Codigo = cons_codigo)
								join CAIA_UNLIMITED.Reserva R on (Reserva_Codigo = rese_codigo)
								join CAIA_UNLIMITED.Estadia E on (E.rese_codigo = R.rese_codigo)
where cons_codigo is not null


--Reserva por huesped
insert into CAIA_UNLIMITED.Reserva_X_Huesped (rese_hues_codigo, rese_hues_documento, rese_hues_mail)
select distinct rese_codigo, hues_documento, hues_mail
from CAIA_UNLIMITED.Reserva join gd_esquema.Maestra on (Reserva_Codigo = rese_codigo)
							join CAIA_UNLIMITED.Huesped on (Cliente_Mail = hues_mail and 
															Cliente_Pasaporte_Nro = hues_documento)

insert into CAIA_UNLIMITED.Usuario (usur_username, usur_password, usur_habilitado, usur_intentos) values('admin', HASHBYTES('SHA2_256', 'w23e'), 1, 0)

insert into CAIA_UNLIMITED.Rol (rol_nombre, rol_estado) values('Administrador General', 1)

insert into CAIA_UNLIMITED.Rol_X_Usuario (rol_usur_username, rol_usur_codigo) values('admin', 0)

insert into CAIA_UNLIMITED.Funcionalidad (func_detalle) values('ABM_ROL'), ('ABM_USUARIO'), ('ABM_CLIENTE'), ('ABM_HOTEL'), ('ABM_HABITACION'), ('ABM_ESTADIA'), ('RESERVA'), ('CANCELAR_RESERVA'), ('ESTADIA'), ('CONSUMIBLES'), ('FACTURAR'), ('LISTADO_ESTADISTICO') 

insert into CAIA_UNLIMITED.Funcionalidad_X_Rol (func_rol_codigo_rol, func_rol_codigo_func) 
values (0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (0, 5), (0, 6), (0, 7), (0, 8), (0, 9), (0, 10), (0, 11)

insert into CAIA_UNLIMITED.Estado_Reserva (esre_detalle)
values ('Reserva correcta'), ('Reserva modificada'), ('Reserva cancelada por recepcion'),
		('Reserva cancelada por cliente'), ('Reserva cancelada por Non-Show'),
		('Reserva con ingreso')

update CAIA_UNLIMITED.Huesped set hues_habilitado = 0
where hues_mail in (select h1.hues_mail from CAIA_UNLIMITED.Huesped h1 group by h1.hues_mail having count(*)>1)

--HOTEL

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_AlmacenarHotel] (@nombre_hotel nvarchar(255), @mail nvarchar(255), @estrellas numeric(18,0),
							@hote_telefono nvarchar(20), @calle nvarchar(255), @numero_calle numeric(18,0),
							@ciudad nvarchar(255), @pais nvarchar(255))
AS
BEGIN
	insert into CAIA_UNLIMITED.Direccion (dire_ciudad, dire_pais, dire_dom_calle, dire_nro_calle,
											dire_telefono)
	values (@ciudad, @pais, @calle, @numero_calle, @hote_telefono)
	insert into CAIA_UNLIMITED.Hotel (hote_nombre, hote_mail, hote_cant_estrellas, hote_habilitado, hote_fecha_creacion, dire_id)
	values (@nombre_hotel, @mail, @estrellas, 1, convert(datetime, GETDATE(), 121), (select dire_id from CAIA_UNLIMITED.Direccion
												where dire_telefono = @hote_telefono and
												dire_dom_calle = @calle and dire_ciudad = @ciudad
												and dire_pais = @pais and dire_nro_calle = @numero_calle))		
					
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_RegimenXHotel] (@codigo_regimen numeric(18,0), 
																@id_hotel numeric(18,0))
AS
BEGIN
	insert into CAIA_UNLIMITED.Regimen_X_Hotel (regi_hote_codigo, regi_hote_id)
	values (@codigo_regimen, @id_hotel)
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_BajaHotel] (@id_hotel numeric(18,0), @fecha_inicio datetime, @fecha_fin datetime, @descripcion nvarchar(255))
AS
BEGIN	
	update CAIA_UNLIMITED.Hotel set hote_habilitado = 0 where hote_id = @id_hotel
	insert into CAIA_UNLIMITED.Mantenimiento (hote_id, mant_fecha_inicio, mant_fecha_fin, mant_descripcion)
	values (@id_hotel, convert(datetime, @fecha_inicio, 121), convert(datetime, @fecha_fin, 121), @descripcion)			
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_ModificarHotel] (@idHotel numeric(18,0), @nombre_hotel nvarchar(255), @mail nvarchar(255), @estrellas numeric(18,0),
							@hote_telefono nvarchar(20), @calle nvarchar(255), @numero_calle numeric(18,0),
							@ciudad nvarchar(255), @pais nvarchar(255))
AS
BEGIN
	update CAIA_UNLIMITED.Direccion 
	set dire_dom_calle = @calle, dire_nro_calle = @numero_calle, dire_ciudad = @ciudad, dire_pais = @pais, dire_telefono = @hote_telefono
	where dire_id = (select H.dire_id 
						from CAIA_UNLIMITED.Hotel H join CAIA_UNLIMITED.Direccion D on (H.dire_id = D.dire_id) 
						where hote_id = @idHotel)

	update CAIA_UNLIMITED.Hotel
	set hote_nombre = @nombre_hotel, hote_mail = @mail, hote_cant_estrellas = @estrellas
	where hote_id = @idHotel
END
GO

--HABITACION

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_CrearHabitacion] (@numero_habitacion numeric(18,0), @piso numeric(18,0), @frente nvarchar(50),
													 @descripcion nvarchar(255), @tipo numeric(18,0), @idHotel numeric(18,0))
AS
BEGIN
	insert into CAIA_UNLIMITED.Habitacion (habi_numero, habi_piso, habi_frente, habi_habilitado, habi_descripcion, 
											thab_codigo, hote_id)
	values(@numero_habitacion, @piso, @frente, 1, @descripcion, @tipo, @idHotel)
					
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_ModificarHabitacion] (@numero_habitacion numeric(18,0), @piso numeric(18,0), @frente nvarchar(50),
													 @descripcion nvarchar(255), @viejo_numero numeric(18,0), @idHotel numeric(18,0))
AS
BEGIN
	update CAIA_UNLIMITED.Habitacion set habi_numero = @numero_habitacion, habi_piso = @piso, habi_frente = @frente, habi_descripcion = @descripcion
	where habi_numero = @viejo_numero and hote_id = @idHotel
					
END
GO

--FACTURA

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_AlmacenarFactura] (@numero numeric(18,0), @total numeric(18,2), 
															@estadia numeric(18,0), @mail nvarchar(255),
															@documento numeric(18,0))
AS
BEGIN
	insert into CAIA_UNLIMITED.Factura (fact_nro, fact_total, fact_fecha, esta_codigo, hues_mail, hues_documento)
	values (@numero, @total, convert(datetime, GETDATE(), 121), @estadia, @mail, @documento)
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_AlmacenarItem] (@consumible numeric(18,0), @cantidad numeric(18,0),
														@monto numeric(18,2), @numero_factura numeric(18,0))
AS 
BEGIN
	insert into CAIA_UNLIMITED.Item_Factura (cons_codigo, item_cantidad, item_monto, fact_nro)
	values (@consumible, @cantidad, @monto, @numero_factura)
END

--PAGO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_AlmacenarPagoTarjeta] (@nombre nvarchar(255), @apellido nvarchar(255), 
														@numero_tarjeta nvarchar(20), @codigo_seguridad nvarchar(4),
														@banco nvarchar(20), @fecha_vencimiento smalldatetime,
														@monto numeric(18,2), @numero_factura numeric(18,0))
AS
BEGIN
	insert into CAIA_UNLIMITED.Pago (pago_nombre, pago_apellido, pago_nro_tarjeta, pago_codigo_seguridad,
										pago_banco, pago_fecha_vencimiento, pago_monto)
	values (@nombre, @apellido, @numero_tarjeta, @codigo_seguridad, @banco, convert(datetime, @fecha_vencimiento, 121), @monto)
	update CAIA_UNLIMITED.Factura set pago_codigo = SCOPE_IDENTITY()
	where fact_nro = @numero_factura
END
GO

CREATE PROCEDURE [CAIA_UNLIMITED].[sp_AlmacenarPagoEfectivo] (@monto numeric(18,2), @numero_factura numeric(18,0))
AS
BEGIN
	insert into CAIA_UNLIMITED.Pago (pago_monto)
	values (@monto)
	update CAIA_UNLIMITED.Factura set pago_codigo = SCOPE_IDENTITY()
	where fact_nro = @numero_factura
END
GO