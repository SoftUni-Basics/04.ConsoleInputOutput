using System;
using System.Linq;

class DreamItem
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split('\\').ToArray();

        int daysInMonth = GetDaysInMonth(input[0]) - 10;
        decimal moneyPerHour = decimal.Parse(input[1]);
        decimal hoursPerDay = decimal.Parse(input[2]);
        decimal priceOfItem = decimal.Parse(input[3]);

        decimal salary = (moneyPerHour * hoursPerDay) * daysInMonth;
        
        if (salary > 700)
        {
            salary *= (decimal)1.10;
        }
        
        if (salary >= priceOfItem)
        {
            Console.WriteLine("Money left = {0:F} leva.", (salary - priceOfItem));
        }
        else
        {
            Console.WriteLine("Not enough money. {0:F} leva needed.", (priceOfItem - salary));
        }
    }
    private static int GetDaysInMonth(string month)
    {
        int days = 0;
        switch (month)
        {
            case "Jan": days = 31; break;
            case "Feb": days = 28; break;
            case "March": days = 31; break;
            case "Apr": days = 30; break;
            case "May": days = 31; break;
            case "June": days = 30; break;
            case "July": days = 31; break;
            case "Aug": days = 31; break;
            case "Sept": days = 30; break;
            case "Oct": days = 31; break;
            case "Nov": days = 30; break;
            case "Dec": days = 31; break;
        }
        return days;
    }
}