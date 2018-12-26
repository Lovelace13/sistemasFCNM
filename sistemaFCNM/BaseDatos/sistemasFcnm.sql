
Create database SistemasFCNM
GO

use SistemasFCNM
GO
--Ubicacion
create table Edificio(ID int identity (1,1) not null primary key,
					  Bloque varchar(50) not null
					  );
create table NombreOficina(ID int identity (1,1) not null primary key,
					  NombreOficina varchar(50) not null
					  );
create table AreaOficina(ID int identity (1,1) not null primary key,
					  Area varchar(50) not null
					  );
create table Oficina (ID int not null identity (1,1) primary key,
                      NombreOficina int not null, 
                      Edificio int  not null,
                      Area int not null,
                      FOREIGN KEY (Edificio) REFERENCES Edificio(ID),
					  FOREIGN KEY (NombreOficina) REFERENCES NombreOficina(ID),
					  FOREIGN KEY (Area) REFERENCES AreaOficina(ID),
					  );


create table Estado (ID int identity (1,1) not null primary key,
                 Estado varchar(20) not null
                 );

--Usuario
create table TipoUsuario (ID int identity(1,1) not null primary key,
                        Tipo varchar(20) not null);
create table Usuario(ID int identity(1,1) not null primary key,
					 Usuario varchar(20) not null,
                     Tipo int not null,
                     Nombre varchar(100) not null,
                     Clave varchar(20) not null,
                     FOREIGN KEY ( Tipo) REFERENCES TipoUsuario(ID)
					 ); 

--Cpu
create table CpuInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table CpuNombre (ID int identity (1,1) primary key,
                 NombrePC varchar(50)
                 );
create table CpuTipo (ID int identity (1,1) primary key,
                 TipoPC varchar(10)
                 );
create table CpuPerfil (ID int identity (1,1) primary key,
                 Perfil varchar(50)
                 );
create table CpuTag (ID int identity (1,1) primary key,
                 Tag varchar(50)
                 );
create table CpuCode (ID int identity (1,1) primary key,
                 Code varchar(50)
                 );
create table CpuProcesador (ID int identity (1,1) primary key,
                 Procesador varchar (30)
                 );
create table CpuMemoria (ID int identity (1,1) primary key,
                 Memoria varchar(10)
                 );
create table CpuDisco (ID int identity (1,1) primary key,
                 Disco varchar(10)
                 );
create table CpuAdicionalLote (ID int identity (1,1) primary key,
                 AdicionalLote varchar(10)
                 );
create table CpuMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table CpuSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );

create table Cpu (ID int identity (1,1) primary key,
                 Inventario int,
                 NombrePC int,
                 TipoPC int,
                 Perfil int ,
                 Tag int,
                 Code int,
                 Procesador int,
                 Memoria int,
                 Disco int,
                 AdicionalLote int,
                 Marca int,
                 Serie int,
                 Estado int,
				 FOREIGN KEY (Inventario) REFERENCES CpuInventario(ID),
                 FOREIGN KEY (NombrePC) REFERENCES CpuNombre(ID),
                 FOREIGN KEY (TipoPC) REFERENCES CpuTipo(ID),
                 FOREIGN KEY (Perfil) REFERENCES CpuPerfil(ID),
                 FOREIGN KEY (Tag) REFERENCES CpuTag(ID),
                 FOREIGN KEY (Code) REFERENCES CpuCode(ID),
				 FOREIGN KEY (Disco) REFERENCES CpuDisco(ID),
                 FOREIGN KEY (Procesador) REFERENCES CpuProcesador(ID),
                 FOREIGN KEY (Memoria) REFERENCES CpuMemoria(ID),
                 FOREIGN KEY (AdicionalLote) REFERENCES CpuAdicionalLote(ID),
                 FOREIGN KEY (Marca) REFERENCES CpuMarca(ID),
                 FOREIGN KEY (Serie) REFERENCES CpuSerie(ID),
                 FOREIGN KEY (Estado) REFERENCES Estado(ID),

                 ); 

--Pantalla
create table PantallaInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table PantallaMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table PantallaModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table PantallaSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table PantallaPulgadas (ID int identity (1,1) primary key,
                 Pulgadas varchar(5)
                 );
create table Pantalla(ID int identity (1,1) primary key,
                       Inventario int,
                       Pulgadas int,
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int,
					   FOREIGN KEY (Inventario) REFERENCES PantallaInventario(ID),
                       FOREIGN KEY (Pulgadas) REFERENCES PantallaPulgadas(ID),
                       FOREIGN KEY (Marca) REFERENCES PantallaMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES PantallaModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES PantallaSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES Estado(ID)
                       );
