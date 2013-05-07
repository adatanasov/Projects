using System;

class IfThirdBitIsZeroOrOne
{
    static void Main()
    {
        Console.WriteLine("Please enter integer!");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int check = number & mask;
        if (check == 0)
            Console.WriteLine("The bit in position 3 is 0");
        else
            Console.WriteLine("The bit in position 3 is 1");
    }
}

