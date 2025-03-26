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
 ('1', 'geleia de banho', ' R$ 20,00', '20/03/2026'),
 ('2', 'esfoliante corporal de marshmellow', ' R$ 15,00', '20/03/2026'),
 ('3', 'esfoliante de melancia', ' R$ 15,00', '20/03/2026'),
 ('4', 'perfume para cabelo olympea', ' R$ 30,00', '20/03/2026'),
 ('5', 'perfume para cabelo red', ' R$ 30,00', '20/03/2026'),
 ('6', 'serum facial', ' R$ 10,00', '20/03/2026'),
 ('7', 'sabonete - ', ' R$ 20,00', '20/03/2026'),
 ('8', 'geleia de banho', ' R$ 20,00', '20/03/2026');



