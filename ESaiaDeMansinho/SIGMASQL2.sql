USE master;
GO


IF DB_ID('dbLIGMA') is not null DROP DATABASE dbLIGMA;
GO

CREATE DATABASE dbLIGMA;
GO

USE dbLIGMA;
GO

CREATE TABLE tbDadosComuns (
	CodDados int identity(1,1)
	CONSTRAINT PK_DadosComuns PRIMARY KEY,
	Nome varchar(75) not null,
	TelFixo decimal(8),
	TelCelular decimal(9),
	DataNasc date not null,
	RG char(10) not null,
	CPF decimal(11) not null
	CONSTRAINT UK_Func_CPF UNIQUE(CPF),
	Complemento varchar(30),
	Cidade varchar(25) not null,
	UF char(2) not null,
	Logradouro varchar(10) not null,
	CEP char(8),
	Numero int
	);
GO

CREATE TABLE tbLogin (
	CodLogin int identity(1,1)
	CONSTRAINT PK_Login PRIMARY KEY,
	Senha varchar(20) not null,
	Email varchar(50) not null
	CONSTRAINT UK_Login_Email UNIQUE,
	Ativada bit not null default 0 --1 pra verdadeiro 0 pra falso
	);

	insert into tbLogin(Senha,Email) values ('admin', 'admin@a.com'); 
GO

CREATE TABLE tbFuncionario (
	CodFunc int identity(1,1)
	CONSTRAINT PK_Func PRIMARY KEY,
	Salario money not null,
	Cargo varchar(20) not null,
	CodDados int
	CONSTRAINT FK_Func_Dados FOREIGN KEY REFERENCES tbDadosComuns(CodDados),
	CodLogin int not null
	CONSTRAINT FK_Func_Login FOREIGN KEY REFERENCES tbLogin(CodLogin)
);
GO

CREATE TABLE tbProfessor (
	CodProf int identity(1,1)
	CONSTRAINT PK_Prof PRIMARY KEY,
	Idioma varchar(18) not null,
	CodFunc int not null
	CONSTRAINT FK_Prof_Func FOREIGN KEY REFERENCES tbFuncionario(CodFunc)
);
GO

CREATE TABLE tbDiaSemana(
	CodDiaSemana int identity(1,1)
	CONSTRAINT PK_DiaSemana PRIMARY KEY,
	Nome varchar(7) not null
);

insert into tbDiaSemana values('Segunda'),
							  ('Ter�a'),
							  ('Quarta'),
							  ('Quinta'),
							  ('Sexta'),
							  ('S�bado'),
							  ('Domingo'); 
GO

CREATE TABLE tbPeriodo(
	CodPeriodo int identity(1,1)
	CONSTRAINT PK_Periodo PRIMARY KEY,
	NomePeriodo varchar(40) not null,
	HorarioAula time not null 
);
GO

CREATE TABLE tbPeriodo_DiaSemana(
	CodPeriodoDiaSemana int identity(1,1)
	CONSTRAINT PK_PeriodoDiaSemana PRIMARY KEY,
	CodPeriodo int not null
	CONSTRAINT FK_PeriodoDiaSemana_Periodo FOREIGN KEY REFERENCES tbPeriodo(CodPeriodo),
	CodDiaSemana int not null
	CONSTRAINT FK_PeriodoDiaSemana_DiaSemana FOREIGN KEY REFERENCES tbDiaSemana(CodDiaSemana)
);
GO

CREATE TABLE tbCurso (
	CodCurso int identity(1,1)
	CONSTRAINT PK_Curso PRIMARY KEY,
	Idioma varchar(15) not null
);

insert into tbCurso values('Ingl�s' ),
						  ('Espanhol'),
						  ('Franc�s'); 
GO

