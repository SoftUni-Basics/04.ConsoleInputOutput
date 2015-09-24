/*  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter Five numbers separated by a space: ");
        decimal[] sumArray = Console.ReadLine().Split(new char[] { ' ' }, 
            StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray();
        
        Console.WriteLine("Sum = {0}", sumArray.Sum());
        
    }
}
