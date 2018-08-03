USE [DB_A3EF3F_SUDOKU]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_SeleccionHorasActivar]
(
  @MAIL VARCHAR(50),
  @ESTADO VARCHAR(50),
  @FECHA DATETIME
 
)
AS
BEGIN

SET NOCOUNT ON;

SELECT DATEDIFF(hour, FECHA, @FECHA) AS HORAS FROM CLIENTE WHERE MAIL= @MAIL AND ESTADO = @ESTADO;
END 
