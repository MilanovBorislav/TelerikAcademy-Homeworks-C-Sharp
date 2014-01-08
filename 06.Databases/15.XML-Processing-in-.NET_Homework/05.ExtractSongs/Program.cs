using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05.ExtractSongs
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlNodeReader.Create("../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (//(reader.NodeType == XmlNodeType.Element)&&
                         (reader.Name == "title"))              
                    {
                        Console.WriteLine(reader.ReadElementString());                        
                    }
                }
            }
        }
    }
}
