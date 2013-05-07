/* Refactor the following loop: 
int i=0;
for (i = 0; i < 100;) 
{
if (i % 10 == 0)
    {
    Console.WriteLine(array[i]);
    if ( array[i] == expectedValue ) 
    {
       i = 666;
    }
    i++;
    }
    else
    {
        Console.WriteLine(array[i]);
    i++;
    }
}
// More code here
if (i == 666)
{
    Console.WriteLine("Value Found");
} */

namespace Homework
{
    using System;

    public class RefactorLoop
    {
        public void Refactor()
        {
            for (int i = 0; i < 100; i++) 
            {
               Console.WriteLine(array[i]);
               if (i % 10 == 0 && array[i] == expectedValue)
               {
                    Console.WriteLine("Value Found at index: {0}", i);
                    break;
               }
            }
        }
    }
}