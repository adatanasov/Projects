using System;

class BonusScore
{
    static void Main()
    {
        Console.WriteLine("Please enter digit between 1 and 9!");
        int digit = int.Parse(Console.ReadLine());
        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                    digit *= 10;
                    Console.WriteLine(digit); break;
            case 4: 
            case 5: 
            case 6: 
                    digit *= 100;
                    Console.WriteLine(digit); break;
            case 7: 
            case 8: 
            case 9: 
                    digit *= 1000;
                    Console.WriteLine(digit); break;
            default: Console.WriteLine("Wrong input!"); break;
        }
    }
}

