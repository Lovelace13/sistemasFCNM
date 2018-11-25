
Create database SistemasFCNM
GO

use SistemasFCNM
GO

create table Edificio(Bloque varchar(5) not null PRIMARY KEY);

create table Oficina (ID int not null identity (1,1) primary key,
                      nombreOficina varchar(30), 
                      Edificio  varchar(5) not null,
                      Area varchar(30) not null,
                      FOREIGN KEY (Edificio) REFERENCES Edificio(bloque));

create table TipoUsuario (IdTipo int identity(1,1) primary key,
                        tipo varchar(20));

create table Usuario(IdUsuario varchar(20) not null primary key,
                     TipoUsuario int,
                     Nombre varchar(50) not null,
                     Clave varchar (20) not null,
                     FOREIGN KEY ( TipoUsuario) REFERENCES TipoUsuario(IdTipo)); 

--Cpu
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
create table CpuModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table CpuSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table CpuEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Cpu (ID int identity (1,1) primary key,
                 InventarioCpu int,
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
                 Modelo int,
                 Serie int,
                 Estado int,
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
                 FOREIGN KEY (Modelo) REFERENCES CpuModelo(ID),
                 FOREIGN KEY (Serie) REFERENCES CpuSerie(ID),
                 FOREIGN KEY (Estado) REFERENCES CpuEstado(ID),

                 ); 

--Pantalla
create table PantallaMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table PantallaModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table PantallaSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table PantallaEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table PantallaPulgadas (ID int identity (1,1) primary key,
                 Pulgadas varchar(5)
                 );
create table Pantalla(ID int identity (1,1) primary key,
                       InventarioPantalla varchar(20),
                       Pulgadas int,
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int,
                       FOREIGN KEY (Pulgadas) REFERENCES PantallaPulgadas(ID),
                       FOREIGN KEY (Marca) REFERENCES PantallaMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES PantallaModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES PantallaSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES PantallaEstado(ID)
                       );
--Teclado
create table TecladoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table TecladoModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table TecladoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table TecladoEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Teclado (ID int identity (1,1) primary key,
                      InventarioTeclado varchar(20),
                      Marca int,
                      Modelo int,
                      Serie int,
                      Estado int,
                      FOREIGN KEY (Marca) REFERENCES TecladoMarca(ID),
                      FOREIGN KEY (Modelo) REFERENCES TecladoModelo(ID),
                      FOREIGN KEY (Serie) REFERENCES TecladoSerie(ID),
                      FOREIGN KEY (Estado) REFERENCES TecladoEstado(ID));
--Mouse

create table MouseMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table MouseModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table MouseSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table MouseEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Mouse (ID int identity (1,1) primary key,
                    InventarioMouse varchar(20),
                    Marca int,
                    Modelo int,
                    Serie int,
                    Estado int
                    FOREIGN KEY (Marca) REFERENCES MouseMarca(ID),
                    FOREIGN KEY (Modelo) REFERENCES MouseModelo(ID),
                    FOREIGN KEY (Serie) REFERENCES MouseSerie(ID),
                    FOREIGN KEY (Estado) REFERENCES MouseEstado(ID)
                    );
--Parlante
create table ParlanteMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ParlanteModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ParlanteSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table ParlanteEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Parlante (ID int identity (1,1) primary key,
                       InventarioParlante varchar(20),
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int
                       FOREIGN KEY (Marca) REFERENCES ParlanteMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES ParlanteModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES ParlanteSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES ParlanteEstado(ID)
                       
                       );
--Impresora
create table ImpresoraMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ImpresoraModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ImpresoraSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table ImpresoraEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Impresora (ID int identity (1,1) primary key,
                       InventarioImpresora varchar(20)  ,
                       Marca int,
                       Modelo int,
                       Serie int,
                       Estado int
                       FOREIGN KEY (Marca) REFERENCES ImpresoraMarca(ID),
                       FOREIGN KEY (Modelo) REFERENCES ImpresoraModelo(ID),
                       FOREIGN KEY (Serie) REFERENCES ImpresoraSerie(ID),
                       FOREIGN KEY (Estado) REFERENCES ImpresoraEstado(ID)
                       
                       
                       
                       );
--Regulador
create table ReguladorMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ReguladorModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ReguladorSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table ReguladorEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table ReguladorTipo (ID int identity (1,1) primary key,
                 Tipo varchar(30)
                 );

create table Regulador (ID int identity (1,1) primary key,
                        InventarioRegulador varchar(30),
                        Tipo int,
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
                        FOREIGN KEY (Tipo) REFERENCES ReguladorTipo(ID),
                        FOREIGN KEY (Marca) REFERENCES ReguladorMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES ReguladorModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES ReguladorSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES ReguladorEstado(ID)
                        
                        );
