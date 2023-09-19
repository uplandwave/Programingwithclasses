using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        List<int> numbers = new List<int>();
        //New numbers 
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (num != 0) {
            Console.Write("Enter Number: ");
            string guess = Console.ReadLine();
            num = int.Parse(guess);
            numbers.Add(num);
        }
        //Finding the sum
        int sum = 0;
        foreach (int i in numbers) {
            sum = sum + i;
        }
        Console.WriteLine($"The sum is: {sum}");

        //Finding the average 
        int av = 0;
        av = sum / numbers.Count;
        Console.WriteLine($"The average is: {av}");

        //Finding the biggest number
        int big = 0;
        foreach (int i in numbers) {
            if (big < i){
                big = i;
            }
        }
        Console.WriteLine($"The largest number is: {big}");

    }
}