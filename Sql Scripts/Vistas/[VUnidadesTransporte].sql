USE [ERP2020v2]
GO

/****** Object:  View [dbo].[VUnidadesTransporte]    Script Date: 19/05/2020 09:27:03 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[VUnidadesTransporte] as
select UT.idUnidadTransporte ID,UT.placas Placas,UT.marca Marca,UT.modelo Modelo,UT.anio Año,
UT.capacidad Capacidad,UT.estatus Estatus
from UnidadesTransporte UT where UT.estatus='A';
GO


