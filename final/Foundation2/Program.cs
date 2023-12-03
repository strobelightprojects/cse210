using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address customerAddress1 = new Address("12 Main rd", "Idaho falls", "ID", "USA");
        Address customerAddress2 = new Address("24 left st", "Mexico city", "IDK", "Mexico");

        // Create customers
        Customer customer1 = new Customer("Bob lee", customerAddress1);
        Customer customer2 = new Customer("Jospeh Smith", customerAddress2);

        // Create products
        Product product1 = new Product("Shirt", 1, 10, 2);
        Product product2 = new Product("Shoes", 2, 20, 1);
        Product product3 = new Product("Socks", 3, 15, 3);

        // Create orders
        List<Product> productList1 = new List<Product> { product1, product2 };
        List<Product> productList2 = new List<Product> { product2, product3 };
        Order order1 = new Order(customer1, productList1);
        Order order2 = new Order(customer2, productList2);

        // Display 
        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());

        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());

        Console.WriteLine("\nOrder 1 Total Price:");
        Console.WriteLine($"${order1.CalculateTotalPrice()}");

        // Display 
        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());

        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());

        Console.WriteLine("\nOrder 2 Total Price:");
        Console.WriteLine($"${order2.CalculateTotalPrice()}");
    }
}
