
Create table [Alumno] (
	[IDAlumno] Integer Identity NOT NULL,
	[Nombre] Varchar(50) NOT NULL,
	[Apellido] Varchar(50) NOT NULL,
	[Telefono] Varchar(20) NULL,
	[Email] Varchar(50) NOT NULL,
Primary Key  ([IDAlumno])
) 
go

Create table [Universidad] (
	[IDUniversidad] Integer Identity NOT NULL,
	[Nombre] Varchar(100) NOT NULL,
	[Provincia] Varchar(50) NOT NULL,
	[Localidad] Varchar(50) NOT NULL,
Primary Key  ([IDUniversidad])
) 
go

Create table [Materia] (
	[IDMateria] Integer Identity NOT NULL,
	[Nombre] Varchar(100) NOT NULL,
Primary Key  ([IDMateria])
) 
go

Create table [AlumnoUni] (
	[IDAlumno] Integer NOT NULL,
	[IDUniversidad] Integer NOT NULL,
Primary Key  ([IDAlumno],[IDUniversidad])
) 
go

Create table [UniMateria] (
	[IDUniversidad] Integer NOT NULL,
	[IDMateria] Integer NOT NULL,
Primary Key  ([IDUniversidad],[IDMateria])
) 
go

Create table [Nota] (
	[IDAlumno] Integer NOT NULL,
	[IDMateria] Integer NOT NULL,
	[Calificacion] Integer NOT NULL,
Primary Key  ([IDAlumno],[IDMateria])
) 
go











Set quoted_identifier on
go

Set quoted_identifier off
go


