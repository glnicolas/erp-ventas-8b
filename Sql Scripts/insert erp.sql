
/*
		Tabla empleados
*/
insert into empleados 
	values ('Nicolas', 'Garcia', 'Lira', 'M', '2020-02-12','1998-09-17',
			666.0, '123456789a', 'soltero', 10, 10, 
			(SELECT * FROM OPENROWSET(BULK N'C:\images\nico.jfif', SINGLE_BLOB) as T1), 
			'calle 123', 'colonia', '12345', 'Licenciatura', 10, null,null, null)
go

/*
		Tabla usuarios
*/
insert into Usuarios values ('nico', '123a', 'A', 'A', '2020-02-10',1)
go

/*
		Tabla estados
*/
insert into Estado values('Michoacan', 'MN')
go

/*
		Tabla ciudades
*/
insert into Ciudades values('Ixtlán', 1)
insert into Ciudades values('Jacona', 1)
insert into Ciudades values('Zamora', 1)
go

/*
		Tabla Clientes
*/
insert into Clientes values ('avenida siempreviva', '12345', '123456789012', '123-123-1234','nico@correo.com','I','A',3)
insert into Clientes values ('avenida conecticut', '54321', '132113131313', '123-000-1234','juan@correo.com','T','A',1)
go

/*
		Tabla Cliente individual
*/
insert into ClienteIndividual values(1, 'Nico','G','L', 'M')
go
/*
		Tabla Cliente tienda
*/
insert into ClienteTienda values(2, 'Zapateria amatista','Juan',10500)
go

/*
		Tabla unidades transporte
*/
insert into UnidadesTransporte values ('ABC-123-Z', 'Nissan', 'Frontier',2010, 2300,'A')
insert into UnidadesTransporte values ('DFC-124-C', 'Ford', 'F-150',2015, 5000,'A')
go

/*
		Tabla Marcas
*/
insert into marcas values('Converse', 'USA')
insert into marcas values('Vans', 'USA')
insert into marcas values('Nike', 'USA')
insert into marcas values('Adidas', 'Alemania')
go

/*
		Tabla estilos
*/
insert into estilos values ('Casual')
insert into estilos values ('Elegante')
insert into estilos values ('Clásico')
insert into estilos values ('Deportivo')
go 

/*
		Tabla Categorias
*/
insert into Categorias values ('Dama')
insert into Categorias values ('Caballero')
insert into Categorias values ('Niña')
insert into Categorias values ('Niño')
insert into Categorias values ('Unisex')
go

/*
		Tabla Productos
*/
insert into Productos values ('Chuck Taylor All Star', 'Estilo clasico',  50, 'U', 740, 1200, 'A', 'Sintetico', 2, 1, 10)
insert into Productos values ('Old School', 'Estilo clasico',  50, 'U', 740, 1200, 'A', 'Sintetico', 3, 1, 10)
insert into Productos values ('Running free', 'Fiaaaaaum',  50, 'F', 943, 1500, 'A', 'Sintetico', 4, 4, 6)
insert into Productos values ('Running free', 'Fiaaaaaum',  50, 'M', 943, 1500, 'A', 'Sintetico', 4, 4, 7)
insert into Productos values ('Samba', 'Diseño ligero que brinda mayor libertad de movimiento',  50, 'U', 1460, 1999, 'A', 'Sintetico', 5, 1, 7)
go
/*
		Tabla imagenes producto

		 Es necesario que los archivos se encuentren en la ruta especificada C:\images\
*/

insert into ImagenesProducto values('vans_old_school.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\vans_old_school.jpg', SINGLE_BLOB) as T1), 
									'P',
									6)

insert into ImagenesProducto values('converse_chuck_taylor.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\converse_chuck_taylor.jpg', SINGLE_BLOB) as T1), 
									'P',
									5)
									
insert into ImagenesProducto values('nike_rf_m.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\nike_rf_m.jpg', SINGLE_BLOB) as T1), 
									'P',
									7)

insert into ImagenesProducto values('nike_rf_h.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\nike_rf_h.jpg', SINGLE_BLOB) as T1), 
									'P',
									8)

insert into ImagenesProducto values('adidas_samba.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\adidas_samba.jpg', SINGLE_BLOB) as T1), 
									'P',
									10)

go

/*
		Tabla Oferas producto
*/
insert into OfertasProductos values(6, 1, 'A')
insert into OfertasProductos values(5, 1, 'I')