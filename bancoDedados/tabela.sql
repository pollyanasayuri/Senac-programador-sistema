use senac;

CREATE TABLE IF NOT EXISTS produto (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome_produto VARCHAR(100) NOT NULL,
    valor VARCHAR(50) NOT NULL,
    validade VARCHAR(16) NOT NULL
); 

SELECT 
    *
FROM
    produto;

INSERT INTO produto (
 nome_produto,
 valor,
 validade
 )
 values 
 ('geleia de banho', ' R$ 20,00', '20/03/2026'),
 ('esfoliante corporal de marshmellow', ' R$ 15,00', '20/03/2026'),
 ('esfoliante de melancia', ' R$ 15,00', '20/03/2026'),
 ('perfume para cabelo olympea', ' R$ 30,00', '20/03/2026'),
 ('perfume para cabelo red', ' R$ 30,00', '20/03/2026'),
 ('serum facial artesanal', ' R$ 10,00', '20/03/2026'),
 ('sabonete facial artesanal', ' R$ 8,00', '20/03/2026'),
 ('limp balm artesanal', ' R$ 20,00', '20/03/2026');
 
 



