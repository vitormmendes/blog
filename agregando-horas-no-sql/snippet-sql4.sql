SELECT
    Aggr.ModeloVeiculo,
    CAST(Aggr.TotalDeSegundos / 3600 AS VARCHAR) + ':' +
    CAST((Aggr.TotalDeSegundos % 3600) / 60 AS VARCHAR) + ':' +
    CAST((Aggr.TotalDeSegundos % 60) AS VARCHAR) AS 'HH:MM:SS'
FROM
(
    SELECT
        ModeloVeiculo,
        SUM(ISNULL(DATEDIFF(SECOND,DataEntradaManutencao,DataSaidaManutencao),0)) TotalDeSegundos
    FROM
        @ManutencaoVeiculos
    GROUP BY
        ModeloVeiculo

)
AS
    Aggr
ORDER BY
    2
DESC