using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        if (number > 90)
        {
            Console.WriteLine("You got an A! You passed!");
        }
        else if (number < 90 && number > 80)
        {
            Console.WriteLine("You got a B. You passed!");
        }
        else if (number < 80 && number > 70)
        {
            Console.WriteLine("You got a C. You passed!");
        }
        else if (number < 70 && number > 60)
        {
            Console.WriteLine("You got a D. You did not pass");
        }
        else
        {
            Console.WriteLine("You got an F. You did not pass");
        }
    } 
}