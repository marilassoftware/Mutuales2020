USE [dbExequial2010]
GO
/****** Object:  StoredProcedure [dbo].[spSociosProcesadosConsultar]    Script Date: 1/05/2019 8:02:00 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Andrés Tabares>
-- Create date: <Mayo 1 de 2019>
-- Description:	<Consulta los registros para mostrar en la web.>
-- =============================================
ALTER PROCEDURE [dbo].[spSociosProcesadosConsultar]
--DECLARE

AS

SELECT TOP 20 intSocioActualidado
    , intCodigoAfi
    , strCedulaAfi
    , strNombreAfi
    , strApellido1Afi
    , strApellido2Afi
    , strPlan
    , intAnoAfi
    , intMesAfi
    , dtmFechaProceso
    , bitProcesado
    , strMutual
FROM tblSociosProcesados
WHERE bitProcesado = 0
ORDER BY intSocioActualidado ASC
