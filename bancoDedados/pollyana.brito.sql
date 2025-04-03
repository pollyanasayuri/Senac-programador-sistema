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
    
    select * from empregado where departamento <> 'RH';

SELECT 
    departamento, 
    COUNT(id)
FROM
    empregado
GROUP BY departamento;

SELECT 
     AVG(salario) from empregado where departamento = 'TI';
     
select 		
 sum(salario) from empregado where departamento = 'Vendas';    

CREATE TABLE  departamento (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL
);

insert into departamento (
departamento.nome
) values 
('RH'),
('TI'),
('Vendas');

CREATE TABLE   empregado (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(30) NOT NULL,
    idade int not null,
    id_departamento int not null,
    salario int not null
);

insert into empregado(

empregado.nome, id.departamento
) values
('João', '1'),
('Sarah', '2'),
('Miguel', '3'),
('Ana', '2'); 






     
     
     
     


        



    






