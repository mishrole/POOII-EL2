-- Listado de Viajes por año de partida

CREATE PROCEDURE SP_VIAJES_X_PARTIDA
@Partida int
AS
	SELECT
	VI.ViajeId,
	VI.Origen,
	VI.Destino,
	VI.VehiculoId,
	CO.Nombre + ' ' + CO.ApellidoPaterno + ' ' + CO.ApellidoMaterno AS Conductor,
	VI.FechaPartida,
	VI.FechaLlegada
	FROM dbo.Viaje VI INNER JOIN dbo.Conductor CO
	ON VI.ConductorId = CO.ConductorId
	WHERE YEAR(FechaPartida) LIKE @Partida
GO

-- Listado de Viajes por Conductor y Año de partida

CREATE PROCEDURE SP_VIAJES_X_CONDUCTORYPARTIDA
@Conductor VARCHAR(100),
@Partida int
AS
	SELECT
	VI.ViajeId,
	VI.Origen,
	VI.Destino,
	VI.VehiculoId,
	CO.Nombre + ' ' + CO.ApellidoPaterno + ' ' + CO.ApellidoMaterno AS Conductor,
	VI.FechaPartida,
	VI.FechaLlegada
	FROM dbo.Viaje VI INNER JOIN dbo.Conductor CO
	ON VI.ConductorId = CO.ConductorId
	WHERE YEAR(FechaPartida) LIKE @Partida
	AND CO.Nombre + ' ' + CO.ApellidoPaterno + ' ' + CO.ApellidoMaterno LIKE '%' + @Conductor + '%'
GO

-- Listado de Viajes por Vehículo y Año de partida

CREATE PROCEDURE SP_VIAJES_X_VEHICULOYPARTIDA
@Vehiculo int,
@Partida int
AS
	SELECT
	VI.ViajeId,
	VI.Origen,
	VI.Destino,
	VI.VehiculoId,
	CO.Nombre + ' ' + CO.ApellidoPaterno + ' ' + CO.ApellidoMaterno AS Conductor,
	VI.FechaPartida,
	VI.FechaLlegada
	FROM dbo.Viaje VI INNER JOIN dbo.Conductor CO
	ON VI.ConductorId = CO.ConductorId
	WHERE YEAR(FechaPartida) LIKE @Partida
	AND VI.VehiculoId LIKE @Vehiculo
GO

/*
exec SP_VIAJES_X_PARTIDA '2011';
exec sp_viajes_x_conductorypartida 'pedro', '2011';
exec SP_VIAJES_X_VEHICULOYPARTIDA '60', '2011';

drop procedure sp_viajes_x_partida;
drop procedure SP_VIAJES_X_CONDUCTORYPARTIDA;
drop procedure SP_VIAJES_X_VEHICULOYPARTIDA;
*/