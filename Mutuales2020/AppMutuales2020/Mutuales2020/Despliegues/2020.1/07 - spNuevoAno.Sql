-- =============================================
-- Author:		<Andrés Tabares>
-- Create date: <Mayo 1 de 2019>
-- Description:	<Registra los datos de nuevo año.>
-- =============================================
ALTER PROCEDURE spNuevoAno
--DECLARE
@intAno INT
, @intAnoAnt INT
, @intMes INT
, @intMesAnt INT
, @strCodServiciop VARCHAR(30)
, @strCodServiciopAnt VARCHAR(30)
, @intCodigoSoc INT
, @Usuario VARCHAR(30)

AS

BEGIN TRY
    BEGIN TRAN
    UPDATE tblSocios
	SET intAño = @intAno
	    , intMeses = @intMes
		, strCodServiciop = @strCodServiciop
	WHERE intCodigoSoc = @intCodigoSoc

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

	INSERT INTO tblLogNuevoAño(intCodigoSoc
		, dtmFechaLog
		, intMesAnterior
		, intMesNuevo
		, intAñoAnterior
		, intAñoNuevo
		, strServicioAnterior
		, strServicioNuevo
		, strUsuario)
	VALUES(@intCodigoSoc
		, GETDATE()
		, @intMesAnt
		, @intMes
		, @intAnoAnt
		, @intAno
		, @strCodServiciopAnt
		, @strCodServiciop
		, @Usuario)

	COMMIT TRAN

    SELECT '1' intCodigo

END TRY    
BEGIN CATCH    
    ROLLBACK TRAN
	--SELECT * FROM tblErroresSp WHERE sp = 'spNuevoAno' ORDER BY id DESC
    INSERT INTO tblErroresSp(fecha, Descripcion, sp) VALUES(GETDATE(), ERROR_MESSAGE(), 'spNuevoAno')
    SELECT 0 intCodigo
END CATCH   