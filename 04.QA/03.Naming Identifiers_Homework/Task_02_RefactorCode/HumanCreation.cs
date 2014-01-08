using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02_RefactorCode
{
    class HumanCreation
    {
        enum Sex { Male, Female };

        class Human
        {
            public Sex sex { get; set; }
            public string HumanName { get; set; }
            public int Age { get; set; }
        }

        public void CreateHuman(int number)
        {
            Human newHuman = new Human();
            newHuman.Age = number;
            if (number % 2 == 0)
            {
                newHuman.HumanName = "Pesho";
                newHuman.sex = Sex.Male;
            }
            else
            {
                newHuman.HumanName = "Iva";
                newHuman.sex = Sex.Female;
            }
        }

        static void Main()
        {

        }
    }
}
