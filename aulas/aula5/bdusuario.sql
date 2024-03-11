create database projeto;
use projeto;
create table usuario(
cod_usu int primary key auto_increment,
nome varchar(70),
email varchar(70),
senha varchar(46)
);
select*from usuario;