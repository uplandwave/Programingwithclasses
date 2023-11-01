public class Listing : Activity
    {
        string[] _prompts = { "Who are you grateful for?", "Do you have any strengths?", "Are you still alive?"};

        public Listing() : base("Listing", "Write as many entries as you want."){}


        public void StartActivity(){
            base.StartBace();
            int rando = new Random().Next(0, _prompts.Length);
            Console.WriteLine(_prompts[rando]);
            
            int counter = 0;
            DateTime endTime = DateTime.Now.AddSeconds(_time);

            while (DateTime.Now < endTime){
                string entrie = Console.ReadLine();
                if (!string.IsNullOrEmpty(entrie)) // I don't know if this works.
                {
                    counter++;
                }}
            Console.WriteLine($"You listed {counter} items.");
            base.EndActivity();
            base.countDown();


        }
    }