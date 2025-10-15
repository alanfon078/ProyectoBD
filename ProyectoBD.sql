create database ProyectoBD;
use ProyectoBD;
create table user(
	id int primary key auto_increment,
    nombre varchar(50) not null,
    apellidos varchar(100) not null,
    user varchar(20) not null unique,
    password varchar (256) not null,
    status boolean not null default true,
    fechaCreacion timestamp default current_timestamp,
    correo varchar(50) not null unique,
    telefono varchar(10) not null unique,
    fechaNacimiento date not null
    );
insert into user(nombre, apellidos, user, password, correo, telefono, fechaNacimiento) 
values('Alan Yael', 'Fonseca Ruiz', 'Admin', sha2('Admin078.', 256), 'correo@gmail.com','4451234567', '2005-12-30');
select * from user;
