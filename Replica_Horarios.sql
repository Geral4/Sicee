USE [PE_POS]
GO
/****** Object:  StoredProcedure [dbo].[REG_HORARIOS]    Script Date: 23/01/2019 12:18:08 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [dbo].[REG_HORARIOS]  
	@EMPLEADO nvarchar(20),
	@F1 nvarchar(50),
	@F2 nvarchar(50)

as

DECLARE @@I INT
SELECT @@I=1



DELETE  cat_nomina_trabajadores_horarios
WHERE     (fecha > CONVERT(DATETIME, @F2, 102)) AND CLAVE_EMPLEADO=@EMPLEADO

DELETE  cat_nomina_trabajadores_horarios_base
WHERE     (fecha > CONVERT(DATETIME, @F2, 102)) AND CLAVE_EMPLEADO=@EMPLEADO



SET @@I=0

WHILE @@I<=3600
BEGIN 
	INSERT INTO cat_nomina_trabajadores_horarios  (clave_empleado, H1,H1C,H2C,H2, [user], SUCURSAL, fecha, descanso, ocultar, observaciones)
	SELECT       clave_empleado, H1,H1C,H2C,H2, [user], SUCURSAL, fecha + 7 AS Expr2, descanso, ocultar, observaciones 
	FROM         cat_nomina_trabajadores_horarios
	WHERE     (fecha = CONVERT(DATETIME, @F1, 102)+@@I ) AND CLAVE_EMPLEADO=@EMPLEADO


	INSERT INTO cat_nomina_trabajadores_horarios_base  (clave_empleado, H1,H1C,H2C,H2, [user], SUCURSAL, fecha, descanso, ocultar, observaciones)
	SELECT       clave_empleado, H1,H1C,H2C,H2, [user], SUCURSAL, fecha + 7 AS Expr2, descanso, ocultar, observaciones 
	FROM         cat_nomina_trabajadores_horarios
	WHERE     (fecha = CONVERT(DATETIME, @F1, 102)+@@I ) AND CLAVE_EMPLEADO=@EMPLEADO

	
	select cat_nom.clave_empleado, getdate() as fecha, 'DIA BLOQUEADO' as tipo_cambio, 'obs' as obs from cat_nomina_trabajadores_cambio cat_cam right join
	cat_nomina_trabajadores cat_nom on cat_nom.clave_empleado = cat_cam.clave_empleado
	group by cat_nom.clave_empleado
	--SELECT       clave_empleado, clave_horario, [user], SUCURSAL, fecha + 7 AS Expr2 FROM         cat_nomina_trabajadores_horarios
--	WHERE     (fecha = CONVERT(DATETIME, '2014-07-28 00:00:00', 102)+@@I ) AND CLAVE_EMPLEADO='PRUEBA'


	SET @@I=@@I+1

END


SELECT       clave_empleado, H1,H1C,H2C,H2, [user], SUCURSAL, fecha + 7 AS Expr2, descanso, ocultar 
	FROM         cat_nomina_trabajadores_horarios
	WHERE     (fecha = CONVERT(DATETIME, '20190107', 102)+2) AND CLAVE_EMPLEADO='MA019'