namespace _02.CompareMathOperations
{
    using System;
    using System.Diagnostics;

    public class CompareMathOperations
    {
        private static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        private static void TestAdd()
        {
            Console.WriteLine("ADD: ");
            Console.Write("int: ");
            DisplayExecutionTime(() =>
            {
                int count = 0;
                for (int i = 0; i < 10000000; i++)
                {
                    count += 3;
                }
            });
            Console.Write("long: ");
            DisplayExecutionTime(() =>
            {
                long count = 0L;
                for (int i = 0; i < 10000000; i++)
                {
                    count += 3;
                }
            });
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (int i = 0; i < 10000000; i++)
                {
                    count += 3.0f;
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (int i = 0; i < 10000000; i++)
                {
                    count += 3.0d;
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (int i = 0; i < 10000000; i++)
                {
                    count += 3.0m;
                }
            });
        }

        private static void TestSubstract()
        {
            Console.WriteLine("SUBSTRACT: ");
            Console.Write("int: ");
            DisplayExecutionTime(() =>
            {
                int count = 300000000;
                for (int i = 0; i < 10000000; i++)
                {
                    count -= 3;
                }
            });
            Console.Write("long: ");
            DisplayExecutionTime(() =>
            {
                long count = 300000000L;
                for (int i = 0; i < 10000000; i++)
                {
                    count -= 3;
                }
            });
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 300000000.0f;
                for (int i = 0; i < 10000000; i++)
                {
                    count -= 3.0f;
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 300000000.0d;
                for (int i = 0; i < 10000000; i++)
                {
                    count -= 3.0d;
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 300000000.0m;
                for (int i = 0; i < 10000000; i++)
                {
                    count -= 3.0m;
                }
            });
        }

        private static void TestIncrement()
        {
            Console.WriteLine("INCREMENT: ");
            Console.Write("int: ");
            DisplayExecutionTime(() =>
            {
                int count = 0;
                for (int i = 0; i < 10000000; i++)
                {
                    count++;
                }
            });
            Console.Write("long: ");
            DisplayExecutionTime(() =>
            {
                long count = 0L;
                for (int i = 0; i < 10000000; i++)
                {
                    count++;
                }
            });
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (int i = 0; i < 10000000; i++)
                {
                    count++;
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (int i = 0; i < 10000000; i++)
                {
                    count++;
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (int i = 0; i < 10000000; i++)
                {
                    count++;
                }
            });
        }

        private static void TestMultiply()
        {
            Console.WriteLine("MULTIPLY: ");
            Console.Write("int: ");
            DisplayExecutionTime(() =>
            {
                int count = 0;
                for (int i = 0; i < 10000000; i++)
                {
                    count *= 3;
                }
            });
            Console.Write("long: ");
            DisplayExecutionTime(() =>
            {
                long count = 0L;
                for (int i = 0; i < 10000000; i++)
                {
                    count *= 3;
                }
            });
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 0.0f;
                for (int i = 0; i < 10000000; i++)
                {
                    count *= 3.0f;
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 0.0d;
                for (int i = 0; i < 10000000; i++)
                {
                    count *= 3.0d;
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 0.0m;
                for (int i = 0; i < 10000000; i++)
                {
                    count *= 3.0m;
                }
            });
        }

        private static void TestDivide()
        {
            Console.WriteLine("DIVIDE: ");
            Console.Write("int: ");
            DisplayExecutionTime(() =>
            {
                int count = 300000000;
                for (int i = 0; i < 10000000; i++)
                {
                    count /= 3;
                }
            });
            Console.Write("long: ");
            DisplayExecutionTime(() =>
            {
                long count = 300000000L;
                for (int i = 0; i < 10000000; i++)
                {
                    count /= 3;
                }
            });
            Console.Write("float: ");
            DisplayExecutionTime(() =>
            {
                float count = 300000000.0f;
                for (int i = 0; i < 10000000; i++)
                {
                    count /= 3.0f;
                }
            });
            Console.Write("double: ");
            DisplayExecutionTime(() =>
            {
                double count = 300000000.0d;
                for (int i = 0; i < 10000000; i++)
                {
                    count /= 3.0d;
                }
            });
            Console.Write("decimal: ");
            DisplayExecutionTime(() =>
            {
                decimal count = 300000000.0m;
                for (int i = 0; i < 10000000; i++)
                {
                    count /= 3.0m;
                }
            });
        }

        private static void Main()
        {
            TestAdd();
            TestSubstract();
            TestIncrement();
            TestMultiply();
            TestDivide();
        }
    }
}
