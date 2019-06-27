create database Teste4

use Teste4

/* Lógico : */

CREATE TABLE Aluno (
    idAluno INTEGER PRIMARY KEY IDENTITY,
    nome varchar(30),
    cpf varchar(30),
    rg varchar(30),
    endereco varchar(30),
	numero varchar(30),
	apto varchar(30),
	cep varchar(30),
    email varchar(30),
    telefone varchar(30),
	celular varchar(30),
    dataNascimenoto DATETIME,
    fk_Categoria_idCategoria INTEGER,
    fk_Time_idTime INTEGER
);

CREATE TABLE Categoria (
    idCategoria INTEGER IDENTITY PRIMARY KEY,
    descricao varchar(30)
);

CREATE TABLE Time (
    idTime INTEGER PRIMARY KEY,
    nome varchar(30),
    fk_Professor_idProfessor VARCHAR(30)
);

CREATE TABLE Competicao (
    idCompeticao INTEGER PRIMARY KEY,
    descricao varchar(30),
    dataInicio DATETIME,
    dataFinal DATETIME
);

CREATE TABLE Estadio (
    idEstadio INTEGER PRIMARY KEY,
    nome varchar(30),
    endereco varchar(30),
    telefone varchar(30),
    email varchar(30)
);

CREATE TABLE Responsavel (
    cpf INTEGER PRIMARY KEY,
    rg INTEGER,
    nome varchar(30),
    dataNascimento DATETIME,
    endereco varchar(30),
    email varchar(30),
    telefone varchar(30),
	celular varchar(30)
);

