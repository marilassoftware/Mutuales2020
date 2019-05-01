-- =============================================
-- Author:		<Andrés Felipe Tabares Monsalve>
-- Create date: <Mayo 1 2019>
-- Description:	<Elimina un egreso.>
-- =============================================
CREATE PROCEDURE [spEgresoEliminar]
--DECLARE
@intCodigoEgr INT

AS

--SET @intCodigoEgr = 1

BEGIN TRY
    BEGIN TRAN

	DECLARE @strCedulaAho VARCHAR(20)
	    , @decRetiro DECIMAL(18,2)
		, @decAhorrado DECIMAL(18,2)
		, @decAcumula DECIMAL(18,2)
		, @decAbonoPrestamo DECIMAL(18,2)
		, @intCodigoCre INT
		, @decIntereses DECIMAL(18,2)

	UPDATE tblEgresos
	SET bitAnulado = 1
	    , dtmFechaAnu = GETDATE()
	WHERE intCodigoEgr = @intCodigoEgr

	IF EXISTS(SELECT 1 FROM tblEgresos WHERE intCodigoEgr = @intCodigoEgr AND bitRetiro = 1)
	    BEGIN
		SELECT @strCedulaAho = strCedulaEgre
		FROM tblEgresos
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decRetiro = decRetiro
		FROM tblEgresosAhorros
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decAhorrado = decAhorrado
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado + @decRetiro

		UPDATE tblAhorradores
		SET decAhorrado = decAhorrado + @decRetiro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransacciones
		SET bitMuestra = 0
		WHERE strTransaccion = 'Retiros'
		    AND intCodigoIng = @intCodigoEgr

		INSERT INTO dbExequial2010.dbo.tblAhorrosTransacciones(strDescripcion
		    , intCodigoIng
			, strCedulaAho
			, decAhorrado
			, strTransaccion
			, decValor
			, decAcumula
			, dtmFechaTra
			, bitMuestra
			, bitCobraCuatroxMil)
        VALUES('Comprobante # ' + CAST(@intCodigoEgr AS VARCHAR(10))
		    , @intCodigoEgr
			, @strCedulaAho
            , @decAhorrado
			, 'Ahorros'
            , @decRetiro
            , @decAcumula
			, GETDATE()
			, 0
            , 0)
		END

	IF EXISTS(SELECT 1 FROM tblEgresos WHERE intCodigoEgr = @intCodigoEgr AND bitRetiroAhorroEstudiante = 1)
	    BEGIN
		SELECT @strCedulaAho = strCedulaEgre
		FROM tblEgresos
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decRetiro = decRetiro
		FROM tblEgresosAhorrosEstudiantes
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decAhorrado = decAhorrosEstudiantes
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado + @decRetiro

		UPDATE tblAhorradores
		SET decAhorrosEstudiantes = decAhorrosEstudiantes + @decRetiro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransaccionesEstudiantil
		SET bitMuestra = 0
		WHERE strTransaccion = 'Retiros'
		    AND intCodigoIng = @intCodigoEgr

		INSERT INTO dbExequial2010.dbo.tblAhorrosTransaccionesEstudiantil(strDescripcion
		    , intCodigoIng
			, strCedulaAho
			, decAhorrado
			, strTransaccion
			, decValor
			, decAcumula
			, dtmFechaTra
			, bitMuestra)
        VALUES('Comprobante # ' + CAST(@intCodigoEgr AS VARCHAR(10))
		    , @intCodigoEgr
			, @strCedulaAho
            , @decAhorrado
			, 'Ahorros'
            , @decRetiro
            , @decAcumula
			, GETDATE()
            , 0)
		END

	IF EXISTS(SELECT 1 FROM tblEgresos WHERE intCodigoEgr = @intCodigoEgr AND bitRetiroAhorroFijo = 1)
	    BEGIN
		SELECT @strCedulaAho = strCedulaEgre
		FROM tblEgresos
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decRetiro = decRetiro
		FROM tblEgresosAhorrosFijos
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decAhorrado = decAhorrosFijo
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado + @decRetiro

		UPDATE tblAhorradores
		SET decAhorrosFijo = decAhorrosFijo + @decRetiro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransaccionesFijo
		SET bitMuestra = 0
		WHERE strTransaccion = 'Retiros'
		    AND intCodigoIng = @intCodigoEgr

		INSERT INTO dbExequial2010.dbo.tblAhorrosTransaccionesFijo(strDescripcion
		    , intCodigoIng
			, strCedulaAho
			, decAhorrado
			, strTransaccion
			, decValor
			, decAcumula
			, dtmFechaTra
			, bitMuestra)
        VALUES('Comprobante # ' + CAST(@intCodigoEgr AS VARCHAR(10))
		    , @intCodigoEgr
			, @strCedulaAho
            , @decAhorrado
			, 'Ahorros'
            , @decRetiro
            , @decAcumula
			, GETDATE()
            , 0)
		END

	IF EXISTS(SELECT 1 FROM tblEgresos WHERE intCodigoEgr = @intCodigoEgr AND bitRetiroAbonos = 1)
	    BEGIN

		SELECT @decAbonoPrestamo = decAbonoPrestamo
		    , @intCodigoCre = intCodigoCre
		FROM tblEgresosPrestamosAbono
		WHERE intCodigoEgr = @intCodigoEgr

		UPDATE tblCreditos
		SET decAbono = decAbono + @decAbonoPrestamo
		WHERE intCodigoCre = @intCodigoCre

		END

	IF EXISTS(SELECT 1 FROM tblEgresos WHERE intCodigoEgr = @intCodigoEgr AND bitRetiroIntereses = 1)
	    BEGIN

		SELECT @strCedulaAho = strCedulaEgre
		FROM tblEgresos
		WHERE intCodigoEgr = @intCodigoEgr

		SELECT @decIntereses = decIntereses
		FROM tblEgresosIntereses
		WHERE intCodigoEgr = @intCodigoEgr

		UPDATE tblAhorradores
		SET decIntereses = decIntereses + @decIntereses
		WHERE strCedulaAho = @strCedulaAho

		END

		COMMIT TRAN

SELECT @intCodigoEgr intCodigoEgr

END TRY    
BEGIN CATCH    
    ROLLBACK TRAN
	--SELECT * FROM tblErroresSp WHERE sp = 'spEgresoEliminar' ORDER BY idCodigo DESC
    INSERT INTO tblErroresSp(fecha, Descripcion, sp) VALUES(GETDATE(), ERROR_MESSAGE(), 'spEgresoEliminar')
    SELECT 0 intCodigoEgr
END CATCH    
