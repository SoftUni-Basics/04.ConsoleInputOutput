using System;

class MagicWand
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int halfInput = input / 2;
        int centerWidth = input + 2;

        Console.WriteLine("{0}{1}*{1}{0}", new string('.', input), new string('.', halfInput + 1));
        for (int i = 0; i < halfInput + 1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (input - i) + halfInput), new string('.', (i * 2) + 1));
        }

        Console.WriteLine("{0}{1}{0}", new string('*',input), new string('.', centerWidth));
        for (int i = 1; i <= halfInput; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string('.', ((input * 2) + centerWidth - 2) - (i * 2)));
        }
        for (int i = 1; i <= halfInput; i++)
        {
            Console.WriteLine("{0}*{1}*{2}*{3}*{2}*{1}*{0}",
                new string('.', (halfInput - i)), new string('.', halfInput), new string('.', (i - 1)), new string('.', input));
        }

        Console.WriteLine("{0}*{1}*{2}*{1}*{0}",
            new string('*', halfInput), new string('.', halfInput), new string('.', input));

        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("{0}*{0}*{0}", new string('.', input));
        }
        Console.WriteLine("{0}{1}{0}", new string('.', input), new string('*', centerWidth));
    }
}
