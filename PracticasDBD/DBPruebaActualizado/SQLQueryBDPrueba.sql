--DLL
/* Create db*/

create database DBPrueba26
go

use DBPrueba26
go

create table Ciudad(
  id INT PRIMARY KEY IDENTITY(1, 1),
  nombre nvarchar(50) not null,
  estado bit default 1
);
go

create table Persona(
    id int Primary key identity (1, 1)
	, primerNombre nvarchar(50) NOT NULL
	, segundoNombre nvarchar(50) 
	, primerApellido nvarchar(50) NOT NULL
	, segundoApellido nvarchar(50) 
	, fechaNac dateTime NOT NULL
	, sexo bit default 1 
	, telefono nvarchar(16) 
	, email nvarchar(100)
	,idCiudad int
	, direccion nvarchar(100) 
	, estado bit default 'true'

);
go 

--DML
/*Crear o Insertar un registro*/

Insert into Ciudad(nombre) values(N'Masaya') 
Insert into Ciudad(nombre) values(N'Managua'),(N'Granada'),(N'Rivas'),(N'León')


--Mostrar Registro

Select * from Ciudad
Select * from Persona


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

-- Query con ctrl + shift + q
SELECT        Persona.primerNombre AS Nombre, Persona.primerApellido AS Apellido, Ciudad.nombreCiudad AS Ciudad
FROM            Ciudad INNER JOIN
                         Persona ON Ciudad.idCiudad = Persona.idCiudad

-- Otra insercion de datos
insert into Persona(primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNac, idCiudad) values 
-- (N'Avi', N'Miguel', N'Zepeda', N'Talavera', N'01-02-2003', 2), 
(N'Luswi', N'Danilo', N'Torres', N'Pomarez', N'20-07-2004', 2),
(N'Lian', N'Alexis', N'Torres', N'Pomarez', N'29-07-2008', 2),
(N'Jose', N'Carlos', N'Perez', N'Reinosa', N'03-03-2003', 2),
(N'Henry', N'Noel', N'Reyes', N'Duarte', N'01-01-1900', 3)

-- funcion like, para buscar coincidencias dependiendo de lo indicado: A% (Que empiezen con A sin importar los siguientes datos)
-- %A (Que finalizen con A sin importar los datos anteriores)
-- %A% (Que contenga A)
select *, ciudad.nombreCiudad from Persona inner join ciudad on ciudad.idCiudad = Persona.idCiudad where ciudad.nombreCiudad like N'%n%'

-- Operadores logicos
-- and (y)
-- or (o)
-- between (entre)
-- in (en)
Select primerNombre, primerApellido, year(getdate()) - year(fechaNac) as edad from Persona where year(getdate()) - year(fechaNac) in (18, 23)

-- Hacer consultas con valores null
-- is null
select * from Persona where telefono is NULL