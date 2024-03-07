using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        //int magic = 5;
        Console.WriteLine("What is the magic number?");
        Random choice = new Random();
        int magic = choice.Next(1,100);
        while (guess != magic)
        {
            string response = Console.ReadLine();
            guess = int.Parse(response);
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Nice guess! You got it!");
            }
        }
    }
}