CREATE TABLE tbTurma(
	CodTurma int identity(1,1)
	CONSTRAINT PK_Turma PRIMARY KEY,
	CodCurso int not null
	CONSTRAINT FK_Turma_Curso FOREIGN KEY REFERENCES tbCurso(CodCurso),
	CodProf int not null
	CONSTRAINT FK_Aula_Prof FOREIGN KEY REFERENCES tbProfessor(CodProf),
	CodPeriodo int not null
	CONSTRAINT FK_Turma_Periodo FOREIGN KEY REFERENCES tbPeriodo(CodPeriodo),
	Estagio varchar(15) not null,
	Preco money not null
);
GO

CREATE TABLE tbAula(
	CodAula int identity(1,1)
	CONSTRAINT PK_Aula PRIMARY KEY,
	Sala int not null,
	Data_Hora datetime not null,
	CodTurma int not null
	CONSTRAINT FK_Aula_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	Descricao varchar(100)
);

CREATE TABLE tbAluno(
	CodAluno int identity(1,1)	
	CONSTRAINT PK_Aluno PRIMARY KEY,
	DataMatricula date not null,
	DataFinal date not null,
	CodTurma int not null
	CONSTRAINT FK_Aluno_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	CodDados int
	CONSTRAINT FK_Aluno_Dados FOREIGN KEY REFERENCES tbDadosComuns(CodDados),
	CodLogin int not null
	CONSTRAINT FK_Aluno_Login FOREIGN KEY REFERENCES tbLogin(CodLogin),
	SituacaoMensalidade bit not null DEFAULT 0 --1 PAGO, 0 N�O PAGO
);
GO

--APAGUEI A TABELA MENSALIDADE

CREATE TABLE tbPagamento(
	CodPagamento int identity(1,1)
	CONSTRAINT PK_Pagamento PRIMARY KEY,
	DiaPagamento date not null,
	ValorLiquido money not null,
	Descontos money not null DEFAULT 0.00,
	B�nus money not null DEFAULT 0.00, 
	StatusPagamento char(1) not null DEFAULT 'N', -- P-Pago, N-N�o Pago
	CodProfessor int not null
	CONSTRAINT FK_Pagamento_Professor FOREIGN KEY REFERENCES tbProfessor(CodProf)
);
GO

CREATE TABLE tbAula_Aluno(
	CodAula int not null
	CONSTRAINT FK_AulaAluno_Aula FOREIGN KEY REFERENCES tbAula(CodAula),
	CodAluno int not null
	CONSTRAINT FK_AulaAluno_Aluno FOREIGN KEY REFERENCES tbAluno(CodAluno),
	CONSTRAINT PK_AulaAluno PRIMARY KEY CLUSTERED(CodAula, CodAluno),
	Presenca bit --1 presente, 0 ausente
);
GO

CREATE TABLE tbAvaliacao(
	CodAvaliacao int identity(1,1)
	CONSTRAINT PK_Avaliacao PRIMARY KEY,
	CodProfessor int not null
	CONSTRAINT FK_Avaliacao_Professor FOREIGN KEY REFERENCES tbProfessor(CodProf),
	TipoAvaliacao varchar(10) not null,
	DataAvaliacao date not null,
	CodTurma int not null
	CONSTRAINT FK_Avaliacao_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	Descricao varchar(100) --MUDEI O TAMANHO
);
GO

CREATE TABLE tbNota(
	CodAluno int not null
	CONSTRAINT FK_Nota_Aluno FOREIGN KEY REFERENCES tbAluno(CodAluno),
	CodAvaliacao int not null
	CONSTRAINT FK_Nota_Avaliacao FOREIGN KEY REFERENCES tbAvaliacao(CodAvaliacao),
	Nota decimal(4,2) not null,
	CONSTRAINT PK_Nota PRIMARY KEY CLUSTERED(CodAluno, CodAvaliacao) 
);
GO

------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------ PROCEDURES ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------


