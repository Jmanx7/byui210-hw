using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Order
{
    //list of products
    private List<Product> _products = new List<Product>();
    //customer
    private Customer _customer;
    
    //Constructors
    public Order()
    {
        SetCustomer(new Customer());
    }
    public Order(string name, string street, string city, string state, string country)
    {
        SetCustomer(new Customer(name, street, city, state, country));
    }

    public double GetTotalCost()
    {
        double tempPrice = 0;
        //get price for every product
        for (int i = 0; i < GetProductList().Count(); i++)
        {
            tempPrice += GetProduct(i).GetTotalCost();
        }
        //Shipping cost based on country
        if (GetCustomer().IsUSA())
        {
            tempPrice += 5;
        } else
        {
            tempPrice += 35;
        }

        return tempPrice;

    }

    //Create the Packing Label & Show it to the user
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        //get each product ID
        for (int i = 0; i < GetProductList().Count(); i++)
        {
            Console.WriteLine(GetProduct(i).GetName());
            Console.WriteLine("ID: "+ GetProduct(i).GetProductId());
        }
        //spacing
        Console.WriteLine("");
    }
    //Create the Shippinh Label & Show it to the user
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");

        //Get Name & The String of the Address
        Console.WriteLine(GetCustomer().GetName());
        Console.WriteLine(GetCustomer().GetAddress().GetString());
        //spacing
        Console.WriteLine("");
    }

    //Customer Getter and Setter 
    public Customer GetCustomer()
    {
        return _customer;
    }
    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    //Product Getter & Setters
    public List<Product> GetProductList()
    {
        return _products;
    }
    public Product GetProduct(int index)
    {
        return _products[index];
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}
