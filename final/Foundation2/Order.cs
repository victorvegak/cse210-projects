
using System.Net.Http.Headers;

class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order (Customer customer)
    {
        _customer = customer;
        _product = new List<Product>();
    }
    // We will need to add a new Method AddProduct
    public void AddProduct(Product product)
    {
        _product.Add(product); 
    }

    public double CalculateTotalPrice()
    {
        double TotalPrice = 0;
        foreach(var product in _product)
        {
            TotalPrice += product.CalculateTotalPrice();
        }

        //Shipping cost 
        if (_customer.IsInUSA())
        {
            TotalPrice += 5.00;
        }
        else
        {
            TotalPrice += 35.00;
        }                   

        return TotalPrice;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _product)
        {
            label += $"{product.GetName()}, {product.GetProductId()}";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}, {_customer.GetAddress().GetFormattedAddress()}";
    }

}