--CADASTRAR FUNCIONARIO
CREATE PROC spcadFunc (
	@Email VARCHAR(50), 
	@Senha varchar(20), 
	@CEP char(8), 
	@Numero int, 
	@Nome varchar(75),
	@Complemento varchar(30), 
	@Cidade varchar(25), 
	@UF char(2), 
	@Logradouro varchar(10),
	@RG char(10), 
	@CPF decimal(11), 
	@DataNasc varchar(10), 
	@Salario money, 
	@Cargo varchar(20), 
	@TelCelular decimal(9) = 0, 
	@TelFixo decimal(8) = 0
)AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or 
		@Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @Salario IS NULL or @Cargo IS NULL
		SELECT 'H� atributos vazios' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email j� registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Funcion�rio j� registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(date, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin int=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados int=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);

			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
							  VALUES (@CodLogin, @CodDados, @Salario, @Cargo);

			SELECT 'Dados Cadastrados Com Sucesso!' Sucesso
		END
END
GO
/*
delete tbFuncionario; DBCC CHECKIDENT('tbFuncionario', RESEED, 0);
delete tbLogin; DBCC CHECKIDENT('tbLogin', RESEED, 0);
delete tbDadosComuns; DBCC CHECKIDENT('tbDadosComuns', RESEED, 0);
*/
exec spcadFunc  'a@a.com', '1', '12345678', 12, 'Jo�o', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;
GO
/*
exec spcadFunc  'Exemplo@oi.com', '12345678', '12345678', 12, 'Jo�o1', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;
exec spcadFunc  'Exemplo@oi.com1', '12345678', '12345678', 12, 'Jo�o', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;

*/

create proc sp_delete_func(
 @codfunc int
)as begin
	delete from tbFuncionario where CodFunc = @codfunc;
end
GO

create view vwFuncionario as 
	select Nome, TelFixo [Telefone Fixo], TelCelular [Celular], DataNasc [Data de Nascimento], RG, CPF, Logradouro, CEP, Numero, Salario, Cargo, Email, Senha, 
		CASE Ativada
        WHEN 0 THEN 'Desativado'
        ELSE 'Ativado' END AS [Ativado/Desativado]
	from tbDadosComuns DC
	inner join tbFuncionario F on DC.CodDados = F.CodDados
	inner join tbLogin L on F.CodLogin = L.CodLogin;

--select * from vwFuncionario
GO

-- CADASTRAR PROFESSOR
CREATE PROC spcadProf  
	@Email VARCHAR(50), 
	@Senha varchar(20), 
	@CEP char(8), 
	@Numero int, 
	@Nome varchar(75),
	@Complemento varchar(30) = '', 
	@Cidade varchar(25),
	@UF char(2), 
	@Logradouro varchar(140),
	@RG char(10), 
	@CPF decimal(11), 
	@DataNasc varchar(10), 
	@Salario money, 
	@Cargo varchar(20), 
	@Idioma varchar(18),
	@TelCelular decimal(9) = 0, 
	@TelFixo decimal(8) = 0
AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or
		@Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @Salario IS NULL or @Cargo IS NULL or @Idioma is null
		SELECT 'H� atributos vazios!' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email j� registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Funcion�rio j� registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
			VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(datetime, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin int=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados int=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);
			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
			VALUES (@CodLogin, @CodDados, @Salario, @Cargo);

			DECLARE @CodFunc int=(SELECT TOP 1 CodFunc FROM tbFuncionario ORDER BY CodFunc DESC);
			INSERT INTO tbProfessor(Idioma, CodFunc)
			VALUES (@Idioma, @CodFunc);

			DECLARE @CodProfessor int = (SELECT TOP 1 CodProf FROM tbProfessor ORDER BY CodProf DESC)
			INSERT INTO tbPagamento(DiaPagamento, ValorLiquido, CodProfessor)
							 VALUES(GETDATE(), @Salario, @CodProfessor);
			SELECT 'Dados Cadastrados Com Sucesso!' SUCESSO
		END
END
GO

