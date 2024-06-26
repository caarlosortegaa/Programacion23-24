use VentasExpress
--CONSULTAR
create procedure SP_U_Consultar
@IdUsuario int
AS 
begin
select * from Usuarios where IdUsuario = @IdUsuario
end
--INSERTAR
Create procedure SP_U_Insertar
@Nombre varchar(50),
@Apellidos varchar(50),
@DNI varchar(20),
@Correo varchar(100),
@Telefono int,
@Fecha_Nacimiento date,
@Privilegio int,
@IMG varchar(max),
@usuario varchar(50),
@contrasenia varchar(500),
@patron varchar(50)
as begin 
insert into Usuarios values(@Nombre, @Apellidos, @DNI, @Correo, @Telefono, @Fecha_Nacimiento, @Privilegio, @IMG,@usuario,(ENCRYPTBYPASSPHRASE(@patron, @contrasenia)))
end

--ELIMINAR
create procedure SP_U_Eliminar
@IdUsuario int
as begin
delete from Usuarios where IdUsuario = @IdUsuario
end

--ACTUALIAR 
create procedure SP_U_Modificar
@IdUsuario int,
@Nombre varchar(50),
@Apellidos varchar(50),
@DNI varchar(20),
@Correo varchar(100),
@Telefono int,
@Fecha_Nacimiento date,
@Privilegio int,
@usuario varchar(50)
as begin
update Usuarios set Nombre=@Nombre, Apellidos=@Apellidos, DNI=@DNI, Correo=@Correo, Telefono=@Telefono, Fecha_nacimiento=@Fecha_Nacimiento, Privilegio=@Privilegio, usuario=@usuario where IdUsuario=@IdUsuario
end

drop procedure SP_U_Modificar

create procedure SP_U_ModificarIMG
@idUsuario int,
@img image
as begin
update Usuarios set img=@img where IdUsuario=@idUsuario
end

create procedure SP_U_ModificarContrasenia
@idUsuario int,
@Contrasenia varchar(500),
@patron varchar(50)
as begin
update Usuarios set contrasenia=(ENCRYPTBYPASSPHRASE(@patron, @Contrasenia)) where IdUsuario=@idUsuario
end

create procedure SP_P_NombrePrivilegio
@IdPrivilegio int
as begin
select NombrePrivilegio from Privilegios where IdPrivilegios=@IdPrivilegio
end

drop procedure SP_P_NombrePrivilegio

create procedure SP_P_IdPrivilegio
@NombrePriivlegio varchar(50)
as begin
select IdPrivilegios from Privilegios where NombrePrivilegio=@NombrePriivlegio
end

create procedure SP_P_CargarPrivilegios
as begin
select NombrePrivilegio from Privilegios
end

create procedure SP_P_CargarUsuarios
as begin
select * from Usuarios inner join Privilegios on Usuarios.Privilegio=Privilegios.IdPrivilegios
end