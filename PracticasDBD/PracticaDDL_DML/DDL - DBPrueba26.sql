-- DDL 

/* Creando la base de datos */
create database DBPrueba26;
go

use DBPrueba26;
go

/* Creacion de las tablas de la base de datos */

-- Tabla Ciudad
create table Ciudad (
	idCiudad int PRIMARY KEY IDENTITY (1, 1),
	nombreCiudad nvarchar(50) not null,
	estado bit default 1
)
go

-- Tabla Persona
create table Persona (
	idPersona int PRIMARY KEY IDENTITY (1, 1),
	primerNombre nvarchar(50) not null,
	segundoNombre nvarchar(50),
	primerApellido nvarchar(50) not null,
	segundoApellido nvarchar(50),
	fechaNac datetime not null,
	sexo bit default 1,
	telefono nvarchar(16) not null,
	correo nvarchar(100) not null,
	direccion nvarchar(200) not null,
	activo bit default 'True'
);
go