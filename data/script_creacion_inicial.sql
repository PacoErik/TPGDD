
--------------------------------------------------------------
-------------------Creación del esquema-----------------------
--------------------------------------------------------------

CREATE SCHEMA DERROCHADORES_DE_PAPEL AUTHORIZATION gdHotel2018
GO 

--------------------------------------------------------------
-------------------Creación de las tablas---------------------
--------------------------------------------------------------
CREATE TABLE DERROCHADORES_DE_PAPEL.Funcionalidad (
	func_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	func_detalle NVARCHAR(50) NOT NULL,
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
	hote_localidad NVARCHAR(50) NOT NULL,
	hote_estrellas NUMERIC(1,0) NOT NULL,
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
CREATE TABLE DERROCHADORES_DE_PAPEL.DatosDePersona (
	dato_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	dato_nombre NVARCHAR(50) NOT NULL,
	dato_apellido NVARCHAR(50) NOT NULL,
	dato_mail NVARCHAR(255) NOT NULL,
	dato_telefono NUMERIC(18,0) NOT NULL,
	dato_calle NVARCHAR(50) NOT NULL,
	dato_numeroDeCalle NUMERIC(8,0) NOT NULL,
	dato_piso NUMERIC(8,0) NOT NULL,
	dato_departamento NUMERIC(8,0) NOT NULL,
	dato_localidad NVARCHAR(50) NOT NULL,
	dato_fechaDeNacimiento DATETIME NOT NULL,
	dato_tipoDeDocumento NUMERIC(18,0) NOT NULL,
	dato_numeroDePasaporte NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (dato_id),
	FOREIGN KEY (dato_tipoDeDocumento) REFERENCES DERROCHADORES_DE_PAPEL.Documento(docu_tipo)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.TipoDeHabitacion (
	tipo_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	tipo_descripcion NVARCHAR(50) NOT NULL,
	tipo_porcentual NUMERIC(18,2) NOT NULL,
	tipo_cantidadDePersonas NUMERIC(1,0),
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
	usur_password NVARCHAR(255) NOT NULL,
	usur_datosDePersona NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (usur_id),
	FOREIGN KEY (usur_datosDePersona) REFERENCES DERROCHADORES_DE_PAPEL.DatosDePersona(dato_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Cliente (
	clie_id NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	clie_nacionalidad NUMERIC(18,0) NOT NULL,
	clie_datosDePersona NUMERIC(18,0) NOT NULL,
	clie_habilitado BIT NOT NULL,
	PRIMARY KEY (clie_id),
	FOREIGN KEY (clie_nacionalidad) REFERENCES DERROCHADORES_DE_PAPEL.Nacionalidad(naci_id),
	FOREIGN KEY (clie_datosDePersona) REFERENCES DERROCHADORES_DE_PAPEL.DatosDePersona(dato_id)
)
CREATE TABLE DERROCHADORES_DE_PAPEL.Reserva (
	rese_codigo NUMERIC(18,0) IDENTITY(1,1) NOT NULL,
	rese_fecha DATETIME NOT NULL,
	rese_hotel NUMERIC(18,0) NOT NULL,
	rese_inicio DATETIME NOT NULL,
	rese_fin DATETIME NOT NULL,
	rese_cliente NUMERIC(18,0) NOT NULL,
	rese_regimen NUMERIC(18,0) NOT NULL,
	rese_costoTotal NUMERIC(18,2) NOT NULL,
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
	esta_usuarioCheckOut NUMERIC(18,0),
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
	item_consumible NUMERIC(18,0) NOT NULL,
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
CREATE TABLE DERROCHADORES_DE_PAPEL.HotelXUsuario (
	hoxu_hotel NUMERIC(18,0) NOT NULL,
	hoxu_usuario NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (hoxu_hotel, hoxu_usuario),
	FOREIGN KEY (hoxu_hotel) REFERENCES DERROCHADORES_DE_PAPEL.Hotel(hote_id),
	FOREIGN KEY (hoxu_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id)
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
CREATE TABLE DERROCHADORES_DE_PAPEL.RolXUsuario (
	roxu_rol NUMERIC(18,0) NOT NULL,
	roxu_usuario NUMERIC(18,0) NOT NULL,
	PRIMARY KEY (roxu_rol, roxu_usuario),
	FOREIGN KEY (roxu_rol) REFERENCES DERROCHADORES_DE_PAPEL.Rol(rol_id),
	FOREIGN KEY (roxu_usuario) REFERENCES DERROCHADORES_DE_PAPEL.Usuario(usur_id)
)

--------------------------------------------------------------
-------------------Migración de los datos---------------------
--------------------------------------------------------------

-- Funcionalidad - Carga manual

-- Tarjeta bancaria - Vacio

-- Modo de pago - Carga manual

-- Consumible - Carga automatica

-- Rol - Carga manual

INSERT INTO DERROCHADORES_DE_PAPEL.Rol (rol_nombre, rol_activo) VALUES ("Administrador", 1)
INSERT INTO DERROCHADORES_DE_PAPEL.Rol (rol_nombre, rol_activo) VALUES ("Recepcionista", 1)
INSERT INTO DERROCHADORES_DE_PAPEL.Rol (rol_nombre, rol_activo) VALUES ("Guest", 1)

-- Estado de reserva - Carga manual

-- Nacionalidad - Carga manual

-- Hotel - Carga automatica

-- Periodo de cierre - Vacio

-- Regimen - Carga automatica

-- Documento - Carga manual

-- Datos de persona - Carga automatica

-- Tipo de habitacion - Carga automatica

-- Habitacion - Carga automatica

-- Usuario - Carga manual

-- Cliente - Carga automatica

-- Reserva - Carga automatica

-- Modificacion reserva - Vacio

-- Cancelacion Reserva - Vacio

-- Estadia - Carga automatica

-- Factura - Carga automatica

-- Item de factura - Carga automatica

-- EstadiaXCliente - Carga automatica

-- FuncionalidadXRol - Carga manual

-- HotelXUsuario - Carga manual

-- RegimenXHotel - Carga automatica

-- ReservaXHabitacion - Carga automatica

-- RolXUsuario - Carga manual










