using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // First Order
        Address address1 = new Address("101 pangani Rd", "Nairobi", "Nairobi", "Kenya");
        Customer customer1 = new Customer("John Anemba", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", "NB101", 3.50, 4));
        order1.AddProduct(new Product("Pen", "PN202", 1.25, 10));

        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}");

        // Second Order
        Address address2 = new Address("200 Maple Ave", "Provo", "UT", "USA");
        Customer customer2 = new Customer("Sarah Williams", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("T-shirt", "TS303", 15.00, 2));
        order2.AddProduct(new Product("Cap", "CP404", 10.00, 1));

        Console.WriteLine("\n=== Order 2 ===");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
