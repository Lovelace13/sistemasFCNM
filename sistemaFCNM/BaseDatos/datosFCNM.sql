
DBCC CHECKIDENT (Equipo, RESEED, 0)
select* FROM Usuario;
delete from TipoUsuario


INSERT INTO TipoUsuario(tipo)
VALUES ('AYUDANTE'); 
INSERT INTO IdUsuario(Usuario)
VALUES ('jcbodero'); 
INSERT INTO ClaveUsuario(Clave)
VALUES ('1234'); 
INSERT INTO NombreUsuario(Nombre)
VALUES ('Julio Bodero'); 
INSERT INTO Usuario(Usuario,clave,Nombre,Tipo)
values(1,1,1,1);
INSERT INTO Equipo(Inventario,Cpu,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector,Usuario) VALUES ((SELECT ID FROM EquipoInventario WHERE Inventario='2018-001'),(SELECT ID FROM Cpu WHERE Inventario='SELECT ID FROM CpuInventario WHERE Inventario='103342''),(SELECT ID FROM Oficina WHERE NombreOficina = 'SELECT ID FROM NombreOficina WHERE NombreOficina='25A-101'' and Edificio = 'SELECT ID FROM Edificio WHERE Bloque='25A''),(SELECT ID FROM Microfono WHERE Inventario='SELECT ID FROM MicrofonoInventario WHERE Inventario='N/A''),(SELECT ID FROM Telefono WHERE Inventario='SELECT ID FROM TelefonoInventario WHERE Inventario='99999-400''),(SELECT ID FROM PantallaProyeccion WHERE Inventario='SELECT ID FROM PantallaProyeccionInventario WHERE Inventario='N/A''),(SELECT ID FROM Radio WHERE Inventario='SELECT ID FROM RadioInventario WHERE Inventario='N/A''),(SELECT ID FROM Pantalla WHERE Inventario='SELECT ID FROM PantallaInventario WHERE Inventario='103309-1''),(SELECT ID FROM Teclado WHERE Inventario='SELECT ID FROM TecladoInventario WHERE Inventario='103309-2''),(SELECT ID FROM Mouse WHERE Inventario='SELECT ID FROM MouseInventario WHERE Inventario='103342-3''),(SELECT ID FROM Parlante WHERE Inventario='SELECT ID FROM ParlanteInventario WHERE Inventario='N/A''),(SELECT ID FROM Regulador WHERE Inventario='SELECT ID FROM ReguladorInventario WHERE Inventario='N/A''),(SELECT ID FROM Impresora WHERE Inventario='SELECT ID FROM ImpresoraInventario WHERE Inventario='N/A''),(SELECT ID FROM Proyector WHERE Inventario='SELECT ID FROM ProyectorInventario WHERE Inventario='N/A''),(SELECT ID FROM Usuario WHERE Usuario='SELECT ID FROM IdUsuario WHERE Usuario='ESPOLWilfredo Angulo''));
insert into Oficina (edificio,nombre_oficina,area)
values('31AyB','25AB-001','Prueba');

INSERT INTO Edificio (bloque)
VALUES('');

INSERT INTO Caracteristicas (marca,modelo,serie,estado)
VALUES ('','','','');

INSERT INTO CpuMemoria values('2T');
delete from Cpu
INSERT INTO CPU(NombrePC,Inventario,TipoPC,perfil,tag,code,procesador,memoria,disco,AdicionalLote,Marca,Modelo,Estado,Serie) VALUES('','','',(select MAX(id_caracteristica) from Caracteristicas),'','','','','','','');

INSERT INTO Pantalla(caracteristicas,Inventario_Pantalla,pulgadas)
VALUES('','','');
INSERT INTO Teclado(caracteristicas,Inventario_teclado) VALUES('','');

INSERT INTO Mouse (caracteristicas,Inventario_Mouse) VALUES('','');

INSERT INTO Parlante(caracteristicas,Inventario_Parlante) VALUES('','');

INSERT INTO Proyector(caracteristicas,Inventario_Espoltech,Inventario_Proyector) VALUES('','','');

INSERT INTO Regulador(caracteristicas,tipo,Inventario_Regulador) VALUES('','','');

INSERT INTO Telefono(caracteristicas,tipo,extension,Inventario_Telefono) VALUES((select MAX(id_caracteristica) from Caracteristicas),'','','');

INSERT INTO Impresora(caracteristicas,Inventario_Impresora) VALUES ('','');

INSERT INTO Microfonos(caracteristicas,tipo,Inventario_Microfono) VALUES ('','','');

