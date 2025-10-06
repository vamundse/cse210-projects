public abstract class Shape
{
    private string _color;
    private string _type;

    public Shape(string type)
    {
        _type = type;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetShapeType()
    {
        return _type;
    }

    public void SetShapeType(string type)
    {
        _type = type;
    }

    public abstract double GetArea();
}