
using System.Collections.Concurrent;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address (string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetFormattedAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
}

