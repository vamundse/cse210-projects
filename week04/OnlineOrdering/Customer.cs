class Customer
{
    private string _name;
    private Adress _adress;

    public Customer()
    {
        _name = "No name";
    }

    public Customer(string name, Adress adress)
    {
        _name = name;
        _adress = adress;
    }

    public string GetName()
    {
        return _name;
    }

    public Adress GetAdress()
    {
        return _adress;
    }

    public bool LivesInUSA()
    {
        if (_adress.CheckUS() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}