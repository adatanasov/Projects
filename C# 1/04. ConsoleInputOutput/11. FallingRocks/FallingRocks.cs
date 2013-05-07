using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Rock
{
    public int x;
    public int y;
    public int l;
    public char c;
    public ConsoleColor color;
}

class FallingRocks
{
    static int playerPositon = Console.WindowWidth / 2 - 1;
    static int score = 0;
    static int playerLenght = 3;

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 50;
    }

    static void SetInitialPosition()
    {
        playerPositon = Console.WindowWidth / 2 - 1;
    }

    private static void MovePlayerLeft()
    {
        if (playerPositon > 0)
        {
            playerPositon--;
        }
    }
    
    private static void MovePlayerRight()
    {
        if (playerPositon < Console.WindowWidth - playerLenght -1)
        {
            playerPositon++;
        }
    }

    static void DrawPlayerPosition()
    {
        PrintAtPosition(playerPositon, Console.WindowHeight - 1, '(');
        PrintAtPosition(playerPositon + 1, Console.WindowHeight - 1, 'O');
        PrintAtPosition(playerPositon + 2, Console.WindowHeight - 1, ')');
    }

    static void PrintAtPosition(int x, int y, char symbol, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void PrintScore()
    {
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("Score:");
        Console.Write(score);
    }

    static void Main()
    {
        RemoveScrollBars();
        SetInitialPosition();
        Random randomGenerator = new Random();
        List<Rock> rocks = new List<Rock>();
        while (true)
        {
            Rock userRock = new Rock();
            userRock.color = ConsoleColor.Red;
            userRock.x = randomGenerator.Next(0, Console.WindowWidth - 1);
            userRock.y = 0;
            userRock.l = randomGenerator.Next(0, 4);
            userRock.c = '^';
            rocks.Add(userRock);
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    MovePlayerLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    MovePlayerRight();
                }
            }
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.l = randomGenerator.Next(0, 4);
                newRock.color = oldRock.color;
                if (newRock.y == Console.WindowHeight && newRock.x >= playerPositon && newRock.x < (playerPositon + playerLenght))
                {
                    Console.SetCursorPosition(20, 15);
                    Console.WriteLine("You lose!");
                    Console.ReadKey();
                }
                if (newRock.y == Console.WindowHeight)
                {
                    score++;
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            Console.Clear();
            DrawPlayerPosition();
            PrintAtPosition(userRock.x, userRock.y, userRock.c, userRock.color);
            foreach (Rock rock in rocks)
            {
                for (int i = 0; i < rock.l; i++)
                {
                    PrintAtPosition(rock.x, rock.y, rock.c, rock.color);
                }
            }
            PrintScore();
            Thread.Sleep(150);
        }
    }
}

