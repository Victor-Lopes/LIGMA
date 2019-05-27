use dbLIGMA; 
go

--CADASTRAR FUNCIONARIO
CREATE PROC spcadFunc (
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
		SELECT 'Há atributos vazios' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email já registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Funcionário já registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(date, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);

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

exec spcadFunc  'Exemplo@oi.com', '12345678', '12345678', 12, 'João', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;
exec spcadFunc  'Exemplo@oi.com', '12345678', '12345678', 12, 'João1', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;
exec spcadFunc  'Exemplo@oi.com1', '12345678', '12345678', 12, 'João', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro', 123456789, 12345678;

*/

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
	@Numero smallint, 
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
		SELECT 'Há atributos vazios!' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email já registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Funcionário já registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
			VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(datetime, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);
			INSERT INTO tbFuncionario(CodLogin, CodDados, Salario, Cargo)
			VALUES (@CodLogin, @CodDados, @Salario, @Cargo);

			DECLARE @CodFunc smallint=(SELECT TOP 1 CodFunc FROM tbFuncionario ORDER BY CodFunc DESC);
			INSERT INTO tbProfessor(Idioma, CodFunc)
			VALUES (@Idioma, @CodFunc);

			DECLARE @CodProfessor smallint = (SELECT TOP 1 CodProf FROM tbProfessor ORDER BY CodProf DESC)
			INSERT INTO tbPagamento(DiaPagamento, ValorLiquido, CodProfessor)
							 VALUES(GETDATE(), @Salario, @CodProfessor);
			SELECT 'Dados Cadastrados Com Sucesso!' SUCESSO
		END
END
GO
/*
exec spcadProf  'Exemplo@oi1.com', '12345678', '12345678', 12, 'João', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678902, '22-12-2002', 670.00, 'Professor','Espanhol', 123456789, 12345678;
exec spcadProf  'Exemplo@oi.com', '12345678', '12345678', 12, 'João1', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro','Espanhol', 123456789, 12345678;
exec spcadProf  'Exemplo@oi.com1', '12345678', '12345678', 12, 'João', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678901, '22-12-2002', 670.00, 'Faxineiro','Espanhol', 123456789, 12345678;
*/

create view vwProfessor as 
	select Nome, TelFixo [Telefone Fixo], TelCelular [Celular], DataNasc [Data de Nascimento], RG, CPF, Logradouro, CEP, Numero, Salario, Cargo, Idioma, 
		CASE StatusPagamento
		WHEN 'N' THEN 'Não Pago'
		ELSE 'Pago' END AS [Situção do Pagamento], 
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
	@CodDiaSemana smallint, 
	@CodDiaSemana2 smallint,
	@CodDiaSemana3 smallint,
	@HorarioAula time
)as
begin
	
	declare @NomePeriodo varchar(40);
	declare @Mensagem varchar(40);
	if @CodDiaSemana is null SELECT @Mensagem = 'Selecione pelo menos um dia da semana!';
	else if @HorarioAula < '7:00' or @HorarioAula > '19:00' SELECT @Mensagem = 'Horário Inválido!'
	else
	begin
		declare @Dia1 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana);
		declare @Dia2 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana2);
		declare @Dia3 varchar(8) = (SELECT Nome from tbDiaSemana where CodDiaSemana = @CodDiaSemana3);

		if @Dia2 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1 + ' - ' + convert(varchar, @HorarioAula,8); 
		else if @Dia3 is null and @NomePeriodo is null SELECT @NomePeriodo = @Dia1 +', '+ @Dia2 + ' - ' + convert(varchar, @HorarioAula,8);
		else SELECT @NomePeriodo = @Dia1 +', '+ @Dia2 +', '+ @Dia3 + ' - ' + convert(varchar, @HorarioAula,8);

		if @NomePeriodo is not null and exists(select NomePeriodo from tbPeriodo where NomePeriodo = @NomePeriodo) 
		SELECT @Mensagem = 'Você já tem um periodo semelhante!';
		else
		begin
			insert into tbPeriodo(NomePeriodo, HorarioAula) values (@NomePeriodo, @HorarioAula);
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
exec spPeriodo  1, null, null, '7:00';
exec spPeriodo  1, 2, null, '19:00';
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
	@CodCurso smallint,
	@CodProf smallint, 
	@CodPeriodo smallint,
	@Estagio varchar(15),
	@Preco money
)as 
begin
	if exists(select * from tbTurma where CodCurso = @CodCurso and CodPeriodo = @CodPeriodo and
			  CodProf = @CodProf and Estagio = @Estagio)
	SELECT 'Já existe essa turma!' ERRO
	else
	begin
		insert into tbTurma(CodCurso, CodPeriodo, CodProf, Estagio, Preco)
					 values(@CodCurso, @CodPeriodo, @CodProf, @Estagio, @Preco);
	SELECT 'Dados Cadastrados Com Sucesso!' Sucesso
	end
end
GO

/*
exec spTurma 1, 1, 1, 'Intermediário', 156.00;
GO
*/

