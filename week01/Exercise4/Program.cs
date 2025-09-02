using System;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;

class GFG : IComparer<int>
{
    public int Compare(int x, int y)
    {
        if (x == 0 || y == 0)
        {
            return 0;
        }
        
        // CompareTo() method
        return x.CompareTo(y);
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int sum = 0;
        int rounds = 0;
        int userNumber = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string firstUserNumber = Console.ReadLine();
            userNumber = int.Parse(firstUserNumber);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            
            rounds += 1;
            sum += userNumber;
        }

        rounds--;
        float average = (float)sum / rounds;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"Number of rounds: {rounds}");
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;

        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        int smallestNumber = 999999999;

        foreach (int number in numbers)
        {
            if (number < smallestNumber && number > 0)
            {
                smallestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest postive number is: {smallestNumber}");

        // "gg" is the object oif class GFG
        GFG gg = new GFG();
        
        Console.WriteLine("The sorted list:");
        
        // use of List<T>.Sort(IComparer<T>) 
        // method. The comparer is "gg"
        numbers.Sort(gg);
        
        foreach( int g in numbers )
        {
            
            // Display sorted list
            Console.WriteLine(g);
            
        }
    }
}