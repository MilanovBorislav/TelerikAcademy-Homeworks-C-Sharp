using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsShop
{
    class MainProgram
    {
        static void Main()
        {
            //intro to project
            Introduction intro = new Introduction();  //  DOBAVI INTROTO KATO CLASS DA SE VIJDA !!!!!!!!!
            intro.IntroAnimation();

            //tests of classes and other functionality
            Shop shop = new Shop("Best Pets Shop", "Sofia, bul.Ala Bala 25", "+359 111 111 111");
            Console.WriteLine(shop.ToString() + "\n");
            shop.ReadAllAnimals();
            Console.WriteLine("List of animals in store for selling:");
            Console.WriteLine("=====================================\n");
            shop.PrintAllAnimals();
            
        }
    }
}
