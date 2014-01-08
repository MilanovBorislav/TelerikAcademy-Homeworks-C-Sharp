using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace _07.CreateXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "../../Person.txt";

            var filestream = new FileStream(fileName,
                                FileMode.Open,
                                FileAccess.Read,
                                FileShare.ReadWrite);
            var fileReader = new StreamReader(filestream, Encoding.UTF8, true, 128);

            XElement person = new XElement("persons");
            string name = "";
            string address = "";

            using (fileReader)
            {
                string line;
                int count = 1;

                while ((line = fileReader.ReadLine()) != null)
                {
                    if (count % 3 == 1)
                    {
                        name = line;
                    }
                    else if (count % 3 == 2)
                    {
                        address = line;
                    }
                    else
                    {
                        var phone = line;

                        person.Add(new XElement("person",
                           new XElement("name", name),
                           new XElement("address", address),
                           new XElement("phone", phone)
                    ));
                    }
                    count++;
                }
            }
            System.Console.WriteLine(person);
            person.Save("../../person.xml");
        }
    }
}
