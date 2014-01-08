using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _02.ExtractingArtists
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new  XmlDocument();
            xml.Load(@"../../catalogue.xml");
            XmlNode rootNode = xml.DocumentElement;
            Dictionary<string,int> artists = new Dictionary<string, int>();

            foreach (XmlNode node in rootNode.ChildNodes)
            {
                var artName = node["artist"].InnerText;

                if (artists.ContainsKey(artName))
                {
                    artists[artName]++;
                }
                else
                {
                    artists.Add(artName,1);    
                }
            }

            foreach (var item in artists)
            {
                Console.WriteLine("Artist Name:{0} Number of Albums {1}", item.Key, item.Value);                  
            }

            Console.WriteLine();
        }
    }
}
