-- 1: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create procedure proc_qteFuncionarios(tipo integer) select count(situacao) as vQte from funcionario 
where funcionario.situacao = tipo;

call proc_qteFuncionarios(0); -- testar procedimento

-- 2: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- FUNÇAO DE VALIDAÇÃO DE CPF OBTIDA DO CHAT DAS AULAS
DELIMITER $
CREATE FUNCTION func_validaCPF(cpf varchar(14)) RETURNS REAL BEGIN
DECLARE contador INT DEFAULT 1; DECLARE contador2 INT DEFAULT 10; DECLARE verifica INT DEFAULT 2; DECLARE soma INT DEFAULT 0;
DECLARE n1 INT DEFAULT 0; DECLARE n2 INT DEFAULT 0; DECLARE passo int; set cpf = replace(cpf,'.',''); set cpf = replace(cpf,'-','');
set cpf = replace(cpf,' ',''); set cpf = trim(cpf); WHILE verifica = 2 DO SET contador = contador + 1;
IF SUBSTRING(cpf, 1, 1) != SUBSTRING(cpf, contador, 1) THEN SET verifica = 1; END IF; IF CONTADOR = 11 THEN SET verifica = 0;
END IF; END WHILE; SET contador = 0; IF verifica = 1 THEN WHILE contador < 9 DO SET contador = contador + 1; 
SET soma = soma + (SUBSTRING(cpf, contador, 1) * contador2); SET contador2 = contador2 - 1; END WHILE; SET n1 = 11 - (soma % 11); 
IF n1 > 9 THEN SET n1 = 0; END IF; SET contador = 1; SET contador2 = 11; SET soma = 0; WHILE contador < 11 DO 
SET soma = soma + (SUBSTRING(cpf, contador, 1) * contador2);  SET contador = contador + 1; SET contador2 = contador2 - 1; END WHILE; 
SET n2 = 11 - (soma % 11); IF n2 > 9 THEN SET n2 = 0; END IF; IF n1 = SUBSTRING(cpf, 10, 1) AND n2 = SUBSTRING(cpf,11,1) THEN 
SET verifica = 1; ELSE SET verifica = 0; END IF; END IF; IF verifica = 1 THEN RETURN 1; ELSE RETURN 0; END IF ;
END$ DELIMITER ;

create procedure proc_qteFuncionariosCPFinv() select count(*) as vQte from funcionario join pessoa
on funcionario.idpessoa = pessoa.id where func_validaCPF(pessoa.cpf) = 0;
call proc_qteFuncionariosCPFinv(); -- testar procedimento

-- 3: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create function func_qteFuncionarioSexo(sexo INTEGER) returns int 
return (select count(*) from funcionario join pessoa 
on pessoa.sexo = sexo and pessoa.id = funcionario.idpessoa and funcionario.situacao = 0);

SELECT func_qteFuncionarioSexo(0) vQte; -- testar função

-- 4: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create function  func_salarioMedio() returns double 
return (select avg(salario) from funcionario 
where funcionario.situacao = 0);

SELECT func_salarioMedio() vSalarioMedio; -- testar função

-- 5: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create function func_folhaPagtoDepartamento(iddepartamento INTEGER) returns double
return (select sum(salario) from funcionario join cargo on funcionario.idcargo = cargo.id 
join departamento on cargo.iddepartamento = departamento.id and iddepartamento = departamento.id and funcionario.situacao = 0);

SELECT func_folhaPagtoDepartamento(2) vSalario; -- testar função

-- 6: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create function func_salarioMedioDepartamento(iddepartamento INTEGER) returns double
return (select avg(salario) from funcionario join cargo on funcionario.idcargo = cargo.id 
join departamento on cargo.iddepartamento = departamento.id and iddepartamento = departamento.id and funcionario.situacao = 0);

SELECT func_salarioMedioDepartamento(2) vSalario; -- testar função

-- 7: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
create function func_idade(dt_nascimento DATETIME) returns int return (select timestampdiff(year, dt_nascimento, now()));

create function func_mediaIdadeDepartamento(iddepartamento INTEGER) returns double 
return (select avg(idade) from (select func_idade(pessoa.dtnascimento) as idade from pessoa 
join funcionario on funcionario.idpessoa = pessoa.id and funcionario.situacao = 0 
join cargo on funcionario.idcargo = cargo.id 
join departamento on iddepartamento = departamento.id and cargo.iddepartamento = departamento.id)
as idade);

SELECT func_mediaIdadeDepartamento(2) vMedia; -- testar função

-- 8: --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
delimiter $
create trigger trg_reajusteCargo after update on cargo for each row 
begin 
declare porcentagem double;
set porcentagem = (new.salariomedio * 100) / old.salariomedio;
update funcionario join cargo set salariotemp = (salario * (porcentagem/100)) where funcionario.idcargo = cargo.id;
end $
delimiter ;

create function func_somaSalarioTemp() returns double 
return (select sum(salariotemp) from funcionario 
where funcionario.situacao = 0);

SELECT func_somaSalarioTemp() vSoma; -- testar função

 /* CARGOS PADRÃO:
 (1,1,'SUPORTE NÍVEL 1',2000),
 (2,1,'SUPORTE NÍVEL 2',2500),
 (3,1,'SUPORTE NÍVEL 3',3000),
 (4,2,'ANALISTA JR',3500),
 (5,2,'ANALISTA PL',4500),
 (6,2,'ANALISTA SR',5500),
 (7,1,'GERENTE',5500),
 (8,2,'GERENTE',7500),
 (9,3,'GERENTE',6500); */