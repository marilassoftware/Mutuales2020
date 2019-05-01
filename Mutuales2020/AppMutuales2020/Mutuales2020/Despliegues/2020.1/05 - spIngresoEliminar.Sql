USE [dbExequial2010]
GO

/****** Object:  StoredProcedure [dbo].[spIngresoEliminar]    Script Date: 1/05/2019 12:47:31 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Andrés Felipe Tabares>
-- Create date: <Abril 29 de 2019>
-- Description:	<Elimina un ingreso>
-- =============================================
CREATE PROCEDURE [dbo].[spIngresoEliminar]
--DECLARE
@intCodigoIng INT

AS

--SET @intCodigoIng = 25051

BEGIN TRY
    BEGIN TRAN

	DECLARE @intAnoRecibo INT
	    , @intCodigoSoc INT
        , @intCuota INT
	    , @intCodigoPre INT
		, @decCapital DECIMAL(18,2)
		, @decAhorro DECIMAL(18,2)
		, @decAbono DECIMAL(18,2)
		, @strCedulaAho VARCHAR(12)
		, @intCodigoTran INT
		, @decAhorrado DECIMAL(18,2)
		, @decRetiro DECIMAL(18,2)
		, @decAcumula DECIMAL(18,2)
		, @strCuenta VARCHAR(20)
		, @strFechaCuota VARCHAR(10)
		, @intCodDeu INT
		, @strCedulaDeu VARCHAR(20)
		, @decAbona DECIMAL(18,2)

	SELECT @intAnoRecibo = intAño
	    , @intCodigoSoc = intCodigoSoc
	FROM tblIngresosCuotas
	WHERE intCodigoIng = @intCodigoIng

	UPDATE tblIngresos
	SET bitAnulado = 1
	    , dtmFechaAnu = GETDATE()
	WHERE intCodigoIng = @intCodigoIng

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitCuota = 1)
	    BEGIN
		DECLARE @intCantidad INT
			, @intAnoSoc INT

		SELECT @intAnoSoc = intAño
		FROM tblSocios
		WHERE intCodigoSoc = @intCodigoSoc

		IF (@intAnoRecibo = @intAnoSoc)
		    BEGIN
		    SELECT @intCantidad = intCantidad
		        , @intCodigoSoc = intCodigoSoc
            FROM tblIngresosCuotas
		    WHERE intCodigoIng = @intCodigoIng

		    UPDATE tblSocios 
		    SET intMeses = intMeses - @intCantidad
		    WHERE @intCodigoSoc = @intCodigoSoc

            INSERT INTO tblSociosProcesados (intCodigoAfi
                , strCedulaAfi
                , strNombreAfi
                , strApellido1Afi
                , strApellido2Afi
                , strPlan
                , intAnoAfi
                , intMesAfi
                , dtmFechaProceso
                , bitProcesado
		        , strMutual)
    		SELECT @intCodigoSoc
	    	    , S.strCedulaSoc
		    	, S.strNombreSoc
			    , S.strApellido1Soc
    			, S.strApellido2Soc
	    		, SP.strNombreSpr
		    	, S.intAño
			    , S.intMeses
    			, GETDATE()
	    		, 0
		    	, 'AMFSA'
    		FROM tblSocios S
	    	    INNER JOIN tblServiciosPrimarios SP ON S.strCodServiciop = SP.strCodSpr
		    WHERE intCodigoSoc = @intCodigoSoc
		
		END
		ELSE
		    BEGIN
			SET @intCodigoIng = -1
			ROLLBACK TRAN
			END
		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitPrestamo = 1)
	    BEGIN

        DECLARE CreInfo CURSOR FOR 
		SELECT intCuota
			, intCodigoPre
			, decCapital
		FROM tblIngresosPrestamos
		WHERE intCodigoIng = @intCodigoIng
        OPEN CreInfo
        FETCH NEXT FROM CreInfo INTO @intCuota, @intCodigoPre, @decCapital
        WHILE @@fetch_status = 0
        BEGIN
		    UPDATE tblCreditos
			SET decDebe = decDebe + @decCapital
			WHERE intCodigoCre = @intCodigoPre

			UPDATE tblCreditosCuota
			SET bitPagada = 0
			    , dtmFechaCuo = '1900-01-01'
			WHERE intCodigoCre = @intCodigoPre
			    AND intCuota = @intCuota

            FETCH NEXT FROM CreInfo INTO @intCuota, @intCodigoPre, @decCapital
        END
        CLOSE CreInfo
        DEALLOCATE CreInfo

		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitPrestamoAbono = 1)
	    BEGIN
		SELECT @intCodigoPre = intCodigoCre
		    , @decCapital = decAbonoPrestamo
		FROM tblIngresosPrestamosAbono
		WHERE intCodigoIng = @intCodigoIng

		UPDATE tblCreditos
		SET decAbono = decAbono - @decCapital
		WHERE intCodigoCre = @intCodigoPre
		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorro = 1)
	    BEGIN

		SELECT @strCedulaAho = strCedulaIng
		FROM tblIngresos
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorro = decAhorro
		FROM tblIngresosAhorros
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorrado = decAhorrado
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado - @decAhorro

		UPDATE tblAhorradores
		SET decAhorrado = decAhorrado - @decAhorro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransacciones
		SET bitMuestra = 0
		WHERE strTransaccion = 'Ahorros'
		    AND intCodigoIng = @intCodigoIng

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
        VALUES('Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaAho
            , @decAhorrado
			, 'Retiros'
            , @decAhorro
            , @decAcumula
			, GETDATE()
			, 0
            , 0)
	    END 

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorroEstudiante = 1)
	    BEGIN

		SELECT @strCedulaAho = strCedulaIng
		FROM tblIngresos
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorro = decAhorro
		FROM tblIngresosAhorrosEstudiantil
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorrado = decAhorrosEstudiantes
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado - @decAhorro

		UPDATE tblAhorradores
		SET decAhorrosEstudiantes = decAhorrosEstudiantes - @decAhorro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransaccionesEstudiantil
		SET bitMuestra = 0
		WHERE strTransaccion = 'Ahorros'
		    AND intCodigoIng = @intCodigoIng

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
        VALUES('Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaAho
            , @decAhorrado
			, 'Retiros'
            , @decAhorro
            , @decAcumula
			, GETDATE()
			, 0
            , 0)
	    END 

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorroFijo = 1)
	    BEGIN

		SELECT @strCedulaAho = strCedulaIng
		FROM tblIngresos
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorro = decAhorro
		FROM tblIngresosAhorrosFijos
		WHERE intCodigoIng = @intCodigoIng

		SELECT @decAhorrado = decAhorrosFijo
		FROM tblAhorradores
		WHERE strCedulaAho = @strCedulaAho

		SET @decAcumula = @decAhorrado - @decAhorro

		UPDATE tblAhorradores
		SET decAhorrosFijo = decAhorrosFijo - @decAhorro
		WHERE strCedulaAho = @strCedulaAho

		UPDATE tblAhorrosTransaccionesFijo
		SET bitMuestra = 0
		WHERE strTransaccion = 'Ahorros'
		    AND intCodigoIng = @intCodigoIng

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
        VALUES('Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaAho
            , @decAhorrado
			, 'Retiros'
            , @decAhorro
            , @decAcumula
			, GETDATE()
			, 0
            , 0)
	    END 

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorroNavideno = 1)
	    BEGIN

        DECLARE CreInfo CURSOR FOR 
		SELECT strCuenta
			, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM tblIngresosAhorrosNavidenos
		WHERE intCodigoIng = @intCodigoIng
        OPEN CreInfo
        FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        WHILE @@fetch_status = 0
        BEGIN
		    UPDATE tblAhorrosNavidenoDetalle
			SET bitPagada = 0
			    , dtmFechaPago = '1900-01-01'
			WHERE strCuenta = @strCuenta
			    AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @strFechaCuota

			UPDATE tblAhorrosNavideno
			SET intPagadas = intPagadas - 1
			WHERE strCuenta = @strCuenta

            FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        END
        CLOSE CreInfo
        DEALLOCATE CreInfo
		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorroNatilleraEscolar = 1)
	    BEGIN

        DECLARE CreInfo CURSOR FOR 
		SELECT strCuenta
			, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM tblIngresosAhorrosNatilleraEscolar
		WHERE intCodigoIng = @intCodigoIng
        OPEN CreInfo
        FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        WHILE @@fetch_status = 0
        BEGIN
		    UPDATE tblAhorrosNatilleraEscolarDetalle
			SET bitPagada = 0
			    , dtmFechaPago = '1900-01-01'
			WHERE strCuenta = @strCuenta
			    AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @strFechaCuota

			UPDATE tblAhorrosNatilleraEscolar
			SET intPagadas = intPagadas - 1
			WHERE strCuenta = @strCuenta

            FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        END
        CLOSE CreInfo
        DEALLOCATE CreInfo
		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitAhorroaFuturo = 1)
	    BEGIN

        DECLARE CreInfo CURSOR FOR 
		SELECT strCuenta
			, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM tblIngresosAhorrosaFuturo
		WHERE intCodigoIng = @intCodigoIng
        OPEN CreInfo
        FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        WHILE @@fetch_status = 0
        BEGIN
		    UPDATE tblAhorrosaFuturoDetalle
			SET bitPagada = 0
			    , dtmFechaPago = '1900-01-01'
			WHERE strCuenta = @strCuenta
			    AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @strFechaCuota

			UPDATE tblAhorrosaFuturo
			SET intPagadas = intPagadas - 1
			WHERE strCuenta = @strCuenta

            FETCH NEXT FROM CreInfo INTO @strCuenta, @strFechaCuota
        END
        CLOSE CreInfo
        DEALLOCATE CreInfo
		END

	IF EXISTS(SELECT 1 FROM tblIngresos WHERE intCodigoIng = @intCodigoIng AND bitDeuda = 1)
	    BEGIN

        DECLARE CreInfo CURSOR FOR 
		SELECT intCodDeu
			, strCedula
			, decAbona
		FROM tblIngresosDeudas
		WHERE intCodigoIng = @intCodigoIng
        OPEN CreInfo
        FETCH NEXT FROM CreInfo INTO @intCodDeu, @strCedulaDeu, @decAbona
        WHILE @@fetch_status = 0
        BEGIN
		    UPDATE tblDeudas
			SET decDebeDeu = decDebeDeu + @decAbona
			    , @decAbono = @decAbono - @decAbona
			WHERE intCodDeu = @intCodDeu
			    AND strCedula = @strCedulaDeu

			UPDATE tblAhorrosaFuturo
			SET intPagadas = intPagadas - 1
			WHERE strCuenta = @strCuenta

            FETCH NEXT FROM CreInfo INTO @intCodDeu, @strCedulaDeu, @decAbona
        END
        CLOSE CreInfo
        DEALLOCATE CreInfo
		END

	COMMIT TRAN

    SELECT @intCodigoIng intCodigoIng
END TRY    
BEGIN CATCH    
    IF (@intCodigoIng <> -1)
	    BEGIN
        ROLLBACK TRAN
		END
	ELSE
	    BEGIN
		SET @intCodigoIng = 0;
		END
	--SELECT * FROM tblErroresSp WHERE sp = 'spIngresoEliminar' ORDER BY id DESC
    INSERT INTO tblErroresSp(fecha, Descripcion, sp) VALUES(GETDATE(), ERROR_MESSAGE(), 'spIngresoEliminar')
    SELECT @intCodigoIng intCodigoIng
END CATCH    
GO