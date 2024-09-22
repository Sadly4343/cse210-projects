using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {


        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int response = -1;

        while (response != number)
        {
            Console.Write("What is your number? ");
            response = int.Parse(Console.ReadLine());

            if (number > response)
            {
                Console.WriteLine("Choose a larger number");
            }
            else if (number < response)
            {
                Console.WriteLine("Choose a smaller number");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
    }
}

