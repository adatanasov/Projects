using System;
using System.Collections.Generic;
using System.Text;

public class AdditionalMethods
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentNullException("Array", "Array can't be null or empty");
        }

        if (startIndex < 0 || startIndex >= arr.Length)
        {
            throw new ArgumentOutOfRangeException(
                "Start index", 
                string.Format("Start index must be between 0 and {0}!", arr.Length - 1));
        }

        if (count < 1 || count + startIndex > arr.Length)
        {
            throw new ArgumentOutOfRangeException(
                "Count",
                string.Format("Count must be between 1 and {0}!", arr.Length - startIndex));
        }

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (string.IsNullOrEmpty(str))
        {
            throw new ArgumentNullException("Input string", "Input string can't be null or empty");
        }

        if (count < 1 || count > str.Length)
        {
            throw new ArgumentOutOfRangeException(
                "Count",
                string.Format("Count must be between 1 and {0}!", str.Length));
        }

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }

    public static void CheckPrime(int number)
    {
        if (number <= 2 || number >= int.MaxValue)
        {
            throw new ArgumentOutOfRangeException(
                "Number",
                string.Format("Number must be between 3 and {0}", int.MaxValue));
        }

        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                Console.WriteLine("{0} is not prime", number);
                return;
            }
        }

        Console.WriteLine("{0} is prime", number);
    }
}