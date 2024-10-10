using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference r1 = new Reference("Matthew", 1, 21, 22);
        Scripture s1 = new Scripture(r1, "And she shall bring forth a son, and thou shalt call his name Jesus: for he shall save his people from their sins");
        s1.HideRandomWords(3);
        string scriptureText = s1.GetDisplayText();
        Console.WriteLine(scriptureText);
        string referenceText = r1.GetDisplayText();
        Console.WriteLine(referenceText);
        Console.ReadLine();

    }

}