CREATE TABLE Professor (
	idProfessor Varchar(30) primary key,
	foto  VARBINARY(MAX),
    nome varchar(30),
    cpf varchar(30),
    rg varchar(30),
	estadoCivil varchar(30),
    endereco varchar(30),
	numero varchar(30),
	apto varchar(30),
	cep varchar(30),
    email varchar(30),
    telefone varchar(30),
	celular varchar(30),
    dataNascimento DATETIME,
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

create proc uspCategoriaInserir
	@descricao varchar(30)

AS 
BEGIN
	BEGIN TRY
		BEGIN TRAN

				insert into Categoria
				values (@descricao)
				declare @idCategoria as int = @@IDENTITY


			SELECT @idCategoria AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN

		SELECT ERROR_MESSAGE() AS RETORNO
	END CATCH
END

CREATE PROC uspCategoriaAlterar
	@idCategoria int,
	@descricao varchar(30)

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN 
				update Categoria
				set descricao = @descricao
				where
					idCategoria = @idCategoria
				SELECT @idCategoria AS Retorno
		COMMIT TRAN
	END TRY

	BEGIN CATCH
	SELECT ERROR_MESSAGE() AS RETORNO
	END CATCH
END


CREATE PROC uspCategoriaPesquisarTodos
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN 
				Select * from Categoria
		COMMIT TRAN
	END TRY

	BEGIN CATCH
	SELECT ERROR_MESSAGE() AS RETORNO
	END CATCH
END

CREATE PROC uspCategoriaExcluir

@idCategoria INT
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM Categoria WHERE idCategoria = @idCategoria

			select @idCategoria as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END



CREATE PROC uspFuncionarioInserir

	@idProfessor Varchar(30),
	@foto  VARBINARY(MAX),
    @nome varchar(30),
    @cpf varchar(30),
    @rg varchar(30),
	@estadoCivil varchar(30),
    @endereco varchar(30),
	@numero varchar(30),
	@apto varchar(30),
	@cep varchar(30),
    @email varchar(30),
    @telefone varchar(30),
	@celular varchar(30),
    @dataNascimento DATETIME
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			insert into Professor
			values
			(	@idProfessor ,
	@foto ,
    @nome ,
    @cpf ,
    @rg ,
	@estadoCivil ,
    @endereco ,
	@numero ,
	@apto ,
	@cep ,
    @email ,
    @telefone ,
	@celular ,
    @dataNascimento)
	SELECT @idProfessor AS Retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END

CREATE PROC uspProfessorAlterar
	@idProfessor Varchar(30),
	@foto  VARBINARY(MAX),
    @nome varchar(30),
    @cpf varchar(30),
    @rg varchar(30),
	@estadoCivil varchar(30),
    @endereco varchar(30),
	@numero varchar(30),
	@apto varchar(30),
	@cep varchar(30),
    @email varchar(30),
    @telefone varchar(30),
	@celular varchar(30),
    @dataNascimento DATETIME

AS
BEGIN
	BEGIN TRY
		BEGIN TRAN 
				update Professor
				set
				foto = @foto,
				cpf = @cpf,
				rg = @rg,
				nome = @nome,
				estadoCivil = @estadoCivil,
				endereco = @endereco,
				numero = @numero,
				apto = @apto,
				cep = @cep,
				email = @email,
				telefone = @telefone,
				celular = @celular,
				dataNascimento = @dataNascimento

				where idProfessor = @idProfessor

				select @idProfessor as retorno;

				
		COMMIT TRAN
	END TRY

	BEGIN CATCH
	SELECT ERROR_MESSAGE() AS RETORNO
	END CATCH
END

CREATE PROC uspProfessorPesquisarTodos
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN 
				Select * from Professor
		COMMIT TRAN
	END TRY

	BEGIN CATCH
	SELECT ERROR_MESSAGE() AS RETORNO
	END CATCH
END

CREATE PROC uspProfessorExcluir

@idProfessor Varchar(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM Professor WHERE idProfessor = @idProfessor

			select @idProfessor as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END

CREATE PROC uspTimeInserir
	@idTime INTEGER ,
    @nome varchar(30),
    @fk_Professor_idProfessor VARCHAR(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			insert into dbo.Time values
			(@idTime,@nome,@fk_Professor_idProfessor)

			select @idTime as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END
fk_Professor_idProfessor
CREATE PROC uspTimeConsultar
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			select * from Time
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END

CREATE PROC uspTimeAlterar
	@idTime INTEGER ,
    @nome varchar(30),
    @fk_Professor_idProfessor VARCHAR(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			update Time 
			set
				nome = @nome,
				fk_Professor_idProfessor = @fk_Professor_idProfessor
			where
				idTime = @idTime

			select @idTime as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END

CREATE PROC uspTimeExcluir

@idTime Varchar(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			DELETE FROM Time WHERE idTime = @idTime

			select @idTime as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END



select * from Professor


create proc uspInserirAluno
    @nome varchar(30),
    @cpf varchar(30),
    @rg varchar(30),
    @endereco varchar(30),
	@numero varchar(30),
	@apto varchar(30),
	@cep varchar(30),
    @email varchar(30),
    @telefone varchar(30),
	@celular varchar(30),
    @dataNascimenoto DATETIME,
    @fk_Categoria_idCategoria INTEGER,
	@fk_Time_idTime INTEGER,
	@cpfR INTEGER ,
    @rgR INTEGER,
    @nomeR varchar(30),
    @dataNascimentoR DATETIME,
    @enderecoR varchar(30),
    @emailR varchar(30),
    @telefoneR varchar(30),
	@celularR varchar(30)
AS
BEGIN
	BEGIN TRY
		BEGIN TRAN
			insert into Aluno
			values(@nome,@cpf,@rg,@endereco,@numero,@apto,@cep,@email,@telefone,@celular,@dataNascimenoto,@fk_Categoria_idCategoria,@fk_Time_idTime)
			declare @idAluno INT = @@IDENTITY
			insert into Responsavel
			values
			(@cpfR ,
				@rgR,
				@nomeR ,
				@dataNascimentoR ,
				@enderecoR ,
				@emailR ,
				@telefoneR ,
				@celularR 
			)
			select @idAluno as retorno
		COMMIT TRAN
	END TRY
	BEGIN CATCH
		ROLLBACK TRAN
	SELECT ERROR_MESSAGE() AS Retorno

	END CATCH
END


select * from time

select * from Professor