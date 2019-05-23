USE master;
GO

IF DB_ID('dbLIGMA') is not null DROP DATABASE dbLIGMA;
GO

CREATE DATABASE dbLIGMA;
GO

USE dbLIGMA;
GO

CREATE TABLE tbEndereco (
	CEP char(8),
	Numero smallint,
	CONSTRAINT PK_Endereco PRIMARY KEY CLUSTERED(CEP, Numero),
	Cimplemento varchar(30) not null,
	Cidade varchar(25) not null,
	UF char(2) not null,
	Logradouro varchar(10) not null,
	Bairro varchar(25) not null,
	NomeRua varchar(30) not null
	);
GO

CREATE TABLE tbLogin (
	CodLogin smallint identity(1,1),
	CONSTRAINT PK_Login PRIMARY KEY(CodLogin),
	Senha varchar(20) not null,
	Email varchar(20) not null,
	CONSTRAINT UK_Login_Email UNIQUE(Email)
	);
GO

CREATE TABLE tbFuncionario (
	CodFunc smallint identity(1,1),
	CONSTRAINT PK_Func PRIMARY KEY(CodFunc),
	RG char(10) not null,
	TelFixo decimal(8),
	CPF decimal(11) not null,
	CONSTRAINT UK_Func_CPF UNIQUE(CPF),
	Nome varchar(75) not null,
	Salario money not null,
	DataNasc date not null,
	TelCelular decimal(9),
	CEP char(8) not null,
	Numero smallint not null,
	CodLogin smallint not null,
	CONSTRAINT FK_Func_End FOREIGN KEY(Cep, Numero) REFERENCES tbEndereco(Cep, Numero),
	CONSTRAINT FK_Func_Login FOREIGN KEY(CodLogin) REFERENCES tbLogin(CodLogin)
);
GO

CREATE TABLE tbProfessor (
	CodProf smallint identity(1,1),
	CONSTRAINT PK_Prof PRIMARY KEY(CodProf),
	Idioma varchar(15) not null,
	CodFunc smallint not null
	CONSTRAINT FK_Prof_Func FOREIGN KEY(CodFunc) REFERENCES tbFuncionario(CodFunc)
);
GO

CREATE TABLE tbTurma(
	CodTurma smallint identity(1,1),
	CONSTRAINT PK_Turma PRIMARY KEY(CodTurma),
	CodCurso smallint not null
	CONSTRAINT FK_Turma_Curso FOREIGN KEY(CodCurso) REFERENCES tbCurso(CodCurso),
	Estagio varchar(15) not null --Retirei código aula
);
GO

CREATE TABLE tbAula(
	CodAula smallint identity(1,1)
	CONSTRAINT PK_Aula PRIMARY KEY(CodAula),
	Sala smallint not null,
	Data_Hora datetime not null,
	CodProf smallint not null
	CONSTRAINT FK_Aula_Prof FOREIGN KEY REFERENCES tbProfessor(codProf),
	CodTurma smallint not null,
	CONSTRAINT FK_Aula_Turma FOREIGN KEY(CodTurma) REFERENCES tbTurma(CodTurma) --Adicionei código turma
);

CREATE TABLE tbCurso(
	CodCurso smallint identity(1,1),
	CONSTRAINT PK_Curso PRIMARY KEY(CodCurso),
	Idioma varchar(15) not null
);
GO

CREATE TABLE tbAluno(
	CodAluno smallint identity(1,1),	
	CONSTRAINT PK_Aluno PRIMARY KEY(CodAluno),
	DataNasc date not null,
	Nome varchar(150) not null,
	CPF decimal(11) not null,
	CONSTRAINT UK_Aluno_CPF UNIQUE(CPF),
	RG varchar(10) not null,
	Periodo varchar(50) not null,--Cada turma tem um periodo especifico?
	DataMatricula date not null,
	DataFinal date not null,
	TelFixo decimal(10),
	TelCel decimal(11),
	CodTurma smallint not null
	CONSTRAINT FK_Aluno_Turma FOREIGN KEY REFERENCES tbTurma(codTurma),
	CEP char(8) not null,
	Numero smallint not null,
	CONSTRAINT FK_Aluno_Endereco FOREIGN KEY(CEP, Numero) REFERENCES tbEndereco(CEP,Numero),
);
GO

