using System.Diagnostics.Contracts;

public class Breathing : Activity
    {
        public Breathing() : base("Breathing", "Focus on your breath and clam down."){}

        public void StartActivity()
        {
            base.StartBace();
            Console.WriteLine("Take a deep breath");
            Console.WriteLine("Breath in...");
            base.countDown();
            Console.WriteLine("Breath out...");
            base.countDown();
            // Thread.Sleep(_mathTime/2);
            base.EndActivity();
            base.countDown();
        }
    }