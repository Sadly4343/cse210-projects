using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Product product1 = new Product("string bean", "1", 5, 2);
        Product product2 = new Product("string beans", "2", 10, 4);

        

        Address a1 = new Address("random street", "otis orchards", "washington", "USA");

        string addressText = a1.GetDisplayText();
        Console.WriteLine(addressText);
        Console.ReadLine();

    }
}

