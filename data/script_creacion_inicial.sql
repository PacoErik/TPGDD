
--------------------------------------------------------------
-------------------Creación del esquema-----------------------
--------------------------------------------------------------

CREATE SCHEMA DERROCHADORES_DE_PAPEL AUTHORIZATION gdHotel2018

GO 

--------------------------------------------------------------
-------------------Creación de stored procedures--------------
--------------------------------------------------------------

CREATE PROCEDURE DERROCHADORES_DE_PAPEL.EliminarRol (@id NUMERIC(18,0))
AS
	BEGIN
		IF ((SELECT COUNT(*)
			FROM DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel
			WHERE rouh_usuario = @id) = 0) 
			BEGIN
				DELETE FROM DERROCHADORES_DE_PAPEL.FuncionalidadXRol WHERE fxro_rol = @id;
				DELETE FROM DERROCHADORES_DE_PAPEL.Rol WHERE rol_id = @id;
			END
	END

GO	

--------------------------------------------------------------
-------------------Creación de funciones----------------------
--------------------------------------------------------------

CREATE FUNCTION DERROCHADORES_DE_PAPEL.DescripcionDeHabitacionACantidad (@descripcion NVARCHAR(255))
RETURNS NUMERIC(1,0)
AS BEGIN
    DECLARE @Cantidad NUMERIC(1,0)

    SET @Cantidad = CASE @descripcion
						WHEN 'Base Simple' THEN 1
						WHEN 'Base Doble' THEN 2
						WHEN 'Base Triple' THEN 3
						WHEN 'Base Cuadruple' THEN 4
						WHEN 'King' THEN 4
						ELSE 0
					END
    RETURN @Cantidad
END

GO

--------------------------------------------------------------
-------------------Creación de las tablas---------------------
--------------------------------------------------------------

