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
-- Description:	<Actualiza los registros llevados a la WEB.>
-- =============================================
CREATE PROCEDURE [dbo].[spSociosProcesadosActualizar]
--DECLARE
@intSocioActualidado INT

AS

UPDATE tblSociosProcesados
SET bitProcesado = 1
WHERE intSocioActualidado = @intSocioActualidado

