
DBCC CHECKIDENT (Inventario, RESEED, 0)
select* FROM TipoUsuario;
delete from Usuario
select Nombre from Usuario where  Usuario = '{0}' and clave = '{1}';

INSERT INTO TipoUsuario(tipo)
VALUES ('AYUDANTE'); 

INSERT INTO TipoUsuario(tipo)
VALUES ('ADMINISTRADOR'); 

INSERT INTO TipoUsuario(tipo)
VALUES ('ESTUDIANTE');

insert into Oficina (edificio,nombre_oficina,area)
values('31AyB','25AB-001','Prueba');
USE [SistemasFCNM]
GO

INSERT INTO [dbo].[Usuario]
           ([Usuario]
           ,[Tipo]
           ,[Nombre]
           ,[Clave])
     VALUES
           ('jfloresb',2,'JOSE FLORES','1234')
GO
INSERT INTO [dbo].[Usuario]
           ([Usuario]
           ,[Tipo]
           ,[Nombre]
           ,[Clave])
     VALUES
           ('jcbodero',1,'JULIO BODERO','1234')
GO

SELECT        CpuInventario.Inventario AS Cpu, Equipo.ID, EquipoInventario.Inventario, ImpresoraInventario.Inventario AS Impresora, MicrofonoInventario.Inventario AS Microfono, MouseInventario.Inventario AS Mouse, 
                         PantallaInventario.Inventario AS Pantalla, PantallaProyeccionInventario.Inventario AS PantallaProyeccion, RadioInventario.Inventario AS Radios, ProyectorInventario.Inventario AS Proyector, 
                         ReguladorInventario.Inventario AS Regulador, TelefonoInventario.Inventario AS Telefono, TecladoInventario.Inventario AS Teclado, ParlanteInventario.Inventario AS Parlante, Propietario.Usuario, FechaInventario.Fecha, 
                         Usuario.Nombre, Inventario.observacion, NombreOficina.NombreOficina
FROM            Equipo INNER JOIN
                         Cpu ON Equipo.Cpu = Cpu.ID INNER JOIN
                         CpuInventario ON Cpu.Inventario = CpuInventario.ID INNER JOIN
                         EquipoInventario ON Equipo.Inventario = EquipoInventario.ID INNER JOIN
                         Impresora ON Equipo.Impresora = Impresora.ID INNER JOIN
                         ImpresoraInventario ON Impresora.Inventario = ImpresoraInventario.ID INNER JOIN
                         Microfono ON Equipo.Microfono = Microfono.ID INNER JOIN
                         MicrofonoInventario ON Microfono.Inventario = MicrofonoInventario.ID INNER JOIN
                         Mouse ON Equipo.Mouse = Mouse.ID INNER JOIN
                         MouseInventario ON Mouse.Inventario = MouseInventario.ID INNER JOIN
                         Pantalla ON Equipo.Pantalla = Pantalla.ID INNER JOIN
                         PantallaInventario ON Pantalla.Inventario = PantallaInventario.ID INNER JOIN
                         PantallaProyeccion ON Equipo.PantallaProyeccion = PantallaProyeccion.ID INNER JOIN
                         PantallaProyeccionInventario ON PantallaProyeccion.Inventario = PantallaProyeccionInventario.ID INNER JOIN
                         Parlante ON Equipo.Parlante = Parlante.ID INNER JOIN
                         ParlanteInventario ON Parlante.Inventario = ParlanteInventario.ID INNER JOIN
                         Proyector ON Equipo.Proyector = Proyector.ID INNER JOIN
                         ProyectorInventario ON Proyector.Inventario = ProyectorInventario.ID INNER JOIN
                         Radio ON Equipo.Radios = Radio.ID INNER JOIN
                         RadioInventario ON Radio.Inventario = RadioInventario.ID INNER JOIN
                         Regulador ON Equipo.Regulador = Regulador.ID INNER JOIN
                         ReguladorInventario ON Regulador.Inventario = ReguladorInventario.ID INNER JOIN
                         Teclado ON Equipo.Teclado = Teclado.ID INNER JOIN
                         TecladoInventario ON Teclado.Inventario = TecladoInventario.ID INNER JOIN
                         Telefono ON Equipo.Telefono = Telefono.ID INNER JOIN
                         TelefonoInventario ON Telefono.Inventario = TelefonoInventario.ID INNER JOIN
                         Propietario ON Equipo.Propietario = Propietario.ID INNER JOIN
                         Inventario ON Equipo.ID = Inventario.Equipo INNER JOIN
                         FechaInventario ON Inventario.Fecha = FechaInventario.ID INNER JOIN
                         Usuario ON Inventario.Ayudante = Usuario.ID INNER JOIN
                         Oficina ON Equipo.Oficina = Oficina.ID INNER JOIN
                         NombreOficina ON Oficina.NombreOficina = NombreOficina.ID
select * from ImpresoraInventario

SELECT        Cpu.ID
FROM            Cpu INNER JOIN
                         CpuInventario ON Cpu.Inventario = CpuInventario.ID
WHERE        (CpuInventario.Inventario = '103345')

UPDATE       Cpu
SET                Inventario = 7
FROM            Cpu INNER JOIN
                         Equipo ON Cpu.ID = Equipo.Cpu INNER JOIN
                         EquipoInventario ON Equipo.Inventario = EquipoInventario.ID
WHERE        (EquipoInventario.Inventario = '2018-007')

select * from Inventario;