exec spcadProf  'p@a.com', '1', '12345678', 12, 'Jo�o', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678902, '22-12-2002', 670.00, 'Professor','Espanhol', 123456789, 12345678;
/*
exec spcadProf  'Exemplo@oi.com', '12345678', '12345678', 12, 'Jo�o1', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro','Espanhol', 123456789, 12345678;
exec spcadProf  'Exemplo@oi.com1', '12345678', '12345678', 12, 'Jo�o', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro','Espanhol', 123456789, 12345678;
*/
GO

create view vwProfessor as 
	select Nome, TelFixo [Telefone Fixo], TelCelular [Celular], DataNasc [Data de Nascimento], RG, CPF, Logradouro, CEP, Numero, Salario, Cargo, Idioma, 
		CASE StatusPagamento
		WHEN 'N' THEN 'N�o Pago'
		ELSE 'Pago' END AS [Situ��o do Pagamento], 
	Email, Senha,
	    CASE Ativada
        WHEN 0 THEN 'Desativado'
        ELSE 'Ativado' END AS [Ativado/Desativado]
	from tbDadosComuns DC
	inner join tbFuncionario F on DC.CodDados = F.CodDados
	inner join tbLogin L on F.CodLogin = L.CodLogin
	inner join tbProfessor P on F.CodFunc = P.CodFunc
	inner join tbPagamento PG on PG.CodProfessor = P.CodProf;
GO
--declare @oi time = '6:45'; print @oi;

--CADASTRAR PERIODO
create procedure spPeriodo(
	@CodDiaSemana int, 
	@CodDiaSemana2 int,
	@CodDiaSemana3 int,
	@HorarioAula time
)as
begin
	
	declare @NomePeriodo varchar(40);
	declare @Mensagem varchar(40);
	if @CodDiaSemana is null SELECT @Mensagem = 'Selecione pelo menos um dia da semana!';
	else if @HorarioAula < '7:00' or @HorarioAula > '19:00' SELECT @Mensagem = 'Hor�rio Inv�lido!'
	else
	begin
		declare @Dia1 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana);
		declare @Dia2 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana2);
		declare @Dia3 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana3);

		if @Dia2 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1 + ' - ' + convert(varchar, @HorarioAula,8); 
		else if @Dia3 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1 +', '+ @Dia2 + ' - ' + convert(varchar, @HorarioAula,8);
		else SELECT @NomePeriodo = @Dia1 +', '+ @Dia2 +', '+ @Dia3 + ' - ' + convert(varchar, @HorarioAula,8);

		if @NomePeriodo is not null and exists(select NomePeriodo from tbPeriodo where NomePeriodo = @NomePeriodo) 
		SELECT @Mensagem = 'Voc� j� tem um periodo semelhante!';
		else
		begin
			insert into tbPeriodo(NomePeriodo, HorarioAula) values (@NomePeriodo, @HorarioAula);
			declare @CodPeriodo int = (select top 1 CodPeriodo from tbPeriodo order by CodPeriodo DESC);
			insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana);
			if @Dia2 is not null insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana2);
			if @Dia3 is not null insert into tbPeriodo_DiaSemana(CodPeriodo, CodDiaSemana) values (@CodPeriodo, @CodDiaSemana3);

			SELECT @Mensagem = 'Dados Incluidos com Sucesso!' 

		end
	end
	SELECT @Mensagem Mensagem;
end
GO
 
exec spPeriodo  1, null, null, '7:00';
GO
/*
exec spPeriodo  1, 3, null, '19:00';
exec spPeriodo  1, 2, 3, '7:00';

truncate table tbPeriodo_DiaSemana;
delete tbPeriodo; DBCC CHECKIDENT ('tbPeriodo', RESEED, 0);
*/

