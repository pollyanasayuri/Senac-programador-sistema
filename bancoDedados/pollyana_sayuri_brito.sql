
/*criando a tabela fornecedor*/
create table fornecedor(
id int primary key auto_increment,
nome varchar(50) not null, 
cidade varchar(50) not null
);

/*inserindo os dados na tabela fornecedor*/
insert into fornecedor(
nome, cidade
) values 
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

/*criando a tabela produto*/
create table if not exists produto(
id int primary key auto_increment,
nome varchar (50) not null,
categoria varchar (50) not null,
preco int not null,
estoque int not null,
fornecedor_id int not null,
     FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
);

/*inserindo os dados da tabela produto*/
insert into produto
(nome, categoria, preco, estoque, fornecedor_id)
values
('celular x', 'eletrônicos', 2500.00, 30, 1),
('notebook y','eletrônicos' ,4800.00, 15, 2 ),
('mesa de madeira','móveis' ,750.00 , 10, 3),
('cadeira z','móveis' , 300.00, 25, 3),
('tv 50','eletrônicos' , 3500.00, 8, 1);

/*criando os dados da tabela cliente*/
create table cliente (
id int primary key auto_increment,
nome varchar(50) not null,
cidade varchar (50) not null,
idade int not null
);

/*inserindo os dados da tabela cliente*/
insert into cliente(
nome, cidade, idade
)values 
('João Silva', 'São Paulo', 35),
('Maria Santos', 'Belo Horizonte', 28),
('Carlos Lima', 'Rio de Janeiro', 42),
('Fernanda', 'Curitiba', 30);

/*criando tabela  pedido*/
create table pedido(
id int primary key auto_increment,
produto_id int not null,
quantidade int not null,
data_pedido date not null,
cliente_id int not null,
   FOREIGN KEY (cliente_id)
        REFERENCES cliente (id)
);

/*colocando os dados na tabela pedido*/
insert into pedido(
produto_id, quantidade, data_pedido, cliente_id
)values 
(1, 2 , '2024-03-10', 1),
(3, 1 , '2024-03-11', 2),
(2, 1 , '2024-03-15', 3),
(5, 3 , '2024-03-18', 1),
(4, 4 , '2024-03-20', 4);

/*2.1*/
SELECT 
    *
FROM
   produto
   where preco > 3000
ORDER BY preco DESC;

select * from cliente where cidade != 'São paulo' and idade > 30;

/*2.3*/
SELECT 
    *
FROM
pedido
WHERE
    data_pedido BETWEEN '2024-03-10'AND '2024-03-15'
    order by  data_pedido asc;
    
insert into produto
(nome, categoria, preco, estoque, fornecedor_id)
values
('xbox polly ', 'eletrônicos', 7000.00, 3, 2);
/*2.4*/
select * from produto where estoque <10
group by estoque asc;

/*2.4*/
select * from fornecedor
where 
cidade != 'Rio de Janeiro' and nome like 'T%';

/*agregação e agrupamento*/









