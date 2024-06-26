create database VentasExpress
use VentasExpress

create table Privilegios (
IdPrivilegios int identity(1,1),
NombrePrivilegio varchar(50)
)

create table Usuarios(
IdUsuario int identity(1,1),
Nombre varchar(50),
Apellidos varchar(80),
DNI VARCHAR(20),
Correo varchar(100),
Telefono int,
Fecha_nacimiento date,
Privilegio int
)

alter database VentasExpress set Single_User with Rollback immediate
alter database VentasExpress set multi_user

alter table Usuarios add img image
alter table Usuarios add usuario varchar(50)
alter table Usuarios add contrasenia varbinary(500)

select * from Usuarios
select * from Privilegios

select (Convert(VARCHAR(50), DECRYPTBYPASSPHRASE('VentasExpress', contrasenia))) from Usuarios where IdUsuario = 1

delete from Usuarios

