USE [dbExequial2010]
GO
/****** Object:  StoredProcedure [dbo].[spImprimirReciboTransacciones]    Script Date: 1/05/2019 11:56:28 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[spImprimirReciboTransacciones]
--Declare

@intCodigoRec int,
@strTransaccion Varchar(15)

As
--Set dateformat YMD

/*
Set @intCodigoRec = 2
Set @strTransaccion = 'Retiros'
--*/

Declare @strFechaTra VARCHAR(19)
, @strAnulado Varchar(15)
, @decGranTotal decimal(18,2)
, @dtmFecha datetime
, @strCedulaAho Varchar(15)
, @strUsuario Varchar(30)
, @strLetras Varchar(200)
, @strSeCobraCuatroxMil Varchar(200)

Set @strSeCobraCuatroxMil = ''

if @strTransaccion = 'Retiros'
    Begin
    Select @strFechaTra = CONVERT(VARCHAR(19), dtmFechaRec, 121)
    , @strAnulado = A.bitAnulado 
    , @strCedulaAho = strCedulaEgre
    --, @strUsuario = strUsuario
    , @strLetras = strLetras
    , @strSeCobraCuatroxMil = case When b.bitCobraCuatroxMil = 1 then 'Se cobra el cuatro por mil' end
    From tblEgresos As A
    Inner Join tblAhorradores As B On A.strCedulaEgre = B.strCedulaAho
    Where intCodigoEgr = @intCodigoRec
    End
Else
    Begin
    Select @strFechaTra = CONVERT(VARCHAR(19), dtmFechaRec, 121)
    , @strAnulado = bitAnulado 
    , @strCedulaAho = strCedulaIng
    , @strUsuario = strUsuario
    , @strLetras = strLetras
    From tblIngresos Where intCodigoIng = @intCodigoRec
    End

if @strAnulado = '1'
    Set @strAnulado = 'Anulado'
Else
    Set @strAnulado = ''

Create Table #tblRecibosIngresosAhorros(
intConse int IDENTITY (1, 1) NOT NULL ,
intCodigo int,
strCedula Varchar(15),
strNombre Varchar(60),
intRecibo int,
dtmFechaRec datetime,
dtmFechaTra datetime,
decSaldoAnt decimal(18,2),
strTransaccion Varchar(8),
decValor decimal(18,2),
decAcumula decimal(18,2),
strDescripcion Varchar(50),
decGranTotal decimal(18,2),
decAnterior decimal(18,2),
decAcumula1 int,
strAnulado Varchar(15),
strValorLetras Varchar(200)
) On [primary] 

Insert Into #tblRecibosIngresosAhorros(intCodigo
, strCedula
, strNombre
, intRecibo
, dtmFechaRec
, dtmFechaTra
, decSaldoAnt
, strTransaccion
, decValor
, decAcumula
, strDescripcion)
Select Top 3 intCodigo
, A.strCedulaAho
, strNombreAho + ' ' + strApellido1Aho + ' ' + strApellido2Aho As strNombre
, intCodigoIng
, dtmFechaTra
, dtmFechaTra
, A.decAhorrado
, strTransaccion
, decValor
, decAcumula
, strDescripcion
From tblAhorrosTransacciones As A 
inner Join tblAhorradores As B On A.strCedulaAho = B.strCedulaAho
Where A.strCedulaAho = @strCedulaAho 
    And CONVERT(VARCHAR(19), dtmFechaTra, 121) <= @strFechaTra
Order By CONVERT(VARCHAR(19), dtmFechaTra, 121) Desc

--Calcula el gran total del recibo.
Select Top 1 @decGranTotal = decValor From #tblRecibosIngresosAhorros Order By intCodigo Desc
upDate #tblRecibosIngresosAhorros Set decGranTotal = @decGranTotal

--Calcula el saldo anterior del recibo.
Select Top 1 @decGranTotal = decSaldoAnt From #tblRecibosIngresosAhorros Order By intCodigo Desc
upDate #tblRecibosIngresosAhorros Set decAnterior = @decGranTotal

--Calcula el saldo que acumula el ahorrador
Select Top 1 @decGranTotal = decAcumula From #tblRecibosIngresosAhorros Order By intCodigo Desc
upDate #tblRecibosIngresosAhorros Set decAcumula1 = @decGranTotal

--Calcula el saldo que acumula el ahorrador
Select Top 1 @dtmFecha = dtmFechaRec From #tblRecibosIngresosAhorros Order By intCodigo Desc
Print @dtmFecha
upDate #tblRecibosIngresosAhorros Set dtmFechaRec = @dtmFecha

--Calcula el saldo que acumula el ahorrador
Select Top 1 @decGranTotal = intRecibo From #tblRecibosIngresosAhorros Order By intCodigo Desc
upDate #tblRecibosIngresosAhorros Set intRecibo = @decGranTotal

--Aca se ingresa el valor de anulado o no de un recibo.
upDate #tblRecibosIngresosAhorros Set strAnulado = @strAnulado

Select intConse
    , intCodigo 
    , strCedula 
    , strNombre 
    , intRecibo 
    , Convert(Varchar(10), dtmFechaRec, 121) As dtmFechaRec
    , Convert(Varchar(19), dtmFechaTra, 121) As dtmFechaTra
    , decSaldoAnt
    , strTransaccion
    , decValor 
    , decAcumula
    , strDescripcion
    , decGranTotal 
    , decAnterior 
    , decAcumula1 
    , strAnulado 
    , @strUsuario As strUsuario 
    , @strLetras As strValorLetras
    , @strSeCobraCuatroxMil As strSeCobraCuatroxMil
From #tblRecibosIngresosAhorros 
ORDER BY intCodigo DESC

Drop Table #tblRecibosIngresosAhorros