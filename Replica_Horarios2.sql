USE [Sicee]
GO
/****** Object:  StoredProcedure [dbo].[Bitacora]    Script Date: 25/01/2019 1:22:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [dbo].[Bitacora]  
	--@EMPLEADO nvarchar(20),
	@F1 nvarchar(50),
	@F2 nvarchar(50)

as

DECLARE @@I INT
--SELECT @@I=1

DELETE FROM  Horario
WHERE     (fecha > CONVERT(DATETIME, @F2, 102)) 

SET @@I=0

WHILE @@I<=4
BEGIN 
	INSERT INTO Horario (DocenteEmpleado_id, Carrera_id, Asignatura_id, HorarioInicio, HorarioFin, Aula_id, Dia, Firma, Fecha)
	SELECT       DocenteEmpleado_id, Carrera_id, Asignatura_id, HorarioInicio, HorarioFin, Aula_id, Dia, Firma, Fecha + 7 As FechaL
	FROM         Horario
	WHERE     (Fecha = CONVERT(DATETIME, @F1, 102)+@@I )
	SET @@I=@@I+1

END

--select * from Horario

