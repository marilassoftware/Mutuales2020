USE [dbExequial2010]
GO

/****** Object:  Table [dbo].[tblSociosProcesados]    Script Date: 1/05/2019 12:43:17 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSociosProcesados](
	[intSocioActualidado] [int] IDENTITY(1,1) NOT NULL,
	[intCodigoAfi] [int] NOT NULL,
	[strCedulaAfi] [varchar](20) NOT NULL,
	[strNombreAfi] [varchar](50) NOT NULL,
	[strApellido1Afi] [varchar](50) NOT NULL,
	[strApellido2Afi] [varchar](50) NOT NULL,
	[strPlan] [varchar](50) NOT NULL,
	[intAnoAfi] [int] NOT NULL,
	[intMesAfi] [int] NOT NULL,
	[dtmFechaProceso] [datetime] NOT NULL,
	[bitProcesado] [bit] NOT NULL,
	[strMutual] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tblSociosProcesados] PRIMARY KEY CLUSTERED 
(
	[intSocioActualidado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


