/*  Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */

using System;

class QuadraticEquation
{
    static void Main()
    {
        double[] a = {2, -1, -0.5, 5};
        double[] b = { 5, 3, 4, 2 };
        double[] c = { -3, 0, -8, 8 };

        for (int i = 0; i < a.Length; i++)
        {
            double discriminant = (b[i] * b[i]) - 4 * a[i] * c[i];
            if (discriminant < 0)
            {
                Console.WriteLine("For integers: {0,3},{1,3},{2,3}:", a[i], b[i], c[i]);
                Console.WriteLine("No real roots");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine("For integers: {0,3},{1,3},{2,3}:", a[i], b[i], c[i]);
                double x = -b[i] / 2 / a[i];
                Console.WriteLine("X1 = X2 ={0,3}", x);
            }
            else
            {
                Console.WriteLine("For integers: {0,3},{1,3},{2,3}:", a[i], b[i], c[i]);
                double x1 = (-b[i] - Math.Sqrt(discriminant)) / 2 / a[i];
                double x2 = (-b[i] + Math.Sqrt(discriminant)) / 2 / a[i];
                Console.WriteLine("X1 ={0,3};   X2 ={1,3}", x1, x2);
            }
            Console.WriteLine();
            //  Console.WriteLine("Discr - {0}", discriminant);
        }
    }
}


/*
a       b   	c	    roots
2       5       -3	    x1=-3; x2=0.5
-1      3       0	    x1=3; x2=0
-0.5	4       -8	    x1=x2=4
5       2       8       no real roots
 */