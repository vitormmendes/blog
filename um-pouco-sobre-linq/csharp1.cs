class Program
{
    static void Main()
    {

        //1º Fonte de dados
        string[] arrayNomes = new string[5]
        {
            "Roberto",
            "Aline",
            "Gustavo",
            "Leonardo",
            "Rodrigo",
        };

        //2° Criação da query
        IEnumerable<string> nomes = from nome in arrayNomes
                                    where nome.StartsWith("R")
                                    select nome;

        //3º A Execução da query
        foreach (string n in nomes)
        {
            Console.WriteLine(n);
        }
    }
}