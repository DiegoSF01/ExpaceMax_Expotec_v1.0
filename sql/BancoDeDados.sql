CREATE DATABASE IF NOT EXISTS ranking_jogo;
USE ranking_jogo;

CREATE TABLE IF NOT EXISTS classificacao (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    pontuacao INT NOT NULL
);
