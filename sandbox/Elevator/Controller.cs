public class Controller
    {
        Elevators elevator1 = new Elevators();
        Elevators elevator2 = new Elevators();
        Elevators vipElevator = new Elevators();
        public void ShowControls()
        {
            while (true)
            {
                Console.WriteLine("Please pick and your elevator: ");
                Console.WriteLine("1. Elevator 1 \n2. Elevator 1\n3. VIP Elevator\n4. Exit");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    elevator1.callElevator();
                    elevator1.closeDoors();
                }
                else if (input == "2")
                {
                    elevator2.callElevator();
                }
                else if (input == "3")
                {
                    vipElevator.callElevator();
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
    }