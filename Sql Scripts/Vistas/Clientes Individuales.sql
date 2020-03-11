use ERP2020
GO
CREATE VIEW Clientes_Individuales AS
select cl.idCliente ID, ci.nombre Nombre, ci.apaterno 'A. Paterno', ci.amaterno 'A. Materno', ci.sexo Sexo, cl.direccion 'Direcci�n', cl.codidoPostal 'C�difo Postal', cl.rfc RFC, cl.telefono 'Tel�fono', cl.email, cd.nombre	Ciudad
		from Clientes cl join ClienteIndividual ci on cl.idCliente = ci.idCliente join Ciudades cd on cl.idCiudad = cd.idCiudad
		where cl.estatus = 'A';