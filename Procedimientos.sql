
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

EXEC [pa_buscar_x_dni] '12345678'