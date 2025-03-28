use senac;

CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    senha VARCHAR(16) NOT NULL
); 

SELECT 
    *
FROM
    usuario;
insert into usuario (nome, email, senha)
values
('Neymar Jr', 'njr@email.com', 'Brun@'),
('Maria Madalena', 'mnadalena@email.com', 'a1s2d3f4!'), 
('Pollyana Brito', 'pollyana@email.com', 'Senha19');