public class Listing : Activity
    {
        string[] _prompts = { "Who are people that you appreciate?", "What are personal strengths of yours?",
            "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };

        public Listing() : base("Listing", "Write as many entries as you want."){}

        public new void StartActivity(){
            base.StartActivity();
            int rando = new Random().Next(0, _prompts.Length);
            Console.WriteLine(_prompts[rando]);

            int counter = 0;
                string entrie = Console.ReadLine();
                if (!string.IsNullOrEmpty(entrie))
                {
                    counter++;
                }

            Console.WriteLine($"You listed {counter} items.");
            base.EndActivity();
        }
    }