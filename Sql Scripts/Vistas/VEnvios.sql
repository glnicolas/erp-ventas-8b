USE [ERP2020v2]
GO

/****** Object:  View [dbo].[VEnvios]    Script Date: 19/05/2020 09:26:03 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VEnvios] as
select E.idEnvio ID,E.estatus Estatus, E.fechaSalida 'Fecha de envio'
from envios E where E.estatus='A';
GO