create view vwPeriodo as
select NomePeriodo [Nome do Periodo], Count(Nome) [Quantidade de Dias da Semana] from tbPeriodo P
	inner join tbPeriodo_DiaSemana PD on P.CodPeriodo = PD.CodPeriodo
	inner join tbDiaSemana DS on PD.CodDiaSemana = DS.CodDiaSemana group by NomePeriodo;
GO

--CADASTRAR TURMA
create proc spTurma(
	@CodCurso int,
	@CodProf int, 
	@CodPeriodo int,
	@Estagio varchar(15),
	@Preco money
)as 
begin
	if exists(select * from tbTurma where CodCurso = @CodCurso and CodPeriodo = @CodPeriodo and
			  CodProf = @CodProf and Estagio = @Estagio)
	SELECT 'J� existe essa turma!' ERRO
	else
	begin
		insert into tbTurma(CodCurso, CodPeriodo, CodProf, Estagio, Preco)
					 values(@CodCurso, @CodPeriodo, @CodProf, @Estagio, @Preco);
	SELECT 'Dados Cadastrados Com Sucesso!' Sucesso
	end
end
GO


exec spTurma 1, 1, 1, 'Intermedi�rio', 156.00;
GO


create view vwTurma as
select Estagio Est�gio, Preco Pre�o, C.Idioma, NomePeriodo [Per�odo], Nome Professor from tbTurma T
	inner join tbCurso C on C.CodCurso = T.CodCurso 
	inner join tbPeriodo P on P.CodPeriodo = T.CodPeriodo
	inner join tbProfessor PR on PR.CodProf = T.CodProf
	inner join tbFuncionario F on F.CodFunc = PR.CodFunc
	inner join tbDadosComuns DC on DC.CodDados = F.CodDados;
GO
--CADASTRAR ALUNO
CREATE PROC spcadAluno( 
	@Email VARCHAR(50), 
	@Senha varchar(20), 
	@CEP char(8), 
	@Numero int, 
	@Nome varchar(75),
	@Complemento varchar(30), 
	@Cidade varchar(25), 
	@UF char(2), 
	@Logradouro varchar(10),
	@RG char(10), 
	@CPF decimal(11), 
	@DataNasc varchar(10), 
	@DataFinal varchar(10), 
	@DataMatricula varchar(10), 
	@TelCelular decimal(9) = 0, 
	@TelFixo decimal(8) = 0,
	@CodTurma int
)AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or 
		@Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @DataFinal IS NULL or @DataMatricula IS NULL
		SELECT 'H� atributos vazios' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email j� registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Aluno j� registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(date, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin int=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados int=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);

			INSERT INTO tbAluno(CodLogin, CodDados, DataMatricula, DataFinal, CodTurma)
							  VALUES (@CodLogin, @CodDados, CONVERT(date, @DataMatricula, 103), CONVERT(date, @DataFinal, 103), @CodTurma);


			SELECT 'Dados Cadastrados Com Sucesso!' Sucesso
		END
END
GO

exec spcadAluno  'al@a.com', '1', '12345678', 12, 'Jo�o', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678903, '22-12-2002', '22-12-2018', '22-12-2020', 123456789, 12345678, 1; 
GO
/*
select * from tbAluno; 

delete tbLogin where CodLogin = 4;  DBCC CHECKIDENT('tbLogin', RESEED, 3);
delete tbDadosComuns where CodDados = 4;  DBCC CHECKIDENT('tbLogin', RESEED, 2);
delete tbAluno; DBCC CHECKIDENT('tbAluno', RESEED, 0);
*/ 

