CREATE VIEW Ofertas_General
 AS
SELECT idOferta AS ID, nombre AS Nombre, descripcion AS Descripci�n, Concat(porDescuento*100,'%') AS Descuento, fechaInicio AS [F. Inicio], fechaFin AS [F. Fin], canMinProducto AS [Cantidad Min.]
FROM Ofertas where estatus = 'A'