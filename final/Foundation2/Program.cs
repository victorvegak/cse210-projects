using System;

class Program
{
    static void Main(string[] args)
    {
        // create address
        Address usaAddress = new Address("156 Michael Ct #4", "Anchorage", "AK", "USA");
        Address international = new Address("Bo El Eden", "Managua", "Managua", "Nicaragua");

        // Customer Info
        Customer usaCustomer = new Customer("Jimmy Robinson", usaAddress);
        Customer InternationalCustomer = new Customer("Victor Abarca", international);

        // products 

        Product product1 = new Product("Tv", "Au8000", 800.00, 3);
        Product product2 = new Product("Iphone", "X12", 1000.00, 2);
        Product product3 = new Product("SmartWatch", "series 3", 300.00, 4);
        Product product4 = new Product("Xbox", "Series X", 600.00, 2);

        //Create Orders
        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(InternationalCustomer);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        //display order details
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
    }
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine();
        // Console.WriteLine($"Customer Name: {order.GetCustomerName()}");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice()}");
        Console.WriteLine();
    }
}