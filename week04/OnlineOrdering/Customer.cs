public class Customer
{
    private string _customer;
    private Address _address;
    public Customer(string customer, Address address)
    {
        _customer = customer;
        _address = address;
    }

    public string GetName()
    {
        return _customer;
    }

    public string GetAddress()
    {
        return _address.FullAddress();
    }

    public bool UsaCountry()
    {
        return _address.UsaCountry();
        
    }
}