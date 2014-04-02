//Declarando uma nova instancia XmlDocument
XmlDocument xmlDocument = new XmlDocument();

//1º exemplo --------------------------------------------------------------

//Carregando XML do disco rigido
xmlDocument.Load(@"C:\ArquivoSuperPesado.xml");

Console.WriteLine("Recuperando todos os elementos Pedido e exibindo o seu respectivo id");

foreach (XmlNode xmlNode in xmlDocument.GetElementsByTagName("Pedido"))
    Console.WriteLine("Id do Pedido: {0}", xmlNode.Attributes["IdPedido"].Value);

Console.WriteLine();

//2º exemplo --------------------------------------------------------------

Console.WriteLine("Recuperando os elementos cuja tagname é igual a Pedido ou Preço");

foreach (XmlNode xmlNode in xmlDocument.SelectNodes("//Preco | //Pedido"))
{
    Console.Write("Tipo: {0}\t Nome: {1}\t Atributo: ", xmlNode.NodeType, xmlNode.Name);

    foreach (XmlAttribute attr in xmlNode.Attributes)
        Console.Write("{0}={1} ", attr.Name, attr.Value);

    Console.WriteLine();
}

Console.WriteLine();

//3º exemplo --------------------------------------------------------------

Console.WriteLine("Somando o preço de todos os itens do pedido cujo o Id é 1");

string xpathWithFunction = "sum(//Pedido[@IdPedido='1']/ItensDoPedido/Item/Preco)";

//Usando de uma função XPath
object result = xmlDocument.CreateNavigator().Evaluate(xpathWithFunction);

Console.WriteLine(Convert.ToDecimal(result));