USE master;
GO


IF DB_ID('dbLIGMA') is not null DROP DATABASE dbLIGMA;
GO

CREATE DATABASE dbLIGMA;
GO

USE dbLIGMA;
GO

CREATE TABLE tbDadosComuns (
	CodDados smallint identity(1,1)
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
	Numero smallint
	);
GO

CREATE TABLE tbLogin (
	CodLogin smallint identity(1,1)
	CONSTRAINT PK_Login PRIMARY KEY,
	Senha varchar(20) not null,
	Email varchar(50) not null
	CONSTRAINT UK_Login_Email UNIQUE,
	Ativada bit not null default 0 --1 pra verdadeiro 0 pra falso
	);

	insert into tbLogin(Senha,Email) values ('admin', 'admin@a.com'); 
GO

CREATE TABLE tbFuncionario (
	CodFunc smallint identity(1,1)
	CONSTRAINT PK_Func PRIMARY KEY,
	Salario money not null,
	Cargo varchar(20) not null,
	CodDados smallint
	CONSTRAINT FK_Func_Dados FOREIGN KEY REFERENCES tbDadosComuns(CodDados),
	CodLogin smallint not null
	CONSTRAINT FK_Func_Login FOREIGN KEY REFERENCES tbLogin(CodLogin)
);
GO

CREATE TABLE tbProfessor (
	CodProf smallint identity(1,1)
	CONSTRAINT PK_Prof PRIMARY KEY,
	Idioma varchar(18) not null,
	CodFunc smallint not null
	CONSTRAINT FK_Prof_Func FOREIGN KEY REFERENCES tbFuncionario(CodFunc)
);
GO

CREATE TABLE tbDiaSemana(
	CodDiaSemana smallint identity(1,1)
	CONSTRAINT PK_DiaSemana PRIMARY KEY,
	Nome varchar(7) not null
);

insert into tbDiaSemana values('Segunda'),
							  ('Terça'),
							  ('Quarta'),
							  ('Quinta'),
							  ('Sexta'),
							  ('Sábado'),
							  ('Domingo'); 
GO

CREATE TABLE tbPeriodo(
	CodPeriodo smallint identity(1,1)
	CONSTRAINT PK_Periodo PRIMARY KEY,
	NomePeriodo varchar(40) not null,
	HorarioAula time not null 
);
GO

CREATE TABLE tbPeriodo_DiaSemana(
	CodPeriodoDiaSemana smallint identity(1,1)
	CONSTRAINT PK_PeriodoDiaSemana PRIMARY KEY,
	CodPeriodo smallint not null
	CONSTRAINT FK_PeriodoDiaSemana_Periodo FOREIGN KEY REFERENCES tbPeriodo(CodPeriodo),
	CodDiaSemana smallint not null
	CONSTRAINT FK_PeriodoDiaSemana_DiaSemana FOREIGN KEY REFERENCES tbDiaSemana(CodDiaSemana)
);
GO

CREATE TABLE tbCurso (
	CodCurso smallint identity(1,1)
	CONSTRAINT PK_Curso PRIMARY KEY,
	Idioma varchar(15) not null
);

insert into tbCurso values('Inglês' ),
						  ('Espanhol'),
						  ('Francês'); 
GO

CREATE TABLE tbTurma(
	CodTurma smallint identity(1,1)
	CONSTRAINT PK_Turma PRIMARY KEY,
	CodCurso smallint not null
	CONSTRAINT FK_Turma_Curso FOREIGN KEY REFERENCES tbCurso(CodCurso),
	CodProf smallint not null
	CONSTRAINT FK_Aula_Prof FOREIGN KEY REFERENCES tbProfessor(CodProf),
	CodPeriodo smallint not null
	CONSTRAINT FK_Turma_Periodo FOREIGN KEY REFERENCES tbPeriodo(CodPeriodo),
	Estagio varchar(15) not null,
	Preco money not null
);
GO

CREATE TABLE tbAula(
	CodAula smallint identity(1,1)
	CONSTRAINT PK_Aula PRIMARY KEY,
	Sala smallint not null,
	Data_Hora datetime not null,
	CodTurma smallint not null
	CONSTRAINT FK_Aula_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	Descricao varchar(100)
);

CREATE TABLE tbAluno(
	CodAluno smallint identity(1,1)	
	CONSTRAINT PK_Aluno PRIMARY KEY,
	DataMatricula date not null,
	DataFinal date not null,
	CodTurma smallint not null
	CONSTRAINT FK_Aluno_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	CodDados smallint
	CONSTRAINT FK_Aluno_Dados FOREIGN KEY REFERENCES tbDadosComuns(CodDados),
	CodLogin smallint not null
	CONSTRAINT FK_Aluno_Login FOREIGN KEY REFERENCES tbLogin(CodLogin),
	SituacaoMensalidade bit not null DEFAULT 0 --1 PAGO, 0 NÃO PAGO
);
GO

--APAGUEI A TABELA MENSALIDADE

CREATE TABLE tbPagamento(
	CodPagamento smallint identity(1,1)
	CONSTRAINT PK_Pagamento PRIMARY KEY,
	DiaPagamento date not null,
	ValorLiquido money not null,
	Descontos money not null DEFAULT 0.00,
	Bônus money not null DEFAULT 0.00, 
	StatusPagamento char(1) not null DEFAULT 'N', -- P-Pago, N-Não Pago
	CodProfessor smallint not null
	CONSTRAINT FK_Pagamento_Professor FOREIGN KEY REFERENCES tbProfessor(CodProf)
);
GO

CREATE TABLE tbAula_Aluno(
	CodAula smallint not null
	CONSTRAINT FK_AulaAluno_Aula FOREIGN KEY REFERENCES tbAula(CodAula),
	CodAluno smallint not null
	CONSTRAINT FK_AulaAluno_Aluno FOREIGN KEY REFERENCES tbAluno(CodAluno),
	CONSTRAINT PK_AulaAluno PRIMARY KEY CLUSTERED(CodAula, CodAluno),
	Presenca bit --1 presente, 0 ausente
);
GO

CREATE TABLE tbAvaliacao(
	CodAvaliacao smallint identity(1,1)
	CONSTRAINT PK_Avaliacao PRIMARY KEY,
	CodProfessor smallint not null
	CONSTRAINT FK_Avaliacao_Professor FOREIGN KEY REFERENCES tbProfessor(CodProf),
	DataAvaliacao date not null,
	CodTurma smallint not null
	CONSTRAINT FK_Avaliacao_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	Descricao varchar(100) --MUDEI O TAMANHO
);
GO

CREATE TABLE tbNota(
	CodAluno smallint not null
	CONSTRAINT FK_Nota_Aluno FOREIGN KEY REFERENCES tbAluno(CodAluno),
	CodAvaliacao smallint not null
	CONSTRAINT FK_Nota_Avaliacao FOREIGN KEY REFERENCES tbAvaliacao(CodAvaliacao),
	Nota decimal(4,2) not null,
	CONSTRAINT PK_Nota PRIMARY KEY CLUSTERED(CodAluno, CodAvaliacao) 
);
GO
