/*  Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop.
*/

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter value for N: ");
        int input = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 1; i <= input; i++)
        {
            Console.Write("No{0} = ", i);
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
