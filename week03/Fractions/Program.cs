using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions myFraction = new Fractions();

        myFraction.Fraction();
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
        myFraction.Fraction(5);
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
        myFraction.Fraction(3, 4);
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
        myFraction.Fraction(1, 3);
        Console.WriteLine(myFraction.GetFractionString());
        Console.WriteLine(myFraction.GetDecimalValue());
    }
}