using System;
using System.Linq;

class CurrencyCheck
{
    static void Main()
    {
        decimal[] gamePrices = new decimal[5];

        gamePrices[0] = (decimal.Parse(Console.ReadLine()) / 100) * (decimal)3.5;
        gamePrices[1] = decimal.Parse(Console.ReadLine()) * (decimal)1.5;
        gamePrices[2] = decimal.Parse(Console.ReadLine()) * (decimal)1.95;
        gamePrices[3] = decimal.Parse(Console.ReadLine()) / (decimal)2;
        gamePrices[4] = decimal.Parse(Console.ReadLine());

        Console.WriteLine("{0:F2}", gamePrices.Min());
    }
}
