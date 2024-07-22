using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine($"You have {goalManager.GetTotalPoints()} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;

                case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFilename = Console.ReadLine();
                    goalManager.SaveGoals(saveFilename);
                    break;

                 case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFilename = Console.ReadLine();
                    goalManager.LoadGoals(loadFilename);
                    break;

                case "5":
                    Console.Write("Enter goal number to record event: ");
                    int goalNumber = int.Parse(Console.ReadLine());
                    goalManager.RecordEvent(goalNumber - 1);
                    break;
            
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddNewGoal(GoalManager goalManager)
    {
        while (true)
        {
            Console.WriteLine("The type of goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Which goal would you like to create?: ");
            string goalTypeChoice = Console.ReadLine();

            switch (goalTypeChoice)
            {
                case "1":
                    Console.Write("What is the name of your goal?: ");
                    string simpleGoalName = Console.ReadLine();
                    Console.Write("How many points do you want associated with this goal?: ");
                    int simpleGoalPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new SimpleGoal(simpleGoalName, simpleGoalPoints));
                    return;
                case "2":
                    Console.Write("What is the name of your goal?: ");
                    string eternalGoalName = Console.ReadLine();
                    Console.Write("How many points do you want associated with this goal?: ");
                    int eternalGoalPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new EternalGoal(eternalGoalName, eternalGoalPoints));
                    return;
                case "3":
                    Console.Write("What is the name of your goal?: ");
                    string checklistGoalName = Console.ReadLine();
                    Console.Write("How many points do you want associated with this goal?: ");
                    int checklistGoalPoints = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
                    int targetCount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? : ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(checklistGoalName, checklistGoalPoints, targetCount, bonusPoints));
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
