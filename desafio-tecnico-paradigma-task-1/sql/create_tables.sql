--Rodar primeiro essa parte do script
CREATE DATABASE desafioparadigmadb;

--Rodar depois essa parte do script
USE desafioparadigmadb;

CREATE TABLE departamento (
    id INT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);

CREATE TABLE pessoa (
    id INT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    salario DECIMAL(10,2) NOT NULL,
    departamento_id INT,
    FOREIGN KEY (departamento_id) REFERENCES departamento(id)
);
