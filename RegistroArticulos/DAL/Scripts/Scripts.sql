CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TaBLE Articulos
(
Id int primary key identity,
Precio varchar(10),
Descripcion varchar(30),
Existencia varchar(10),
CantidadCotizada varchar(10)
);