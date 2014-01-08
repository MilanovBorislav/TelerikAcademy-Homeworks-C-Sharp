using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PetsShop
{
    public class Shop
    {
        public string Name { get; protected set; }

        public string Address { get; protected set; }

        public string Phone { get; protected set; }

        public Shop(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        private static List<Animal> allAnimals = new List<Animal>(); // list with all animals
        private static List<Animal> soldAnimals = new List<Animal>(); // list of sold pets

        public List<Animal> AllAnimals
        {
            get
            {
                return allAnimals;
            }
        }

        public static List<Animal> SoldAnimals
        {
            get
            {
                return SoldAnimals;
            }
        }

        public override string ToString()
        {
            return String.Format("Pets Shop: {0}\nAddress: {1}; Phone of Shop: {2}", this.Name, this.Address, this.Phone);
        }

        public void ReadAllAnimals()
        {
            string fileName = "../../ListOfAnimalsInShop.txt";
            StreamReader strR = new StreamReader(fileName);
            using (strR)
            {
                string line = strR.ReadLine();
                while (line != null)
                {
                    string[] array = line.Split(',');
                    switch (array[6])
                    {
                        case "Parrot":
                            allAnimals.Add(new Parrot(array[0], Int32.Parse(array[1]), (array[2].Equals(Sex.Male)) ? Sex.Male : Sex.Female,
                                array[3], Int32.Parse(array[4]), Decimal.Parse(array[5]), array[6], short.Parse(array[7])));
                            
                            break;
                        case "Cat":
                            allAnimals.Add(new Cat(array[0], Int32.Parse(array[1]), (array[2].Equals(Sex.Male)) ? Sex.Male : Sex.Female,
                                array[3], Int32.Parse(array[4]), Decimal.Parse(array[5]), array[6], short.Parse(array[7])));
                            
                            break;
                        case "Fish":
                            allAnimals.Add(new Fish(array[0], Int32.Parse(array[1]), (array[2].Equals(Sex.Male)) ? Sex.Male : Sex.Female,
                                array[3], Int32.Parse(array[4]), Decimal.Parse(array[5]), array[6], short.Parse(array[7])));
                            
                            break;
                        case "Dog":
                            allAnimals.Add(new Dog(array[0], Int32.Parse(array[1]), (array[2].Equals(Sex.Male)) ? Sex.Male : Sex.Female,
                                array[3], Int32.Parse(array[4]), Decimal.Parse(array[5]),array[6], short.Parse(array[7])));
                           
                            break;
                        default:
                            break;
                    }
                    line = strR.ReadLine();
                }
            }
        }

        public void PrintAllAnimals()
        {
            foreach (var item in allAnimals)
            {
                StringBuilder strB = new StringBuilder();
                strB.AppendLine(item.ToString() + String.Format("Sound: {0}; Movement: {1}", item.MakeSound(), item.MakeMovement()));
                Console.WriteLine(strB.ToString());
            }
        }
    }
}