use dbLIGMA;
go


CREATE PROC cadFunc (
	@Email VARCHAR(50), 
	@Senha varchar(20), 
	@CEP char(8), 
	@Numero smallint, 
	@Nome varchar(75),
	@Complemento varchar(30), 
	@Cidade varchar(25), 
	@UF char(2), 
	@Logradouro varchar(10),
	@RG char(10), 
	@CPF decimal(11), 
	@DataNasc date, 
	@Salario money, 
	@Cargo varchar(20), 
	@TelCelular decimal(9) = 0, 
	@TelFixo decimal(8) = 0
)AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or
		@Complemento IS NULL or @Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @Salario IS NULL or @Cargo IS NULL
		SELECT 'Há atributos vazios' [ERRO];
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, @DataNasc);

			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);

			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
							  VALUES (@CodLogin, @CodDados, @Salario, @Cargo);
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
	SELECT @Mensagem Mensagem;
end
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

CREATE PROC cadProf (
	@Email VARCHAR(50), 
	@Senha varchar(20), 
	@CEP char(8), 
	@Numero smallint, 
	@Nome varchar(75),
	@Complemento varchar(30), 
	@Cidade varchar(25), 
	@UF char(2), 
	@Logradouro varchar(10),
	@RG char(10), 
	@CPF decimal(11), 
	@DataNasc date, 
	@Salario money, 
	@Cargo varchar(20), 
	@TelCelular decimal(9) = 0, 
	@TelFixo decimal(8) = 0,
	@Idioma varchar(18)
)AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or
		@Complemento IS NULL or @Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @Salario IS NULL or @Cargo IS NULL
		SELECT 'Há atributos vazios' [ERRO];
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, @DataNasc);

			DECLARE @CodLogin smallint=(SELECT TOP 1 CodLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);
			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
							  VALUES (@CodLogin, @CodDados, @Salario, @Cargo);

			DECLARE @CodFuncionario smallint = (SELECT TOP 1 CodFuncionario FROM tbFuncionario ORDER BY CodFuncionario DESC);
			INSERT INTO tbProfessor(Idoma, CodFuncionario)
							 VALUES(@Idioma, @CodFuncionario);

			DECLARE @CodProfessor smallint = (SELECT TOP 1 CodProfessor FROM tbProfessor ORDER BY CodProfessor DESC)
			INSERT INTO tbPagamento(DiaPagamento, ValorLiquido, CodProfessor)
							 VALUES(GETDATE(), @Salario, @CodProfessor);
		END
END
GO
