using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallingRocks
{
    static int thePlayerPosition;
    static Random randomGenerator = new Random();
    static int result;
    static int randomNumber;
    static int randomPosition;
    static char randomSymbol;
    static int[,] positions = new int[Console.WindowHeight - 1, Console.WindowWidth - 1];
    static char[,] symbols = new char[Console.WindowHeight - 1, Console.WindowWidth - 1];
    static int difficulty = 3;
    static int countDifficulty = 3;
    static int sleep = 150;

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight = 24;
        Console.BufferWidth = Console.WindowWidth = 40;
    }

    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void DrawThePlayer()
    {
        PrintAtPosition(thePlayerPosition, Console.WindowHeight - 1, '0');
        PrintAtPosition(thePlayerPosition - 1, Console.WindowHeight - 1, '(');
        PrintAtPosition(thePlayerPosition + 1, Console.WindowHeight - 1, ')');
    }

    static void SetInitialPositions()
    {
        thePlayerPosition = (Console.WindowWidth / 2);
    }

    static void MoveThePlayerLeft()
    {
        if (thePlayerPosition > 1)
        {
            thePlayerPosition--;
        }
    }

    static void MoveThePlayerRight()
    {
        if (thePlayerPosition < Console.WindowWidth - 3)
        {
            thePlayerPosition++;
        }
    }

    static void TheResult()
    {
        Console.SetCursorPosition(Console.WindowWidth / 2, 0);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(result);
    }

    static void MakeTheRocks()
    {
        randomNumber = randomGenerator.Next(0, (2 + difficulty));
        if (randomNumber <= 2)
        {
            randomNumber = 0;
        }
        else
        {
            randomNumber -= 2;
        }
        for (int i = 1; i <= randomNumber; i++)
        {
            randomPosition = randomGenerator.Next(0, Console.WindowWidth - 1);
            randomSymbol = Convert.ToChar(randomGenerator.Next('\u0021', '\u002F'));
            symbols[0, randomPosition] = randomSymbol;
        }
    }

    static void TheRockMove()
    {
        int row;
        for (row = Console.WindowHeight - 1; row > 0; row--)
        {
            for (int col = 0; col < Console.WindowWidth; col++)
            {
                if (symbols[row - 1, col] != '\u0000')
                {
                    symbols[row, col] = symbols[row - 1, col];
                    symbols[row - 1, col] = '\u0000';
                    if (row != Console.WindowHeight)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        PrintAtPosition(col, row, symbols[row, col]);
                    }                  
                }
            }
        }        
    }

    static void Main()
    {
        RemoveScrollBars();
        SetInitialPositions();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    MoveThePlayerLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    MoveThePlayerRight();
                }
            }

            for (int col = 0; col < Console.WindowWidth; col++)
            {
                if (symbols[Console.WindowHeight - 1, col] != '\u0000')
                {
                    if ((col == thePlayerPosition) || (col == thePlayerPosition + 1) || (col == thePlayerPosition - 1))
                    {
                        Console.SetCursorPosition((Console.WindowWidth - 8) / 2, Console.WindowHeight / 2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Game Over!!!");
                        Console.SetCursorPosition((Console.WindowWidth - 11) / 2, (Console.WindowHeight - 2) / 2);
                        Console.WriteLine("Your score is: {0}", result);
                        Console.ReadKey();
                        //return;
                    }
                    else
                    {
                        symbols[Console.WindowHeight - 1, col] = '\u0000';
                        result++;
                        //if ((result > countDifficulty * 100) && (result < 1210))
                        //{
                        //    countDifficulty += 3;
                        //    difficulty++;
                        //}
                        //if ((result > countDifficulty * 100) && (result > 1210) && (result < 6010))
                        //{
                        //    sleep -= 5;
                        //    countDifficulty += 3;
                        //}
                        if ((countDifficulty % 2) == 0 && (countDifficulty * 100 < result))
                        {
                            countDifficulty += 3;
                            difficulty++;
                        }
                        if ((result > countDifficulty * 100) && (countDifficulty % 2 == 1))
                        {
                            sleep -= 10;
                            countDifficulty += 3;
                        }
                    }
                }
            }
            Console.Clear();
            MakeTheRocks();
            TheResult();       
            DrawThePlayer();
            TheRockMove();
            Thread.Sleep(sleep);
        }
    }
}

