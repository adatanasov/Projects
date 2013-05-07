using System;

class PrintingMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter number N (0 < N < 20)!");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = i +1; j <= i + n; j++)
            {
                if (j == i + n)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}

