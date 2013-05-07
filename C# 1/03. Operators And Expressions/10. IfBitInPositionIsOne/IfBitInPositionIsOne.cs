using System;

class IfBitInPositionIsOne
{
    static void Main()
    {
        Console.WriteLine("Enter integer, please!");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position, please!");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        Console.WriteLine(Convert.ToString(v, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'));
        bool result = ((v & mask) >> p) == 1;
        Console.WriteLine(result);
    }
}

