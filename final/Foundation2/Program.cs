using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a couple of orders with products
        Order order1 = new Order();
        order1.AddProduct(new Product("Product 1", "P1", 10.99, 2));
        order1.AddProduct(new Product("Product 2", "P2", 5.99, 3));
        order1.Customer = new Customer("Carlos Arjonilla", new Address("Street name", "City", "State", "Country"));

        Order order2 = new Order();
        order2.AddProduct(new Product("Product 3", "P3", 7.99, 1));
        order2.Customer = new Customer("Diego Arroyo", new Address("Street Name", "City", "State", "Country"));

        // Display the packing label, shipping label, and total price for each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label: Amazon\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: Temu\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());

        Console.ReadLine();
    }
}