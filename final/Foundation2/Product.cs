
class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product (string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _quantity = quantity;
        _price = price;
    }
    public string GetName ()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public string GetProductId()
    {
        return _productId;
    }
    // public void SetProductId(string productId)
    // {
    //     _productId = productId;
    // }   

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {_name}, ID:{_productId}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"Price: ${_price} ");
        Console.WriteLine($"Total Price: ${CalculateTotalPrice()}");
    }
    public double CalculateTotalPrice()
    {
        return _price * _quantity;
    }
    

}
