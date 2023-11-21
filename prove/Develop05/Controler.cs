public class Controller
{
    public void ShowControls()
    {
        while (true)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. View Goals 1 \n2. Create Goals 1\n3. Complete a goals\n4. Save Goals\n5. Load Goals\n6. Exit");
            string input = Console.ReadLine();

            if (input == "1")
            {

            }
            else if (input == "2")
            {
                Console.WriteLine("What type of goal do you want to create? \n1. Single goal\n2. Eternal Goal\n3. Checklist Goal");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Console.WriteLine("What is your goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many points do you want to get from this goal?\n");
                    int points = int.Parse(Console.ReadLine());
                    Goal goal = new Goal();
                    goal.create_goal("S",points,nameof);
                }
                else if (input2 == "2")
                {
                    Console.WriteLine("What is your eternal goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many points do you want every time you do this?\n");
                    int points = int.Parse(Console.ReadLine());
                    Eternal eternal = new Eternal();
                    eternal.create_goal("E",points,nameof);
                }
                else if (input2 == "3")
                {
                    Console.WriteLine("What is your checklist goal?\n");
                    string nameof = Console.ReadLine();
                    Console.WriteLine("How many times do you want to do this task?\n");
                    int requirement = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many points do you want every time you do this?\n");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine($"How many points do you want when you complete this goal {requirement} times?\n");
                    int reward = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist();
                    checklist.create_goal("C",)
                }
                else
                {Console.WriteLine("Invalid input! Please try again.");}
            }
            else if (input == "3")
            {
                string _filename = "goals.txt";

                    using (StreamWriter outputFile = new StreamWriter(_filename))
                    {
                        outputFile.WriteLine($"{_totalPoints}");

                        foreach (var goal in _goals)
                        {
                            if (goal.Type == "checklist")
                            {
                                outputFile.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.Type},{goal.BonusAmount},{goal.BonusTimes},{goal.TimesTillBonus}");
                            }
                            else
                            {
                                outputFile.WriteLine($"{goal.Name},{goal.Description},{goal.Points},{goal.Type}");
                            }
                        }
                    }
                }
            }}
            else if (input == "4")
            {
                break;
            }
            else if (input == "5")
            {

            }
            else if (input == "6")
            {
                
            }
            else
            {
                Console.WriteLine("Invalid input! Please try again.");
            }
        }
    }
}