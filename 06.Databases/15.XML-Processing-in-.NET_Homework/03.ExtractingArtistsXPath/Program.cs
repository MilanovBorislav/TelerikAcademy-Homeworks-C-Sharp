using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _03.ExtractingArtistsXPath
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("../../catalogue.xml");
            XmlNode root = new XmlDocument();
            const string xPathQuery = "catalogue/album";
            var artists = new Dictionary<string, int>();
            XmlNodeList artistsXmlNodeList = xml.SelectNodes(xPathQuery);

            foreach (XmlNode artist in artistsXmlNodeList)
            {
                string artName = artist.SelectSingleNode("artist").InnerText;

                if (artists.ContainsKey(artName))
                {
                    artists[artName]++;
                }
                else
                {
                    artists.Add(artName, 1);
                }
            }

            foreach (var item in artists)
            {
                Console.WriteLine("Artist Name:{0} Number of Albums {1}", item.Key, item.Value);
            }
        }
    }
}
