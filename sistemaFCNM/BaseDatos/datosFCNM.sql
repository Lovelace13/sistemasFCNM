INSERT INTO tipo_user(tipo)
VALUES ('JEFE SISTEMAS'); 

select* FROM Oficina;
delete from Oficina
SELECT * FROM tipo_user;

INSERT INTO Usuario(id_usuario,clave,Nombre,tipo_usuario)
values('arcuenca','1234','ARIANA CUENCA',1);

INSERT INTO Usuario(id_usuario,clave,Nombre,tipo_usuario)
values('jfloresb','1234','JOSE FLORES',2);


insert into Oficina (edificio,nombre_oficina,area)
values('31AyB','25AB-001','Prueba');

INSERT INTO Edificio (bloque)
VALUES('');

INSERT INTO Caracteristicas (marca,modelo,serie,estado)
VALUES ('','','','');

INSERT INTO CPU(nombre_PC,inventario_cpu,tipo_PC,Caracteristicas,
perfil,tag,code,procesador,memoria,disco,adicional_lote)
VALUES('','','','','','','','','','','','');

INSERT INTO Pantalla(caracteristicas,Inventario_Pantalla,pulgadas)
VALUES('','','');
INSERT INTO Teclado(caracteristicas,Inventario_teclado)
VALUES('','');

INSERT INTO Mouse (caracteristicas,Inventario_Mouse)
VALUES('','');

INSERT INTO Parlante(caracteristicas,Inventario_Parlante)
VALUES('','');

INSERT INTO Proyector(caracteristicas,Inventario_Espoltech,Inventario_Proyector)
VALUES('','','');

INSERT INTO Regulador(caracteristicas,tipo,Inventario_Regulador)
VALUES('','','');

INSERT INTO Telefono(caracteristicas,tipo,extension,Inventario_Telefono)
VALUES('','','','');

INSERT INTO Impresora(caracteristicas,Inventario_Impresora)
VALUES ('','');

INSERT INTO Microfonos(caracteristicas,tipo,Inventario_Microfono)
VALUES ('','','');

INSERT INTO Pantalla_Proyeccion(caracteristicas,Dimensiones,Inventario_PantallaProyeccion)
VALUES ('','','');

INSERT INTO Radio(caracteristicas,Inventario_Radio)
VALUES ('','');


INSERT INTO Equipo(id_Equipo,Inventario_CPU,Oficina,Microfono,Telefono,PantallaProyeccion,Radios,Pantalla,Teclado,Mouse,Parlante,Regulador,Impresora,Proyector)
VALUES('20180270','928','1993','218','928','218','218','928','573','218','218','1993','573','218');

INSERT INTO Inventario(fecha_inventario,Ayudante,observacion,Equipo)
VALUES ('2018-07-21','arcuenca','N/A','20180270')

use sistemasFCNM;
Alter table Microfonos
add  tipo varchar(20) ;
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

select e.id_Equipo, p.Inventario_Pantalla,p.pulgadas,car.estado,car.marca,car.modelo,car.serie
from  Equipo e, Pantalla p, Mouse m, Teclado t, CPU ,Caracteristicas car
where e.Inventario_CPU= CPU.ID and e.Pantalla=p.ID and e.Mouse=m.ID and e.Teclado=t.ID and car.id_caracteristica = p.caracteristicas  and p.Inventario_Pantalla like '1036%';

select e.id_Equipo,c.inventario_cpu,c.nombre_PC,c.tipo_PC,c.perfil,
c.tag,c.code,c.procesador,c.memoria,c.disco,c.adicional_lote,car.estado,car.marca,car.modelo,car.serie
from  Equipo e,CPU c ,Caracteristicas car
where e.Inventario_CPU= c.ID and car.id_caracteristica = c.Caracteristicas ;

select e.id_Equipo,o.nombre_oficina,inv.Ayudante,inv.fecha_inventario,c.inventario_cpu,p.Inventario_Pantalla,t.Inventario_teclado,m.Inventario_Mouse,par.Inventario_Parlante,reg.Inventario_Regulador,im.Inventario_Impresora,pro.Inventario_Proyector,mi.Inventario_Microfono,tel.Inventario_Telefono,pp.Inventario_PantallaProyeccion,ra.Inventario_Radio from  Equipo e,Oficina o, Pantalla p, Mouse m, Teclado t, CPU c,Parlante par, Regulador reg, Impresora im,Proyector pro,Microfonos mi, Telefono tel,Pantalla_Proyeccion pp,Radio ra,Inventario inv where e.Inventario_CPU= c.ID and e.Oficina = o.ID and e.id_Equipo = inv.Equipo and e.Pantalla = p.ID and e.Teclado = t.ID and e.Mouse = m.ID and e.Parlante = par.ID and e.Regulador = reg.ID and e.Impresora = im.ID and e.Telefono = tel.ID and e.PantallaProyeccion = pp.ID and e.Radios = ra.ID and e.Microfono = mi.ID and e.Proyector = pro.ID and e.id_Equipo = '';


select*from Equipo;
select*from Inventario;
--p.Inventario_Pantalla like '1036%'  busqueda por cierto numero

select MAX(ID) as ID from CPU;
 
select e.id_Equipo, reg.Inventario_Telefono,reg.extension,reg.tipo,car.estado,car.marca,
                car.modelo,car.serie from  Equipo e, Telefono reg,
                Caracteristicas car where 
                e.Telefono = reg.ID and car.id_caracteristica = reg.caracteristicas and e.id_Equipo = '20180270';

