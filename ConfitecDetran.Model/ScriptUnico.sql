--Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=Confitec_Detran;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Force

CREATE DATABASE Confitec_Detran
GO

USE Confitec_Detran
GO

CREATE TABLE Usuario(
	Cod_Usuario INT PRIMARY KEY,
	Nome VARCHAR(200) NOT NULL,
	Senha VARCHAR(50) NOT NULL
)
GO

CREATE TABLE Condutor(
	Cod_Condutor INT PRIMARY KEY,
	Nome VARCHAR(200) NOT NULL,
	CPF VARCHAR(11) NOT NULL,
	Telefone VARCHAR(11),
	Email VARCHAR(100) NOT NULL,
	CNH VARCHAR(100) NOT NULL,
	Data_Nascimento Date NOT NULL
)
GO

CREATE TABLE Veiculo(
	Cod_Veiculo INT PRIMARY KEY,
	Placa VARCHAR(7) NOT NULL,
	Modelo VARCHAR(200) NOT NULL,
	Marca VARCHAR(100) NOT NULL,
	Cor VARCHAR(50) NOT NULL,
	Ano INT NOT NULL
)
GO

CREATE TABLE Transferencia(
	Cod_Transferencia INT PRIMARY KEY,
	Cod_Condutor INT NOT NULL,
	Cod_Veiculo INT NOT NULL,
	Data_Inicio DATETIME DEFAULT GETDATE(),
	Data_Fim DATETIME
)
GO

ALTER TABLE Transferencia ADD CONSTRAINT FK_Transferencia_Condutor FOREIGN KEY (Cod_Condutor)
	REFERENCES Condutor (Cod_Condutor)
GO

ALTER TABLE Transferencia ADD CONSTRAINT FK_Transferencia_Veiculo FOREIGN KEY (Cod_Veiculo)
	REFERENCES Veiculo (Cod_Veiculo)
GO
