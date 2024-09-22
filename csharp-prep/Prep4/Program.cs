using System;
using System.Globalization;
using System.Net;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> totals = new List<int>();
        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished");
            string user = Console.ReadLine();
            userNum = int.Parse(user);
            if (userNum != 0)
            {
                totals.Add(userNum);
            }

        }
        int sum = 0;
        foreach (int number in totals)
        {
            sum += number;
        }
        Console.WriteLine($"Sum is {sum}");

        float average = ((float)sum) / totals.Count;
        Console.WriteLine($"The average {average}");

        int max = totals[0];
        foreach (int number in totals)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Max is {max}");

    }
}