CREATE TABLE tbAulaAluno(
	CodAula smallint, 
	CONSTRAINT FK_AulaAluno_Aula FOREIGN KEY(CodAula) REFERENCES tbAula(codAula),
	CodAluno smallint,
	CONSTRAINT FK_AulaAluno_Aluno FOREIGN KEY(CodAluno) REFERENCES tbAluno(codAluno),
	CONSTRAINT PK_AulaAluno PRIMARY KEY CLUSTERED(codAula, codAluno),
	Presenca bit --1 presente, 0 ausente
);
GO

CREATE TABLE tbAvaliacao(
	CodAvaliacao smallint identity(1,1)
	CONSTRAINT PK_Avaliacao PRIMARY KEY,
	CodProfessor smallint
	CONSTRAINT FK_Avaliacao_Professor FOREIGN KEY REFERENCES tbProfessor(codProfessor),
	DataAvalicao date not null,
	CodTurma smallint not null
	CONSTRAINT FK_Avaliacao_Turma FOREIGN KEY REFERENCES tbTurma(codTurma),
	Descricao varchar(75) 
);
GO

CREATE TABLE tbNota(
	CodAluno smallint identity(1,1)
	CONSTRAINT FK_Nota_Aluno FOREIGN KEY REFERENCES tbAluno(codAluno),
	CodAvaliacao smallint
	CONSTRAINT FK_Nota_Avaliacao FOREIGN KEY REFERENCES tbAvaliacao(codAvaliacao),
	Nota double not null,
	CONSTRAINT PK_Nota PRIMARY KEY CLUSTERED(CodAluno, CodAvaliacao) 
);
GO

/* 
						-----------------------COISAS ADICIONAR-----------------------

Notas
	cod aluno
	nota
	avaliação

Avaliação
	nome
	professor
	requisitos
*/


/*
CREATE TABLE tbAluno (
CodAluno smallint PRIMARY KEY,
Nome varchar(75),
Tel decimal(8),
Duracao smallint,
RG char(9),
Periodo varchar(10),
CodTurma smallint,
CPF decimal(11),
-- Erro: nome do campo duplicado nesta tabela!
CodAluno smallint,
CEP char(8),
Numero smallint,
CodLogin smallint,
FOREIGN KEY(Numero,,) REFERENCES tbEndereco (CEP,Numero)
)
CREATE TABLE tbTurma (
CodTurma smallint PRIMARY KEY,
CodCurso smallint
)
CREATE TABLE tbAula_Aluno (
CodAula smallint,
CodAluno smallint,
Presenca bit,
PRIMARY KEY(CodAula,CodAluno),
FOREIGN KEY(CodAluno) REFERENCES tbAluno (CodAluno)
)
CREATE TABLE tbAula (
CodAula smallint PRIMARY KEY,
Sala smallint,
DataHora datetime,
CodTurma smallint,
CodProf smallint,
CodAluno smallint,
FOREIGN KEY(CodTurma) REFERENCES tbTurma (CodTurma),
FOREIGN KEY(CodAluno) REFERENCES tbTurma (CodTurma)
)
CREATE TABLE tbCurso (
CodCurso smallint PRIMARY KEY,
Idioma varchar(15)
)
CREATE TABLE tbProfessor (
CodProf smallint PRIMARY KEY,
Idioma varchar(15),
CodFunc smallint,
FOREIGN KEY(CodFunc) REFERENCES tbFuncionario (CodFunc)
)
ALTER TABLE tbAluno ADD FOREIGN KEY(CodTurma) REFERENCES tbTurma (CodTurma)
ALTER TABLE tbAluno ADD FOREIGN KEY(CodAluno) REFERENCES tbTurma (CodTurma)
ALTER TABLE tbAluno ADD FOREIGN KEY(CodLogin) REFERENCES tbLogin (CodLogin)
ALTER TABLE tbTurma ADD FOREIGN KEY(CodCurso) REFERENCES tbCurso (CodCurso)
ALTER TABLE tbAula_Aluno ADD FOREIGN KEY(CodAula) REFERENCES tbAula (CodAula)
ALTER TABLE tbAula ADD FOREIGN KEY(CodProf) REFERENCES tbProfessor (CodProf)
ALTER TABLE tbFuncionario ADD FOREIGN KEY(CodLogin) REFERENCES tbLogin (CodLogin)
*/
