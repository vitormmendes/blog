using (XmlReader xmlReader = new XmlTextReader(@"C:\XmlDocumentTest.xml"))
{
    while (xmlReader.Read())
    {
        switch (xmlReader.NodeType)
        {
            case XmlNodeType.XmlDeclaration:
                Console.WriteLine("Declaração: {0} - {1}", xmlReader.Name, xmlReader.Value);
                break;
            case XmlNodeType.Element:
            case XmlNodeType.Comment:
                Console.WriteLine("Elemento: {0} - {1}", xmlReader.Name, xmlReader.Value);
                break;
            case XmlNodeType.Text:
                Console.WriteLine("Texto: {0}", xmlReader.Value);
                break;
        }

        if (xmlReader.HasAttributes)
        {
            while (xmlReader.MoveToNextAttribute())
            {
                Console.WriteLine("Atributo: {0} - {1}", xmlReader.Name, xmlReader.Value);
            }
        }
    }
}