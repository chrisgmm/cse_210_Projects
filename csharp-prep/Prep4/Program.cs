using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int value = -1;
        while (value != 0) 
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string response = Console.ReadLine();
            value = int.Parse(response);

            if (value != 0)
            {
                numbers.Add(value);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("The sum is " + sum);

        float mean = ((float)sum / numbers.Count);
        Console.WriteLine("The average is: " + mean);

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("The max is: " + max);
    }
}