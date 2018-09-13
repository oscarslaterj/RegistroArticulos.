CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TaBLE Articulos
(
Id int primary key identity,
Precio decimal,
Descripcion varchar(30),
Existencia int,
CantidadCotizada int 
);