USE [dbExequial2010]
GO
/****** Object:  StoredProcedure [dbo].[spReporteTransacciones06TransaccionesRegistradasdeunahorradorenunrangodeFecha]    Script Date: 1/05/2019 11:37:47 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Andrés Felipe Tabares>
-- Create date: <Marzo 13 de 2010>
-- Description:	<Consulta los ahorros en un rango de fecha>
-- =============================================
ALTER PROCEDURE [dbo].[spReporteTransacciones06TransaccionesRegistradasdeunahorradorenunrangodeFecha]
--Declare
@dtmFechaIni datetime
, @dtmFechaFin datetime
, @strCedulaAho Varchar(20)

As

Declare @strFechaIni Varchar(10)
, @strFechaFin Varchar(10)

Set @strFechaIni = Convert(Varchar(10), @dtmFechaIni, 121)
Set @strFechaFin = Convert(Varchar(10), @dtmFechaFin, 121)

Select A.intCodigoIng
, A.strCedulaAho
, B.strNombreAho
, B.strApellido1Aho + ' ' + B.strApellido2Aho As strApellidoAho
, Convert(Varchar(19), A.dtmFechaTra, 121) As dtmFechaTra
, A.strDescripcion
, A.decAhorrado
, A.strTransaccion
, A.decValor
, A.decAcumula
, Case When A.bitMuestra = 1 Then 'Si' When A.bitMuestra = 0 Then 'No' End As Valida
From tblAhorrosTransacciones As A
Inner Join tblAhorradores As B On A.strCedulaAho = B.strCedulaAho
Where Convert(Varchar(10), A.dtmFechaTra, 121) >= @strFechaIni
And Convert(Varchar(10), A.dtmFechaTra, 121) <= @strFechaFin
And A.strCedulaAho = @strCedulaAho
Order By A.intCodigo desc




