USE master;
GO


IF DB_ID('dbLIGMA') is not null DROP DATABASE dbLIGMA;
GO

CREATE DATABASE dbLIGMA;
GO

USE dbLIGMA;
GO

CREATE TABLE tbDadosComuns (
	CEP char(8),
	Numero smallint,
<<<<<<< HEAD
	CONSTRAINT PK_Endereco PRIMARY KEY CLUSTERED(CEP, Numero),
=======
	Nome varchar(75) not null,
	CodDados smallint identity(1,1)
	CONSTRAINT PK_DadosComuns PRIMARY KEY,
>>>>>>> 76f55a7229af8da09840f8af41d42d734559f168
	Complemento varchar(30) not null,
	Cidade varchar(25) not null,
	UF char(2) not null,
	Logradouro varchar(10) not null,
	TelFixo decimal(8),
	TelCelular decimal(9),
	DataNasc date not null,
	RG char(10) not null,
	CPF decimal(11) not null
	CONSTRAINT UK_Func_CPF UNIQUE(CPF),
	);
GO

CREATE TABLE tbLogin (
	CodLogin smallint identity(1,1)
	CONSTRAINT PK_Login PRIMARY KEY,
	Senha varchar(20) not null,
	Email varchar(50) not null
	CONSTRAINT UK_Login_Email UNIQUE,
	Ativada bit not null default 1 --1 pra verdadeiro 0 pra falso
	
	);
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
<<<<<<< HEAD
							  ('Terça'),
							  ('Quarta'),
							  ('Quinta'),
							  ('Sexta'),
							  ('Sábado'),
							  ('Domingo'); 
=======
			      ('Terça'),
			      ('Quarta'),
			      ('Quinta'),
			      ('Sexta'),
			      ('Sábado'),
			      ('Domingo'); --adicionei isso
>>>>>>> f1a4e3095f32ec167a0cee5d28dbbdb09941f79d
GO

CREATE TABLE tbPeriodo(
	CodPeriodo smallint identity(1,1)
	CONSTRAINT PK_Periodo PRIMARY KEY,
	NomePeriodo varchar(30) not null -- TIREI DA TABELA PERIODO AS HORAS
);
GO

CREATE TABLE tbPeriodo_DiaSemana(
	CodPeriodoDiaSemana smallint identity(1,1)
	CONSTRAINT PK_PeriodoDiaSemana PRIMARY KEY,
	CodPeriodo smallint not null
	CONSTRAINT FK_PeriodoDiaSemana_Periodo FOREIGN KEY REFERENCES tbPeriodo(CodPeriodo),
	CodDiaSemana smallint not null
<<<<<<< HEAD
	CONSTRAINT FK_PeriodoDiaSemana_DiaSemana FOREIGN KEY REFERENCES tbDiaSemana(CodDiaSemana) --MUDEI A CHAVE
=======
	CONSTRAINT FK_PeriodoDiaSemana_DiaSemana FOREIGN KEY REFERENCES tbDiaSemana(CodDiaSemana)
>>>>>>> f1a4e3095f32ec167a0cee5d28dbbdb09941f79d
);
GO

CREATE TABLE tbCurso (
	CodCurso smallint identity(1,1)
	CONSTRAINT PK_Curso PRIMARY KEY,
	Idioma varchar(15) not null,
	TempoTotal int not null
);
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
	Preço money not null --adicionei isso
);
GO

CREATE TABLE tbAula(
	CodAula smallint identity(1,1)
	CONSTRAINT PK_Aula PRIMARY KEY,
	Sala smallint not null,
	Data_Hora datetime not null,
	CodTurma smallint not null
	CONSTRAINT FK_Aula_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma) --Adicionei código turma
);

CREATE TABLE tbAluno(
	CodAluno smallint identity(1,1)	
	CONSTRAINT PK_Aluno PRIMARY KEY,
	DataMatricula date not null,
	DataFinal date not null,
	CodTurma smallint not null
	CONSTRAINT FK_Aluno_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	CodDados smallint
	CONSTRAINT FK_Aluno_dados FOREIGN KEY REFERENCES tbDadosComuns(CodDados)
);
GO

CREATE TABLE tbMensalidade(
	CodMensalidade smallint identity(1,1)
	CONSTRAINT PK_Mensalidade PRIMARY KEY,
	DiaPagamento date not null,
	Valor money not null,
	MetodoPagamento varchar(8) not null, 
	StatusPagamento char(1) not null, -- P-Pago, A-Atrasado, N-Não Pago
	CodAluno smallint not null
	CONSTRAINT FK_Mensalidade_Aluno FOREIGN KEY REFERENCES tbAluno(CodAluno)
);
GO

CREATE TABLE tbPagamento(
	CodPagamento smallint identity(1,1)
	CONSTRAINT PK_Pagamento PRIMARY KEY,
	DiaPagamento date not null,
	ValorLiquido money not null,
	Descontos money not null DEFAULT 0.00,
	Bônus money not null DEFAULT 0.00, 
	StatusPagamento char(1) not null, -- P-Pago, N-Não Pago
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
	DataAvalicao date not null,
	CodTurma smallint not null
	CONSTRAINT FK_Avaliacao_Turma FOREIGN KEY REFERENCES tbTurma(CodTurma),
	Descricao varchar(75) 
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
