using System;
using System.Xml;

namespace XMLPathDemo
{
    class XMLPathDemo
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"..\..\..\test-doc.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("/users/user");
            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value);
                userNode.Attributes["age"].Value = (age + 10).ToString();
            }
            xmlDoc.Save(@"..\..\..\test-doc.xml");
        }

    }
}
