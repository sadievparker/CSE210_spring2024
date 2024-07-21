using System;

class Program
{
    static void Main()
    {
        // Addresses
        var address1 = new Address("200 East 500 West", "Rexburg", "ID", "USA");
        var address2 = new Address("100 Chaparral Drive", "Calgary", "AB", "Canada");

        // Customers
        var customer1 = new Customer("Dallin Archibald", address1);
        var customer2 = new Customer("Sadie Parker", address2);

        // Products
        var product1 = new Product("Soap", "S123", 1.00, 1);
        var product2 = new Product("Book", "B789", 12.00, 2);
        var product3 = new Product("TV", "T962", 500.00, 1);
        var product4 = new Product("Painting", "P823", 80.00, 2);

        // Create orders with products
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // List of orders
        var orders = new List<Order> { order1, order2 };

        // Display
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.PackingLabel());

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.ShippingLabel());

            Console.WriteLine();
            Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
            Console.WriteLine();
        }
    }
}