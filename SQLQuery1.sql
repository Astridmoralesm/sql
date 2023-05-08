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
	, idCiudad int
	, direccion nvarchar (100) not null 
	, estado bit default 'True' 
);
go 

/*DML 
Crear o insertar un registro */

insert into Ciudad(nombre) values (N'Masaya')
insert into Ciudad(nombre) values (N'Managua'), (N'Granada'), (N'Jinotepe'), (N'Leon')

--Mostrar registros 
 select * from Ciudad 

 --Editar Registros
Update Ciudad set nombre = N'Leon', estado = 0 where id = 4

/*En los valores boleanos se puede usar el uno como el cero o el true o el false*/
Update Ciudad set nombre = N'Leon', estado = 'True' where id = 4
go

--Eliminar Registros
delete from Ciudad where id = 4
go

--Antes de tocar una base de datos para mantenimiento hay que hacer respaldos

--Si hago esto se eliminan todos los datos de la base de datos, ya que no especifico una fila en especifico

delete from Ciudad 
go

insert into Ciudad(nombre) values (N'Rivas')
go

--si hago esto se escribe en toda la base de datos
update Ciudad set nombre = N'Rivas'

--Insertar registros a la tabla Personas 
Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'Auxiliadora', N'Marcela', N'Garcia', N'Serrano', '22/02/1974', 1)
go

Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'María', N'Paula', N'Garcia', N'Lopez', '07/06/2005', 1)
go

Insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values (N'Flavio', N'Moises', N'Arana', N'Garcia', '31/12/1992', 1)
go

Select * from Persona
go
--consultas de seccion 
--esto lo cree utilizando ctr shift q
SELECT primerNombre, primerApellido, fechaNac, idCiudad
FROM     Persona

--mostrar en una coluna el primer nombre y el primer apellido y en otra columna la edad de la persona

SELECT primerNombre+N' '+primerApellido as N'Nombre Completo', year(getdate())-year(fechaNac) as Edad, idCiudad
FROM     Persona

print(GetDate()) --imprime la hora a la que se ejecuta el programa

print(year(getDate())) --solo imprime el anio de la fecha
print Month(GetDate())  --muestra unicamente el numero del mes
print Day(GetDate()) --muestra el dia

print convert(nvarchar(10), GetDate(), 102)--muestra la fecha en el formato britanico según el profesor Duran

/*102 - 103 foramato británico*/ 
