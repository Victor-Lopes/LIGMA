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
GO

create procedure sp_insert_periodo(
	@NomePeriodo varchar(30),
	@CodDiaSemana smallint, 
	@CodDiaSemana2 smallint,
	@CodDiaSemana3 smallint
)as
begin

	declare @Mensagem varchar(40);
	if @CodDiaSemana is null SELECT @Mensagem = 'Selecione pelo menos um dia da semana!'; 
	else if @NomePeriodo is not null and exists(select NomePeriodo from tbPeriodo where NomePeriodo = @NomePeriodo)
	SELECT @Mensagem = 'Nome Já Existente!'
	else
	begin
		declare @Dia1 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana);
		declare @Dia2 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana2);
		declare @Dia3 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana3);

		if @Dia2 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1; 
		else if @Dia3 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1 +', '+ @Dia2;
		else SELECT @NomePeriodo = @Dia1 +', '+ @Dia2 +', '+ @Dia3;

		if @NomePeriodo is not null and exists(select NomePeriodo from tbPeriodo where NomePeriodo = @NomePeriodo) 
		SELECT @Mensagem = 'Você já tem um periodo semelhante!';
		else
		begin
			insert into tbPeriodo(NomePeriodo) values (@NomePeriodo);
			declare @CodPeriodo smallint = (select top 1 CodPeriodo from tbPeriodo order by CodPeriodo DESC);
			insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana);
			if @Dia2 is not null insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana2);
			if @Dia3 is not null insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana3);

			SELECT @Mensagem = 'Dados Incluidos com Sucesso!' 

		end
	end
	SELECT @Mensagem as Mensagem;
end
GO

-- CADASTRAR PROFESSOR
CREATE PROC cadProf  @Email VARCHAR(50), @Senha varchar(20), @CEP char(8), @Numero smallint, @Nome varchar(75),
						@Complemento varchar(30) = '', @Cidade varchar(25), @UF char(2), @Logradouro varchar(140),
						@RG char(10), @CPF decimal(11), @DataNasc date, @Salario money, @Cargo varchar(20), @Idioma varchar(18),
						@TelCelular decimal(9) = 0, @TelFixo decimal(8) = 0
AS
BEGIN
	IF @Email IS NULL AND @Senha IS NULL AND @CEP <> 0AND @Numero <> 0 AND @Nome IS NULL AND 
		@Cidade IS NULL AND @UF IS NULL AND @Logradouro IS NULL AND
		@RG IS NULL AND @CPF <> 0 AND @DataNasc IS NULL and @Salario IS NULL AND @Cargo IS NULL
		AND @Idioma IS NULL
		SELECT 'Há atributos vazios' AS [ERRO];
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc)
			VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, @DataNasc);

			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados);
			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
			VALUES (@CodLogin, @CodDados, @Salario, @Cargo);

			DECLARE @CodFunc smallint=(SELECT TOP 1 CodFunc FROM tbFuncionario ORDER BY CodFunc);

			INSERT INTO tbProfessor(Idioma, CodFunc)
			VALUES (@Idioma, @CodFunc);
		END
END
GO


 /*
exec sp_insert_periodo null, 1, null, null;
exec sp_insert_periodo null, 1, 2, null;
exec sp_insert_periodo null, 1, 2, 3;
exec sp_insert_periodo '3 dias', 4, 5, 6;
exec sp_insert_periodo 'Segunda', 3, null, null;
exec sp_insert_periodo null, 1, null, null;

truncate table tbPeriodo_DiaSemana;
delete tbPeriodo; DBCC CHECKIDENT ('tbPeriodo', RESEED, 0);
*/

