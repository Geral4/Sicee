alter view c_visor_bitacora as
select ROW_NUMBER() OVER(ORDER BY fecha ASC) AS 'N°', 
(emp.Nombre + ' ' + emp.ApellidoP + ' ' + emp.ApellidoM) 'Nombre Empleado', 
hr.CAlumnos 'Cantidad Alumnos', car.Nombre Carrera, asig.Nombre Asignatura,hr.ClasePractica 'Clase/Practica', 
hr.HorarioInicio 'Hora Inicio', hr.HorarioFin 'Hora Fin', hr.Observaciones 'Observaciones', 
hr.Firma 'Firma', hr.Fecha from Horario hr inner join Empleado emp on hr.DocenteEmpleado_id = emp.NPersonal 
inner join Carrera car on hr.Carrera_id = car.Clave inner join Asignatura asig on hr.Asignatura_id = asig.Clave 
inner join cat_aulas aula on hr.Aula_id = aula.clave


select [N°], [Nombre Empleado], [Cantidad Alumnos], Carrera, Asignatura, [Clase/Practica], [Hora Inicio], 
[Hora Fin], Observaciones, Firma from c_visor_bitacora where format(Fecha, 'yyyyMMdd') = format(getDate(), 'yyyyMMdd')


create view c_prestamos as
select p.Folio, iif(p.es_usuario= 1, p.NPersonal_id, p.NControl_id) prestado_a,
iif(p.es_usuario= 1, (emp.Nombre + ' '+ emp.ApellidoP + ' ' + emp.ApellidoM), (alum.Nombre + ' '+ alum.ApellidoP + ' ' + alum.ApellidoM)) prestado_a_nombre, 
p.FechaP fecha_prestamo, p.FechaE fecha_entrega,
pr.Nserie_id, inm.Nombre, pr.Observaciones, iif(pr.Prestado= 1, 'NO', 'SI') devuelto   
from Prestamo p inner join PrestamoInmueble pr on p.Folio = pr.Folio_id
left join Inmueble inm on pr.Nserie_id = inm.Nserie
left join Empleado emp on p.NPersonal_id = emp.NPersonal
left join Alumno alum on p.NControl_id = alum.NControl

select * from c_prestamos

select * from Horario where cast(HorarioInicio as smalldatetime) between cast('8:00' as smalldatetime) and 
cast('10:00' as smalldatetime)


