USE [ERP2020v2]
GO

/****** Object:  View [dbo].[VTripilacion]    Script Date: 19/05/2020 09:26:49 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VTripilacion] as
select T.estatus Estado,T.idEmpleado 'ID empleado',T.idEnvio 'ID Envio',T.rol ROL
from Tripulacion T where T.estatus='A';
GO