INSERT INTO Pantalla_Proyeccion(caracteristicas,Dimensiones,Inventario_PantallaProyeccion) VALUES ('','','');

INSERT INTO Radio(caracteristicas,Inventario_Radio) VALUES ('','');


INSERT INTO Equipo(id_Equipo,Inventario_CPU,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector)
VALUES('20180270','928','1993','218','928','218','218','928','573','218','218','1993','573','218');

INSERT INTO Inventario(fecha_inventario,Ayudante,observacion,Equipo) VALUES ('2018-07-21','arcuenca','N/A','20180270')

use sistemasFCNM;
Alter table Equipo
add  PcNombre varchar(15) ;
ALTER TABLE Cpu DROP COLUMN PcNombre ; 
--use sistemasFCNM;

--select*from Usuario;


--INSERT INTO Oficina(numero_oficina, edificio, area, Usuario)
--VALUES ('xx','xx', 'xx','xx'); 

--INSERT INTO Usuario(tipo_usuario,nombre_Usuario)
--VALUES ('ADMINISTRATIVO','GERONIMO VILLON'); 

--delete from table_name;

alter authorization on database :: sistemasFCNM to SA; 
select * from Inventario;

--delete from Impresora;

--delete from Caracteristicas where id_caracteristica >= 4972;

SELECT Equipo.id_Equipo,CPU.inventario_cpu
FROM Equipo
INNER JOIN CPU ON Equipo.Inventario_CPU = CPU.ID;

select e.id_Equipo, p.Inventario_Pantalla,p.pulgadas,car.estado,car.marca,car.modelo,car.serie from  Equipo e, Pantalla p, Mouse m, Teclado t, CPU ,Caracteristicas car where e.Inventario_CPU= CPU.ID and e.Pantalla=p.ID and e.Mouse=m.ID and e.Teclado=t.ID and car.id_caracteristica = p.caracteristicas  and p.Inventario_Pantalla like '1036%';

select e.id_Equipo,c.inventario_cpu,c.nombre_PC,c.tipo_PC,c.perfil,
c.tag,c.code,c.procesador,c.memoria,c.disco,c.adicional_lote,car.estado,car.marca,car.modelo,car.serie
from  Equipo e,CPU c ,Caracteristicas car
where e.Inventario_CPU= c.ID and car.id_caracteristica = c.Caracteristicas ;

select e.id_Equipo,o.nombre_oficina,inv.Ayudante,inv.fecha_inventario,c.inventario_cpu,p.Inventario_Pantalla,t.Inventario_teclado,m.Inventario_Mouse,par.Inventario_Parlante,reg.Inventario_Regulador,im.Inventario_Impresora,pro.Inventario_Proyector,mi.Inventario_Microfono,tel.Inventario_Telefono,pp.Inventario_PantallaProyeccion,ra.Inventario_Radio from  Equipo e,Oficina o, Pantalla p, Mouse m, Teclado t, CPU c,Parlante par, Regulador reg, Impresora im,Proyector pro,Microfonos mi, Telefono tel,Pantalla_Proyeccion pp,Radio ra,Inventario inv where e.Inventario_CPU= c.ID and e.Oficina = o.ID and e.id_Equipo = inv.Equipo and e.Pantalla = p.ID and e.Teclado = t.ID and e.Mouse = m.ID and e.Parlante = par.ID and e.Regulador = reg.ID and e.Impresora = im.ID and e.Telefono = tel.ID and e.PantallaProyeccion = pp.ID and e.Radios = ra.ID and e.Microfono = mi.ID and e.Proyector = pro.ID and e.id_Equipo = '20180270';


select*from Pantalla;
DELETE from Pantalla WHERE Caracteristicas>2841;
--p.Inventario_Pantalla like '1036%'  busqueda por cierto numero

select* from Caracteristicas where id_caracteristica = (select MAX(id_caracteristica) from Caracteristicas);
 
select e.id_Equipo, reg.Inventario_Telefono,reg.extension,reg.tipo,car.estado,car.marca,
                car.modelo,car.serie from  Equipo e, Telefono reg,
                Caracteristicas car where 
                e.Telefono = reg.ID and car.id_caracteristica = reg.caracteristicas and e.id_Equipo = '20180270';

update c set c.perfil ='N/A',c.code =''
from  Equipo e,CPU c ,Caracteristicas car
where e.Inventario_CPU= c.ID and car.id_caracteristica = c.Caracteristicas ;


update c set c.inventario_cpu='',c.nombre_PC='',c.tipo_PC ='',c.perfil = '',
c.tag = '',c.code ='',c.procesador='',c.memoria='',c.disco='',c.adicional_lote=''
from  Equipo e,CPU c
where e.Inventario_CPU= c.ID and e.id_Equipo = '';

