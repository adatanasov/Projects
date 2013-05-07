using System;

class PrintingCards
{
    static void Main()
    {
        char club = (char)9827;
        char diamond = (char)9830;
        char heart = (char)9829;
        char spade = (char)9824;
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write("2"); break;
                    case 3: Console.Write("3"); break;
                    case 4: Console.Write("4"); break;
                    case 5: Console.Write("5"); break;
                    case 6: Console.Write("6"); break;
                    case 7: Console.Write("7"); break;
                    case 8: Console.Write("8"); break;
                    case 9: Console.Write("9"); break;
                    case 10: Console.Write("10"); break;
                    case 11: Console.Write("J"); break;
                    case 12: Console.Write("Q"); break;
                    case 13: Console.Write("K"); break;
                    case 14: Console.Write("A"); break;
                }
                switch (j)
                {
                    case 1: Console.Write(club + " "); break;
                    case 2: Console.Write(diamond + " "); break;
                    case 3: Console.Write(heart + " "); break;
                    case 4: Console.WriteLine(spade + " "); break;
                }
            }
        }
        Console.WriteLine("     OR      ");
        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write("Deuce of "); break;
                    case 3: Console.Write("Three of "); break;
                    case 4: Console.Write("Four of "); break;
                    case 5: Console.Write("Five of "); break;
                    case 6: Console.Write("Six of "); break;
                    case 7: Console.Write("Seven of "); break;
                    case 8: Console.Write("Eight of "); break;
                    case 9: Console.Write("Nine of "); break;
                    case 10: Console.Write("Ten of "); break;
                    case 11: Console.Write("Jack of "); break;
                    case 12: Console.Write("Queen of "); break;
                    case 13: Console.Write("King of "); break;
                    case 14: Console.Write("Ace of "); break;
                }
                switch (j)
                {
                    case 1: Console.Write("clubs - "); break;
                    case 2: Console.Write("diamonds - "); break;
                    case 3: Console.Write("hearts - "); break;
                    case 4: Console.WriteLine("spades - "); break;
                }
            }
        }
    }
}