--Teclado
create table TecladoInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table TecladoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table TecladoModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table TecladoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Teclado (ID int identity (1,1) primary key,
                      Inventario int,
                      Marca int,
                      Modelo int,
                      Serie int,
                      Estado int,
					  FOREIGN KEY (Inventario) REFERENCES TecladoInventario(ID),
                      FOREIGN KEY (Marca) REFERENCES TecladoMarca(ID),
                      FOREIGN KEY (Modelo) REFERENCES TecladoModelo(ID),
                      FOREIGN KEY (Serie) REFERENCES TecladoSerie(ID),
                      FOREIGN KEY (Estado) REFERENCES Estado(ID));
--Mouse
create table MouseInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table MouseMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table MouseModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table MouseSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Mouse (ID int identity (1,1) primary key,
                    Inventario int,
                    Marca int,
                    Modelo int,
                    Serie int,
                    Estado int,
					FOREIGN KEY (Inventario) REFERENCES MouseInventario(ID),
                    FOREIGN KEY (Marca) REFERENCES MouseMarca(ID),
                    FOREIGN KEY (Modelo) REFERENCES MouseModelo(ID),
                    FOREIGN KEY (Serie) REFERENCES MouseSerie(ID),
                    FOREIGN KEY (Estado) REFERENCES Estado(ID)
                    );
--Parlante
create table ParlanteInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table ParlanteMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ParlanteModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ParlanteSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Parlante (ID int identity (1,1) primary key,
                       Inventario int,
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int,
					   FOREIGN KEY (Inventario) REFERENCES ParlanteInventario(ID),
                       FOREIGN KEY (Marca) REFERENCES ParlanteMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES ParlanteModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES ParlanteSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES Estado(ID)
                       
                       );
--Impresora
create table ImpresoraInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table ImpresoraMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ImpresoraModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ImpresoraSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Impresora (ID int identity (1,1) primary key,
                       Inventario int,
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int,
					   FOREIGN KEY (Inventario) REFERENCES ImpresoraInventario(ID),
                       FOREIGN KEY (Marca) REFERENCES ImpresoraMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES ImpresoraModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES ImpresoraSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES Estado(ID)
                       
                       
                       
                       );
--Regulador
create table ReguladorInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table ReguladorMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ReguladorModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ReguladorSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table ReguladorTipo (ID int identity (1,1) primary key,
                 Tipo varchar(30)
                 );

create table Regulador (ID int identity (1,1) primary key,
                        Inventario int,
                        Tipo int,
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
						FOREIGN KEY (Inventario) REFERENCES ReguladorInventario(ID),
                        FOREIGN KEY (Tipo) REFERENCES ReguladorTipo(ID),
                        FOREIGN KEY (Marca) REFERENCES ReguladorMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES ReguladorModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES ReguladorSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES Estado(ID)
                        
                        );
