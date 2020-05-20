
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
insert into Clientes values ('avenida conecticut', '54321', '132113131313', '123-000-1234','amatista@correo.com','T','A',1)
go

/*
		Tabla Cliente individual
*/
insert into ClienteIndividual values(1, 'Nico','G','L', 'M')
go
/*
		Tabla Cliente tienda
*/
insert into ClienteTienda values(2, 'Zapateria amatista','Jeni',10500)
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
insert into Productos values ('Chuck Taylor All Star', 'Estilo clasico',  50, 'U', 740, 1200, 'A', 'Sintetico', 1, 1, 5)
insert into Productos values ('Old School', 'Diseño clasico',  50, 'U', 740, 1200, 'A', 'Sintetico', 2, 1, 5)
insert into Productos values ('Running free dama', 'Fiaaaaaum',  50, 'F', 943, 1500, 'A', 'Sintetico', 3, 4, 1)
insert into Productos values ('Running free caballero', 'Fiaaaaaum',  50, 'M', 943, 1500, 'A', 'Sintetico', 3, 4, 2)
insert into Productos values ('Samba', 'Diseño ligero que brinda mayor libertad de movimiento',  50, 'U', 1460, 1999, 'A', 'Sintetico', 4, 1, 2)
go
/*
		Tabla imagenes producto

		 Es necesario que los archivos se encuentren en la ruta especificada C:\images\
*/

insert into ImagenesProducto values('vans_old_school.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\vans_old_school.jpg', SINGLE_BLOB) as T1), 
									'P',
									17)

insert into ImagenesProducto values('converse_chuck_taylor.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\converse_chuck_taylor.jpg', SINGLE_BLOB) as T1), 
									'P',
									16)
									
insert into ImagenesProducto values('nike_rf_m.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\nike_rf_m.jpg', SINGLE_BLOB) as T1), 
									'P',
									18)

insert into ImagenesProducto values('nike_rf_h.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\nike_rf_h.jpg', SINGLE_BLOB) as T1), 
									'P',
									19)

insert into ImagenesProducto values('adidas_samba.jpg', 
									(SELECT * FROM OPENROWSET(BULK N'C:\images\adidas_samba.jpg', SINGLE_BLOB) as T1), 
									'P',
									20)

go

/*
		Tabla Oferas producto
*/
insert into OfertasProductos values(16, 1, 'A')
insert into OfertasProductos values(17, 1, 'A')
go



create procedure sp_detalleproductos (
@id int
)
as
begin
	select dp.idProductoDetalle,dp.talla, dp.existencia, colores.nombre color from DetalleProductos dp
	join Colores on dp.idColor=Colores.idColor where dp.idProducto=@id
end
go

select * from Colores

insert into colores values('rojo')
insert into colores values('azul')
insert into colores values('verde')
insert into colores values('amarillo')
insert into colores values('negro')
insert into colores values('gris')

select* from DetalleProductos where idProducto=5 and talla=23

/*
	Detalles para producto  (Converse)
*/
select * from Productos
insert into DetalleProductos values(23, 13,1,16)
insert into DetalleProductos values(23, 10,2,16)
insert into DetalleProductos values(24, 15,6,16)
insert into DetalleProductos values(25, 20,2,16)
insert into DetalleProductos values(26, 5,2,16)
go

/*
	Detalles para producto 6 (vans)
*/
insert into DetalleProductos values(23, 22,2,17)
insert into DetalleProductos values(23, 12,6,17)
insert into DetalleProductos values(24, 15,3,17)
insert into DetalleProductos values(25, 18,5,17)
insert into DetalleProductos values(26, 7,2,17)
go


alter table ventas alter column totalPagar float
alter table ventas alter column cantPagada float
alter table ventas alter column comentarios varchar(100)
alter table ventas alter column idcliente int 
alter table ventas alter column idempleado int
go 

insert into ventas values (GETDATE(), 0,0,'Venta 2','A',null,null)
insert into ventas values (GETDATE(), 0,0,'Venta 3','A',null,null)
insert into ventas values (GETDATE(), 0,0,'Venta 4','A',null,null)

select * from Ventas


go

create procedure sp_buscarProductoEnOfertas (@id int)
as
begin
	select o.idOferta, o.canMinProducto, o.nombre, o.porDescuento from ofertas o
	join OfertasProductos op on o.idOferta=op.idOferta
	where op.idProducto=@id
	and o.estatus='A' 
	and GETDATE() between o.fechaInicio and o.fechaFin
end
go


go
alter table VentasOfertas drop constraint VentasOfertas_PK
alter table VentasOfertas drop column idventaproducto
alter table VentasOfertas add constraint VentasOfertas_PK primary key (idVentaDetalle,idProducto, idoferta)