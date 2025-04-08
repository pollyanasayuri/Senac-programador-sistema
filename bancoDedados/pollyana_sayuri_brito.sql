
/*criando a tabela fornecedor*/
CREATE TABLE fornecedor (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    cidade VARCHAR(50) NOT NULL
);

/*inserindo os dados na tabela fornecedor*/
insert into fornecedor(
nome, cidade
) values 
('TechBrasil', 'São Paulo'),
('Computech', 'Rio de Janeiro'),
('Moveis&Co', 'Curitiba');

/*criando a tabela produto*/
CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    preco INT NOT NULL,
    estoque INT NOT NULL,
    fornecedor_id INT NOT NULL,
    FOREIGN KEY (fornecedor_id)
        REFERENCES fornecedor (id)
)

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

select * from cliente where cidade != 'São paulo' and idade > 30; /* <> ou != significa diferente*/

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
SELECT 
    *
FROM
    produto
WHERE
    estoque < 10
GROUP BY estoque ASC;

/*2.4*/
SELECT 
    *
FROM
    fornecedor
WHERE
    cidade != 'Rio de Janeiro' 
        AND nome LIKE 'T%';

/*agregação e agrupamento 1*/
SELECT 
    categoria, 
    AVG(preco)
FROM
    produto
GROUP BY categoria; 

/*agregação e agrupamento - 2*/ 
SELECT 
    cliente.nome, 
    COUNT(pedido.id) as 'Qtd de pedidos'
FROM
    pedido
inner join cliente on pedido.cliente_id = cliente.id
GROUP BY
 cliente_id;

/*agregação e agrupamento - 3*/
SELECT 
    categoria,
    SUM(estoque) as ' Total em estoque'
FROM
    produto
GROUP BY categoria;

/*agregação e agrupamento - 4*/
SELECT 
    id, produto_id, quantidade
FROM
    pedido
    order by quantidade desc
    limit 1; 

/*agregação e agrupamento - 5*/
insert into cliente(nome, cidade, idade) values
('Pollyana Brito', 'São Paulo', '25');
SELECT 
	cidade, COUNT(id) as 'Qtd de clientes'
FROM
    cliente
GROUP BY cidade
ORDER BY 'qtd de clientes' DESC;

/*junções inner join*/
/*1 - lista o produto junto com o nome do fornecedor correspodente*/
SELECT 
   produto.id,
   produto.nome as 'nome do produto',
   produto.categoria,
   produto.preco,
   produto.estoque,
   fornecedor.nome as 'nome do fornecedor'
FROM
    produto 
        INNER JOIN
    fornecedor  ON produto.fornecedor_id = fornecedor.id 
    ORDER BY  fornecedor.nome asc;

/*2 mostre a quantidade e exiba o nome do cliente, o nome do produto comprando, 
ordenando pela data do pedido*/
SELECT 
    pedido.id AS ' id do pedido', 
    pedido.data_pedido as 'data do pedido',
    cliente.nome as 'nome do cliente',
    produto.nome as 'nome do produto'
FROM
    pedido p /**/
        JOIN
    produto p ON p.produto_id = i.id /**/
        JOIN
    cliente c ON p.cliente_id = c.id /**/
ORDER BY data_pedido;  /*ordenar por data de pedido*/

/*3*/
SELECT 
    pedido.id AS ' id do pedido', 
    cliente.nome as 'nome do cliente',
    produto.nome as 'nome do produto',
    fornecedor.nome as 'nome do fornecedor'
FROM
    pedido 
        inner join
    cliente  ON pedido.cliente_id = cliente.id
        inner join 
    produto i ON pedido.produto_id = produto.id
        inner join 
    fornecedor  ON produto.fornecedor_id = i.fornecedor.id;
   
 /*4*/
SELECT 
    cliente_id AS 'nome do cliente',
    SUM(pedido.quantidade) AS 'quantidade total'
FROM
    pedido
        INNER JOIN
    cliente ON pedido.cliente_id = cliente.id
GROUP BY pedido.cliente_id;

/**/

select * from produto p
where 
	preco > ( select 
			avg(preco)
		from
			produto pr
		where 
			p.categoria = pr.categoria)
order by p.categoria;

/**/

UPDATE produto 
SET 
    preco = preco * 1.1
WHERE
    categoria = 'eletronicos';

/**/
DELETE FROM pedido 
WHERE
    cliente_id in(SELECT 
        id
    FROM
        cliente
    WHERE
        cidade = 'Curitiba');

/**/
insert into cliente (nome, cidade, idade)
values ('Ricardo Lopes', 'Porto alegre', '38');

/**/
select  id from produto where nome = 'notebook y'; 

select * from cliente where nome = 'joao silva' and cidade = 'São Paulo';

insert into pedido (quantidade, data_pedido, produto_id, cliente_id)



/*create, read, update, delete vão ser mais usados no projeto final*/














