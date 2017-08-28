using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatME
{
    class Messages
    {
        public void Legend()
        {
            Console.SetCursorPosition(39, 9);
            Console.Write("Menu");
            Console.SetCursorPosition(39, 11);
            Console.Write("Control:   ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((char)(16) + "   " + (char)(17) + "   " + (char)(30) + "   " + (char)(31));
            Console.SetCursorPosition(39, 12);
            Console.WriteLine("ESC");
            Console.SetCursorPosition(39, 13);
            Console.Write("F1 - ");
            Console.ResetColor();
            Console.WriteLine("NewPlayer");
            Console.SetCursorPosition(39, 14);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("F2 - ");
            Console.ResetColor();
            Console.WriteLine("BestPlayers");
            Console.SetCursorPosition(39, 15);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("F3 - ");
            Console.ResetColor();
            Console.WriteLine("ChangeBoard");
        }
        public void Attention()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(5, 18);
            Console.WriteLine("It is not a good way. Choose an another direction.");
            Console.ResetColor();
        }
        public void Logo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("█████ █████ █████   █   █ █████");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("█     █   █   █     ██ ██ █");
            Console.SetCursorPosition(35, 4);
            Console.WriteLine("███   █████   █     █████ ███");
            Console.SetCursorPosition(35, 5);
            Console.WriteLine("█     █   █   █     █ █ █ █");
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("█████ █   █   █     █ █ █ █████");
            Console.ResetColor();
        }
    }
}
