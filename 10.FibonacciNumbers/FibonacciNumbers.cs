/*  Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
 *  (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 *  Note that you may need to learn how to use loops.
 */

using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter value for Fibonacci length: ");
        int maxFibonacci = int.Parse(Console.ReadLine());
        int firstFib = 0;
        int secondFib = 1;
        int sumFib = 1;

        for (int i = 1; i <= maxFibonacci; i++)
        {
            Console.Write("{0} ", firstFib);
            firstFib = secondFib;
            secondFib = sumFib;
            sumFib = firstFib + secondFib;
        }
        Console.WriteLine();
    }
}
