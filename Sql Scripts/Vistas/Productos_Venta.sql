create view Productos_venta as
select Productos.idProducto ID, Marcas.nombre Marca, Estilos.nombre Estilo, Categorias.nombre Categoria,
	Productos.nombre,Productos.descripcion, Productos.genero, Productos.precioVenta from Productos
	join Marcas on Marcas.idMarca=Productos.idMarca
	join Estilos on Estilos.idEstilo = Productos.idEstilo
	join Categorias on Categorias.idCategoria = Productos.idCategoria
	where Productos.estatus = 'A'