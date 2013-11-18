List<string> nomes = (from nome in arrayNomes
                    where nome.StartsWith("R")
                    select nome).ToList();