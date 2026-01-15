SELECT
    d.nome AS nome_departamento,
    p.nome AS nome_pessoa,
    p.salario
FROM departamento d
CROSS APPLY (
    SELECT TOP (1)
        p.nome,
        p.salario
    FROM pessoa p
    WHERE p.departamento_id = d.id
    ORDER BY p.salario DESC, p.nome
) p
ORDER BY d.nome;