WITH RankedEmployees AS (
    SELECT 
        t1.nome AS nome_departamento,
        t0.nome AS nome_pessoa,
        t0.salario AS salario,
        ROW_NUMBER() OVER (PARTITION BY t1.nome ORDER BY t0.salario DESC, t0.nome) AS rn
    FROM pessoa t0
    INNER JOIN departamento t1 
        ON t0.departamento_id = t1.id
)
SELECT 
    nome_departamento,
    nome_pessoa,
    salario
FROM RankedEmployees
WHERE rn = 1
ORDER BY nome_departamento;