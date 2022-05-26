-- A) Faça uma consulta SQL que retorne a soma dos salários dos funcionários agrupados por empresa.

SELECT f.codigo_empresa AS CodigoEmpresa,
       SUM(f.salario)   AS Salario
FROM funcionarios AS f
GROUP BY f.codigo_empresa;


-- B) Faça uma consulta SQL que retorne o nome das empresas que possuem mais de 30 funcionários.

SELECT e.descricao AS Descrição
FROM empresas AS e
         INNER JOIN funcionarios AS f ON (e.codigo = f.codigo_empresa)
GROUP BY e.descricao
HAVING SUM(f.codigo_empresa) > 30;

-- C) Faça uma consulta SQL que retorne o nome do funcionário, o código e a descrição do centro de custos e o código e a descrição do seu cargo.

SELECT f.nome       AS Nome,
       cc.codigo    AS Codigo,
       cc.descricao AS Descrição
FROM funcionarios AS f
         INNER JOIN centro_de_custos AS cc ON (f.codigo_centro_custos = cc.codigo);


-- D) Faça uma consulta SQL que retorne todos os funcionários que não possuem dependentes.

SELECT f.codigo_empresa       AS CodigoEmpresa,
       f.codigo               AS Codigo,
       f.nome                 AS Nome,
       f.salario              AS Salário,
       f.codigo_cargo         AS CodigoCargo,
       f.codigo_centro_custos AS CodigoCentroCustos
FROM funcionarios AS f
WHERE codigo NOT IN (SELECT codigo_funcionario
                     FROM dependentes AS d);

