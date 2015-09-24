/*  A company has:
        name, address, phone number, fax number, web site and manager. 
    The manager has first name, last name, age and a phone number. 
    Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class CompanyInfo
{
    static string[] company = { "Company name", "Company address", "Phone number", "Fax number", "Web site", };
    static string[] manager = { "Manager first name", "Manager last name", "Manager age", "Manager phone", };
    
    static void Main()
    {
        int counter = 0;
        string input;

        List<string> companyData = new List<string>();
        List<string> managerData = new List<string>();

        using (StreamReader file = new StreamReader("file.txt"))
        {
            while ((input = file.ReadLine()) != null)
            {
                if (company.Length > counter)
                {
                    Console.Write("{0,-20}  ", company[counter]);
                    Thread.Sleep(500);
                    Console.WriteLine(input);
                    companyData.Add(input);
                    counter++;
                }
                else
                {
                    Console.Write("{0,-20}  ", manager[counter-5]);
                    Thread.Sleep(500);
                    Console.WriteLine(input);
                    managerData.Add(input);
                    counter++;
                }
                Thread.Sleep(800);
            }
        }

        Console.Write("\r\n   wQQding ");

        for (int i = 0; i < 19; i++)
        {
            char ch = '.';
            Console.Write(ch);
            System.Threading.Thread.Sleep(500);
            if (i % 9 == 0)
            {
                int currentLineCursor = Console.CursorTop;
                Console.SetCursorPosition(11, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(11, currentLineCursor);
            }
        }
        Console.Clear();

        Console.WriteLine("{0}\r\nAddress:\t{1}     \r\nTel.\t\t{2}    \r\nFax:\t\t{3}      \r\nWeb site:\t{4}",
            companyData[0], companyData[1], companyData[2], companyData[3], companyData[4]);
        Console.WriteLine("\r\nManager:\t{0} {1} (age: {2},\r\n\t\ttel. {3})\r\n",
            managerData[0], managerData[1], managerData[2], managerData[3]);
    }
}

/*
    Software University
    15-18 Tintyava, Sofia
    +359 899 55 55 92
    (no fax)
    http://softuni.bg
    Svetlin
    Nakov
    25
    +359 2 981 981
 */