create view vwAluno as
select Nome, TelFixo [Telefone Fixo], TelCelular [Celular], DataNasc [Data de Nascimento], RG, CPF, Logradouro, CEP, Numero, DataMatricula [Data de Matricula], DataFinal [Data Final do Contrato], Estagio Est�gio, NomePeriodo [Per�odo], 
		CASE SituacaoMensalidade
		WHEN 0 THEN 'N�o Pago'
		ELSE 'Pago' END AS [Situ��o da Mensalidade], 
	Email, Senha,
	    CASE Ativada
        WHEN 0 THEN 'Desativado'
        ELSE 'Ativado' END AS [Ativado/Desativado]
	from tbDadosComuns DC
	inner join tbAluno A on DC.CodDados = A.CodDados
	inner join tbLogin L on A.CodLogin = L.CodLogin
	inner join tbTurma T on T.CodTurma = A.CodTurma
	inner join tbPeriodo P on P.CodPeriodo = T.CodPeriodo;
GO

create view vwAlunoPrincipal as
select Nome, Idioma, Estagio, NomePeriodo [Periodo]
	from tbDadosComuns DC
	inner join tbAluno A on DC.CodDados = A.CodDados
	inner join tbLogin L on A.CodLogin = L.CodLogin
	inner join tbTurma T on T.CodTurma = A.CodTurma
	inner join tbCurso C on C.CodCurso = T.CodCurso
	inner join tbPeriodo P on P.CodPeriodo = T.CodPeriodo
	where Ativada = 1; 
GO

 create proc spSelectPresenca
as begin
	declare @PresencaAluno int = (select count(Presenca) from tbAula_Aluno where Presenca = 1 and CodAluno = (select CodAluno from tbAluno A 
																											  inner join tbLogin T 
																											  on A.CodLogin = T.CodLogin
																											  where Ativada = 1)),
			@PresencaTotal int = (select count(*) from tbAula);
			
			select convert(varchar(4),(@PresencaAluno / @PresencaTotal) * 100) + '%'; 
end
GO


create proc spcadAula(
	@Sala int,
	@CodTurma int,
	@Data_Hora datetime,
	@Descricao varchar(100)
)as begin
	if exists(select * from tbAula where Sala = @Sala and CodTurma = @CodTurma and Data_Hora = @Data_Hora)
		SELECT 'Aula j� Registrada!' ERRO;
	else
	begin

		insert into tbAula(Sala, CodTurma, Data_Hora, Descricao) values(@Sala, @CodTurma, @Data_Hora, @Descricao);
		SELECT 'Dados Cadastrados com Sucesso!' Mensagem
	end
end
GO


exec spcadAula 1, 1, '2019-05-26 11:45', null; 
GO
/*
insert into tbAula(Sala, CodTurma) values(1,1);
*/

create proc spAulaAluno(
	@CodAula int,
	@CodAluno int
)as begin
	insert into tbAula_Aluno(CodAula, CodAluno, Presenca) values(@CodAula, @CodAluno, 1);
end
GO


exec spAulaAluno 1, 1;
GO

create view vwListaPresen�a as
select Nome [Nome do Aluno], Sala [N�mero da Sala], Estagio [Est�gio], Data_Hora [Data] from tbAluno AL
	inner join tbDadosComuns DC on DC.CodDados = AL.CodDados
	inner join tbAula_Aluno AA on AL.CodAluno = AA.CodAluno
	inner join tbAula A on A.CodAula = AA.CodAula
	inner join tbTurma T on T.CodTurma = A.CodTurma;
GO

create proc spAvaliacao(
	@CodProfessor int,
	@TipoAvaliacao varchar(10),
	@DataAvaliacao date,
	@CodTurma int,
	@Descricao varchar(100)
)as begin
	insert into tbAvaliacao(CodProfessor, TipoAvaliacao, DataAvaliacao, CodTurma, Descricao) values(@CodProfessor,@TipoAvaliacao,  @DataAvaliacao, @CodTurma, @Descricao);
end
GO
exec spAvaliacao 1, 'Prova', '2019-12-05', 1, null

GO
create view vwNotas as
select Nome [Nome do Aluno], DataAvaliacao [Data da Avaliacao], Nota from tbAluno AL
	inner join tbDadosComuns DC on DC.CodDados = AL.CodDados
	inner join tbNota N on N.CodAluno = AL.CodAluno
	inner join tbAvaliacao A on A.CodAvaliacao = N.CodAvaliacao;
