using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _04.DeleteAlbums
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../catalogue.xml");

            foreach (XmlNode xmlNode in xml.DocumentElement)
            {
                if (decimal.Parse(xmlNode["price"].InnerText)>20)
                {
                    XmlNode parent = xmlNode.ParentNode;
                    parent.RemoveChild(xmlNode);
                }
            }

            Console.WriteLine("Modified XML document:");
            Console.WriteLine(xml.OuterXml);

            xml.Save("../../catalogueNEW.xml");
        }
    }
}
