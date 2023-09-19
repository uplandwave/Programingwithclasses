using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        int newguess = 1000;
        while (newguess != number)
        {
            Console.WriteLine($"Try Guessing the Magic number. {number}");
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            newguess = int.Parse(guess);
            //Console.WriteLine(newguess + 4);
            if (newguess < number){
                Console.WriteLine("Higher");
            }
            else if (newguess > number){
                Console.WriteLine("Lower");
            }
            else{
                Console.WriteLine("You got it");
            }
    }
}}