GO

create proc spNota(
	@CodAluno int,
	@CodAvaliacao int,
	@Nota decimal(4,2)
)as begin
	insert into tbNota(CodAluno, CodAvaliacao, Nota) values(@CodAluno, @CodAvaliacao, @Nota);
end
GO

create proc sp_logar_usuario(
@email varchar (50),
@senha_usuario varchar (20)
)
as
begin
	if (select count (*) as CNT from tbLogin where Email = @email and Senha = @senha_usuario) = 1
		update tbLogin set Ativada = 1 where Email = @email and Senha = @senha_usuario;
end
GO

create proc sp_deslogar_usuario
as
begin
	update tbLogin set Ativada = 0 where Ativada = 1;
end
GO

create proc sp_mudar_senha(
@senhaatual varchar(20),
@senhanova varchar (20)
)
as
begin
	if (select count (*) as CNT from tbLogin where Senha = @senhaatual) = 1
		update tbLogin set Senha = @senhanova where Senha = @senhaatual;
end
GO

create proc sp_VEAluno( --Verificar Email
	@email varchar(50)
)as begin
	if exists(select * from vwAluno where Email = @email)
	select 'true'; 
	else select 'false';
end
GO

create proc sp_VEProf( --Verificar Email
	@email varchar(50)
)as begin
	if exists(select * from vwProfessor where Email = @email and Cargo = 'Professor')
	select 'true'; 
	else select 'false';
end
GO

create proc sp_VEAdmin( --Verificar Email
	@email varchar(50)
)as begin
	if exists(select * from vwFuncionario where Email = @email)
	select 'true'; 
	else select 'false';
end
GO

SELECT CONCAT(Est�gio, ', Data: ', convert(varchar, Data, 3), ', Sala: ', [N�mero da Sala]) as [Aula] from vwListaPresen�a
GO

create view vwAulaAluno as
 select A.CodAula Codigo, CONCAT(T.Estagio, ', Data: ', convert(varchar, Data_Hora, 3), ', Sala: ', Sala) as [Aula], Ativada
 from tbAula A inner join tbAula_Aluno AA on A.CodAula = AA.CodAula
			   inner join tbAluno AL on AA.CodAluno = AL.CodAluno
			   inner join tbTurma T on AL.CodTurma = T.CodTurma
			   inner join tbLogin L on AL.CodLogin = L.CodLogin;
GO

create view vwAvaliacaoAluno as
 select A.CodAvaliacao Codigo, CONCAT(TipoAvaliacao, ', Data: ', convert(varchar, DataAvaliacao, 3), ' Descri��o: ',isnull(Descricao, 'Sem Descri��o')) as [Avaliacao], Ativada
  from tbAvaliacao A inner join tbTurma T on A.CodTurma = T.CodTurma
			   inner join tbAluno AL on T.CodTurma = AL.CodTurma
			   inner join tbLogin L on AL.CodLogin = L.CodLogin;
GO

update tbLogin set Ativada = 1 where Email = 'al@a.com'

select Codigo, Aula from vwAulaAluno where Ativada = 1;
GO
create view vwNotifAluno as
	SELECT Concat('Aluno: ',Nome,'. Turma: ',Estagio,' - ', NomePeriodo )[Aluno], Ativada 
	 from tbDadosComuns DC 
	 inner join tbAluno A on A.CodDados = DC.CodDados 
	 inner join tbLogin L on A.CodLogin = L.CodLogin
	 inner join tbTurma T on A.CodTurma = T.CodTurma
	 INNER JOIN tbPeriodo P on P.CodPeriodo = T.CodPeriodo;
GO

select Aluno from vwNotifAluno	where  Ativada = 1;
SELECT [Codigo], [Avaliacao] from vwAvaliacaoAluno where Ativada = 1
