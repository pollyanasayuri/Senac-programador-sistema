create table usuario (
id int primary key auto_increment,
email varchar(50) not null,
senha varchar(20)
);

insert into usuario (email, senha) values
('neymar.jr@email.com','Brun@123'),
('pablo.vitar@email.com','12345Abc!'),
('sukuna.silva@email.com','Sete7Sete!');

select * from usuario where email = 'pablo.vitar@email.com';