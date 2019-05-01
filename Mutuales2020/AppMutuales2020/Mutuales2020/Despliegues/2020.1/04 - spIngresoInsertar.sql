USE [dbExequial2010]
GO

/****** Object:  StoredProcedure [dbo].[spIngresoInsertar]    Script Date: 1/05/2019 12:46:51 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Andrés Felipe Tabares Monsalve>
-- Create date: <Junio 10 de 2010>
-- Description:	<Ingresa los datos de un ingreso.>
-- =============================================
CREATE PROCEDURE [dbo].[spIngresoInsertar] 
--DECLARE
@xmlIngreso Xml

AS

--SET @xmlIngreso = 

BEGIN TRY
    BEGIN TRAN
	DECLARE @bitAhorro BIT
	    , @bitAhorroaFuturo BIT
	    , @bitAhorroaFuturoMulta BIT
	    , @bitAhorroCdt BIT
	    , @bitAhorroCdtMulta BIT
	    , @bitAhorroEstudiante BIT
	    , @bitAhorroFijo BIT
	    , @bitAhorroNavideno BIT
	    , @bitAhorroNavidenoMulta BIT
	    , @bitCuota BIT
	    , @bitDeuda BIT
	    , @bitPrestamo BIT
	    , @bitPrestamoAbono BIT
	    , @bitVenta BIT
	    , @bitOtro BIT
		, @bitAhorroNatilleraEscolar BIT
		, @decTotalIng DECIMAL(18,3)
		, @strCedulaIng VARCHAR(50)
		, @intCodigoIng INT
		, @intCantidad INT
		, @intCodigoSoc INT
		, @decCapital DECIMAL(18,3)
		, @intCodigoCre INT
		, @intCuota INT
		, @strCuenta VARCHAR(50)
		, @dtmFechaCuo VARCHAR(10)
		, @decAbonboPrestamo DECIMAL(18,3)
		, @bitDeducirAbonodelMonto BIT
		, @decAhorro DECIMAL(18,3)
		, @intCodVenta INT
		, @decAbona DECIMAL(18,3)
		, @intCodDeu INT
		, @strApelido VARCHAR(50)

    SELECT @bitAhorro = x.item.value('(bitAhorro/text())[1]','bit')
        , @bitAhorroaFuturo = x.item.value('(bitAhorroaFuturo/text())[1]','bit')
        , @bitAhorroaFuturoMulta = x.item.value('(bitAhorroaFuturoMulta/text())[1]','bit')
        , @bitAhorroCdt = x.item.value('(bitAhorroCdt/text())[1]','bit')
        , @bitAhorroCdtMulta = x.item.value('(bitAhorroCdtMulta/text())[1]','bit')
        , @bitAhorroEstudiante = x.item.value('(bitAhorroEstudiante/text())[1]','bit')
        , @bitAhorroFijo = x.item.value('(bitAhorroFijo/text())[1]','bit')
        , @bitAhorroNavideno = x.item.value('(bitAhorroNavideno/text())[1]','bit')
        , @bitAhorroNavidenoMulta = x.item.value('(bitAhorroNavidenoMulta/text())[1]','bit')
		, @bitCuota = x.item.value('(bitCuota/text())[1]','bit')
		, @bitDeuda = x.item.value('(bitDeuda/text())[1]','bit')
		, @bitPrestamo = x.item.value('(bitPrestamo/text())[1]','bit')
		, @bitPrestamoAbono = x.item.value('(bitPrestamoAbono/text())[1]','bit')
		, @bitVenta = x.item.value('(bitVenta/text())[1]','bit')
		, @bitOtro = x.item.value('(bitOtro/text())[1]','bit')
		, @decTotalIng = x.item.value('(decTotalIng/text())[1]','decimal(18,8)')
		, @strCedulaIng = x.item.value('(strCedulaIng/text())[1]','Varchar(50)')
		, @bitAhorroNatilleraEscolar = x.item.value('(bitAhorroNatilleraEscolar/text())[1]','bit')
		, @strApelido = x.item.value('(strApellidoIng/text())[1]','Varchar(50)')
    FROM @xmlIngreso.nodes('tblIngreso') AS x(item)

    SELECT @intCodigoIng = MAX(intCodigoIng)
    FROM dbExequial2010.dbo.tblIngresos

    IF(@intCodigoIng IS NULL)
	    BEGIN
	    SET @intCodigoIng = 1;
	    END
    ELSE
	    BEGIN
	    SET @intCodigoIng = @intCodigoIng + 1
	    END

    INSERT INTO dbExequial2010.dbo.tblIngresos(intCodigoIng
        , strCedulaIng 
        , strNombreIng 
        , strApellidoIng 
        , dtmFechaRec 
        , bitAhorro 
        , bitAhorroaFuturo 
        , bitAhorroaFuturoMulta 
        , bitAhorroCdt 
        , bitAhorroCdtMulta 
        , bitAhorroEstudiante 
        , bitAhorroFijo 
        , bitAhorroNavideno 
        , bitAhorroNavidenoMulta 
        , bitCuota 
        , bitDeuda 
        , bitPrestamo 
        , bitPrestamoAbono 
        , bitVenta 
        , bitOtro 
        , decTotalIng 
        , strLetras 
        , bitAnulado 
        , dtmFechaAnu 
        , strUsuario 
        , strComputador 
        , bitAhorroNatilleraEscolar)
    SELECT @intCodigoIng
	    , @strCedulaIng
	    , x.item.value('(strNombreIng/text())[1]','Varchar(50)')
        , ISNULL(@strApelido, '')
        , GETDATE()
		, @bitAhorro
		, @bitAhorroaFuturo
		, @bitAhorroaFuturoMulta
        , @bitAhorroCdt
        , @bitAhorroCdtMulta
        , @bitAhorroEstudiante
        , @bitAhorroFijo
        , @bitAhorroNavideno
        , @bitAhorroNavidenoMulta
		, @bitCuota
		, @bitDeuda
		, @bitPrestamo
		, @bitPrestamoAbono
		, @bitVenta
		, @bitOtro
		, @decTotalIng
		, x.item.value('(strLetras/text())[1]','Varchar(200)')
		, 0
		, '1900-01-01'
		, x.item.value('(strUsuario/text())[1]','Varchar(200)')
 		, x.item.value('(strComputador/text())[1]','Varchar(200)')
		, @bitAhorroNatilleraEscolar
   FROM @xmlIngreso.nodes('tblIngreso') AS x(item)

    IF (@bitCuota = 1)
        BEGIN

		SELECT @intCantidad = x.item.value('(intCantidad/text())[1]','Int')
		    , @intCodigoSoc = x.item.value('(intCodigoSoc/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoCuota') AS x(item)	

	    INSERT INTO dbExequial2010.dbo.tblIngresosCuotas(intCodigoIng
	        , intCodigoSoc
		    , intMesActual
		    , intMesesCancelados
		    , strCodServiciop
		    , intCantidad
		    , decDescuento
		    , intTotal
		    , intAño
		    , dtmFechaRes
		    , strMeses
		    , strMesFinal
		    , intAdultos
		    , intCuotaAdultos)
        SELECT @intCodigoIng
	        , @intCodigoSoc
	        , x.item.value('(intMesActual/text())[1]','Int')
	        , x.item.value('(intMesesCancelados/text())[1]','Int')
	        , x.item.value('(strCodServiciop/text())[1]','Varchar(50)')
	        , @intCantidad
	        , x.item.value('(decDescuento/text())[1]','Decimal(18,3)')
	        , x.item.value('(intTotal/text())[1]','Int')
	        , x.item.value('(intAño/text())[1]','Int')
	        , x.item.value('(dtmFechaRes/text())[1]','DateTime')
	        , x.item.value('(strMeses/text())[1]','Varchar(100)')
	        , x.item.value('(strMesFinal/text())[1]','Varchar(50)')
	        , x.item.value('(intAdultos/text())[1]','Int')
	        , x.item.value('(intCuotaAdultos/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoCuota') AS x(item)	

		UPDATE dbExequial2010.dbo.tblSocios
		SET intMeses = intMeses + @intCantidad
		WHERE intCodigoSoc = @intCodigoSoc

        INSERT INTO tblSociosProcesados (intCodigoAfi
           ,strCedulaAfi
           ,strNombreAfi
           ,strApellido1Afi
           ,strApellido2Afi
           ,strPlan
           ,intAnoAfi
           ,intMesAfi
           ,dtmFechaProceso
           ,bitProcesado
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

	if (@bitPrestamo = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosPrestamos(intCodigoIng
		    , intCuota
			, intCodigoPre
			, decCapital
			, decInteres
			, decMora
			, decCausado
			, decDebioPagar
			, decPago
			, intMesesAtrasados)
        SELECT @intCodigoIng
	        , x.item.value('(intCuota/text())[1]','Int')
	        , x.item.value('(intCodigoPre/text())[1]','Int')
	        , x.item.value('(decCapital/text())[1]','Decimal(18,3)')
	        , x.item.value('(decInteres/text())[1]','Decimal(18,3)')
	        , x.item.value('(decMora/text())[1]','Decimal(18,3)')
	        , x.item.value('(decCausado/text())[1]','Decimal(18,3)')
	        , x.item.value('(decDebioPagar/text())[1]','Decimal(18,3)')
	        , x.item.value('(decPago/text())[1]','Decimal(18,3)')
	        , x.item.value('(intMesesAtrasados/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoPrestamo/tblIngresosPrestamo') AS x(item)			

		DECLARE Credito_Cursor CURSOR FOR  
		SELECT decCapital, intCuota, intCodigoPre
		FROM dbExequial2010.dbo.tblIngresosPrestamos
		WHERE intCodigoIng = @intCodigoIng
		OPEN Credito_Cursor  
		FETCH NEXT FROM Credito_Cursor 
		INTO @decCapital, @intCuota, @intCodigoCre
		WHILE @@FETCH_STATUS = 0  
		   BEGIN  
		   UPDATE dbExequial2010.dbo.tblCreditos
		   SET decDebe = decDebe - @decCapital
		   WHERE intCodigoCre = @intCodigoCre

		   UPDATE dbExequial2010.dbo.tblCreditosCuota
		   SET bitPagada = 1
		       , dtmFechaPago = GETDATE()
			   , intCodigoIng = @intCodigoIng
		   WHERE intCodigoCre = @intCodigoCre
		       AND intCuota = @intCuota
           FETCH NEXT FROM Credito_Cursor INTO @decCapital, @intCuota, @intCodigoCre  
		   END
		CLOSE Credito_Cursor
		DEALLOCATE Credito_Cursor

		END

	IF (@bitAhorro = 1)
	    BEGIN
		SELECT @decAhorro = x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorro') AS x(item)

		INSERT INTO dbExequial2010.dbo.tblIngresosAhorros(intCodigoIng
		    , decAhorrado
			, decAhorro
			, decAcumula
			, bitCobraCuatroxMil)
        SELECT @intCodigoIng
	        , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
	        , @decAhorro
	        , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
	        , x.item.value('(bitCobraCuatroxMil/text())[1]','Bit')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorro') AS x(item)
		
		UPDATE dbExequial2010.dbo.tblAhorradores
		SET decAhorrado = decAhorrado + @decAhorro
		WHERE strCedulaAho = @strCedulaIng			

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
        SELECT 'Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaIng
            , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
			, 'Ahorros'
            , x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
            , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
			, GETDATE()
			, 1
            , x.item.value('(bitCobraCuatroxMil/text())[1]','bit')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorro') AS x(item)

		END

	IF (@bitAhorroEstudiante = 1)
	    BEGIN
		SELECT @decAhorro = x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroEstudiantil') AS x(item)

		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosEstudiantil(intCodigoIng
		    , decAhorrado
			, decAhorro
			, decAcumula)
        SELECT @intCodigoIng
	        , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
	        , @decAhorro
	        , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroEstudiantil') AS x(item)
		
		UPDATE dbExequial2010.dbo.tblAhorradores
		SET decAhorrosEstudiantes = decAhorrosEstudiantes + @decAhorro
		WHERE strCedulaAho = @strCedulaIng
		
		INSERT INTO dbExequial2010.dbo.tblAhorrosTransaccionesEstudiantil(strDescripcion
		    , intCodigoIng
			, strCedulaAho
			, decAhorrado
			, strTransaccion
			, decValor
			, decAcumula
			, dtmFechaTra
			, bitMuestra)
        SELECT 'Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaIng
            , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
			, 'Ahorros'
            , x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
            , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
			, GETDATE()
			, 1
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroEstudiantil1') AS x(item)
		END

	IF (@bitAhorroFijo = 1)
	    BEGIN
		SELECT @decAhorro = x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroFijo') AS x(item)

		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosFijos(intCodigoIng
		    , decAhorrado
			, decAhorro
			, decAcumula)
        SELECT @intCodigoIng
	        , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
	        , @decAhorro
	        , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroFijo') AS x(item)
		
		UPDATE dbExequial2010.dbo.tblAhorradores
		SET decAhorrosFijo = decAhorrosFijo + @decAhorro
		WHERE strCedulaAho = @strCedulaIng
		
		INSERT INTO dbExequial2010.dbo.tblAhorrosTransaccionesFijo(strDescripcion
		    , intCodigoIng
			, strCedulaAho
			, decAhorrado
			, strTransaccion
			, decValor
			, decAcumula
			, dtmFechaTra
			, bitMuestra)
        SELECT 'Comprobante # ' + CAST(@intCodigoIng AS VARCHAR(10))
		    , @intCodigoIng
			, @strCedulaIng
            , x.item.value('(decAhorrado/text())[1]','Decimal(18,3)')
			, 'Ahorros'
            , x.item.value('(decAhorro/text())[1]','Decimal(18,3)')
            , x.item.value('(decAcumula/text())[1]','Decimal(18,3)')
			, GETDATE()
			, 1
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroFijo') AS x(item)
		END

	IF (@bitAhorroNavideno = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosNavidenos(intCodigoIng
		    , dtmFechaCuo
			, strCuenta
			, decValorCuo
			, intCuotasPendientes
			, intCuotasPagadas)
        SELECT @intCodigoIng
	        , x.item.value('(dtmFechaCuo/text())[1]','DateTime')
	        , x.item.value('(strCuenta/text())[1]','Varchar(30)')
	        , x.item.value('(decValorCuo/text())[1]','Decimal(18,3)')
	        , x.item.value('(intCuotasPendientes/text())[1]','Int')
	        , x.item.value('(intCuotasPagadas/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroNavideño/tblIngresosAhorrosNavideno') AS x(item)			

		DECLARE Credito_Cursor CURSOR FOR  
		SELECT strCuenta, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM dbExequial2010.dbo.tblIngresosAhorrosNavidenos
		WHERE intCodigoIng = @intCodigoIng
		OPEN Credito_Cursor  
		FETCH NEXT FROM Credito_Cursor 
		INTO @strCuenta, @dtmFechaCuo
		WHILE @@FETCH_STATUS = 0  
		   BEGIN  
		   UPDATE dbExequial2010.dbo.tblAhorrosNavidenoDetalle
		   SET bitPagada = 1
		       , dtmFechaPago = @dtmFechaCuo
		   WHERE strCuenta = @strCuenta
		       AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @dtmFechaCuo

			UPDATE dbExequial2010.dbo.tblAhorrosNavideno
			SET intPagadas = intPagadas + 1
			WHERE strCuenta = @strCuenta

           FETCH NEXT FROM Credito_Cursor INTO @strCuenta, @dtmFechaCuo
		   END
		CLOSE Credito_Cursor
		DEALLOCATE Credito_Cursor

		END

	IF (@bitAhorroNatilleraEscolar = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosNatilleraEscolar(intCodigoIng
		    , dtmFechaCuo
			, strCuenta
			, decValorCuo
			, intCuotasPendientes
			, intCuotasPagadas)
        SELECT @intCodigoIng
	        , x.item.value('(dtmFechaCuo/text())[1]','DateTime')
	        , x.item.value('(strCuenta/text())[1]','Varchar(30)')
	        , x.item.value('(decValorCuo/text())[1]','Decimal(18,3)')
	        , x.item.value('(intCuotasPendientes/text())[1]','Int')
	        , x.item.value('(intCuotasPagadas/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroNatilleraEscolar') AS x(item)			

		DECLARE Credito_Cursor CURSOR FOR  
		SELECT strCuenta, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM dbExequial2010.dbo.tblIngresosAhorrosNatilleraEscolar
		WHERE intCodigoIng = @intCodigoIng
		OPEN Credito_Cursor  
		FETCH NEXT FROM Credito_Cursor 
		INTO @strCuenta, @dtmFechaCuo
		WHILE @@FETCH_STATUS = 0  
		   BEGIN  
		   UPDATE dbExequial2010.dbo.tblAhorrosNatilleraEscolarDetalle
		   SET bitPagada = 1
		       , dtmFechaPago = @dtmFechaCuo
		   WHERE strCuenta = @strCuenta
		       AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @dtmFechaCuo

			UPDATE dbExequial2010.dbo.tblAhorrosNatilleraEscolar
			SET intPagadas = intPagadas + 1
			WHERE strCuenta = @strCuenta

           FETCH NEXT FROM Credito_Cursor INTO @strCuenta, @dtmFechaCuo
		   END
		CLOSE Credito_Cursor
		DEALLOCATE Credito_Cursor

		END
		
	IF (@bitAhorroaFuturo = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosaFuturo(intCodigoIng
		    , dtmFechaCuo
			, strCuenta
			, decValorCuo
			, intCuotaPendientes
			, intCuotasPagadas)
        SELECT @intCodigoIng
	        , x.item.value('(dtmFechaCuo/text())[1]','DateTime')
	        , x.item.value('(strCuenta/text())[1]','Varchar(30)')
	        , x.item.value('(decValorCuo/text())[1]','Decimal(18,3)')
	        , x.item.value('(intCuotaPendientes/text())[1]','Int')
	        , x.item.value('(intCuotasPagadas/text())[1]','Int')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAhorroaFuturo/tblIngresosAhorrosaFuturo') AS x(item)			

		DECLARE Credito_Cursor CURSOR FOR  
		SELECT strCuenta, CONVERT(VARCHAR(10), dtmFechaCuo, 121)
		FROM dbExequial2010.dbo.tblIngresosAhorrosaFuturo
		WHERE intCodigoIng = @intCodigoIng
		OPEN Credito_Cursor  
		FETCH NEXT FROM Credito_Cursor 
		INTO @strCuenta, @dtmFechaCuo
		WHILE @@FETCH_STATUS = 0  
		   BEGIN  
		   UPDATE dbExequial2010.dbo.tblAhorrosaFuturoDetalle
		   SET bitPagada = 1
		       , dtmFechaPago = @dtmFechaCuo
		   WHERE strCuenta = @strCuenta
		       AND CONVERT(VARCHAR(10), dtmFechaCuota, 121) = @dtmFechaCuo

			UPDATE dbExequial2010.dbo.tblAhorrosaFuturo
			SET intPagadas = intPagadas + 1
			WHERE strCuenta = @strCuenta

           FETCH NEXT FROM Credito_Cursor INTO @strCuenta, @dtmFechaCuo
		   END
		CLOSE Credito_Cursor
		DEALLOCATE Credito_Cursor

		END

	IF (@bitOtro = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosOtrosIngresos(intCodigoIng
		    , strCodOtrosIngresos
			, strDescripcion
			, decValor)
        SELECT @intCodigoIng
	        , x.item.value('(strCodOtrosIngresos/text())[1]','Varchar(30)')
	        , x.item.value('(strDescripcion/text())[1]','Varchar(100)')
	        , x.item.value('(decValor/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoOtrosIngresos/tblIngresosOtrosIngreso') AS x(item)			

		END

	IF (@bitPrestamoAbono = 1)
	    BEGIN
        SELECT @intCodigoCre = x.item.value('(intCodigoCre/text())[1]','Int')
		    , @decAbonboPrestamo = x.item.value('(decAbonoPrestamo/text())[1]','Decimal(18,3)')
			, @bitDeducirAbonodelMonto = x.item.value('(bitDeducirAbonodelMonto/text())[1]','Bit')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAbonoaPrestamo') AS x(item)
		
        INSERT INTO dbExequial2010.dbo.tblIngresosPrestamosAbono(intCodigoIng
		    , intCodigoCre
     		, decAbonoPrestamo)
        VALUES (@intCodigoIng
	        , @intCodigoCre
	        , @decAbonboPrestamo)

		IF(@bitDeducirAbonodelMonto = 0)			
		    BEGIN
			UPDATE dbExequial2010.dbo.tblCreditos
			SET decAbono = decAbono + @decAbonboPrestamo
			WHERE intCodigoCre = @intCodigoCre
			END
		ELSE
		    BEGIN
			UPDATE dbExequial2010.dbo.tblCreditos
			SET decMonto = decMonto - @decAbonboPrestamo
			WHERE intCodigoCre = @intCodigoCre
			END
		END

	IF (@bitVenta = 1)
	    BEGIN
        SELECT @intCodVenta = x.item.value('(intCodigoCre/text())[1]','Int')
		    , @decAbona = x.item.value('(decAbona/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAbonoaVenta') AS x(item)

		INSERT INTO dbExequial2010.dbo.tblIngresosVentas(intCodigoIng
		    , intCodVenta
			, decAbona
			, decAdeuda)
        SELECT @intCodigoIng
		    , x.item.value('(intCodVenta/text())[1]','Int')
		    , x.item.value('(decAbona/text())[1]','Decimal(18,3)')
		    , x.item.value('(decAdeuda/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAbonoaVenta') AS x(item)

		UPDATE dbExequial2010.dbo.tblVentas
		SET decDebeVen = decDebeVen - @decAbona
		WHERE intCodVenta = @intCodVenta
		END

	IF (@bitDeuda = 1)
	    BEGIN
        SELECT @intCodDeu = x.item.value('(intCodDeu/text())[1]','Int')
		    , @decAbona = x.item.value('(decAbona/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAbonoaDeuda/tblIngresosDeuda') AS x(item)

        INSERT INTO dbExequial2010.dbo.tblIngresosDeudas(intCodigoIng
		    , strCedula
			, intCodDeu
			, decDebe
			, decAbona
			, decQueda)
        SELECT @intCodigoIng
		    , @strCedulaIng
		    , x.item.value('(intCodDeu/text())[1]','Int')
		    , x.item.value('(decDebe/text())[1]','Decimal(18,3)')
		    , x.item.value('(decAbona/text())[1]','Decimal(18,3)')
		    , x.item.value('(decQueda/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/ingresoAbonoaDeuda/tblIngresosDeuda') AS x(item)

		UPDATE dbExequial2010.dbo.tblDeudas
		SET decAbonaDeu = decAbonaDeu + @decAbona
		    , decDebeDeu = decAbonaDeu - @decAbona
		WHERE intCodDeu = @intCodDeu
		    AND strCedula = @strCedulaIng

		END

	IF (@bitAhorroCdt = 1)
	    BEGIN
		INSERT INTO dbExequial2010.dbo.tblIngresosAhorrosCdt(intCodigoIng
		    , intNumeroCdt
			, decValorCdt)
        SELECT @intCodigoIng
		    , x.item.value('(intNumeroCdt/text())[1]','Int')
		    , x.item.value('(decValorCdt/text())[1]','Decimal(18,3)')
        FROM @xmlIngreso.nodes('tblIngreso/objIngresosAhorrosCdt') AS x(item)		
		
		INSERT INTO dbExequial2010.DBO.tblAhorrosCdts(intNumeroCdt
            , strCedulaAho
            , decInteresesCdt
            , dtmFechaIniCdt
            , dtmFechaFinCdt
            , decMontoCdt
            , decValorIntereses
            , bitAnuladoCdt
            , bitLiquidadoCdt
            , intMesesCdt
            , decInteresMensualCdt
            , intAnoMes
            , bitAnticipadoCdt
            , dtmFechaLiquidacion
            , dtmFechaAnulado
            , intCodigoIng)	
        SELECT x.item.value('(intNumeroCdt/text())[1]','Int')
		    , x.item.value('(strCedulaAho/text())[1]','VARCHAR(30)')
		    , x.item.value('(decInteresesCdt/text())[1]','Decimal(18,3)')
		    , x.item.value('(dtmFechaIniCdt/text())[1]','DateTime')
		    , x.item.value('(dtmFechaIniCdt/text())[1]','DateTime')
		    , x.item.value('(decMontoCdt/text())[1]','Decimal(18,3)')
		    , x.item.value('(decValorIntereses/text())[1]','Decimal(18,3)')
			, x.item.value('(bitAnuladoCdt/text())[1]','Bit')
			, x.item.value('(bitLiquidadoCdt/text())[1]','Bit')
			, x.item.value('(intMesesCdt/text())[1]','Int')
		    , x.item.value('(decInteresMensualCdt/text())[1]','Decimal(18,3)')
			, x.item.value('(intAnoMes/text())[1]','Int')
			, x.item.value('(bitAnticipadoCdt/text())[1]','Bit')
		    , x.item.value('(dtmFechaLiquidacion/text())[1]','DateTime')
		    , x.item.value('(dtmFechaAnulado/text())[1]','DateTime')
			, @intCodigoIng
        FROM @xmlIngreso.nodes('tblIngreso/objAhorroCdt') AS x(item)
		END

	COMMIT TRAN

    SELECT @intCodigoIng intCodigoIng

END TRY    
BEGIN CATCH    
    ROLLBACK TRAN
	--SELECT * FROM tblErroresSp WHERE sp = 'spIngresoInsertar' ORDER BY idCodigo DESC
    INSERT INTO tblErroresSp(fecha, Descripcion, sp) VALUES(GETDATE(), ERROR_MESSAGE(), 'spIngresoInsertar')
    SELECT 0 intCodigoIng
END CATCH    
GO


