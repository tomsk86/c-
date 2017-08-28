using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatME
{
    class IntroduceYourself
    {
        private string name;
        private int colorIndex, sign;
        private char pawnPattern;
        public readonly List<ConsoleColor> WhichColor = new List<ConsoleColor>();
        public readonly List<char> WhichPawn = new List<char>();
        Messages message = new Messages();

        public IntroduceYourself()
        {
            WhichColor = new List<ConsoleColor> { ConsoleColor.Gray, ConsoleColor.Cyan, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Green };
            WhichPawn = new List<char> { (char)(1), (char)(3), (char)(14), (char)(4) };
        }

        public void Color()
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("Choose color of your name and pawn");
            WhichColor.ForEach(color =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine("{0} - {1}", WhichColor.IndexOf(color), Enum.GetName(typeof(ConsoleColor), color));
            });
            Console.ResetColor();
            Console.WriteLine();

            while (true)
            {
                try { colorIndex = int.Parse(Console.ReadLine()); }
                catch { Console.WriteLine("Wrong value. Try again."); continue; }
                if (colorIndex >= 0 && colorIndex < WhichColor.Count) break;
                else
                {
                    System.Console.WriteLine("Wrong value. Try again");
                }
            }

            Console.WriteLine();
        }
        public void GetColor()
        {
            int i = colorIndex;
            Console.ForegroundColor = WhichColor[i];
        }
        public void Name()
        {
            Console.Write("What's your name? ");
            GetColor();
            name = Console.ReadLine();
            Console.WriteLine();
            Console.ResetColor();
        }
        public void GetNameInColor()
        {
            GetColor();
            Console.WriteLine(name);
            Console.ResetColor();
        }
        public string GetName()
        {
            return name;
        }
        public void Sign()
        {
            Console.WriteLine("Choose pattern of your pawn");

            for (int i = 0; i<WhichPawn.Count; i++)
            {
                Console.Write(i + " - "); GetColor(); Console.WriteLine(WhichPawn[i]); Console.ResetColor();
            }

            Console.WriteLine();

            while (true)
            {
                try { sign = int.Parse(Console.ReadLine()); }
                catch { Console.WriteLine("Wrong value. Try again."); continue; }
                if (sign >= 0 && sign < WhichPawn.Count) break;
                else
                {
                    System.Console.WriteLine("Wrong value. Try again");
                }
            }

            if (sign == 0) pawnPattern = (char)(1);
            if (sign == 1) pawnPattern = (char)(3);
            if (sign == 2) pawnPattern = (char)(14);
            if (sign == 3) pawnPattern = (char)(4);

            Console.Clear();
        }
        public char GetPawnPattern()
        {
            return pawnPattern;
        }
        public void GetPawnPatternInColor()
        {
            GetColor();
            Console.WriteLine(pawnPattern);
            Console.ResetColor();
        }
    }
}
