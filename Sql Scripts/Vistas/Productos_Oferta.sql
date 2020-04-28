create view Productos_Oferta as
select Productos.idProducto ID, Marcas.nombre Marca, Estilos.nombre Estilo, Categorias.nombre Categoria,
	Productos.nombre,Productos.descripcion, Productos.genero, Productos.precioVenta, OfertasProductos.idOferta, OfertasProductos.estatus from Productos
	join Marcas on Marcas.idMarca=Productos.idMarca
	join Estilos on Estilos.idEstilo = Productos.idEstilo
	join Categorias on Categorias.idCategoria = Productos.idCategoria
	join ofertasproductos on Productos.idProducto=OfertasProductos.idProducto
	where Productos.estatus = 'A'

