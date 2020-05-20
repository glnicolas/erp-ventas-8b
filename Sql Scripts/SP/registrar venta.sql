USE [ERP2020v2]
GO

/****** Object:  StoredProcedure [dbo].[sp_registrarVenta]    Script Date: 19/05/2020 09:49:27 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_registrarVenta] 
as
begin
	set nocount on
	begin try
		begin tran
		insert into ventas values(GETDATE(), 0,0,'','A',null,null)
		commit
		select idVenta,fecha,estatus from ventas where idVenta= SCOPE_IDENTITY()
	end try
	begin catch
		rollback
		declare @msg varchar(max)
		set @msg= CONCAT('Error al registrar nueva venta. Error', ERROR_MESSAGE())
		RAISERROR(@msg,16,1)
	end catch
end
GO


