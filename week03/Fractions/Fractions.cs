public class Fractions
{
    private int _top;
    private int _bottom;

    public void Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public void Fraction(int wholeNumber)
    {
        SetTop(wholeNumber);
        _bottom = 1;
    }

    public void Fraction(int top, int bottom)
    {
        SetTop(top);
        SetBottom(bottom);
    }

    private int GetTop()
    {
        return _top;
    }

    private void SetTop(int top)
    {
        _top = top;
    }

    private int GetBottom()
    {
        return _bottom;
    }

    private void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        int top = GetTop();
        int bottom = GetBottom();

        return $"{top}/{bottom}";
    }

    public double GetDecimalValue()
    {
        int top = GetTop();
        int bottom = GetBottom();

        return (double)top / (double)bottom;
    }
}

