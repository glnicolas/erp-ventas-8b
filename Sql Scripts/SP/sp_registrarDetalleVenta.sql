create procedure sp_registrarDetalleVenta 
(
@unitario float,
@cantidad float,
@subtotal float,
@idventa int,
@iddetalle int
)
as
begin
	begin try
		begin tran
			insert into VentasDetalle values(@unitario,@cantidad,@subtotal,@idventa,@iddetalle,'A')
			commit
			select SCOPE_IDENTITY()
	end try
	begin catch
		rollback
		declare @msg varchar(max)
		set @msg= CONCAT('Error al registrar detalle de venta. Error', ERROR_MESSAGE())
		RAISERROR(@msg,16,1)
	end catch

end
go
select * from VentasDetalle