CREATE TABLE DERROCHADORES_DE_PAPEL.Funcionalidad (
	func_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	func_detalle NVARCHAR(50) NOT NULL UNIQUE,
	PRIMARY KEY (func_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.TarjetaBancaria (
	tarj_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	tarj_nombreDeEntidad NVARCHAR(50) NOT NULL,
	tarj_numeroDeCuenta NUMERIC(38,0) NOT NULL,
	PRIMARY KEY (tarj_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.ModoDePago (
	modo_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	modo_descripcion NVARCHAR(50) NOT NULL,
	PRIMARY KEY (modo_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Consumible (
	cons_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	cons_detalle NVARCHAR(50) NOT NULL,
	cons_precio NUMERIC(18,2) NOT NULL,
	PRIMARY KEY (cons_codigo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Rol (
	rol_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	rol_nombre NVARCHAR(50) NOT NULL,
	rol_activo BIT NOT NULL,
	PRIMARY KEY (rol_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.EstadoDeReserva (
	esta_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	esta_detalle NVARCHAR(50) NOT NULL,
	PRIMARY KEY (esta_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Nacionalidad (
	naci_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	naci_detalle NVARCHAR(50) NOT NULL,
	PRIMARY KEY (naci_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Hotel (
	hote_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	hote_nombre NVARCHAR(50) NOT NULL,
	hote_mail NVARCHAR(255) NOT NULL,
	hote_telefono NUMERIC(18,0) NOT NULL,
	hote_calle NVARCHAR(50) NOT NULL,
	hote_numeroDeCalle NUMERIC(5,0) NOT NULL,
	hote_localidad NVARCHAR(50) NOT NULL,
	hote_estrellas NUMERIC(1,0) NOT NULL,
	hote_recargaEstrella NUMERIC(4,0) NOT NULL,
	hote_ciudad NVARCHAR(50) NOT NULL,
	hote_pais NVARCHAR(50) NOT NULL,
	hote_fechaDeCreacion DATETIME NOT NULL,
	PRIMARY KEY (hote_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.PeriodoDeCierre (
	peri_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	peri_hotel NUMERIC(18,0) NOT NULL,
	peri_fechaInicio DATETIME NOT NULL,
	peri_fechaFin DATETIME NOT NULL,
	peri_motivo NVARCHAR(255) NOT NULL,
	PRIMARY KEY (peri_id),
	FOREIGN KEY (peri_hotel) REFERENCES DERROCHADORES_DE_PAPEL.Hotel (hote_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Regimen (
	regi_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	regi_descripcion NVARCHAR(50) NOT NULL,
	regi_precioBase NUMERIC(18,2) NOT NULL,
	regi_estado BIT NOT NULL,
	PRIMARY KEY (regi_codigo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Documento (
	docu_tipo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	docu_detalle NVARCHAR(50) NOT NULL,
	PRIMARY KEY (docu_tipo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.TipoDeHabitacion (
	tipo_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	tipo_descripcion NVARCHAR(50) NOT NULL,
	tipo_porcentual NUMERIC(18,2) NOT NULL,
	tipo_cantidadDePersonas NUMERIC(1,0) NOT NULL,
	PRIMARY KEY (tipo_codigo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Habitacion (
	habi_hotel NUMERIC(18,0) NOT NULL,
	habi_numero NUMERIC(18,0) NOT NULL,
	habi_piso NUMERIC(18,0) NOT NULL,
	habi_frente BIT NOT NULL,
	habi_descripcion NVARCHAR(50) NOT NULL,
	habi_tipo NUMERIC(18,0) NOT NULL,
	habi_estado BIT NOT NULL,
	PRIMARY KEY (habi_hotel, habi_numero, habi_piso),
	FOREIGN KEY (habi_tipo) REFERENCES DERROCHADORES_DE_PAPEL.TipoDeHabitacion(tipo_codigo),
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Usuario (
	usur_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	usur_username NVARCHAR(255) NOT NULL,
	usur_password NVARCHAR(64) NOT NULL,
	usur_nombre NVARCHAR(50) NOT NULL,
	usur_apellido NVARCHAR(50) NOT NULL,
	usur_mail NVARCHAR(255) NOT NULL,
	usur_telefono NUMERIC(18,0) NOT NULL,
	usur_fechaDeNacimiento DATETIME NOT NULL,
	usur_calle NVARCHAR(50) NOT NULL,
	usur_numeroDeCalle NUMERIC(8,0) NOT NULL,
	usur_piso NUMERIC(8,0) NOT NULL,
	usur_departamento NVARCHAR(50) NOT NULL,
	usur_localidad NVARCHAR(50) NOT NULL,
	usur_tipoDeDocumento NUMERIC(18,0) NOT NULL,
	usur_numeroDeDocumento NUMERIC(18,0) NOT NULL,
	usur_habilitado BIT NOT NULL,
	PRIMARY KEY (usur_id),
	FOREIGN KEY (usur_tipoDeDocumento) REFERENCES DERROCHADORES_DE_PAPEL.Documento(docu_tipo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Cliente (
	clie_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	clie_nombre NVARCHAR(50) NOT NULL,
	clie_apellido NVARCHAR(50) NOT NULL,
	clie_mail NVARCHAR(255) NOT NULL,
	clie_telefono NUMERIC(18,0) NOT NULL,
	clie_fechaDeNacimiento DATETIME NOT NULL,
	clie_calle NVARCHAR(50) NOT NULL,
	clie_numeroDeCalle NUMERIC(8,0) NOT NULL,
	clie_piso NUMERIC(8,0) NOT NULL,
	clie_departamento NVARCHAR(50) NOT NULL,
	clie_localidad NVARCHAR(50) NOT NULL,
	clie_tipoDeDocumento NUMERIC(18,0) NOT NULL,
	clie_numeroDeDocumento NUMERIC(18,0) NOT NULL,
	clie_habilitado BIT NOT NULL,
	clie_nacionalidad NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (clie_id),
	FOREIGN KEY (clie_tipoDeDocumento) REFERENCES DERROCHADORES_DE_PAPEL.Documento(docu_tipo),
	FOREIGN KEY (clie_nacionalidad) REFERENCES DERROCHADORES_DE_PAPEL.Nacionalidad(naci_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Reserva (
	rese_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	rese_fecha DATETIME NOT NULL,
	rese_hotel NUMERIC(18,0) NOT NULL,
	rese_inicio DATETIME NOT NULL,
	rese_fin DATETIME NOT NULL,
	rese_cliente NUMERIC(18,0) NOT NULL,
	rese_regimen NUMERIC(18,0) NOT NULL,
	rese_usuario NUMERIC(18,0) NOT NULL,
	rese_estado NUMERIC(18,0) NOT NULL,
	rese_cantidadDeNoches NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (rese_codigo),
	FOREIGN KEY (rese_hotel) REFERENCES DERROCHADORES_DE_PAPEL.Hotel(hote_id),
	FOREIGN KEY (rese_cliente) REFERENCES DERROCHADORES_DE_PAPEL.Cliente(clie_id),
	FOREIGN KEY (rese_regimen) REFERENCES DERROCHADORES_DE_PAPEL.Regimen(regi_codigo),
	FOREIGN KEY (rese_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id),
	FOREIGN KEY (rese_estado) REFERENCES DERROCHADORES_DE_PAPEL.EstadoDeReserva(esta_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.ModificacionReserva (
	modi_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	modi_reserva NUMERIC(18,0) NOT NULL,
	modi_fechaDeModificacion DATETIME NOT NULL,
	modi_usuario NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (modi_id),
	FOREIGN KEY (modi_reserva) REFERENCES DERROCHADORES_DE_PAPEL.Reserva(rese_codigo),
	FOREIGN KEY (modi_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.CancelacionReserva (
	canc_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	canc_reserva NUMERIC(18,0) NOT NULL,
	canc_motivo NVARCHAR(255) NOT NULL,
	canc_fechaDeCancelacion DATETIME NOT NULL,
	canc_usuario NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (canc_id),
	FOREIGN KEY (canc_reserva) REFERENCES DERROCHADORES_DE_PAPEL.Reserva(rese_codigo),
	FOREIGN KEY (canc_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Estadia (
	esta_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	esta_fechaDeInicio DATETIME NOT NULL,
	esta_fechaDeFin DATETIME NOT NULL,
	esta_cantidadDeNoches NUMERIC(18,0) NOT NULL,
	esta_reserva NUMERIC(18,0) NOT NULL,
	esta_usuarioCheckIn NUMERIC(18,0) NOT NULL,
	esta_usuarioCheckOut NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (esta_id),
	FOREIGN KEY (esta_reserva) REFERENCES DERROCHADORES_DE_PAPEL.Reserva(rese_codigo),
	FOREIGN KEY (esta_usuarioCheckIn) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id),
	FOREIGN KEY (esta_usuarioCheckOut) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id),
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Factura (
	fact_numero NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	fact_fecha DATETIME NOT NULL,
	fact_costoTotal NUMERIC(18,2) NOT NULL,
	fact_estadia NUMERIC(18,0) NOT NULL,
	fact_cliente NUMERIC(18,0) NOT NULL,
	fact_modoDePago NUMERIC(18,0) NOT NULL,
	fact_tarjeta NUMERIC(18,0),
	PRIMARY KEY (fact_numero),
	FOREIGN KEY (fact_estadia) REFERENCES DERROCHADORES_DE_PAPEL.Estadia(esta_id),
	FOREIGN KEY (fact_cliente) REFERENCES DERROCHADORES_DE_PAPEL.Cliente(clie_id),
	FOREIGN KEY (fact_modoDePago) REFERENCES DERROCHADORES_DE_PAPEL.ModoDePago(modo_id),
	FOREIGN KEY (fact_tarjeta) REFERENCES DERROCHADORES_DE_PAPEL.TarjetaBancaria(tarj_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.ItemDeFactura (
	item_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	item_cantidad NUMERIC(18,0) NOT NULL,
	item_monto NUMERIC(18,2) NOT NULL,
	item_factura NUMERIC(18,0) NOT NULL,
	item_descripcion NVARCHAR(50) NOT NULL,
	item_consumible NUMERIC(18,0),
	PRIMARY KEY (item_id),
	FOREIGN KEY (item_factura) REFERENCES DERROCHADORES_DE_PAPEL.Factura(fact_numero),
	FOREIGN KEY (item_consumible) REFERENCES DERROCHADORES_DE_PAPEL.Consumible(cons_codigo)
)

CREATE TABLE DERROCHADORES_DE_PAPEL.EstadiaXCliente (
	esxc_estadia NUMERIC(18,0) NOT NULL,
	esxc_cliente NUMERIC(18,0) NOT NULL,
	esxc_hotel NUMERIC(18,0) NOT NULL,
	esxc_numero NUMERIC(18,0) NOT NULL,
	esxc_piso NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (esxc_estadia, esxc_cliente),
	FOREIGN KEY (esxc_estadia) REFERENCES DERROCHADORES_DE_PAPEL.Estadia(esta_id),
	FOREIGN KEY (esxc_cliente) REFERENCES DERROCHADORES_DE_PAPEL.Cliente(clie_id),
	FOREIGN KEY (esxc_hotel, esxc_numero, esxc_piso) REFERENCES DERROCHADORES_DE_PAPEL.Habitacion(habi_hotel, habi_numero, habi_piso)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.FuncionalidadXRol (
	fxro_funcionalidad NUMERIC(18,0) NOT NULL,
	fxro_rol NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (fxro_funcionalidad, fxro_rol),
	FOREIGN KEY (fxro_funcionalidad) REFERENCES DERROCHADORES_DE_PAPEL.Funcionalidad(func_id),
	FOREIGN KEY (fxro_rol) REFERENCES DERROCHADORES_DE_PAPEL.Rol(rol_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.RegimenXHotel (
	rexh_regimen NUMERIC(18,0) NOT NULL,
	rexh_hotel NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (rexh_regimen, rexh_hotel),
	FOREIGN KEY (rexh_regimen) REFERENCES DERROCHADORES_DE_PAPEL.Regimen(regi_codigo),
	FOREIGN KEY (rexh_hotel) REFERENCES DERROCHADORES_DE_PAPEL.Hotel(hote_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.ReservaXHabitacion (
	rexh_reserva NUMERIC(18,0) NOT NULL,
	rexh_hotel NUMERIC(18,0) NOT NULL,
	rexh_numero NUMERIC(18,0) NOT NULL,
	rexh_piso NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (rexh_reserva, rexh_hotel, rexh_numero, rexh_piso),
	FOREIGN KEY (rexh_reserva) REFERENCES DERROCHADORES_DE_PAPEL.Reserva(rese_codigo),
	FOREIGN KEY (rexh_hotel, rexh_numero, rexh_piso) REFERENCES DERROCHADORES_DE_PAPEL.Habitacion(habi_hotel, habi_numero, habi_piso)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel (
	rouh_rol NUMERIC(18,0) NOT NULL,
	rouh_usuario NUMERIC(18,0) NOT NULL,
	rouh_hotel NUMERIC(18,0) NOT NULL,
	rouh_habilitado BIT NOT NULL,
	PRIMARY KEY (rouh_rol, rouh_usuario, rouh_hotel),
	FOREIGN KEY (rouh_rol) REFERENCES DERROCHADORES_DE_PAPEL.Rol(rol_id),
	FOREIGN KEY (rouh_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id),
	FOREIGN KEY (rouh_hotel) REFERENCES DERROCHADORES_DE_PAPEL.Hotel(hote_id)
)

GO

--------------------------------------------------------------
-------------------Migración de los datos---------------------
--------------------------------------------------------------

-- Funcionalidad - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Funcionalidad (func_detalle) VALUES 	('ABM DE ROL'),
																		('ABM DE USUARIO'),
																		('ABM DE CLIENTE'),
																		('ABM DE HOTEL'),
																		('ABM DE HABITACION'),
																		('ABM REGIMEN DE ESTADIA'),
																		('GENERAR O MODIFICAR UNA RESERVA'),
																		('CANCELAR RESERVA' ),
																		('REGISTRAR ESTADIA'),
																		('REGISTRAR CONSUMIBLES'),
																		('LISTADO ESTADISTICO')

GO																		
	
-- Tarjeta bancaria - Vacio

-- Modo de pago - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.ModoDePago (modo_descripcion) VALUES ('TARJETA DE CREDITO'),
																		('EFECTIVO')

GO
																		
-- Consumible - Carga automatica

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Consumible ON

INSERT INTO DERROCHADORES_DE_PAPEL.Consumible (cons_codigo, cons_detalle, cons_precio)
	SELECT DISTINCT Consumible_Codigo, Consumible_Descripcion, Consumible_Precio
	FROM gd_esquema.Maestra 
	WHERE Consumible_Codigo IS NOT NULL
	ORDER BY Consumible_Codigo

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Consumible OFF
	
GO
	
-- Rol - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Rol (rol_nombre, rol_activo) VALUES 	('ADMINISTRADOR GENERAL', 1),
																		('ADMINISTRADOR', 1),
																		('RECEPCIONISTA', 1),
																		('GUEST', 1)

GO																		
																		
-- Estado de reserva - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.EstadoDeReserva (esta_detalle) VALUES 	('RESERVA CORRECTA'),
																			('RESERVA MODIFICADA'),
																			('RESERVA CANCELADA POR RECEPCION'),
																			('RESERVA CANCELADA POR CLIENTE'),
																			('RESERVA CANCELADA POR NO-SHOW'),
																			('RESERVA EFECTIVIZADA')

GO																			
																			
-- Nacionalidad - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Nacionalidad (naci_detalle) VALUES ('ARGENTINO')

GO

-- Hotel - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.Hotel (hote_nombre, hote_mail, hote_telefono, hote_calle, hote_numeroDeCalle, hote_localidad, hote_estrellas, hote_recargaEstrella, hote_ciudad, hote_pais, hote_fechaDeCreacion)
  	SELECT DISTINCT 'Hotel '+RTRIM(Hotel_Ciudad)+' '+STR(Hotel_Nro_Calle), '', 0, Hotel_Calle, Hotel_Nro_Calle, '', Hotel_CantEstrella, Hotel_Recarga_Estrella, Hotel_Ciudad, 'ARGENTINA', CONVERT(datetime,0)
	FROM gd_esquema.Maestra
GO
	
-- Periodo de cierre - Vacio

-- Regimen - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.Regimen (regi_descripcion, regi_precioBase, regi_estado)
	SELECT DISTINCT Regimen_Descripcion, Regimen_Precio, 1
	FROM gd_esquema.Maestra

GO
	
-- Documento - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Documento (docu_detalle) VALUES ('DOCUMENTO NACIONAL DE IDENTIDAD')
INSERT INTO DERROCHADORES_DE_PAPEL.Documento (docu_detalle) VALUES ('CARNET DE EXTRANJERIA')
INSERT INTO DERROCHADORES_DE_PAPEL.Documento (docu_detalle) VALUES ('PASAPORTE')

GO

-- Cliente - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.Cliente (clie_nombre, clie_apellido, clie_mail, clie_telefono, clie_fechaDeNacimiento, clie_calle, clie_numeroDeCalle, clie_piso, clie_departamento, clie_localidad, clie_tipoDeDocumento, clie_numeroDeDocumento, clie_habilitado, clie_nacionalidad)
	SELECT Cliente_Nombre, Cliente_Apellido, Cliente_Mail, 0, MAX(Cliente_Fecha_Nac), MAX(Cliente_Dom_Calle), MAX(Cliente_Nro_Calle), MAX(Cliente_Piso), MAX(Cliente_Depto), '', (SELECT docu_tipo FROM DERROCHADORES_DE_PAPEL.Documento WHERE docu_detalle = 'PASAPORTE'), MAX(Cliente_Pasaporte_Nro), 1, (SELECT naci_id FROM DERROCHADORES_DE_PAPEL.Nacionalidad WHERE naci_detalle = 'ARGENTINO')
	FROM gd_esquema.Maestra
	GROUP BY Cliente_Nombre, Cliente_Apellido, Cliente_Mail

GO

INSERT INTO DERROCHADORES_DE_PAPEL.Cliente (clie_nombre, clie_apellido, clie_mail, clie_telefono, clie_fechaDeNacimiento, clie_calle, clie_numeroDeCalle, clie_piso, clie_departamento, clie_localidad, clie_tipoDeDocumento, clie_numeroDeDocumento, clie_habilitado, clie_nacionalidad)
	SELECT DISTINCT Cliente_Nombre, Cliente_Apellido, Cliente_Mail, 0, Cliente_Fecha_Nac, Cliente_Dom_Calle, Cliente_Nro_Calle, Cliente_Piso, Cliente_Depto, '', (SELECT docu_tipo FROM DERROCHADORES_DE_PAPEL.Documento WHERE docu_detalle = 'PASAPORTE'), Cliente_Pasaporte_Nro, 0, (SELECT naci_id FROM DERROCHADORES_DE_PAPEL.Nacionalidad WHERE naci_detalle = 'ARGENTINO')
	FROM gd_esquema.Maestra 
	WHERE Cliente_Pasaporte_Nro NOT IN (SELECT C.clie_numeroDeDocumento
										FROM DERROCHADORES_DE_PAPEL.Cliente C
										WHERE C.clie_nombre = Cliente_Nombre AND C.clie_apellido = Cliente_Apellido)

GO

-- Tipo de habitacion - Carga automatica

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.TipoDeHabitacion ON 

INSERT INTO DERROCHADORES_DE_PAPEL.TipoDeHabitacion (tipo_codigo, tipo_descripcion, tipo_porcentual, tipo_cantidadDePersonas)
	SELECT DISTINCT Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual, DERROCHADORES_DE_PAPEL.DescripcionDeHabitacionACantidad(Habitacion_Tipo_Descripcion)
	FROM gd_esquema.Maestra
	ORDER BY Habitacion_Tipo_Codigo

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.TipoDeHabitacion OFF

GO

-- Habitacion - Carga automatica
INSERT INTO DERROCHADORES_DE_PAPEL.Habitacion (habi_hotel, habi_numero, habi_piso, habi_frente, habi_descripcion, habi_tipo, habi_estado)
	SELECT DISTINCT hote_id, Habitacion_Numero, Habitacion_Piso, (CASE Habitacion_Frente WHEN 'S' THEN 1 ELSE 0 END), '', Habitacion_Tipo_Codigo, 1
	FROM DERROCHADORES_DE_PAPEL.Hotel JOIN gd_esquema.Maestra ON (Hotel_Ciudad = hote_ciudad AND
																Hotel_Calle = hote_calle AND
																Hotel_Nro_Calle = hote_numeroDeCalle)
	ORDER BY hote_id
	
GO
	
-- Usuario - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Usuario (usur_username, usur_password, usur_nombre, usur_apellido, usur_mail, usur_telefono, usur_fechaDeNacimiento, usur_calle, usur_numeroDeCalle, usur_piso, usur_departamento, usur_localidad, usur_tipoDeDocumento, usur_numeroDeDocumento, usur_habilitado) 
	VALUES 	('admin', 'E6B87050BFCB8143FCB8DB0170A4DC9ED00D904DDD3E2A4AD1B1E8DC0FDC9BE7', '', '', '', 0, CONVERT(datetime,0), '', 0, 0, '', '', 1, 0, 1),
			('guest', '', '', '', '', 0, CONVERT(datetime,0), '', 0, 0, '', '', 1, 0, 1)

GO

-- Reserva - Carga automatica

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Reserva ON

INSERT INTO DERROCHADORES_DE_PAPEL.Reserva (rese_codigo, rese_fecha, rese_hotel, rese_inicio, rese_fin, rese_cliente, rese_regimen, rese_usuario, rese_estado, rese_cantidadDeNoches)
	SELECT Reserva_Codigo, CONVERT(datetime,'2017-01-01'), hote_id, Reserva_Fecha_Inicio, (Reserva_Fecha_Inicio+Reserva_Cant_Noches), (SELECT clie_id FROM DERROCHADORES_DE_PAPEL.Cliente WHERE Cliente_Mail = clie_mail AND Cliente_Pasaporte_Nro = clie_numeroDeDocumento), (SELECT regi_codigo FROM DERROCHADORES_DE_PAPEL.Regimen WHERE regi_descripcion = Regimen_Descripcion), 2, (CASE WHEN MAX(Factura_Nro) IS NULL THEN (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = 'RESERVA CANCELADA POR NO-SHOW') ELSE (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = 'RESERVA EFECTIVIZADA') END), Reserva_Cant_Noches
	FROM DERROCHADORES_DE_PAPEL.Hotel JOIN gd_esquema.Maestra ON (Hotel_Ciudad = hote_ciudad AND
																	Hotel_Calle = hote_calle AND
																	Hotel_Nro_Calle = hote_numeroDeCalle)
	GROUP BY Reserva_Codigo, hote_id, Reserva_Fecha_Inicio, Reserva_Cant_Noches, Cliente_Mail, Cliente_Pasaporte_Nro, Regimen_Descripcion
	ORDER BY Reserva_Codigo

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Reserva OFF

GO
	
-- Modificacion reserva - Vacio

-- Cancelacion Reserva - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.CancelacionReserva (canc_reserva, canc_motivo, canc_fechaDeCancelacion, canc_usuario)
	SELECT rese_codigo, 'Motivo desconocido', rese_fin, 1
	FROM DERROCHADORES_DE_PAPEL.Reserva 
	WHERE rese_estado = (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.EstadoDeReserva WHERE esta_detalle = 'RESERVA CANCELADA POR NO-SHOW')

GO
	
-- Estadia - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.Estadia (esta_fechaDeInicio, esta_fechaDeFin, esta_cantidadDeNoches, esta_reserva, esta_usuarioCheckIn, esta_usuarioCheckOut)
	SELECT DISTINCT Estadia_Fecha_Inicio, (Estadia_Fecha_Inicio+Estadia_Cant_Noches), Estadia_Cant_Noches, Reserva_Codigo, 1, 1 
	FROM gd_esquema.Maestra 
	WHERE Reserva_Codigo IS NOT NULL AND
			Estadia_Fecha_Inicio IS NOT NULL
	ORDER BY Reserva_Codigo

GO

-- Factura - Carga automatica

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Factura ON

INSERT INTO DERROCHADORES_DE_PAPEL.Factura (fact_numero, fact_fecha, fact_costoTotal, fact_estadia, fact_cliente, fact_modoDePago, fact_tarjeta)
	SELECT Factura_Nro, Factura_Fecha, SUM(Item_Factura_Cantidad), (SELECT esta_id FROM DERROCHADORES_DE_PAPEL.Estadia WHERE esta_reserva = Reserva_Codigo), (SELECT clie_id FROM DERROCHADORES_DE_PAPEL.Cliente WHERE clie_numeroDeDocumento = Cliente_Pasaporte_Nro AND clie_mail = Cliente_Mail), 2, NULL
	FROM gd_esquema.Maestra 
	WHERE Factura_Nro IS NOT NULL
	GROUP BY Factura_Nro, Factura_Fecha, Reserva_Codigo, Cliente_Pasaporte_Nro, Cliente_Mail
	ORDER BY Factura_Nro

SET IDENTITY_INSERT DERROCHADORES_DE_PAPEL.Factura OFF

GO

-- Item de factura - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.ItemDeFactura (item_cantidad, item_monto, item_factura, item_descripcion, item_consumible)
	SELECT Item_Factura_Monto, Item_Factura_Cantidad, Factura_Nro, (CASE WHEN Consumible_Codigo IS NULL THEN 'Hospedaje' ELSE STR(Item_Factura_Monto)+'x '+Consumible_Descripcion END), (CASE WHEN Consumible_Codigo IS NULL THEN NULL ELSE (SELECT cons_codigo FROM DERROCHADORES_DE_PAPEL.Consumible WHERE cons_detalle = Consumible_Descripcion) END)
	FROM gd_esquema.Maestra 
	WHERE Factura_Nro IS NOT NULL
	ORDER BY Factura_Nro

GO

-- EstadiaXCliente - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.EstadiaXCliente (esxc_estadia, esxc_cliente, esxc_hotel, esxc_numero, esxc_piso)
	SELECT esta_id, 
		clie_id, 
		(SELECT hote_id FROM DERROCHADORES_DE_PAPEL.Hotel WHERE rese_hotel = hote_id),
		(SELECT DISTINCT Habitacion_Numero FROM gd_esquema.Maestra WHERE Reserva_Codigo = rese_codigo),
		(SELECT DISTINCT Habitacion_Piso FROM gd_esquema.Maestra WHERE Reserva_Codigo = rese_codigo)
	FROM DERROCHADORES_DE_PAPEL.Estadia, DERROCHADORES_DE_PAPEL.Cliente, DERROCHADORES_DE_PAPEL.Reserva
	WHERE clie_id = rese_cliente AND 
		esta_reserva = rese_codigo

GO

-- FuncionalidadXRol - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol)
	SELECT func_id, rol_id 
	FROM DERROCHADORES_DE_PAPEL.Funcionalidad, DERROCHADORES_DE_PAPEL.Rol
	WHERE rol_nombre = 'ADMINISTRADOR GENERAL'
	
INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol)
	SELECT func_id, rol_id 
	FROM DERROCHADORES_DE_PAPEL.Funcionalidad, DERROCHADORES_DE_PAPEL.Rol
	WHERE rol_nombre = 'ADMINISTRADOR' AND
		func_detalle IN ('ABM DE HOTEL','ABM DE HABITACION','ABM REGIMEN DE ESTADIA','ABM DE USUARIO')
	
INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol)
	SELECT func_id, rol_id 
	FROM DERROCHADORES_DE_PAPEL.Funcionalidad, DERROCHADORES_DE_PAPEL.Rol
	WHERE rol_nombre = 'RECEPCIONISTA' AND
		func_detalle IN ('ABM DE CLIENTE','GENERAR O MODIFICAR UNA RESERVA','CANCELAR RESERVA','REGISTRAR ESTADIA','REGISTRAR CONSUMIBLES')
	
INSERT INTO DERROCHADORES_DE_PAPEL.FuncionalidadXRol (fxro_funcionalidad, fxro_rol)
	SELECT func_id, rol_id 
	FROM DERROCHADORES_DE_PAPEL.Funcionalidad, DERROCHADORES_DE_PAPEL.Rol
	WHERE rol_nombre = 'GUEST' AND 
		func_detalle IN ('GENERAR O MODIFICAR UNA RESERVA','CANCELAR RESERVA')

GO
			
-- RegimenXHotel - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.RegimenXHotel (rexh_regimen, rexh_hotel)
	SELECT (SELECT regi_codigo
			FROM DERROCHADORES_DE_PAPEL.Regimen
			WHERE regi_descripcion = Regimen_Descripcion), 
			(SELECT hote_id
			FROM DERROCHADORES_DE_PAPEL.Hotel
			WHERE hote_calle = Hotel_Calle AND
					hote_numeroDeCalle = Hotel_Nro_Calle)
	FROM gd_esquema.Maestra
	GROUP BY Regimen_Descripcion, Hotel_Calle, Hotel_Nro_Calle
	ORDER BY 1, 2
	
GO

-- ReservaXHabitacion - Carga automatica

INSERT INTO DERROCHADORES_DE_PAPEL.ReservaXHabitacion (rexh_reserva, rexh_hotel, rexh_numero, rexh_piso)
	SELECT DISTINCT Reserva_Codigo, (SELECT hote_id FROM DERROCHADORES_DE_PAPEL.Hotel WHERE hote_calle = Hotel_Calle AND hote_numeroDeCalle = Hotel_Nro_Calle), Habitacion_Numero, Habitacion_Piso
	FROM gd_esquema.Maestra
	ORDER BY Reserva_Codigo
	
GO

-- RolXUsuarioXHotel - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.RolXUsuarioXHotel (rouh_rol, rouh_usuario, rouh_hotel, rouh_habilitado)
	SELECT rol_id, usur_id, hote_id, 1
	FROM DERROCHADORES_DE_PAPEL.Rol, DERROCHADORES_DE_PAPEL.Usuario, DERROCHADORES_DE_PAPEL.Hotel
	WHERE (rol_nombre = 'ADMINISTRADOR GENERAL' AND usur_username = 'admin') OR
			(rol_nombre = 'GUEST' AND usur_username = 'guest')

GO

