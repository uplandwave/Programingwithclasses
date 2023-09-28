// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Job lds = new Job("LDS Church", "Manager", 2019, 2023);
lds.Display();

Resume myResume = new Resume();
myResume._name = "Allison Rose";

myResume._jobs.Add(lds);
// myResume._jobs.Add();
myResume.Display();
    