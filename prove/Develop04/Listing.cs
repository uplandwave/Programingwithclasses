public class Listing : Activity
    {
        string[] _prompts = { "Who are you grateful for?", "Do you have any strengths?", "Are you still alive?"};

        public Listing() : base("Listing", "Write as many entries as you want."){}

        public new void StartActivity(){
            base.StartActivity();
            int rando = new Random().Next(0, _prompts.Length);
            Console.WriteLine(_prompts[rando]);

            int counter = 0;
                string entrie = Console.ReadLine();
                if (!string.IsNullOrEmpty(entrie)) // I don't know if this works.
                {
                    counter++;
                }

            Console.WriteLine($"You listed {counter} items.");
            base.EndActivity();
        }
    }