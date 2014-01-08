using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taks_11_Cards
{
    class Taks_11_Cards
    {
        static void Main(string[] args)
        {
            string[] CardNumbers = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            string[] Suits = { "Spades ♠", "Hearts ♥", "Diamonds ♦", "Clubs ♣" };

            foreach(var card in CardNumbers)
            {
                foreach(var paint in Suits)
                {
                    Console.Write(" {0} ", card);
                    Console.WriteLine(" {0} ", paint);
                }
                Console.WriteLine();
            }
        }
    }
}