update car set car.estado='',car.marca = '',car.modelo='',car.serie=''
from  Equipo e,CPU c,Caracteristicas car
where e.Inventario_CPU= c.ID and car.id_caracteristica = c.Caracteristicas and e.id_Equipo = ''; 

update va set va.Inventario_Pantalla = '',va.pulgadas = ''
from  Equipo e,Pantalla va
where e.Pantalla= va.ID and e.id_Equipo = '';

update car set car.estado='PRUEBA',car.marca = 'DELL',car.modelo='P2214HB',
car.serie='CN-0KW14V-74261-3B7-0A4L'  
from Equipo e,Pantalla va, Caracteristicas car 
where e.Pantalla = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '20180270'; 

update car set car.estado='PRUEBA',car.marca = 'DELL',car.modelo='P2214HB',
car.serie='CN-0KW14V-74261-3B7-0A4L'  
from Equipo e,Teclado va, Caracteristicas car 
where e.Teclado = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '20180270'; 

update car set car.estado='PRUEBA',car.marca = 'DELL',car.modelo='P2214HB',
car.serie='CN-0KW14V-74261-3B7-0A4L'  
from Equipo e,Regulador va, Caracteristicas car 
where e.Regulador = va.ID and car.id_caracteristica = va.Caracteristicas and e.id_Equipo = '20180270'; 


select MAX(Caracteristicas) from Proyector;

select*from Equipo;
select*from Pantalla;
select*from Mouse;
select*from Teclado;
select*from Parlante;
select*from Impresora;
select*from Regulador;
select*from Pantalla_Proyeccion;
select*from Telefono;
select*from Radio;
select*from Microfonos;
select*from Proyector;
select*from Caracteristicas;

select * from Oficina where ID = (1776);

INSERT INTO Equipo(id_Equipo,Inventario_CPU,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector)
VALUES('12345', (select MAX(ID) from CPU), '1993', (select MAX(ID) from Microfonos), (select MAX(ID) from Telefono),(select MAX(ID) from Pantalla_Proyeccion), (select MAX(ID) from Radio), (select MAX(ID) from Pantalla), (select MAX(ID) from Teclado), (select MAX(ID) from Mouse), (select MAX(ID) from Parlante), (select MAX(ID) from Regulador), (select MAX(ID) from Impresora), (select MAX(ID) from Proyector));

select bloque from Edificio union select '[Seleccione Edificio]';

SELECT nombre_oficina, COUNT(*) AS RecuentoFilas
FROM Oficina 
GROUP BY nombre_oficina
HAVING COUNT(*) > 1
ORDER BY nombre_oficina;

select top 1 id  from Oficina where nombre_oficina = '25A-101';

SELECT Nombre FROM Usuario WHERE IdUsuario = 'jcbodero' and clave ='1234';

select TipoUsuario from Usuario where IdUsuario = ('jcbodero');

INSERT INTO CpuNombre VALUES ('');

select * FROM Cpu;
select * FROM Pantalla;
select * FROM Teclado;
select * FROM Mouse;
select * FROM Regulador;
select * FROM Proyector;
select * FROM Parlante;
select * FROM TelefonoInventario;
select * FROM Impresora;
select * FROM Microfono;
select * FROM PantallaProyeccion;
select * FROM Radio;
select * from NombreOficina
select * from Equipo;
select e.Cpu,nom.NombrePC from Cpu c inner join Equipo e on e.Cpu = c.ID inner join CpuNombre nom on c.NombrePC = nom.ID;

INSERT INTO CpuNombre(NombrePC) VALUES('DOF-001');
INSERT INTO Edificio VALUES ('24');
INSERT INTO FechaInventario (Fecha) values ('2018-06-26');
select * from FechaInventario;
SELECT ID FROM NombreOficina WHERE NombreOficina='25A-232'
SELECT ID FROM Oficina WHERE NombreOficina = (SELECT ID FROM NombreOficina WHERE NombreOficina='25A-232')
SELECT ID FROM Telefono WHERE Inventario = (SELECT ID FROM TelefonoInventario WHERE Inventario='99999-400');
SELECT ID FROM Usuario WHERE Usuario=(SELECT ID FROM IdUsuario WHERE Usuario='NO-USER')
SELECT ID FROM ClaveUsuario WHERE Clave='qtvwaqbjtfygha'
select Usuario from NombreUsuario where  Usuario = 'jcbodero' and clave = '1234'