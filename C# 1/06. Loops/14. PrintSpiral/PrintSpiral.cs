using System;

class PrintSpiral
{
    static void Main()
    {
        Console.Write("Please enter positive integer N (N < 20) = ");
        byte n = byte.Parse(Console.ReadLine());
        int[,] matrix = new int[n,n];
        int number = 0;
        int inner = 0;
        for (int i = 0; i < 1; i++)         // Declare first row
        {                                   //
            for (int j = 0; j < n; j++)     //
            {                               //
                number++;                   //
                matrix[i, j] = number;      //
            }                               //
        }                                   //
        for (int i = 1; i < n; i++)             // Declare last col
        {                                       //
            for (int j = n - 1; j < n; j++)     //
            {                                   //
                number++;                       //
                matrix[i, j] = number;          //
            }                                   //
        }                                       //
        for (int i = n - 1; i < n; i++)             // Declare last row
        {                                           //
            for (int j = n - 2; j >= 0; j--)        //
            {                                       //
                number++;                           //
                matrix[i, j] = number;              //
            }                                       //
        }                                           //
        for (int i = n - 2; i > 0; i--)         // Declare first col
        {                                       //
            for (int j = 0; j < 1; j++)         //
            {                                   //
                if (number == n * n)            //
                {                               //
                    break;                      //
                }                               //
                number++;                       //
                matrix[i, j] = number;          //
            }                                   //
        }                                       //
        while (number < n * n)     // until last number is reached
        {
            inner++;
            for (int i = inner; i < inner + 1; i++)        // Declare next upper row
            {                                              //
                for (int j = inner; j < n - inner; j++)   //
                {                                         //
                    number++;                             //
                    matrix[i, j] = number;               //
                }                                        //
            }                                           //
            for (int i = inner + 1; i < n - inner; i++)             // Declare next right col
            {                                                       //
                for (int j = n - inner - 1; j < n - inner; j++)     //
                {                                                    //
                    number++;                                         //
                    matrix[i, j] = number;                            //
                }                                                     //
            }                                                         //
            for (int i = n - inner - 1; i < n - inner; i++)             // Declare next bottom row
            {                                                         //
                for (int j = n - inner - 2; j >= inner; j--)        //
                {                                                    //
                    number++;                                        //
                    matrix[i, j] = number;                           //
                }                                                    //
            }                                                        //
            for (int i = n - inner - 2; i > inner; i--)         // Declare next left col
            {                                                    //
                for (int j = inner; j < inner + 1; j++)         //
                {                                                //
                    number++;                                    //
                    matrix[i, j] = number;                       //
                }                                                //
            }                                                    //
        }           // end ot while loop  
        for (int rows = 0; rows < n; rows++)           // Print the matrix
        {                                              //
            for (int cols = 0; cols < n; cols++)       //
            {                                          //
                Console.Write("{0,-4}", matrix[rows,cols]);//
            }                                          //
            Console.WriteLine();                       //
        }                                              //
    }
}

