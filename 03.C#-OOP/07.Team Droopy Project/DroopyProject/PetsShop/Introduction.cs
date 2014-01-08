using System;
using System.Threading;

namespace PetsShop
{
    class Introduction
    {
        public void IntroAnimation()
        {
            Console.Clear();
            //Console.SetCursorPosition(15, 22);
            Console.WriteLine("                              ,.  ,                       ");
            Console.WriteLine("                          .-. \\ \\  \\                   ");
            Console.WriteLine("             ,---._    _,-.> `.\\\\ (                     ");
            Console.WriteLine("            (__,'  `   `>-         -\\                    ");
            Console.WriteLine("                     ,-'             `-.                  ");
            Console.WriteLine("         ,-'       ,  ,    .       .    `.                ");
            Console.WriteLine("       ,'\\      ,' ,-'    `-.      ;    :`.              ");
            Console.WriteLine("      (__;     ,',,'      ,   `     : `. : \\             ");
            Console.WriteLine("             ,' |  _,'   /_    `    :  ; :  \\            ");
            Console.WriteLine("            /  ,',' |   /  \\       '     ;  \\           ");
            Console.WriteLine("           /   | |(o|  /  (o)          |  |    ;          ");
            Console.WriteLine("          /     ___-^-^-----.          |  |    |          ");
            Console.WriteLine("         (   ,---. `-.           :.    |       :          ");
            Console.WriteLine("          ;,'      )  `          :..   |        |         ");
            Console.WriteLine("          :\\     /              :.    |        ;         ");
            Console.WriteLine("          :.`-.__,              ,:`    |        |         ");
            Console.WriteLine("          ;`.    .             ':'      \\     ,          ");
            Console.WriteLine("         /   `-.__\\          '      ,   \\   \\.         ");
            Console.WriteLine("        (   ,'    \\`--,-----.      /     \\   \\`.       ");
            Console.WriteLine("         `-'       \\,' ,'   /    / |      \\    | `.     ");
            Console.WriteLine("                   /  '   ,'    /-.|        `.   ;   `.   ");
            Console.WriteLine("                  (      /`----'   |          `--'     `  ");
            Console.WriteLine();
            Console.WriteLine("     THIS IS Droopy Team Project: Please Press <Enter>"); Console.ReadLine();
            string text = "P E T S --- S H O P --- P R O J E C T";
            TextAnimate(text);
        }

        private void TextAnimate(string text)
        {
            Console.Clear(); 
            Console.SetCursorPosition(15, 12);
            for (int left = 0; left <= 16; left++)
            {
                Console.Clear();
                Console.SetCursorPosition(left, 12);
                Console.Write(text); Thread.Sleep(100);
            }
            //Console.WriteLine(text);
            Console.SetCursorPosition(15, 23);
            Console.WriteLine("Please press <Enter>");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
