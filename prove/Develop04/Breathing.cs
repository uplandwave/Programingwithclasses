public class Breathing : Activity
    {
        public Breathing() : base("Breathing", "Focus on your breath and clam down."){}

        public new async void StartActivity()
        {
            base.StartActivity();
            Console.WriteLine("Take a deep breath");
            await Task.Delay(_mathTime/2);
            // Wait wait = new Wait();
            // wait.Pause(_mathTime/2); 
            Console.WriteLine("Breath in... Breath out");
            await Task.Delay(_mathTime/2);
            // wait.Pause(_mathTime); 
            await Task.Delay(_mathTime);
            base.EndActivity();
        }
    }