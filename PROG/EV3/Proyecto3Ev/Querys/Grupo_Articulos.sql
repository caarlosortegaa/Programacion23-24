create table Articulos(
IdArticulo int identity(1,1),
Nombre varchar(100),
Grupo int,
Codigo varchar(100),
Precio float,
Activo bit,
Cantidad Float,
UnidadMedida varchar(10),
img image,
descripcion varchar(256)
)

create table Grupo(
IdGrupo int identity(1,1),
nombre varchar(50)
)

insert into Grupo values('Electrodomesticos')

select * from Grupo

create procedure SP_A_CargarArticulo
as begin
select* from Articulos inner join Grupo on Grupo.IdGrupo=Articulos.Grupo
end

create procedure SP_G_CargarDatos
as begin
select Nombre from Grupo 
end

create procedure SP_G_IdGrupo
@Nombre varchar(50)
as begin
select IdGrupo from Grupo where nombre = @Nombre 
end

create procedure SP_G_NombreGrupo
@IdGrupo int 
as begin
select Nombre from Grupo where IdGrupo = @IdGrupo
end

create procedure SP_A_Buscar
@Nombre varchar(50)
as begin
select * from Articulos where Nombre like @Nombre+'%' or Codigo like @Nombre+'%'
end

create procedure SP_A_Insertar
@Nombre varchar(100),
@Grupo int,
@Codigo varchar(100),
@Precio float,
@Activo bit,
@Cantidad float,
@UnidadMedida varchar(10), @Img image, @Descripcion varchar(256) as begin
insert into Articulos values(@Nombre, @Grupo, @Codigo, @Precio, @Activo, 
							@Cantidad, @UnidadMedida, @Img, @Descripcion) end


create procedure SP_A_Eliminar
@IdArticulo int
as begin
delete from Articulos where IdArticulo = @IdArticulo end

create procedure SP_A_Consultar
@IdArticulo int as begin
select * from Articulos where IdArticulo = @IdArticulo end

create procedure SP_A_Actualizar
@IdArticulo int,
@Nombre varchar(100),
@Grupo int,
@Codigo varchar(100),
@Precio float,
@Activo bit,
@Cantidad float,
@UnidadMedida varchar(10), @Descripcion varchar(256) as begin
update Articulos set Nombre = @Nombre, Grupo = @Grupo, Codigo = @Codigo, Precio=@Precio,
					Activo = @Activo, Cantidad = @Cantidad, UnidadMedida = @UnidadMedida, descripcion = descripcion 
					where IdArticulo = @IdArticulo end


create procedure SP_A_ActualizarIMG
@IdArticulo int,
@Img image
as begin
update Articulos set img = @Img where IdArticulo = @IdArticulo end

