using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        
        Console.WriteLine("What is your grade?");
        string gradeInText = Console.ReadLine();

        int grade = int.Parse(gradeInText);
        string letter = string.Empty;

            if (grade >= 90)
            {
                letter = "A";
            }
            else if (grade >= 80)
            {
                letter = "B";
            }
            else if (grade >= 70)
            {
                letter = "C";
            }
            else if (grade >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        Console.WriteLine($"Your grade for this class is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed this course!");
        }
        else
        {
            Console.WriteLine("Try again.");
        }
        
    }
}