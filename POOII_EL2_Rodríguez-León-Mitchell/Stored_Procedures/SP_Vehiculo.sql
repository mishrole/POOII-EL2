CREATE PROCEDURE SP_VEHICULOS_LISTAR
AS
	SELECT IdVehiculo, Placa FROM dbo.Vehiculo
GO

-- Registro de nuevo Vehículo

CREATE PROCEDURE SP_VEHICHULOS_REGISTRAR
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

-- Detalle de datos de Vehículo

CREATE PROCEDURE SP_VEHICULOS_DETALLE
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