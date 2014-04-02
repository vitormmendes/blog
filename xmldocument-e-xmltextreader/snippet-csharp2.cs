//Blogs
Dictionary<string, string> blogs = new Dictionary<string, string>();

blogs.Add("Fernando Henrique Ferreira", "http://ferhenriquef.com/");
blogs.Add("Eduardo Pires", "http://www.eduardopires.net.br/");
blogs.Add("Eric Milaneze", "http://www.milaneze.com.br/");

//Declarando uma nova instancia XmlDocument
XmlDocument xmlDocument = new XmlDocument();

//Criando declaração
xmlDocument.AppendChild(xmlDocument.CreateXmlDeclaration("1.0", "utf-8", null));

//Criando elemento principal
XmlElement blogsElement = xmlDocument.CreateElement("blogs");

//Adicionando ao documento xml
xmlDocument.AppendChild(blogsElement);

foreach (KeyValuePair<string, string> blog in blogs)
{
    //Criando elemento blog
    XmlElement blogElement = xmlDocument.CreateElement("blog");

    //Criando elemento autor e atribuindo autor
    XmlElement autorElement = xmlDocument.CreateElement("autor");
    autorElement.InnerText = blog.Key;

    //Criando atributo url e atribuindo url do blog
    XmlAttribute atrr = xmlDocument.CreateAttribute("url");
    atrr.Value = blog.Value;

    //Adicionando atributo ao nó blog
    blogElement.Attributes.Append(atrr);

    //Adicionando o autor ao blog
    blogElement.AppendChild(autorElement);

    //Adicionando o blog a coleção de blogs
    blogsElement.AppendChild(blogElement);
}

//Salvando xml
xmlDocument.Save(@"C:\Blogs.xml");