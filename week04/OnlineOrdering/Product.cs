using System;


class Product
{
    String _name;
	int _id;
	int _price;
	int _quantity;

    public Product(string name,int id, int price,int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int  totalCost()
    {
        Console.WriteLine($"ID: {_id}| Name: {_name}| Qauntity: {_quantity}| Price: {_price}| Total: {_price * _quantity}");

        return (_price * _quantity);
    }

    public void packing()
    {
        Console.WriteLine($"Name: {_name}| ID: {_id}");
    }

}