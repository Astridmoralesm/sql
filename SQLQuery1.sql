--DDL 
/*Crear base de datos*/

create database DBPrueba26;
go 

use DBPrueba26
go 

create table Ciudad (
	id INT PRIMARY KEY identity (1, 1),
	nombre NVARCHAR (50) NOT NULL,
	estado bit default 1,
);
go 

create table Persona (
	id INT PRIMARY KEY identity (1, 1)
	, primerNombre nvarchar(50) not null 
	, segundoNombre nvarchar(50)  
	, primerApellido nvarchar(50) not null 
	, segundoApellido nvarchar (50) 
	, fechaNac dateTime not null  
	, sexo bit default 1 not null 
	, telefono nvarchar(16) not null 
	, email nvarchar(100) not null 
	, direccion nvarchar (100) not null 
	, estado bit default 'True' 
);
go 

