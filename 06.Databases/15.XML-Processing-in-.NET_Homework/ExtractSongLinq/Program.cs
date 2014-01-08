using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Linq;


namespace ExtractSongLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xml = XDocument.Load("../../catalogue.xml");
            var songs =
                from song in xml.Descendants("song")
                select new
                    {
                        Title =song.Element("title").Value
                    };

            foreach (var song in songs)
            {
                Console.WriteLine("Song Title {0}", song.Title);
            }
        }
    }
}
