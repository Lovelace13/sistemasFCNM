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