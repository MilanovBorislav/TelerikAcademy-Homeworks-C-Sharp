using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _09.Album
{
    class Program
    {
        private static void WriteBook(XmlWriter writer, string name, string artist)
        {
            writer.WriteStartElement("album");
            writer.WriteElementString("name", name);
            writer.WriteElementString("artist", artist);
            writer.WriteEndElement();
        }

        static void Main(string[] args)
        {
            string path = "../../album.xml";
            Encoding encoding = Encoding.GetEncoding("windows-1251");
            XmlTextWriter writer = new XmlTextWriter(path, encoding);

            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("albums");

                string name = string.Empty;

                using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element &&
                            reader.Name == "name")
                        {
                            name = reader.ReadElementString();
                        }
                        else if ((reader.NodeType == XmlNodeType.Element) &&
                                 (reader.Name == "artist"))
                        {
                            string artist = reader.ReadElementString();
                            WriteBook(writer, name, artist);
                        }
                    }
                }
                writer.WriteEndDocument();
                Console.WriteLine("Document {0} was created.", path);
            }
        }
    }
}