--Proyector
create table ProyectorMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table ProyectorModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table ProyectorSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table ProyectorEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Proyector (ID int identity (1,1) primary key,
                        InventarioProyector varchar(20),
                        InventarioEspoltech varchar(20),
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
                        FOREIGN KEY (Marca) REFERENCES ProyectorMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES ProyectorModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES ProyectorSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES ProyectorEstado(ID)
						
						);

--Telefono
create table TelefonoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table TelefonoModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table TelefonoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table TelefonoEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table TelefonoTipo (ID int identity (1,1) primary key,
                 Tipo varchar(20)
                 );
create table TelefonoExtension (ID int identity (1,1) primary key,
                 Extension varchar(10)
                 );

create table Telefono (ID int identity (1,1) primary key,
                        InventarioTelefono varchar(20), 
                        Extension int,
                        Tipo int,
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
                        FOREIGN KEY (Tipo) REFERENCES TelefonoTipo(ID),
                        FOREIGN KEY (Marca) REFERENCES TelefonoMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES TelefonoModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES TelefonoSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES TelefonoEstado(ID),
						FOREIGN KEY (Extension) REFERENCES TelefonoExtension(ID)
						);

--#;Pantalla_Proyeccion

create table PantallaProyeccionMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table PantallaProyeccionModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table PantallaProyeccionSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table PantallaProyeccionEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table PantallaProyeccionDimensiones (ID int identity (1,1) primary key,
                 Dimensiones varchar(10)
                 );
create table PantallaProyeccion(ID int identity (1,1) primary key,
                                InventarioPantallaProyeccion varchar(30),
                                Dimensiones int,
                                Marca int,
                                Modelo int,
                                Serie int,
                                Estado int,
                                FOREIGN KEY (Dimensiones) REFERENCES PantallaProyeccionDimensiones(ID),
                                FOREIGN KEY (Marca) REFERENCES PantallaProyeccionMarca(ID),
                                FOREIGN KEY (Modelo) REFERENCES PantallaProyeccionModelo(ID),
                                FOREIGN KEY (Serie) REFERENCES PantallaProyeccionSerie(ID),
                                FOREIGN KEY (Estado) REFERENCES PantallaProyeccionEstado(ID)
                                
                                );
--Microfono
create table MicrofonoMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table MicrofonoModelo (ID int identity (1,1) primary key,
                 Modelo varchar(70)
                 );
create table MicrofonoSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table MicrofonoEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Microfono (ID int identity (1,1) primary key,
                        InventarioMicrofono varchar(30),
                        Marca int,
                        Modelo int,
                        Serie int,
                        Estado int,
                        FOREIGN KEY (Marca) REFERENCES MicrofonoMarca(ID),
                        FOREIGN KEY (Modelo) REFERENCES MicrofonoModelo(ID),
                        FOREIGN KEY (Serie) REFERENCES MicrofonoSerie(ID),
                        FOREIGN KEY (Estado) REFERENCES MicrofonoEstado(ID));
create table RadioMarca (ID int identity (1,1) primary key,
                 Marca varchar(70)
                 );
create table RadioModelo (ID int identity (1,1) primary key,
                 modelo varchar(70)
                 );
create table RadioSerie (ID int identity (1,1) primary key,
                 Serie varchar(70)
                 );
create table RadioEstado (ID int identity (1,1) primary key,
                 Estado varchar(20)
                 );
create table Radio (ID int identity (1,1) primary key,
                    InventarioRadio varchar(30),
                    Marca int,
                    Modelo int,
                    Serie int,
                    Estado int,
                    FOREIGN KEY (Marca) REFERENCES RadioMarca(ID),
                    FOREIGN KEY (Modelo) REFERENCES RadioModelo(ID),
                    FOREIGN KEY (Serie) REFERENCES RadioSerie(ID),
                    FOREIGN KEY (Estado) REFERENCES RadioEstado(ID)
					
					);

create table Equipo (IdEquipo varchar(20) PRIMARY KEY,
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
					 Usuario varchar(20),
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
					 FOREIGN KEY (Usuario) REFERENCES Usuario(IdUsuario));

create table Inventario (IdInventario INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
                         FechaInventario date not null, 
                         Ayudante varchar(20) not null,
                         observacion varchar(500), 
                         Equipo varchar(20) not null,
                         FOREIGN KEY (Ayudante) REFERENCES Usuario(IdUsuario ),
                         FOREIGN KEY (Equipo) REFERENCES Equipo(IdEquipo));



