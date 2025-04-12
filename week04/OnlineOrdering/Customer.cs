using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Customer
{
    //Customer Data
    private string _name;
    private Address _address;

    //Constructors
    public Customer()
    {
        SetName("n/a");
        SetAddress(new Address());
    }
    public Customer(string name, Address address)
    {
        SetName(name);
        SetAddress(address);
    }
    public Customer(string name, string street, string city, string state, string country)
    {
        SetName(name);
        SetAddress(new Address(street, city, state, country));
    }

    //Determine whether customer lives in the US
    public Boolean IsUSA()
    {
        return GetAddress().IsUSA();
    }

    //Name Setter & Getter
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    //Address setter/getter
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
}
