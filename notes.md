# Notes for Class so I can pass
---
**Variables**
When a variable is declared, its data type must be specified

>int x;
x = 5; 
Console.WriteLine(x);

You can also declare a variable an initialize it in one statement:
> int x = 5;
Console.WriteLine(x);

To print or write something out use this
>Console.WriteLine("Hello World!");

or if you do not want it to automaticaly write a new line after use this
>Console.Write("There will not be a newline after this.");

Getting imputs 
>Console.Write("What is your favorite color? ");
string color = Console.ReadLine();

If statements ie. no indent 
>if (x > y)
{
  Console.WriteLine("greater");
}

String interpolation ie. use the $ insted of f
>string school = "BYU-Idaho";
Console.WriteLine($"I am studying at {school}.");

If, elce, elif
>if (x > y)
{
    Console.WriteLine("greater than y");
}
else if (x > z)
{
    Console.WriteLine("greater than z");
}
else
{
    Console.WriteLine("less than both");
}

Oporators
>if (name == "John")
{
    Console.WriteLine("The name is John");
}

>if (color != favoriteColor)
{
    Console.WriteLine("That color is not my favorite");
}

>if (name == "Peter" || name == "James" || name == "John")
{
    Console.WriteLine("This is a biblical name.");
}

>if (firstName == "Brigham" && lastName == "Young")
{
    Console.WriteLine("Welcome Brother Brigham!");
}

>if (!(name == "Peter" || name == "James" || name == "John"))
{
    Console.WriteLine("This is a not one of those three");
}

Converting Strings 
>string valueInText = "42";
int number = int.Parse(valueInText);

Expecialy when you get a mumber back from a user
>Console.Write("What is your favorite number? ");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

Number to string
>int number = 42;
string textVersion = number.ToString();

**Loops**

string response = "yes";

while (response == "yes")
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
}

string response;

do
{
    Console.Write("Do you want to continue? ");
    response = Console.ReadLine();
} while (response == "yes");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

if you are confused on the ++ it is jsut shortening the sintax for this 

for (int i = 2; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}

foreach (string color in colors)
{
    Console.WriteLine(color);
}

**Getting Random numbers.**
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 11);

**Lists**
List<int> numbers;
List<string> words;

For adding to lists

>using System.Collections.Generic;

...

List<string> words = new List<string>();

words.Add("phone");
words.Add("keyboard");
words.Add("mouse");

For couniting Lists
Console.WriteLine(words.Count);

Loop Through Lists 
foreach (string word in words)
{
    Console.WriteLine(word);
}

Acces the list by index
for (int i = 0; i < words.Count; i++)
{
    Console.WriteLine(words[i]);
}


