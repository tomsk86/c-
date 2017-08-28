using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace EatME
{
    class PlayTheGame
    {
        In_GameControl control = new In_GameControl();
        IntroduceYourself player = new IntroduceYourself();
        BestPlayersList bestPlayers = new BestPlayersList();
        Messages message = new Messages();
        private string time;
        bool firstPlay = true;
        bool isContinue = true;

        public void Exit()
        {
            Console.Clear();
            message.Logo();
            Console.SetCursorPosition(7, 10);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The End");
            Thread.Sleep(1000);
            isContinue = !isContinue;
        }
        public void PrepareToPlay()
        {
            bestPlayers.ReadTheFile();            
            message.Legend();
            message.Logo();
            Console.SetCursorPosition(2, 2);
            player.GetNameInColor();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            control.DisplayField();

            control.GetPlayerPositionX();
            control.GetPlayerPositionY();

            Console.SetCursorPosition(control.GetPlayerPositionX() + 14, control.GetPlayerPositionY() + 5);
            player.GetPawnPatternInColor();

            while (true)
            {
                var action = Console.ReadKey(true).Key;
                
                int prevX = control.GetPlayerPositionX();
                int prevY = control.GetPlayerPositionY();

                Console.SetCursorPosition(5, 18);
                Console.WriteLine("                                                  ");

                switch (action)
                {
                    case ConsoleKey.UpArrow: control.Up(); break;
                    case ConsoleKey.DownArrow: control.Down(); break;
                    case ConsoleKey.RightArrow: control.Right(); break;
                    case ConsoleKey.LeftArrow: control.Left(); break;
                    case ConsoleKey.F1: firstPlay = true; NewPlayer(); break;
                    case ConsoleKey.F2: bestPlayers.DisplayList(); break;
                    case ConsoleKey.F3: firstPlay = false; NewPlayer(); break; //changeBoard
                    case ConsoleKey.Escape: Exit(); return;
                    default: break;
                }

                Console.SetCursorPosition(prevX + 14, prevY + 5);
                Console.WriteLine(' ');
                Console.SetCursorPosition(control.GetPlayerPositionX() + 14, control.GetPlayerPositionY() + 5);                
                player.GetPawnPatternInColor();

                control.GetBoard()[prevY, prevX] = ' ';
                control.GetBoard()[control.GetPlayerPositionY(), control.GetPlayerPositionX()] = player.GetPawnPattern();

                if (control.HasEverythingEaten())
                {
                    control.GetBoard()[control.GetPlayerPositionY(), control.GetPlayerPositionX()] = ' ';
                    stopwatch.Stop();
                    Console.SetCursorPosition(7, 8);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("You are the Winner !! ");
                    Console.SetCursorPosition(7, 9);
                    time = stopwatch.Elapsed.ToString();
                    bestPlayers.FillTheList(player.GetName(), GetTime());
                    bestPlayers.WriteTheFile();
                    Console.WriteLine("You played for " + time);
                    Console.ResetColor();
                    return;
                }
            }
        }
        public string GetTime()
        {
            return time;
        }
        public void NewPlayer()
        {
            if (firstPlay)
            {
                Console.Clear();
                message.Logo();
                player.Color();
                player.Name();                
                player.Sign();
                control.ResetPosition();                
                PrepareToPlay();
                firstPlay = !firstPlay;
            }
            else
            {
                Console.Clear();
                control.ResetPosition();
                PrepareToPlay();
            }
        }
        public void WantPlay()
        {            
            char answer;

            message.Logo();
            while (isContinue)
            {                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(7, 5);
                Console.Write("Wanna play the Game?");
                Console.SetCursorPosition(7, 6);
                Console.Write("Yes(Y) or No(N)");
                answer = Console.ReadKey().KeyChar;
                Console.ResetColor();

                switch (answer)
                {
                    case 'y': //121
                    case 'Y': NewPlayer(); break; //89
                    case 'n': //110
                    case 'N': Exit(); return; //78
                    default:
                        break;
                }
            }
        }
    }
}
