SELECT
    Aggr.Id,
    Aggr.ModeloVeiculo,
    Aggr.TotalDeSegundos,
    CAST(Aggr.TotalDeSegundos / 3600 AS VARCHAR) + ':' +
    CAST((Aggr.TotalDeSegundos % 3600) / 60 AS VARCHAR) + ':' +
    CAST((Aggr.TotalDeSegundos % 60) AS VARCHAR) AS 'HH:MM:SS'
FROM
(
    SELECT
        Id,
        ModeloVeiculo,
        ISNULL(DATEDIFF(SECOND,DataEntradaManutencao,DataSaidaManutencao),0) TotalDeSegundos
    FROM
        @ManutencaoVeiculos
)
AS
    Aggr