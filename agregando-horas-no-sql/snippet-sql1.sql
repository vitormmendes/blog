SET DATEFORMAT DMY

DECLARE @ManutencaoVeiculos TABLE
(
    Id INT IDENTITY(40,1),
    ModeloVeiculo VARCHAR(50),
    DataEntradaManutencao DATETIME,
    DataSaidaManutencao DATETIME
)

INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoAAA','01/09/2012 15:03', '02/09/2012 09:00')
INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoBBB','03/09/2012 11:21', '03/09/2012 12:00')
INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoCCC','01/09/2012 08:01', '02/09/2012 09:05')
INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoDDD','10/09/2012 18:48', '21/09/2012 09:00')
INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoAAA','01/09/2012 15:03', NULL)
INSERT INTO @ManutencaoVeiculos VALUES
    ('VeiculoDDD','23/09/2012 10:20', '29/09/2012 08:50')