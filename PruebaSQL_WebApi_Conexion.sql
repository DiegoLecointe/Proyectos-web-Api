create database BD_Banco;
use BD_Banco;

create table Usuario(
Id integer primary key,
Nombre varchar(50),
Apellido varchar(50),
Estado char(1)
)

insert into Usuario(Id, Nombre, Apellido, Estado) values(@Id, @Nombre, @Apellido, @Estado);

select * from Usuario;
drop table Usuario;