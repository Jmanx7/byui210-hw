using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
    //Product Data
    private string _name;
    private double _price;
    private int _productId;
    private int _quantity;

    // Constructors
    public Product()
    {
        SetName("n/a");
        SetPrice(0.0);
        SetProductId(0);
        SetQuantity(0);
    }
    public Product(string name, double price, int id, int quantity)
    {
        SetName(name);
        SetPrice(price);
        SetProductId(id);
        SetQuantity(quantity);
    }

    //Get the total cost
    public double GetTotalCost()
    {
        return GetPrice() * GetQuantity();
    }

    // Name Setter & Getter
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    //Product ID Getter & Setter
    public int GetProductId()
    {
        return _productId;
    }
    public void SetProductId(int productId)
    {
        _productId = productId;
    }

    //Quantity Getter & Setter
    public int GetQuantity()
    {
        return _quantity;
    }
    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    //Price setter & getter
    public double GetPrice()
    {
        return _price;
    }
    public void SetPrice(double price)
    {
        _price = price;
    }
}
