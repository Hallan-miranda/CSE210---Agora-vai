using System;

class Customer
{
    String _name;
	Adress _adress;

    public Customer(string name, string street, string stateprovince, string city, string country)
    {
        _name = name;
        _adress = new Adress(street, stateprovince, city, country);
    }

    public bool liveUsa()
    {
        bool usa = _adress.isUSA();

        if (usa == true)
        {
            Console.WriteLine("Live in USA");
        }
        else
        {
            Console.WriteLine("Do not Live in USA");
        }

        return usa;
    }

    public void shipping()
    {
        Console.WriteLine($"Name: {_name}");
        _adress.allAdress();
    }

}