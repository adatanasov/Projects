using System;

class ModifyBitInPosition
{
    static void Main()
    {
        Console.WriteLine("Enter integer, please!");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value, please!");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter position, please!");
        int p = int.Parse(Console.ReadLine());
        int result;
        Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        if (v==0) 
            result = ~(1<<p) & n;
        else 
            result = (1<<p) | n;
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

