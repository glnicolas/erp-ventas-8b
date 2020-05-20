USE [ERP2020v2]
GO

/****** Object:  StoredProcedure [dbo].[sp_buscarProductoEnOfertas]    Script Date: 19/05/2020 09:49:13 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_buscarProductoEnOfertas] (@id int)
as
begin
	select o.idOferta, o.canMinProducto, o.nombre, o.porDescuento from ofertas o
	join OfertasProductos op on o.idOferta=op.idOferta
	where op.idProducto=@id
	and o.estatus='A' 
	and GETDATE() between o.fechaInicio and o.fechaFin
end
GO


