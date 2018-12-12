
Use BDEA_Valverde
go;

Create or ALTER   procedure [dbo].[pa_persona_listarTodos]
as
select  P.dni , P.Apellidop, P.Apellidom,  P.Nombres, P.Direccion , P.Email , P.Edad
from Persona P 

exec pa_persona_listarTodos;

go;

CREATE OR ALTER procedure [dbo].[pa_buscar_x_dni]
@dni char(8)
as
select  P.Nombres + P.Apellidop + P.Apellidom as [Nombre y Apellido], P.Direccion , P.Email , P.Edad
from Persona P 
where P.dni=@dni

EXEC [pa_buscar_x_dni] '12345678';
go;

CREATE OR ALTER procedure [dbo].[pa_mayor]
@numero int out
as
set @numero = (SELECT count(*) 
from Persona P 
where p.Edad>18);

go;



CREATE OR ALTER procedure [dbo].[pa_menor]
@numero int out
as
set @numero = (SELECT count(*) 
from Persona P 
where p.Edad<=18)

create or alter procedure SeleccionarDescripcion 
@codEscuela int
as

select E.CodEscuela,E.Nombres,E.Apellidos,ES.Descripcion from ESTUDIANTE E inner join ESCUELA ES ON E.CodEscuela=ES.CodEscuela
WHERE ES.CodEscuela=@codEscuela