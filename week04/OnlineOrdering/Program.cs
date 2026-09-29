using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice Smith", address1);
        Customer customer2 = new Customer("Bob Jones", address2);

        List<Product> products1 = new List<Product>();
        Product p1 = new Product("Laptop", "L101", 999.99, 1);
        Product p2 = new Product("Wireless Mouse", "M202", 25.50, 2);
        Product p3 = new Product("Mechanical Keyboard", "K303", 89.99, 1);
        products1.Add(p1);
        products1.Add(p2);
        products1.Add(p3);

        List<Product> products2 = new List<Product>();
        Product p4 = new Product("Laptop", "L101", 999.99, 2);
        Product p5 = new Product("Wireless Mouse", "M202", 25.50, 2);
        Product p6 = new Product("Mechanical Keyboard", "K303", 89.99, 2);
        Product p7 = new Product("Monitor", "N404", 199.99, 2);
        products2.Add(p4);
        products2.Add(p5);
        products2.Add(p6);
        products2.Add(p7);

        Order o1 = new Order(products1, customer1);
        Order o2 = new Order(products2, customer2);
        orders.Add(o1);
        orders.Add(o2);

        foreach (Order item in orders)
        {
            item.shippingLabel();
            item.packingLabel();
            Console.WriteLine();
            Console.WriteLine($"Total: {item.Total()}");
            Console.WriteLine("\n");
        }  
    }
}