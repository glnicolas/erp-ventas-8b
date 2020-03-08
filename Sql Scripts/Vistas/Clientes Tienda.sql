
CREATE VIEW Clientes_Tienda AS
	select cte.idCliente ID, tienda.nombre 'Nombre Tienda', tienda.contacto Contacto, tienda.limiteCredito 'Limite Crédito', 
			cte.direccion Direccion, cte.codidoPostal 'Codigo Postal', cte.rfc RFC,  cte.telefono Telefono, cte.email Correo, cd.nombre Ciudad
			from Clientes cte 
				join ClienteTienda tienda on cte.idCliente = tienda.idCliente
				join Ciudades cd on cd.idCiudad=cte.idCiudad
			where cte.estatus='A'


