using System;
using System.Xml;

namespace XMLReaderDemo
{
    class XMLReaderDemo
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create(@"..\..\..\pets.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "pet"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("type") + ": " + xmlReader.GetAttribute("age"));
                }
            }
        }
    }
}
