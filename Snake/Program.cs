using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Unit
{
    public int x;
    public int y;
    public ConsoleColor color;
    public string symbol;
}
class FallingRocks
{
    static void ResetBuffer()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 60;
    }

    static void PrintAtPosition(int x, int y, string symbol, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(symbol);
    }

    static void PrintStringAtPosition(int x, int y, string text, ConsoleColor color)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(text);
    }

    

    static void Main()
    {
        ResetBuffer();
        Random rand = new Random();
        List<Unit> RocksList = new List<Unit>();
        int speed = 150;
        int livesCount = 3;
        int score = 0;
        string[] rocks = { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        string[] bigRocks = { };
        int randRock = rand.Next(1, 3);        

        // Init Dwarf
        Unit Dwarf = new Unit();
        Dwarf.x = Console.WindowWidth / 2 - 1;
        Dwarf.y = Console.WindowHeight - 1;
        Dwarf.color = ConsoleColor.White;
        Dwarf.symbol = "(O)";

        while (true)
        {
            bool hitted = false;
            Unit newInitRock = new Unit();
            newInitRock.x = rand.Next(0, Console.WindowWidth - 2);
            newInitRock.y = 5;
            newInitRock.color = (ConsoleColor)rand.Next((int)ConsoleColor.Blue, (int)ConsoleColor.Yellow);
            newInitRock.symbol = rocks[rand.Next(0, 9)];
            RocksList.Add(newInitRock);

            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                while (Console.KeyAvailable) { Console.ReadKey(true); }
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    if (Dwarf.x > 0)
                    {
                        Dwarf.x--;
                    }
                }
                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    if (Dwarf.x < Console.WindowWidth - 2)
                    {
                        Dwarf.x++;
                    }
                }
            }

            List<Unit> newList = new List<Unit>();
            for (int i = 0; i < RocksList.Count; i++)
            {
                Unit oldRock = RocksList[i];
                Unit NewMovedRock = new Unit();
                NewMovedRock.x = oldRock.x;
                NewMovedRock.y = oldRock.y + 1;
                NewMovedRock.color = oldRock.color;
                NewMovedRock.symbol = oldRock.symbol;

                if ((NewMovedRock.x == Dwarf.x || NewMovedRock.x == Dwarf.x + 1 || NewMovedRock.x == Dwarf.x+2) 
                    && NewMovedRock.y == Dwarf.y)
                {
                    livesCount--;
                    hitted = true;
                    if (livesCount == 0)
                    {
                        PrintStringAtPosition(10, 2, "Lives: " + livesCount, ConsoleColor.Green);
                        PrintStringAtPosition(42, 2, "Game over!", ConsoleColor.Red);
                        PrintStringAtPosition(33, 3, "Press [enter] to restart.", ConsoleColor.Red);
                        Console.ReadLine();
                        livesCount = 3;
                        RocksList = newList;
                        Console.Clear();
                        score = 0;
                    }
                }
                if (NewMovedRock.y < Console.WindowHeight)
                {
                    newList.Add(NewMovedRock);
                }
                else
                {
                    score++;
                }
            }
            RocksList = newList;
            Console.Clear();

            if (hitted)
            {
                PrintAtPosition(Dwarf.x, Dwarf.y, "???", ConsoleColor.Red);
            }
            else
            {
                PrintAtPosition(Dwarf.x, Dwarf.y, Dwarf.symbol, Dwarf.color);
            }
            foreach (Unit rock in RocksList)
            {
                PrintAtPosition(rock.x, rock.y, rock.symbol, rock.color);
            }
            for (int i = 1; i < Console.WindowWidth-1; i++)
            {
                PrintAtPosition(i, 5, "-", ConsoleColor.Gray);
            }
            PrintStringAtPosition(10, 2, "Lives: " + livesCount, ConsoleColor.Green);
            PrintStringAtPosition(20, 2, "Score: " + score, ConsoleColor.Green);
            PrintStringAtPosition(20, 3, "Speed: " + speed, ConsoleColor.Green);
            Thread.Sleep(150);
        }
    }
}