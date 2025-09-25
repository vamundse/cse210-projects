class Product
{
    private string _name;
    private int _ID;
    private double _price;
    private int _quantity;

    public Product()
    {
        _name = "No name";
        _ID = 0;
        _price = 0.00;
        _quantity = 0;
    }

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _ID;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public double ProductCost()
    {
        double total = (double)_price * _quantity;
        return total;
    }
}