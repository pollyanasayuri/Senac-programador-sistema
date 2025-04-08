/*criando a tabela*/
create table if not exists cliente(
id int primary key auto_increment,
nome varchar (60) not null,
idade int not null,
cidade varchar (100) not null,
saldo int (30) not null
);

/*inserindo os clientes e seus dados na tabela*/
insert into cliente(
nome, idade, cidade, saldo
) values 
('Carlos', '45', 'São Paulo', '2500.00'),
('Mariana', '32', 'Rio de Janeiro', '3200.50'),
('Pedro', '27', 'Belo Horizonte', '1500.75'),
('fernanda', '38', 'Curitiba', '4200.00');

/*1.1 */
SELECT 
    *
FROM
    cliente
WHERE
    cidade LIKE 'Rio de Janeiro' ;

/*1.2*/    
select 
*
from  
cliente 
where 
saldo > 2000;

/*1.3*/
SELECT 
    nome, idade
FROM
    cliente
WHERE
    idade > 30;

 /*2.1*/   
select nome, idade from cliente where idade >=25 and idade <=40;

/*2.2*/
SELECT 
    *
FROM
   cliente
WHERE
    nome LIKE 'F%';

/*2.3*/

select * from cliente 
where 
cidade not like 'São Paulo' and cidade not like'Curitiba';

/*3. com uma nova tabela*/
create table pedido(
id int primary key auto_increment,
cliente_id int not null,
valor int(50) not null,
data_pedido date not null,
foreign key (cliente_id) references cliente (id)
);

/*Inserindo dados na tabela de pedido*/
insert into pedido(
cliente_id, valor, data_pedido
)values 
('1', '500.00', '2024-03-10'),
('2', '1200.00', '2024-03-12'),
('3', '300.50', '2024-03-15'),
('1', '800.00', '2024-03-18');

/*3.1*/
select count(id) as pedido from pedido;

/*3.2*/
select avg(valor) as pedido from pedido;

/*3.3*/
select cliente.nome, sum(valor) from pedido
join cliente on pedido.cliente_id = cliente_id group by cliente_id;

/*4.1 inner join*/
select pedido.id as 'pedido', valor, data_pedido, cliente.nome
from pedido
inner join cliente on pedido.cliente_id = cliente_id
order by pedido.id asc;
/*4,2- left join*/
select pedido.id as 'cliente', valor, data_pedido, cliente.nome
from pedido
left join cliente on pedido.cliente_id = cliente_id
order by pedido.id asc; 
/*5.1*/


select 
nome, valor
from 
pedido
inner join cliente on pedido.cliente_id = cliente.id
where valor > (select avg(valor) from pedido );
 













