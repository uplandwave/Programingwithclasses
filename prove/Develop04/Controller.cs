public class Controller{
    public void ShowControls(){
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("Mindfulness is easy, pick an activity:");
            Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. Exit");
            Console.WriteLine("========================================");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Breathing breathing = new Breathing();
                breathing.StartActivity();
            }
            else if (input == "2")
            {
                Reflection reflection = new Reflection();
                reflection.StartActivity();
            }
            else if (input == "3")
            {
                Listing listing = new Listing();
                listing.StartActivity();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again.");
            }
        }
    }

    // public static void ShowControls()
    // {
    //     while (true)
    //     {
    //         Console.WriteLine("Welcome to your activity session");
    //         Console.WriteLine("Please select an activity:");
    //         Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. Exit");
    //         string input = Console.ReadLine();
    //         int quit;
    //         int.TryParse(input, out quit);

    //         switch (quit)
    //         {
    //             case 1:
    //                 Breathing breathing = new Breathing();
    //                 breathing.StartActivity();
    //                 break;

    //             case 2:
    //                 break;

    //             case 3:
    //                 break;

    //             case 4:
    //                 break;

    //             case 5:
    //                 Console.Write("Quitting...");
    //                 break;
    //             default:
    //                 return;
    //         }
    //         if (quit == 5)
    //         {
    //             break;
    //         }
    //     };
    // }
}