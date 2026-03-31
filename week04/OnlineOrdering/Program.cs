using System;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        order._customer = new Customer("Hallan","Av Voluntários da Patria", "Parana", "Londrina", "BR" );
        order._product = new List<Product>();
        order._product.Add(new Product("katchup", 23, 5, 4));

        order._customer.shipping();
        order.PackingLabel();
        order.shippingLabel();
        Console.WriteLine($"Total Cost: {order._totalCost}");




    }
}