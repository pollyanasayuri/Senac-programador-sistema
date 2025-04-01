CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    idade VARCHAR(3) NOT NULL,
    departamento VARCHAR(10) NOT NULL,
    salario int(30) NOT NULL
);

insert into empregado ( 
nome, idade, departamento, salario
) values 
('João', '30', 'RH', '50000'),
('Sarah', '28', 'TI', '60000'),
('Miguel', '35', 'Vendas', '55000'),
('Ana', '27','TI' , '62000');

SELECT 
    *
FROM
    empregado
WHERE
    departamento LIKE 'TI';

SELECT 
    nome, salario
FROM
    empregado
WHERE
    salario > 55000;
    
select * from empregado order by idade desc;

SELECT 
    *
FROM
    empregado 
WHERE
    idade >= '28'
        AND idade <= '35';
        
	SELECT 
    *
FROM
    empregado
WHERE
    nome LIKE 'M%';

select departamento, count(departamento) from empregado group by departamento;

SELECT 
     AVG(salario) from empregado where departamento = 'TI';
     
select 		
 sum(salario) from empregado where departamento = 'Vendas';    

CREATE TABLE IF NOT EXISTS departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL
);

insert into departamento (
nome
) values 
('RH'),
('TI'),
('Vendas');

CREATE TABLE IF NOT EXISTS empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    departamento_id varchar(30)
);

insert into(
nome, departamento
) values
('João', '1'),
('Sarah', '2'),
('Miguel', '3'),
('Ana', '2');





     
     
     
     


        



    






