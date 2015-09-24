/*  Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */

using System;
using System.Collections.Generic;

class DividableNumber
{
    static void Main()
    {
        Console.WriteLine("Enter first: ");
        int firstNumb = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter last: ");
        int lastNumb = int.Parse(Console.ReadLine());
        
        List<int> allNumbers = new List<int>();
        int counter = 0;

        for (int i = 0; i <= lastNumb; i += 5)
        {
            if (i % 5 == 0 && i > 0)
            {
                counter++;
                allNumbers.Add(i);
            }
            else if(firstNumb > lastNumb || lastNumb < 5)
            {
                Console.WriteLine("-");
                return;
            }
            else if(firstNumb > 5)
            {
                int reminder = firstNumb % 5;
                i = firstNumb - reminder;
            }
        }
        Console.WriteLine("\r\nCounted numbers: {0}", counter);
        Console.WriteLine(string.Join(", ", allNumbers));
        Console.WriteLine();
    }
}
