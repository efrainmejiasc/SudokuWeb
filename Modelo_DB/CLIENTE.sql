/*
   domingo, 29 de julio de 201813:39:47
   Usuario: sa
   Servidor: EMCSERVER
   Base de datos: DB_A3EF3F_SUDOKU
   Aplicación: 
*/

/* Para evitar posibles problemas de pérdida de datos, debe revisar este script detalladamente antes de ejecutarlo fuera del contexto del diseñador de base de datos.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.CLIENTE
	(
	ID int NOT NULL IDENTITY (1, 1),
	MAIL varchar(50) NULL,
	NOMBRE varchar(50) NULL,
	USUARIO varchar(50) NULL,
	PASSWORD varchar(MAX) NULL,
	FECHA datetime NULL,
	ESTADO varchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.CLIENTE ADD CONSTRAINT
	PK_CLIENTE PRIMARY KEY CLUSTERED 
	(
	ID
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CLIENTE SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CLIENTE', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CLIENTE', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CLIENTE', 'Object', 'CONTROL') as Contr_Per 