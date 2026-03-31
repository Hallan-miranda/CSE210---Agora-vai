using System;


class Adress
{
    string _street;
    string _stateprovince;
    string _city;
    string _country;


    public Adress(string street, string stateprovince, string city, string country)
    {
        _street = street;
        _stateprovince = stateprovince;
        _city = city;
        _country = country;
    }
   public bool isUSA()
    {
        bool _isUsa;
        if (_country == "USA")
        {
            _isUsa = true;
        }
        else
        {
            _isUsa = false;
        }

        return _isUsa;
    }
    
    public string allAdress()
    {
        string _allAdress = $"{_street}\n{_stateprovince}\n{_city}\n{_country}";

        return _allAdress;
    }


}