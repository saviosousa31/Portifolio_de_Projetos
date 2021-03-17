CREATE DATABASE bd_autoescola_turmaA;

USE bd_autoescola_turmaA;

CREATE TABLE Pessoa(
	cpf VARCHAR(11) NOT NULL, nome VARCHAR(50) NOT NULL, telres INT(12), telcel INT(13) NOT NULL,
	rua VARCHAR(50) NOT NULL, numero VARCHAR(10) NOT NULL, bairro VARCHAR(50) NOT NULL, cidade VARCHAR(50) NOT NULL,
	PRIMARY KEY(cpf)
);

DESC Pessoa;

CREATE TABLE Aluno(
	codAluno INT NOT NULL AUTO_INCREMENT, dtIngresso DATE NOT NULL, dtNascimento DATE NOT NULL, cpf VARCHAR(11) NOT NULL,
	PRIMARY KEY(codAluno),
	CONSTRAINT fk_aluno_pessoa FOREIGN KEY(cpf) REFERENCES Pessoa(cpf) 					
);

DESC aluno;

CREATE TABLE Instrutor(
	codInstrutor INT NOT NULL AUTO_INCREMENT, dtAdimissao DATE NOT NULL, dtDemissao DATE,
	salario FLOAT, cpf VARCHAR(11) NOT NULL,
	PRIMARY KEY(codInstrutor),
	CONSTRAINT fk_instrutor_pessoa FOREIGN KEY(cpf) REFERENCES Pessoa(cpf)
);

DESC Instrutor;

CREATE TABLE Automovel(
	codAutomovel INT NOT NULL AUTO_INCREMENT, tipo VARCHAR(20) NOT NULL, placa VARCHAR(8) NOT NULL, 
	marca VARCHAR(20) NOT NULL, modelo VARCHAR(20) NOT NULL,	ano INT(4) NOT NULL,
	PRIMARY KEY (codAutomovel)
);

DESC Automovel;

CREATE TABLE Aula(
	codAula INT NOT NULL AUTO_INCREMENT, dtAula DATE NOT NULL, horarioInicio TIME, horarioTermino TIME,
	codAluno INT NOT NULL, codInstrutor INT NOT NULL, codAutomovel INT NOT NULL,
	PRIMARY KEY(codAula),
	CONSTRAINT fk_aula_aluno FOREIGN KEY(codAluno) REFERENCES Aluno(codAluno),
	CONSTRAINT fk_aula_instrutor FOREIGN KEY(codInstrutor) REFERENCES Instrutor(codInstrutor),
	CONSTRAINT fk_aula_automovel FOREIGN KEY(codAutomovel) REFERENCES Automovel(codAutomovel)
);

DESC aula;

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("11111111111", "Savio", 32140000, 99990000, "Rua A", "10", "centro", "passos");

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("22222222222", "Christopher", 32141111, 99991111, "Rua B", "20", "cohab v", "passos");

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("33333333333", "Ratin", 32142222, 99992222, "Rua C", "30", "penha", "passos");

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("44444444444", "Duardo", 32143333, 99993333, "Rua D", "40", "aclimacao", "passos");

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("55555555555", "Pedrao", 32144444, 99994444, "Rua E", "50", "polivalente", "passos");

INSERT INTO Pessoa (cpf, nome, telres, telcel, rua, numero, bairro, cidade)
VALUES ("66666666666", "Giovani", 32145555, 99995555, "Rua F", "60", "exposicao", "passos");

SELECT * FROM Pessoa;

DESC Aluno;

INSERT INTO Aluno ( dtIngresso, dtNascimento, cpf )
VALUES ("2020-09-22", "2001-01-31", "11111111111");

INSERT INTO Aluno ( dtIngresso, dtNascimento, cpf )
VALUES ("2020-09-22", "2000-07-23", "22222222222");

INSERT INTO Aluno ( dtIngresso, dtNascimento, cpf )
VALUES ("2020-09-22", "2001-06-19", "33333333333");

select * from aluno;

DESC Instrutor;

INSERT INTO Instrutor (dtAdimissao, dtDemissao, cpf)
VALUES ("2020-01-22","2020-09-24",  "44444444444");

INSERT INTO Instrutor (dtAdimissao, dtDemissao, cpf)
VALUES ("2020-04-12","2020-09-24",  "55555555555");

INSERT INTO Instrutor (dtAdimissao, dtDemissao, cpf)
VALUES ("2020-06-19","2020-09-24",  "66666666666");

select * from instrutor;

DESC Automovel;

INSERT INTO Automovel (tipo, placa, marca, modelo, ano)
VALUES ("carro", "HAD1444", "fiat", "siena", 2010);

INSERT INTO Automovel (tipo, placa, marca, modelo, ano)
VALUES ("carro", "AOP9876", "volkswagem", "gol", 2006);

INSERT INTO Automovel (tipo, placa, marca, modelo, ano)
VALUES ("moto", "KAL3129", "honda", "cg", 2007);

select * from Automovel;

DESC Aula;

SELECT codAluno FROM aluno;
SELECT codInstrutor FROM Instrutor;
SELECT codAutomovel FROM Automovel;

INSERT INTO Aula (dtAula, horarioInicio, horarioTermino, codAluno, codInstrutor, codAutomovel)
VALUES("2020-10-22", "16:00:00", "17:00:00", 1, 1, 1);  

INSERT INTO Aula (dtAula, horarioInicio, horarioTermino, codAluno, codInstrutor, codAutomovel)
VALUES("2020-10-23", "17:30:00", "18:30:00", 2, 2, 2); 

INSERT INTO Aula (dtAula, horarioInicio, horarioTermino, codAluno, codInstrutor, codAutomovel)
VALUES("2020-10-24", "19:00:00", "20:00:00", 3, 3, 3); 

SELECT * from Aula;

SELECT * from pessoa;

SELECT * from automovel;

SELECT * from Aula
WHERE codInstrutor = 1;

SELECT * from Aula
WHERE codInstrutor = 2;

SELECT * from Aula
WHERE codInstrutor = 3;
