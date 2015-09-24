/*  Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */

using System;
using System.Globalization;
using System.Threading;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter value for radius: ");
        string input = Console.ReadLine();
        input = input.Replace(',', '.');

        double radius;
        bool checker = double.TryParse(input, out radius);
        
        //  Perimeter = 2Pi*r
        double perimeter = (2 * Math.PI) * radius;
        //  Area = π × r2
        double area = Math.PI * Math.Pow(radius, 2);

        if (!checker)
        {
            Console.WriteLine("Invalid value! Please enter value with dot.(3.5)");
        }
        else
        {
            Console.WriteLine("Perimeter {0, -10} = {1:F2}", input, perimeter);
            Console.WriteLine("Area {0, -15} = {1:F2}", input, area);
        }
    }
}
