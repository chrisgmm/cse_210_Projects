using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage?");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >=70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("Your grade is: " + grade);

        if (grade == "A"|| grade == "B"|| grade =="C" )
        {
            Console.Write("You passed!");
        }
        else 
        {
            Console.Write("Better luck next time!");
        }

    }
}