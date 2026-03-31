using System;
using System.Collections.Concurrent;
using System.Reflection.Metadata;


class Order
{
    public List<Product> _product;
    public Customer _customer;
    public int _totalCost;

    public void PackingLabel()
    {
        foreach(Product product in _product)
        {
            _totalCost += product.totalCost();

        }
    }
	public int shippingLabel()
    {
        bool country =_customer.liveUsa();
        int shippingValue;

        if (country == true)
        {
            shippingValue = 5;
        }
        else
        {
            shippingValue = 35;
        }
        _totalCost += shippingValue;
        Console.WriteLine($"Shipping Value: {shippingValue}");
        return shippingValue;
    }

}
