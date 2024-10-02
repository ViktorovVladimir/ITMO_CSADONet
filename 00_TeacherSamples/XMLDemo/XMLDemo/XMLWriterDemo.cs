using System.Xml;

namespace XMLWriterDemo
{
    class XMLWriterDemo
    {
        static void Main(string[] args)
        {
            XmlWriter xmlWriter = XmlWriter.Create(@"..\..\..\test.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");
            
            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "14");
            xmlWriter.WriteString("Jack Daniels");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "4");
            xmlWriter.WriteString("Melanie Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}

