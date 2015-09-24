/*Write a program that reads 3 real numbers from the console and prints their sum.*/

using System;

class Sum3Numbers
{
    static void Main()
    {
        Console.Write("Enter value A = ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter value B = ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter value C = ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;
        Console.WriteLine("Sum[a,b,c] = {0}", sum);
    }
}
