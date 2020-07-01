-- Listar Marcas
CREATE PROCEDURE SP_MARCAS_LISTAR
AS
	SELECT IdMarca, Nombre
	FROM dbo.Marca
GO

-- Listado General de Vehículos
CREATE PROCEDURE SP_VEHICULOS_LISTAR
AS
	SELECT
	V.IdVehiculo,
	V.Placa,
	V.Año,
	V.Modelo,
	V.IdMarca,
	M.Nombre
	FROM dbo.Vehiculo AS V INNER JOIN dbo.Marca AS M
	ON V.IdMarca = M.IdMarca
GO

-- Registro de nuevo Vehículo

CREATE PROCEDURE SP_VEHICULOS_REGISTRAR
@Placa varchar(20),
@Año int,
@Modelo varchar(50),
@IdMarca int
AS
	INSERT INTO dbo.Vehiculo(Placa, Año, Modelo, IdMarca)
	VALUES(@Placa, @Año, @Modelo, @IdMarca)
GO

-- Actualización de registro de Vehículo

CREATE PROCEDURE SP_VEHICULOS_ACTUALIZAR
@Placa varchar(20),
@Año int,
@Modelo varchar(50),
@IdMarca int,
@IdVehiculo int
AS
	UPDATE dbo.Vehiculo
	SET Placa = @Placa, Año = @Año, Modelo = @Modelo, IdMarca = @IdMarca
	WHERE IdVehiculo = @IdVehiculo
GO

-- Detalle de Vehículo

CREATE PROCEDURE SP_VEHICULOS_OBTENER
@IdVehiculo int
AS
	SELECT
	IdVehiculo,
	Placa,
	Año,
	Modelo,
	IdMarca
	FROM dbo.Vehiculo
	WHERE IdVehiculo = @IdVehiculo
GO

-- Eliminación de registro de Vehículo

CREATE PROCEDURE SP_VEHICULOS_ELIMINAR
@IdVehiculo int
AS
	DELETE FROM dbo.Vehiculo WHERE IdVehiculo = @IdVehiculo
GO