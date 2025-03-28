create table if not exists genero (
id INT PRIMARY KEY AUTO_INCREMENT,
nome varchar(100) not null
);

SELECT DISTINCT
    (genero)
FROM
    livro;
INSERT INTO genero (nome)
VALUES
('tecnologia'),
('documentário cinematográfico'),
('terror'),
('drama'),
('entrevista'),
('aventura'),
('fantasia'),
('ação'),
('ficção científica'),
('romance distópico');