IEnumerable<string> nomes = from string nome in arrayNomes
                            where nome.StartsWith("R")
                            select nome;