DROP TABLE IF EXISTS contas_pagar;
CREATE TABLE contas_pagar(
	id INT PRIMARY KEY IDENTITY(1,1), 
	nome VARCHAR(100),
	valor DECIMAL(6,2),
	tipo VARCHAR(100),
	data_vencimento DATETIME2

);

SELECT * FROM contas_pagar;

DROP TABLE IF EXISTS clientes;
CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY(1,1), 
	nome VARCHAR(100),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,
	rg VARCHAR(9) 
);
SELECT * FROM clientes;

DROP TABLE contas_receber;
CREATE TABLE contas_receber (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	valor DECIMAL(6,2),
	valor_recebido DECIMAL(6,2),
	data_vencimento DATETIME2,
	recebido BIT
);