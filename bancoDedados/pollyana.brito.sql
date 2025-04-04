CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    idade int NOT NULL,
    departamento VARCHAR(50) NOT NULL,
    salario int NOT NULL
);

insert into empregado ( 
nome, idade, departamento, salario
) values 
('João', 30, 'RH', 50000),
('Sarah', 28, 'TI', 60000),
('Miguel', 35, 'Vendas', 55000),
('Ana', 27,'TI' , 62000);

insert into empregado ( 
nome, idade, departamento, salario
) values 
('Paulo', 59,'vendas' , 75000);

SELECT 
    *
FROM
    empregado
WHERE
    departamento = 'TI';

SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;
    
SELECT 
    *
FROM
    empregado
ORDER BY idade DESC;

SELECT 
    *
FROM
    empregado
WHERE
    idade BETWEEN 28 AND 35;
        
	SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%'; /* like é como e procurar algo que comece com M*/
    
  SELECT 
    *
FROM
    empregado
WHERE
    departamento <> 'Rh';

SELECT 
    departamento, 
    COUNT(id)
FROM
    empregado
GROUP BY departamento;

SELECT 
    AVG(salario)
FROM
    empregado
WHERE
    departamento = 'TI';
     
SELECT 
    SUM(salario)
FROM
    empregado
WHERE
    departamento = 'Vendas';    

CREATE TABLE  departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    idade INT NOT NULL,
    id_departamento INT NOT NULL,
    salario INT NOT NULL,
    FOREIGN KEY (id_departamento)
        REFERENCES departamento (id)
);
insert into departamento (
nome)
values 
('RH'),
('TI'),
('Vendas');

insert into departamento (nome)
values ('compras');

select 
*
from
departamento;

INSERT INTO empregado (nome, idade, salario, id_departamento) VALUES
('João', 30, 50000, 1),
('Sarah', 28, 60000, 2),
('Miguel', 35, 55000, 3),
('Ana', 27, 62000, 2),
('Paulo', 59, 75000, 3);

select 
e.nome as empregado, d.nome as departamento
from
empregado e 
inner join d on e.id_departamento = d.id;











     
     
     
     


        



    






