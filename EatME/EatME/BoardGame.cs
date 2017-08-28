using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatME
{
    class BoardGame
    {
        private const int rows = 12, cells = 12;
        protected char[,] t;
        IntroduceYourself sign = new IntroduceYourself();

        public BoardGame()
        {
            t = new char[rows, cells];

            int i, j;

            //Fame of board game
            for (i = 0; i < rows; i++)
                for (j = 0; j < cells; j++)
                    t[i, j] = ' ';

            for (i = 0; i < rows; ++i)
            {
                for (j = 0; j < cells; ++j)
                {
                    t[0, j] = '█';
                    t[rows - 1, j] = '█';
                }
                t[i, 0] = '█';
                t[i, cells - 1] = '█';
            }            
        }

        #region Mazes of boards
        private void FieldA()
        {
            int i, j;

            //Inside of game board
            for (i = 2; i < rows - 2; i += 2)
            {
                for (j = 2; j < cells - 2; j++)
                    t[i, j] = '█';
            }

            t[1, 3] = '█';
            t[7, 3] = '█';
            t[4, 10] = '█';
            t[6, 1] = '█';
            t[9, 2] = '█';
            t[9, 6] = '█';
            t[10, 4] = '█';
            t[10, 8] = '█';
        }
        private void FieldB()
        {
            int i, j;

            //Inside of game board
            for (i = 2; i < 5; i += 2)
                for (j = 2; j < cells - 2; j++)
                    if ((j >= 2 && j <= 4) || (j >= 7 && j <= 9)) t[i, j] = '█';

            for (i = 7; i < 10; i += 2)
                for (j = 2; j < cells - 2; j++)
                    if ((j >= 2 && j <= 4) || (j >= 7 && j <= 9)) t[i, j] = '█';

            t[1, 5] = '█';
            t[1, 6] = '█';
            t[3, 2] = '█';
            t[3, 9] = '█';
            t[5, 4] = '█';
            t[5, 7] = '█';
            t[6, 4] = '█';
            t[6, 7] = '█';
            t[8, 2] = '█';
            t[8, 9] = '█';
        }
        private void FieldC()
        {
            int i, j;

            //Inside of game board
            for (i = 1; i < rows; i++)
            {
                if (i == 2 || i == 6 || i == 9)
                {
                    for (j = 2; j < cells - 2; j++)
                        if ((j >= 2 && j <= 4) || (j >= 7 && j <= 9)) t[i, j] = '█';
                }

                for (j = 1; j < cells - 2; j++)
                {
                    if (i == 1 || i == 8)
                    {
                        if (j == 3 || j == 8) t[i, j] = '█';
                    }

                    if (i == 3 || i == 5 || i == 7 || i == 10)
                    {
                        if (j == 2 || j == 9) t[i, j] = '█';
                    }

                    if (i == 4)
                    {
                        if (j >= 4 && j <= 7) t[i, j] = '█';
                    }
                }
            }
        }
        private void FieldD()
        {
            int i, j;

            //Inside of game board
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j < cells; j++)
                {
                    if (i == 1)
                    {
                        if (j == 3 || j == 4) t[i, j] = '█';
                    }
                    if (i == 2)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 6 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 3)
                    {
                        if ((j >= 3 && j <= 4) || (j >= 8 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 4)
                    {
                        if ((j >= 2 && j <= 6) || (j == 8)) t[i, j] = '█';
                    }
                    if (i == 5)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 8 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 6)
                    {
                        if ((j == 2) || (j >= 5 && j <= 8)) t[i, j] = '█';
                    }
                    if (i == 7)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 7 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 8)
                    {
                        if ((j >= 3 && j <= 5) || (j == 9)) t[i, j] = '█';
                    }
                    if (i == 9)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 7 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 10)
                    {
                        if (j >= 7 && j <= 8) t[i, j] = '█';
                    }
                }
            }
        }
        private void FieldE()
        {
            int i, j;

            //Inside of game board
            for (i = 1; i < rows; i++)
            {
                for (j = 1; j < cells; j++)
                {
                    if (i == 1)
                    {
                        if (j == 1 || (j >= 5 && j <= 6) || (j >= 8 && j <= 9)) t[i, j] = '█';
                    }
                    if (i == 2)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 5 && j <= 6)) t[i, j] = '█';
                    }
                    if (i == 3)
                    {
                        if ((j >= 2 && j <= 3) || (j >= 6 && j <= 8) || j == 10) t[i, j] = '█';
                    }
                    if (i == 4)
                    {
                        if ((j >= 3 && j <= 4) || j == 10) t[i, j] = '█';
                    }
                    if (i == 5)
                    {
                        if (j == 1 || (j >= 4 && j <= 8)) t[i, j] = '█';
                    }
                    if (i == 6)
                    {
                        if ((j >= 3 && j <= 4) || (j >= 6 && j <= 8) || j == 10) t[i, j] = '█';
                    }
                    if (i == 7)
                    {
                        if ((j >= 2 && j <= 4) || (j >= 6 && j <= 7)) t[i, j] = '█';
                    }
                    if (i == 8)
                    {
                        if ((j >= 3 && j <= 4) || j == 7 || (j >= 9 && j <= 10)) t[i, j] = '█';
                    }
                    if (i == 9)
                    {
                        if (j == 1 || (j >= 6 && j <= 7) || j == 10) t[i, j] = '█';
                    }
                    if (i == 10)
                    {
                        if ((j >= 3 && j <= 4) || (j >= 9 && j <= 10)) t[i, j] = '█';
                    }
                }
            }
        }
        #endregion

        public char[,] GetBoard()
        {
            return t;
        }
        private void WhichBoard()
        {
            Random rndBoard = new Random();
            int RandomBoard = rndBoard.Next(0, 5);
            switch (RandomBoard)
            {
                case 0: FieldA(); break;
                case 1: FieldB(); break;
                case 2: FieldC(); break;
                case 3: FieldD(); break;
                case 4: FieldE(); break;
                default: break;
            }
        }
        private void RandomObjects()
        {
            Random WhereIsObjects = new Random();
            int Y = 0, X = 0;
            for (int i = 0; i < 3; i++)
            {
                while (t[Y, X] != ' ')
                {
                    Y = WhereIsObjects.Next() % rows;
                    X = WhereIsObjects.Next() % cells;
                }
                t[Y, X] = 'O';
            }
        }
        private void ClearBoardContent()
        {
            for (int i = 1; i < rows - 1; i++)
            {
                for (int j = 1; j < cells - 1; j++)
                    t[i, j] = ' ';
            }
        }

        public void DisplayField()
        {
            ClearBoardContent();
            WhichBoard();
            RandomObjects();
            for (int i = 0; i < rows; ++i)
            {
                Console.SetCursorPosition(14, i + 5);
                for (int j = 0; j < cells; ++j)
                {
                    Console.Write(t[i, j]);
                }
                Console.WriteLine();
            }
        }                
        public bool HasEverythingEaten()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cells; j++)
                {
                    if (t[i, j] == 'O')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
