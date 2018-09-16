
Create database sistemasFCNM
GO

use sistemasFCNM
GO

create table Edificio(bloque varchar(5) not null PRIMARY KEY);

create table Oficina (ID int not null identity (1,1) primary key,
					  nombre_oficina varchar(30), 
					  edificio  varchar(5) not null,
					  area varchar(30) not null,
					  FOREIGN KEY (edificio) REFERENCES Edificio(bloque));

create table tipo_user (id_tipo int identity(1,1) primary key,
						tipo varchar(20));

create table Usuario(id_usuario varchar(20) not null primary key,
					 tipo_usuario int,
					 Nombre varchar(50) not null,
					 clave varchar (20) not null,
					 FOREIGN KEY ( tipo_usuario) REFERENCES tipo_user(id_tipo)); 

create table Caracteristicas (id_caracteristica INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
							  marca varchar(70),
							  modelo varchar(70),
							  serie varchar(70),
							  estado varchar(20));


create table CPU (ID int identity (1,1) primary key,
				inventario_cpu varchar(50),
				 nombre_PC varchar(50),
				 tipo_PC varchar(10),
				 perfil varchar(50),
				 tag varchar(50),
				 code varchar(50),
				 procesador varchar (30),
				 memoria varchar(10),
				 disco varchar(10),
				 adicional_lote varchar(10),
				 Caracteristicas int not null,
				 FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica)); 

create table Pantalla(ID int identity (1,1) primary key,
					   Inventario_Pantalla varchar(20),
					   caracteristicas int not null, 
					   pulgadas varchar(5),
					   FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Teclado (ID int identity (1,1) primary key,
					  Inventario_teclado varchar(20),
					  caracteristicas int not null,
					   FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Mouse (ID int identity (1,1) primary key,
					Inventario_Mouse varchar(20),
					  caracteristicas int not null
					   FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Parlante (ID int identity (1,1) primary key,
					   Inventario_Parlante varchar(20),
					  caracteristicas int not null,
					   FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));


create table Impresora (ID int identity (1,1) primary key,
						Inventario_Impresora varchar(20)  ,
					   caracteristicas int not null,
					   FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Regulador (ID int identity (1,1) primary key,
						Inventario_Regulador varchar(30),
						tipo varchar(30),
					    caracteristicas int not null,
						 FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Proyector (ID int identity (1,1) primary key,
						Inventario_Proyector varchar(20),
						Inventario_Espoltech varchar(20),
					    caracteristicas int not null
						 FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));


create table Telefono (ID int identity (1,1) primary key,
						Inventario_Telefono varchar(20), 
						caracteristicas int NOT NULL ,
					    extension varchar(10),
						tipo varchar(20)
						 FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Pantalla_Proyeccion(ID int identity (1,1) primary key,
								caracteristicas int not null,
								 Inventario_PantallaProyeccion varchar(30),
								 Dimensiones varchar(10),
								  FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Microfonos (ID int identity (1,1) primary key,
						caracteristicas int not null,
						 Inventario_Microfono varchar(30),
						  FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Radio (ID int identity (1,1) primary key,
					caracteristicas int not null,
					Inventario_Radio varchar(30),
					 FOREIGN KEY ( Caracteristicas) REFERENCES Caracteristicas(id_caracteristica));

create table Equipo (id_Equipo varchar(20) PRIMARY KEY,
					 Inventario_CPU int not null,
					 Oficina int not null,
					 Microfono int not null,
					 Telefono int not null,
					 PantallaProyeccion int not null,
					 Radios int not null,
					 Pantalla int not null,
					 Teclado int not null,
					 Mouse int not null,
					 Parlante int not null,
					 Regulador int not null,
					 Impresora int not null,
					 Proyector int not null,
					 FOREIGN KEY (Oficina) REFERENCES Oficina(ID),
					 FOREIGN KEY (Inventario_CPU) REFERENCES CPU(ID),
					 FOREIGN KEY (Microfono) REFERENCES Microfonos(ID),
					 FOREIGN KEY (Telefono) REFERENCES Telefono(ID),
					 FOREIGN KEY (PantallaProyeccion) REFERENCES Pantalla_Proyeccion(ID),
					 FOREIGN KEY (Radios) REFERENCES Radio(ID),
					 FOREIGN KEY (Pantalla) REFERENCES Pantalla(ID),
					 FOREIGN KEY (Teclado) REFERENCES Teclado(ID),
					 FOREIGN KEY (Mouse) REFERENCES Mouse(ID),
					 FOREIGN KEY (Parlante) REFERENCES Parlante(ID),
					 FOREIGN KEY (Regulador) REFERENCES Regulador(ID),
					 FOREIGN KEY (Impresora) REFERENCES Impresora(ID),
					 FOREIGN KEY (Proyector) REFERENCES Proyector(ID));

create table Inventario (id_inventario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
						 fecha_inventario date not null, 
						 Ayudante varchar(20) not null,
						 observacion varchar(500), 
						 Equipo varchar(20) not null,
						 FOREIGN KEY (Ayudante) REFERENCES Usuario(id_usuario),
						 FOREIGN KEY (Equipo) REFERENCES Equipo(id_Equipo));



