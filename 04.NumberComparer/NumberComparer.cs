/*  Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.
*/

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter value for A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for B: ");        
        double b = double.Parse(Console.ReadLine());
        
        double max = Math.Max(a, b);

        Console.WriteLine("\r\nGreater from A({0}) and B({1}) = {2}\r\n", a, b, max);
    }
}
