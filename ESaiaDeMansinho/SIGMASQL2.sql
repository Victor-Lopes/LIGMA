-- Geração de Modelo físico
-- Sql ANSI 2003 - brModelo.



CREATE TABLE tbEndereco (
CEP char(8),
Numero smallint,
Cidade varchar(25),
UF char(2),
Logradouro varchar(10),
Bairro varchar(25),
NomeRua varchar(30),
PRIMARY KEY(CEP,Numero)
)

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

CREATE TABLE tbFuncionario (
CodFunc smallint PRIMARY KEY,
RG char(10),
TelFixo decimal(8),
CPF decimal(11),
Nome varchar(75),
Salario money,
DataNasc date,
Celular decimal(9),
CEP char(8),
Numero smallint,
CodLogin smallint,
FOREIGN KEY(Numero,,) REFERENCES tbEndereco (CEP,Numero)
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

CREATE TABLE tbLogin (
CodLogin smallint PRIMARY KEY,
Senha varchar(20),
Email varchar(20)
)

ALTER TABLE tbAluno ADD FOREIGN KEY(CodTurma) REFERENCES tbTurma (CodTurma)
ALTER TABLE tbAluno ADD FOREIGN KEY(CodAluno) REFERENCES tbTurma (CodTurma)
ALTER TABLE tbAluno ADD FOREIGN KEY(CodLogin) REFERENCES tbLogin (CodLogin)
ALTER TABLE tbTurma ADD FOREIGN KEY(CodCurso) REFERENCES tbCurso (CodCurso)
ALTER TABLE tbAula_Aluno ADD FOREIGN KEY(CodAula) REFERENCES tbAula (CodAula)
ALTER TABLE tbAula ADD FOREIGN KEY(CodProf) REFERENCES tbProfessor (CodProf)
ALTER TABLE tbFuncionario ADD FOREIGN KEY(CodLogin) REFERENCES tbLogin (CodLogin)
