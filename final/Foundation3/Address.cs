
class Address
{
    public string _street;
    public string _city;
    public string _state;
    public string _zipCode;

    public Address (string street, string city, string state, string zipCode)
    {
        _street = street; 
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string GetStreet ()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetCity ()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetState()
    {
        return _state;
    }
    public void SetState(string state)
    {
        _state = state;
    }
    public string GetZipCode()
    {
        return _zipCode;
    }
    public void SetZipCode(string zipCode)
    {
        _zipCode = zipCode;
    }
    public override string ToString()
    {
        return  $"{_street}, {_city}, {_state}, {_zipCode}";
    }



}
