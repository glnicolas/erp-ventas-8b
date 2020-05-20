USE [ERP2020v2]
GO

/****** Object:  View [dbo].[VEnviosVentas]    Script Date: 19/05/2020 09:26:33 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[VEnviosVentas] as SELECT        dbo.EnviosVentas.idVenta,EnviosVentas.estatus, dbo.EnviosVentas.fechaEntregaPlaneada, dbo.EnviosVentas.fechaEntregaREal, dbo.Ventas.totalPagar, dbo.Clientes.direccion, dbo.Clientes.codidoPostal
FROM            dbo.EnviosVentas INNER JOIN
                         dbo.Ventas ON dbo.EnviosVentas.idVenta = dbo.Ventas.idVenta INNER JOIN
                         dbo.Clientes ON dbo.Ventas.idCliente = dbo.Clientes.idCliente where EnviosVentas.estatus='A';
GO


