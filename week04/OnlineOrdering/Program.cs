using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();
        // order number 1
        Console.WriteLine("Order number 1");
        Console.WriteLine();
        // creating John Daley as customer and his adress
        Adress johnAdress = new Adress("Main street 44", "55342 Johnstown", "Iowa", "USA");
        Customer johnDayley = new Customer("John Daley", johnAdress);

        // adding products to John Daleys basket
        List<Product> johnProducts = new List<Product>();
        johnProducts.Add(new Product("Television", 001, 399.00, 1));
        johnProducts.Add(new Product("Xbox", 002, 499.00, 1));
        johnProducts.Add(new Product("Xbox Controller", 003, 99.00, 3));

        // putting together the order for John Daley
        Order johnOrder = new Order(johnProducts, johnDayley);

        // show John Daleys order in the Console
        Console.WriteLine(johnOrder.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(johnOrder.PackingLabel());
        Console.WriteLine(johnOrder.TotalOrderCost());
        Console.WriteLine("--------------------------------");
        Console.WriteLine();

        // order number 2
        Console.WriteLine("Order number 2");
        Console.WriteLine();
        // creating John Daley as customer and his adress
        Adress marthaAdress = new Adress("Johangate 17", "2000 Lillestrøm", "", "Norway");
        Customer marthaJohansen = new Customer("Martha Johansen", marthaAdress);

        // adding products to John Daleys basket
        List<Product> marthaProducts = new List<Product>();
        marthaProducts.Add(new Product("Mobile Phone", 001, 599.00, 1));
        marthaProducts.Add(new Product("Phone Charger", 002, 99.00, 1));
        marthaProducts.Add(new Product("Cover for Mobile Phone", 003, 49.00, 1));

        // putting together the order for John Daley
        Order marthaOrder = new Order(marthaProducts, marthaJohansen);

        // show John Daleys order in the Console
        Console.WriteLine(marthaOrder.ShippingLabel());
        Console.WriteLine();
        Console.WriteLine(marthaOrder.PackingLabel());
        Console.WriteLine(marthaOrder.TotalOrderCost());
        Console.WriteLine("--------------------------------");
        Console.WriteLine();
    }
}