USE [DB_A3EF3F_SUDOKU]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_SeleccionUsuario]
(
 
  @USUARIO VARCHAR(50)
 
)
AS
BEGIN

SET NOCOUNT ON;

SELECT ID FROM  CLIENTE WHERE USUARIO = @USUARIO ;
END 
