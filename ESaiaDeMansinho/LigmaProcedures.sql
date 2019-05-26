use dbLIGMA;
go


CREATE PROC cadFunc @Email VARCHAR(50), @Senha varchar(20), @CEP char(8), @Numero smallint, @Nome varchar(75),
						@Complemento varchar(30), @Cidade varchar(25), @UF char(2), @Logradouro varchar(10),
						@RG char(10), @CPF decimal(11), @DataNasc date, @Salario money, @Cargo varchar(20), 
						@TelCelular decimal(9) = 0, @TelFixo decimal(8) = 0
AS
BEGIN
	IF @Email IS NULL AND @Senha IS NULL AND @CEP <> 0AND @Numero <> 0 AND @Nome IS NULL AND
						@Complemento IS NULL AND @Cidade IS NULL AND @UF IS NULL AND @Logradouro IS NULL AND
						@RG IS NULL AND @CPF <> 0 AND @DataNasc IS NULL and @Salario IS NULL AND @Cargo IS NULL
		SELECT 'Há atributos vazios' AS [ERRO];
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);
			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc)
			VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, @DataNasc);
			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin)
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados)
			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
			VALUES (@CodLogin, @CodDados, @Salario, @Cargo)
		END
END
