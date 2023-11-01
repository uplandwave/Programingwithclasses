using System.Diagnostics.Contracts;

public class Breathing : Activity
    {
        public Breathing() : base("Breathing", "Focus on your breath and clam down."){}

        public void StartActivity()
        {
            base.StartBace();
            Console.WriteLine("Take a deep breath");
            Thread.Sleep(_mathTime/2);
            Console.WriteLine("Breath in... Breath out");
            Thread.Sleep(_mathTime/2);
            base.EndActivity();
            Thread.Sleep(5000);
        }

        // public async void CallEndAct(){
        //     base.EndActivity();
        // }
    }