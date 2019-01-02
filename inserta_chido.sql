USE [Sicee]
GO

/****** Object:  StoredProcedure [dbo].[inserta_chido]    Script Date: 29/12/2018 01:49:53 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[inserta_chido]   
@maxRegistros int,  
@claveEdif nvarchar(20)  
as  
truncate table cat_aulas
declare @cont as int
set @cont = @maxRegistros

begin  
while @cont > = 0  
begin   
insert into cat_aulas (clave, nombre, capacidad) values (CONCAT(@claveEdif, @cont),'  ', 0) 
set @cont = @cont-1   
end   
  
end 
GO

