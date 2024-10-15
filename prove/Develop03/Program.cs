using System;
using System.Net.Quic;


// Added the ability to only select different words as in the stretch challenge to make it so that the words are removed and any
// that have already been chosen are not selected.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference r1 = new Reference("Matthew", 1, 21, 22);
        Scripture s1 = new Scripture(r1, "And she shall bring forth a son, and thou shalt call his name Jesus: for he shall save his people from their sins");

        string userQuit = "";
        while (s1.IsCompletelyHidden() != false && userQuit != "quit")
        {
            string referenceText = r1.GetDisplayText();
            Console.WriteLine(referenceText);
            s1.HideRandomWords(3);

            string scriptureText = s1.GetDisplayText();
            Console.WriteLine(scriptureText);

            Console.Write("Hide more words or quit to exit");
            userQuit = Console.ReadLine();
        }
    }

}