using System;

class Promped {
    public List<string> _prompts = new List<string>();
    Journal journal = new Journal();

    public Promped() {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("How many ducks did you spit on today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("How did you get closer to ruling the world today?");
        _prompts.Add("Did you hurt anyone's feelings?");

    }
    //When called this should print out a list for the user to chose
    public void Run() {
        while(true) {
            Console.WriteLine();
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
            string option = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|_|");
            int optint;

            int.TryParse(option, out optint);

            switch(optint) {
                case 1:
                //this is were a random promped is selected 
                    Random rando = new Random();
                    int promptIndex = rando.Next(0,_prompts.Count());
                    Console.WriteLine("Prompt: " + _prompts[promptIndex]);
                    Console.Write("Response: ");
                    string response = Console.ReadLine() ?? string.Empty;
                    journal.AddEntry(_prompts[promptIndex], response);
                    break;

                case 2:
                    journal.DisplayJournal();
                    break;

                case 3:
                    Console.Write("Enter a filename: ");
                    string filename = Console.ReadLine() ?? string.Empty;
                    journal.Load(filename);
                    break;

                case 4:
                    Console.Write("Enter a filename: ");
                    filename = Console.ReadLine() ?? string.Empty;
                    journal.Save(filename);
                    break;

                case 5:
                    Console.Write("Quitting...");
                    break;
                default:
                    return;
            }
            if (optint == 5) {
                break;
            }
        };
    }
}