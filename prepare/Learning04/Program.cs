Assignment a = new Assignment("Samuel Bennett", "Multiplication");
Console.WriteLine(a.GitSummary());
a.GitSummary();
a.Display();

MathAssignment m = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
Console.WriteLine(m.GitSummary());
Console.WriteLine(m.GetHomeworkList());

WritingAssignment w = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
Console.WriteLine(w.GitSummary());
Console.WriteLine(w.GetWritingInformation());
