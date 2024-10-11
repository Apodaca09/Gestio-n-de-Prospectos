create database prospects;

use prospects;

create table Prospecto (
  id int PRIMARY KEY IDENTITY(1,1),
  nombre varchar(100) not null,
  primer_apellido varchar(100) not null,
  segundo_apellido varchar(100),
  calle varchar(100) not null,
  numero varchar(10) not null,
  colonia varchar(100) not null,
  codigo_postal varchar(10) not null,
  telefono varchar(15) not null,
  rfc varchar(13) not null,
  estatus varchar(20) not null default 'Enviado'
  constraint chk_estatus check (estatus in ('Enviado','Autorizado','Rechazado'))
)

create table Documentos(
 id INT PRIMARY KEY IDENTITY (1,1),
 prospecto_id int not null,
 contenido_archivo varbinary(max),
 nombre_archivo varchar(100) not null,
 fecha_captura DateTime default CURRENT_TIMESTAMP,
 foreign key (prospecto_id) references Prospecto(id) ON DELETE CASCADE
)

create table Evaluacion(
 id int primary key identity(1,1),
 prospecto_id int not null,
 estatus varchar(20) not null,
 observaciones_rechazo text,
 fecha_evaluacion datetime default CURRENT_TIMESTAMP,
 constraint chk_status_evaluacion check (estatus in('Autorizado','Rechazado')),
 foreign key (prospecto_id) references Prospecto(id) ON DELETE CASCADE
)

select * from Prospecto;

select * from Documentos;

select * from Evaluacion;

delete from Evaluacion;

delete from Documentos;

delete from Prospecto;

/* Reiniciar campos identity*/
DBCC CHECKIDENT ('Prospecto', RESEED, 0);
DBCC CHECKIDENT ('Documentos', RESEED, 0);
DBCC CHECKIDENT ('Evaluacion', RESEED, 0);
