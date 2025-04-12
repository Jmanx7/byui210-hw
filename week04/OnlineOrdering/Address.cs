using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    //Constructors
    public Address()
    {
        SetStreet("Unknown Street");
        SetCity("?????");
        SetState("??");
        SetCountry("USA");
    }
    public Address(string street, string city, string state, string country)
    {
        SetStreet(street);
        SetCity(city);
        SetState(state);
        SetCountry(country);
    }

    //Check if the country is the USA
    public Boolean IsUSA()
    {
        return GetCountry() == "USA";
    }

    //returns a strang of the class' values
    public string GetString()
    {
        return GetStreet() + ", " + GetCity()+", " + GetState() + ", " + GetCountry();
    }

    //Street Getter and Setter
    public string GetStreet()
    {
        return _street;
    }
    public void SetStreet(string street)
    {
        _street = street;
    }

    //City Getter and Setter
    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    //State Getter and Setter
    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    //Country Getter and Setter
    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}
