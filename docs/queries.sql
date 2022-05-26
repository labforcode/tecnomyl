-- A) Fa�a uma consulta SQL que retorne a soma dos sal�rios dos funcion�rios agrupados por empresa.

SELECT f.codigo_empresa AS CodigoEmpresa,
       SUM(f.salario)   AS Salario
FROM funcionarios AS f
GROUP BY f.codigo_empresa;


-- B) Fa�a uma consulta SQL que retorne o nome das empresas que possuem mais de 30 funcion�rios.

SELECT e.descricao AS Descri��o
FROM empresas AS e
         INNER JOIN funcionarios AS f ON (e.codigo = f.codigo_empresa)
GROUP BY e.descricao
HAVING SUM(f.codigo_empresa) > 30;

-- C) Fa�a uma consulta SQL que retorne o nome do funcion�rio, o c�digo e a descri��o do centro de custos e o c�digo e a descri��o do seu cargo.

SELECT f.nome       AS Nome,
       cc.codigo    AS Codigo,
       cc.descricao AS Descri��o
FROM funcionarios AS f
         INNER JOIN centro_de_custos AS cc ON (f.codigo_centro_custos = cc.codigo);


-- D) Fa�a uma consulta SQL que retorne todos os funcion�rios que n�o possuem dependentes.

SELECT f.codigo_empresa       AS CodigoEmpresa,
       f.codigo               AS Codigo,
       f.nome                 AS Nome,
       f.salario              AS Sal�rio,
       f.codigo_cargo         AS CodigoCargo,
       f.codigo_centro_custos AS CodigoCentroCustos
FROM funcionarios AS f
WHERE codigo NOT IN (SELECT codigo_funcionario
                     FROM dependentes AS d);

