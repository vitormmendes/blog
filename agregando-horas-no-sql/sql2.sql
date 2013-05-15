SELECT
    *
FROM
(
    SELECT
        Id,
        ModeloVeiculo ,
        DataEntradaManutencao,
        DataSaidaManutencao,
        ISNULL(DATEDIFF(SECOND,DataEntradaManutencao,DataSaidaManutencao),0) TotalDeSegundos
    FROM
        @ManutencaoVeiculos
)
AS
    Aggr