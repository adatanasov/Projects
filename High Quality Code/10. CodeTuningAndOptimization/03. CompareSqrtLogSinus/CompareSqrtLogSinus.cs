namespace _03.CompareSqrtLogSinus
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompareSqrtLogSinus
    {
        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static void TestSqrt()
        {
            Console.WriteLine("SQRT: ");
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (float i = 1f; i < 1000000.0f; i++)
                {
                    count = (float)Math.Sqrt((double)i);
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (double i = 1d; i < 1000000d; i++)
                {
                    count = Math.Sqrt(i);
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (decimal i = 1m; i < 1000000m; i++)
                {
                    count = (decimal)Math.Sqrt((double)i);
                }
            });
        }

        private static void TestLog()
        {
            Console.WriteLine("LOG: ");
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (float i = 1f; i < 1000000.0f; i++)
                {
                    count = (float)Math.Log((double)i);
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (double i = 1d; i < 1000000d; i++)
                {
                    count = Math.Log(i);
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (decimal i = 1m; i < 1000000m; i++)
                {
                    count = (decimal)Math.Log((double)i);
                }
            });
        }

        private static void TestSin()
        {
            Console.WriteLine("SIN: ");
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (float i = 1f; i < 1000000.0f; i++)
                {
                    count = (float)Math.Sin((double)i);
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (double i = 1d; i < 1000000d; i++)
                {
                    count = Math.Sin(i);
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (decimal i = 1m; i < 1000000m; i++)
                {
                    count = (decimal)Math.Sin((double)i);
                }
            });
        }

        private static void Main()
        {
            TestSqrt();
            TestLog();
            TestSin();
        }
    }
}
