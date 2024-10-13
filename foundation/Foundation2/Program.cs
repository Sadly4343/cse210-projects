using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("String beans", "1", 2, 3);
        Product product2 = new Product("Watermelon", "2", 20, 4);
        Product product6 = new Product("Apples", "3", 5, 4);
        List<Product> products = new List<Product> { product1, product2, product6 };

        Address a1 = new Address("123 Neverlane rd", "Forever", "Washington", "USA");
        Customer customer = new Customer("John Richards", a1);
        Order order = new Order(customer, products);
        string shippingLabel = order.GetShippingLabel();
        string packingLabel = order.GetPackingLabel();
        int totalCost = order.GetTotalCost();
        Console.WriteLine();
        Console.WriteLine(shippingLabel);
        Console.WriteLine();
        Console.WriteLine(packingLabel);
        Console.WriteLine($"Total cost is {totalCost}$");


        Product product3 = new Product("String beans", "1", 2, 3);
        Product product4 = new Product("Pineapple", "2", 5, 4);
        Product product5 = new Product("Asparagus", "3", 10, 4);
        List<Product> products1 = new List<Product> { product3, product4, product5 };

        Address a2 = new Address("5809 N Aurora Ln", "Borealis", "Washington", "USA");
        Customer customer1 = new Customer("Ted Mosby", a2);
        Order order1 = new Order(customer1, products1);
        string shippingLabel1 = order1.GetShippingLabel();
        string packingLabel1 = order1.GetPackingLabel();
        int totalCost1 = order1.GetTotalCost();
        Console.WriteLine();
        Console.WriteLine(shippingLabel1);
        Console.WriteLine();
        Console.WriteLine(packingLabel1);
        Console.WriteLine($"Total cost is {totalCost1}$");
        Console.ReadLine();

    }
}

