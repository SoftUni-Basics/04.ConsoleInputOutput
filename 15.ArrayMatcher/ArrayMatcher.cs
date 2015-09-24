using System;
using System.Collections.Generic;
using System.Linq;

class ArrayMatcher
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\').ToArray();
        
        string foundChars = string.Empty;

        char[] first = input[0].ToCharArray();
        char[] second = input[1].ToCharArray();

        if (input[2] == "join")
        {
            foundChars = SearchForEquals(first, second);
        }
        else if (input[2] == "right exclude")
        {
            foundChars = SearchForDifferent(first, second);
        }
        else
        {
            foundChars = SearchForDifferent(second, first);
        }

        char[] sorting = foundChars.ToCharArray();
        Array.Sort(sorting);
        string sorted = string.Join("", sorting);
        Console.WriteLine(sorted);
    }

    static string SearchForDifferent(char[] first, char[] second)
    {
        string different = string.Empty;
        for (int i = 0; i < first.Length; i++)
        {
            bool checker = false;
            for (int j = 0; j < second.Length; j++)
            {
                if (first[i] == second[j])
                {
                    checker = true;
                }
            }
            if (checker == false)
            {
                different += first[i];
            }
        }
        return different;
    }

    static string SearchForEquals(char[] first, char[] second)
    {
        string equals = string.Empty;
        for (int i = 0; i < first.Length; i++)
        {
            for (int j = 0; j < second.Length; j++)
            {
                if (first[i] == second[j])
                {
                    equals += first[i].ToString();
                }
            }
        }
        return equals;
    }
}
