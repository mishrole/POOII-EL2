CREATE PROCEDURE SP_VEHICULOS_LISTAR
AS
	SELECT IdVehiculo, Placa FROM dbo.Vehiculo
GO

-- Registro de nuevo Veh�culo

CREATE PROCEDURE SP_VEHICHULOS_REGISTRAR
@Placa varchar(20),
@A�o int,
@Modelo varchar(50),
@IdMarca int
AS
	INSERT INTO dbo.Vehiculo(Placa, A�o, Modelo, IdMarca)
	VALUES(@Placa, @A�o, @Modelo, @IdMarca)
GO

-- Actualizaci�n de registro de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_ACTUALIZAR
@Placa varchar(20),
@A�o int,
@Modelo varchar(50),
@IdMarca int,
@IdVehiculo int
AS
	UPDATE dbo.Vehiculo
	SET Placa = @Placa, A�o = @A�o, Modelo = @Modelo, IdMarca = @IdMarca
	WHERE IdVehiculo = @IdVehiculo
GO

-- Detalle de datos de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_DETALLE
@IdVehiculo int
AS
	SELECT
	IdVehiculo,
	Placa,
	A�o,
	Modelo,
	IdMarca
	FROM dbo.Vehiculo
	WHERE IdVehiculo = @IdVehiculo
GO

-- Eliminaci�n de registro de Veh�culo

CREATE PROCEDURE SP_VEHICULOS_ELIMINAR
@IdVehiculo int
AS
	DELETE FROM dbo.Vehiculo WHERE IdVehiculo = @IdVehiculo
GO