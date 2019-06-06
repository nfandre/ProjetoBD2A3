create database projetoBD

use projetoBD

/* Lógico : */

CREATE TABLE Aluno (
    idAluno INTEGER PRIMARY KEY,
    nome CHARACTER,
    cpf CHARACTER,
    rg CHARACTER,
    endereco CHARACTER,
    email CHARACTER,
    telefone CHARACTER,
	celular character,
    dataNascimenoto DATE,
    fk_Categoria_idCategoria INTEGER,
    fk_Time_idTime INTEGER
);

CREATE TABLE Categoria (
    idCategoria INTEGER PRIMARY KEY,
    descricao CHARACTER
);

CREATE TABLE Time (
    idTime INTEGER PRIMARY KEY,
    nome CHARACTER,
    fk_Professor_idProfessor INTEGER
);

CREATE TABLE Competicao (
    idCompeticao INTEGER PRIMARY KEY,
    descricao CHARACTER,
    dataInicio DATE,
    dataFinal DATE
);

CREATE TABLE Estadio (
    idEstadio INTEGER PRIMARY KEY,
    nome CHARACTER,
    endereco CHARACTER,
    telefone CHARACTER,
    email CHARACTER
);

CREATE TABLE Responsavel (
    cpf INTEGER PRIMARY KEY,
    rg INTEGER,
    nome CHARACTER,
    dataNascimento DATE,
    endereco CHARACTER,
    email CHARACTER,
    telefone CHARACTER,
	celular CHARACTER
);

CREATE TABLE Professor (
    idProfessor INTEGER PRIMARY KEY,
    cpf CHARACTER,
    rg CHARACTER,
    nome CHARACTER,
    endereco CHARACTER,
    dataNascimento DATE,
    telefone CHARACTER,
	celular CHARACTER,
    email CHARACTER
);

CREATE TABLE jogo (
    fk_Competicao_idCompeticao INTEGER,
    fk_Estadio_idEstadio INTEGER,
	dataHora datetime

);

CREATE TABLE tem (
    fk_Aluno_idAluno INTEGER,
    fk_Responsavel_cpf INTEGER
);

CREATE TABLE esta (
    fk_Time_idTime INTEGER,
    fk_Competicao_idCompeticao INTEGER
);
 
ALTER TABLE Aluno ADD CONSTRAINT FK_Aluno_2
    FOREIGN KEY (fk_Categoria_idCategoria)
    REFERENCES Categoria (idCategoria)
 
ALTER TABLE Aluno ADD CONSTRAINT FK_Aluno_3
    FOREIGN KEY (fk_Time_idTime)
    REFERENCES Time (idTime)
    ON DELETE CASCADE;
 
ALTER TABLE Time ADD CONSTRAINT FK_Time_2
    FOREIGN KEY (fk_Professor_idProfessor)
    REFERENCES Professor (idProfessor)
 
ALTER TABLE jogo ADD CONSTRAINT FK_jogo_1
    FOREIGN KEY (fk_Competicao_idCompeticao)
    REFERENCES Competicao (idCompeticao)
 
ALTER TABLE jogo ADD CONSTRAINT FK_jogo_2
    FOREIGN KEY (fk_Estadio_idEstadio)
    REFERENCES Estadio (idEstadio)
 
ALTER TABLE tem ADD CONSTRAINT FK_tem_1
    FOREIGN KEY (fk_Aluno_idAluno)
    REFERENCES Aluno (idAluno)
 
ALTER TABLE tem ADD CONSTRAINT FK_tem_2
    FOREIGN KEY (fk_Responsavel_cpf)
    REFERENCES Responsavel (cpf)
    ON DELETE SET NULL;
 
ALTER TABLE esta ADD CONSTRAINT FK_esta_1
    FOREIGN KEY (fk_Time_idTime)
    REFERENCES Time (idTime)
 
ALTER TABLE esta ADD CONSTRAINT FK_esta_2
    FOREIGN KEY (fk_Competicao_idCompeticao)
    REFERENCES Competicao (idCompeticao)
    ON DELETE SET NULL;


create proc uspInserirAluno
@IdAluno int,
    @nome CHARACTER,
    @cpf CHARACTER,
    @rg CHARACTER,
    @endereco CHARACTER,
    @email CHARACTER,
    @telefone CHARACTER,
	@celular character,
    @dataNascimenoto DATE
as
begin
insert into Aluno
values(@IdAluno,@nome,@cpf,@rg,@endereco,@email,@telefone,@celular,@dataNascimenoto)	
end