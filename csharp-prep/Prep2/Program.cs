using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = "done";
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What was your score? ");
        string score = Console.ReadLine();
        int number = int.Parse(score);
        if (number >= 90)
        {
            grade = ("You got an A! You passed!");
        }
        else if (number < 90 && number >= 80)
        {
            grade = ("You got a B. You passed!");
        }
        else if (number < 80 && number >= 70)
        {
            grade = ("You got a C. You passed!");
        }
        else if (number < 70 && number >= 60)
        {
            grade = ("You got a D. You did not pass, maybe try studying");
        }
        else
        {
            grade = ("You got an F. You did not pass, maybe try studying");
        }
        Console.WriteLine(grade);
    } 
}