create view vwTurma as
select Estagio Estágio, Preco Preço, C.Idioma, NomePeriodo [Período], Nome Professor from tbTurma T
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
	@Numero smallint, 
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
	@CodTurma smallint
)AS
BEGIN
	IF @Email IS NULL or @Senha IS NULL or @CEP = 0 or @Numero = 0 or @Nome IS NULL or 
		@Cidade IS NULL or @UF IS NULL or @Logradouro IS NULL or
		@RG IS NULL or @CPF = 0 or @DataNasc IS NULL and @DataFinal IS NULL or @DataMatricula IS NULL
		SELECT 'Há atributos vazios' [ERRO];
	ELSE IF exists(select * from tbLogin where Email = @Email) SELECT 'Email já registrado!' ERRO;
	ELSE IF exists(select * from tbDadosComuns where CPF = @CPF) SELECT 'Aluno já registrado!' ERRO;
	ELSE
		BEGIN
			INSERT INTO tbLogin(Email,Senha) VALUES (@Email, @Senha);

			INSERT INTO tbDadosComuns(CEP, Numero, Nome, Complemento, Cidade, UF, Logradouro, RG, CPF, DataNasc, TelFixo, TelCelular)
							  VALUES (@CEP, @Numero, @Nome, @Complemento, @Cidade, @UF, @Logradouro, @RG, @CPF, CONVERT(date, @DataNasc, 103), @TelFixo, @TelCelular);

			DECLARE @CodLogin smallint=(SELECT TOP 1 codLogin FROM tbLogin ORDER BY CodLogin DESC);
			DECLARE @CodDados smallint=(SELECT TOP 1 CodDados FROM tbDadosComuns ORDER BY CodDados DESC);

			INSERT INTO tbAluno(CodLogin, CodDados, DataMatricula, DataFinal, CodTurma)
							  VALUES (@CodLogin, @CodDados, CONVERT(date, @DataMatricula, 103), CONVERT(date, @DataFinal, 103), @CodTurma);


			SELECT 'Dados Cadastrados Com Sucesso!' Sucesso
		END
END
GO

/*
exec spcadAluno  'Exemplo@oi2.com', '12345678', '12345678', 12, 'João', null, 'oi', 'sp', 'rua 12', '1234567890', 12345678903, '22-12-2002', '22-12-2018', '22-12-2020', 123456789, 12345678, 1; 

select * from tbAluno; 

delete tbLogin where CodLogin = 4;  DBCC CHECKIDENT('tbLogin', RESEED, 3);
delete tbDadosComuns where CodDados = 4;  DBCC CHECKIDENT('tbLogin', RESEED, 2);
delete tbAluno; DBCC CHECKIDENT('tbAluno', RESEED, 0);
*/ 

create view vwAluno as
select Nome, TelFixo [Telefone Fixo], TelCelular [Celular], DataNasc [Data de Nascimento], RG, CPF, Logradouro, CEP, Numero, DataMatricula [Data de Matricula], DataFinal [Data Final do Contrato], Estagio Estágio, NomePeriodo [Período], 
		CASE SituacaoMensalidade
		WHEN 0 THEN 'Não Pago'
		ELSE 'Pago' END AS [Situção da Mensalidade], 
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

create proc spcadAula(
	@Sala smallint,
	@CodTurma smallint,
	@Data_Hora datetime,
	@Descricao varchar(100)
)as begin
	if exists(select * from tbAula where Sala = @Sala and CodTurma = @CodTurma and Data_Hora = @Data_Hora)
		SELECT 'Aula já Registrada!' ERRO;
	else
	begin

		insert into tbAula(Sala, CodTurma, Data_Hora, Descricao) values(@Sala, @CodTurma, @Data_Hora, @Descricao);
		SELECT 'Dados Cadastrados com Sucesso!' Mensagem
	end
end
GO

/*
exec spcadAula 1, 1, getdate(), null; 

insert into tbAula(Sala, CodTurma) values(1,1);
*/

create proc spAulaAluno(
	@CodAula smallint,
	@CodAluno smallint
)as begin
	insert into tbAula_Aluno(CodAula, CodAluno, Presenca) values(@CodAula, @CodAluno, 1);
end
GO

/*
exec spAulaAluno 1, 1;
*/

create view vwListaPresença as
select Nome [Nome do Aluno], Sala [Número da Sala], Estagio [Estágio], Data_Hora [Data] from tbAluno AL
	inner join tbDadosComuns DC on DC.CodDados = AL.CodDados
	inner join tbAula_Aluno AA on AL.CodAluno = AA.CodAluno
	inner join tbAula A on A.CodAula = AA.CodAula
	inner join tbTurma T on T.CodTurma = A.CodTurma order by Nome;
GO

create proc spAvaliacao(
	@CodProfessor smallint,
	@DataAvaliacao date,
	@CodTurma smallint,
	@Descricao varchar(100)
)as begin
	insert into tbAvaliacao(CodProfessor, DataAvaliacao, CodTurma, Descricao) values(@CodProfessor, @DataAvaliacao, @CodTurma, @Descricao);
end
GO

create view vwNotas as
select Nome [Nome do Aluno], DataAvaliacao [Data da Avaliacao], Nota from tbAluno AL
	inner join tbDadosComuns DC on DC.CodDados = AL.CodDados
	inner join tbNota N on N.CodAluno = AL.CodAluno
	inner join tbAvaliacao A on A.CodAvaliacao = N.CodAvaliacao;
GO

create proc spNota(
	@CodAluno smallint
	@CodAvaliacao smallint,
	@Nota decimal(4,2)
)as begin
	insert into tbNota value(@CodAluno, @CodAvaliacao, @Nota);
end
GO

create proc sp_logar_usuario(
@email varchar (50),
@senha_usuario varchar (20)
)
as
begin
	if (select count (*) as CNT from tbLogin where Email = @email and Senha = @senha_usuario) = 1
		update tbUsuario set Ativada = 1 where Emal = @email and Senha = @senha_usuario;
end
GO

create proc sp_mudar_senha(
@senhaatual varchar(20)
@senhanova varchar (20)
)
as
begin
	if (select count (*) as CNT from tbLogin Senha = @senhaatual) = 1
		update tbUsuario set Senha = @senhanova where Senha = @senhaatual;
end
GO