--Proyector
create table ProyectorInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table ProyectorInventarioEspolTech (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table ProyectorMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ProyectorModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ProyectorSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Proyector (ID int identity (1,1) primary key,
                        Inventario int,
                        InventarioEspoltech int,
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
						FOREIGN KEY (Inventario) REFERENCES ProyectorInventario(ID),
						FOREIGN KEY (InventarioEspoltech) REFERENCES ProyectorInventarioEspolTech(ID),
                        FOREIGN KEY (Marca) REFERENCES ProyectorMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES ProyectorModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES ProyectorSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES Estado(ID)
						
						);

--Telefono
create table TelefonoInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table TelefonoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table TelefonoModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table TelefonoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table TelefonoTipo (ID int identity (1,1) primary key,
                 Tipo varchar(20)
                 );
create table TelefonoExtension (ID int identity (1,1) primary key,
                 Extension varchar(10)
                 );

create table Telefono (ID int identity (1,1) primary key,
                        Inventario int, 
                        Extension int,
                        Tipo int,
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
						FOREIGN KEY (Inventario) REFERENCES TelefonoInventario(ID),
                        FOREIGN KEY (Tipo) REFERENCES TelefonoTipo(ID),
                        FOREIGN KEY (Marca) REFERENCES TelefonoMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES TelefonoModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES TelefonoSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES Estado(ID),
						FOREIGN KEY (Extension) REFERENCES TelefonoExtension(ID)
						);

--Pantalla_Proyeccion
create table PantallaProyeccionInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table PantallaProyeccionMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table PantallaProyeccionModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table PantallaProyeccionSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table PantallaProyeccionDimensiones (ID int identity (1,1) primary key,
                 Dimensiones varchar(10)
                 );
create table PantallaProyeccion(ID int identity (1,1) primary key,
                                Inventario int,
                                Dimensiones int,
                                Marca int,
                                Modelo int,
                                Serie int,
                                Estado int,
								FOREIGN KEY (Inventario) REFERENCES PantallaProyeccionInventario(ID),
                                FOREIGN KEY (Dimensiones) REFERENCES PantallaProyeccionDimensiones(ID),
                                FOREIGN KEY (Marca) REFERENCES PantallaProyeccionMarca(ID),
                                FOREIGN KEY (Modelo) REFERENCES PantallaProyeccionModelo(ID),
                                FOREIGN KEY (Serie) REFERENCES PantallaProyeccionSerie(ID),
                                FOREIGN KEY (Estado) REFERENCES Estado(ID)
                                
                                );
--Microfono
create table MicrofonoInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table MicrofonoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table MicrofonoTipo (ID int identity (1,1) primary key,
                 Tipo varchar(70)
                 );
create table MicrofonoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Microfono (ID int identity (1,1) primary key,
                        Inventario int,
                        Marca int,
                        Tipo int,
                        Serie int,
                        Estado int,
						FOREIGN KEY (Inventario) REFERENCES MicrofonoInventario(ID),
                        FOREIGN KEY (Marca) REFERENCES MicrofonoMarca(ID),
                        FOREIGN KEY (Tipo) REFERENCES MicrofonoTipo(ID),
                        FOREIGN KEY (Serie) REFERENCES MicrofonoSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES Estado(ID));
--Radio
create table RadioInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table RadioMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table RadioModelo (ID int identity (1,1) primary key,
                 modelo varchar(70)
                 );
create table RadioSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table Radio (ID int identity (1,1) primary key,
                    Inventario int,
                    Marca int,
                    Modelo int,
                    Serie int,
                    Estado int,
					FOREIGN KEY (Inventario) REFERENCES RadioInventario(ID),
                    FOREIGN KEY (Marca) REFERENCES RadioMarca(ID),
                    FOREIGN KEY (Modelo) REFERENCES RadioModelo(ID),
                    FOREIGN KEY (Serie) REFERENCES RadioSerie(ID),
                    FOREIGN KEY (Estado) REFERENCES Estado(ID)
					
					);

--Equipo
create table EquipoInventario (ID int identity (1,1) primary key,
                 Inventario varchar(30)
                 );
create table Propietario (ID int identity (1,1) primary key,
                 Usuario varchar(20)
                 );

create table Equipo (ID int identity (1,1) primary key,
					 Inventario int,
                     Cpu int,
                     Oficina int,
                     Microfono int,
                     Telefono int,
                     PantallaProyeccion int,
                     Radios int,
                     Pantalla int,
                     Teclado int,
                     Mouse int,
                     Parlante int,
                     Regulador int,
                     Impresora int ,
                     Proyector int,
					 Propietario int,
					 FOREIGN KEY (Inventario) REFERENCES EquipoInventario(ID),
                     FOREIGN KEY (Oficina) REFERENCES Oficina(ID),
                     FOREIGN KEY (Cpu) REFERENCES CPU(ID),
                     FOREIGN KEY (Microfono) REFERENCES Microfono(ID),
                     FOREIGN KEY (Telefono) REFERENCES Telefono(ID),
                     FOREIGN KEY (PantallaProyeccion) REFERENCES PantallaProyeccion(ID),
                     FOREIGN KEY (Radios) REFERENCES Radio(ID),
                     FOREIGN KEY (Pantalla) REFERENCES Pantalla(ID),
                     FOREIGN KEY (Teclado) REFERENCES Teclado(ID),
                     FOREIGN KEY (Mouse) REFERENCES Mouse(ID),
                     FOREIGN KEY (Parlante) REFERENCES Parlante(ID),
                     FOREIGN KEY (Regulador) REFERENCES Regulador(ID),
                     FOREIGN KEY (Impresora) REFERENCES Impresora(ID),
                     FOREIGN KEY (Proyector) REFERENCES Proyector(ID),
					 FOREIGN KEY (Propietario) REFERENCES Propietario(ID));

--Inventario 
create table FechaInventario (ID int identity (1,1) primary key,
                 Fecha date not null
                 );
create table Inventario (ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                         Fecha int not null, 
                         Ayudante int not null,
                         observacion varchar(500), 
                         Equipo int not null,
                         FOREIGN KEY (Ayudante) REFERENCES Usuario(ID ),
                         FOREIGN KEY (Equipo) REFERENCES Equipo(ID),
						 FOREIGN KEY (Fecha) REFERENCES FechaInventario(ID)
						 );



