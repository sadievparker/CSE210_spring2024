public class MindfulnessProgram
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Breathing Activity");
            Console.WriteLine(" 2. Reflection Activity");
            Console.WriteLine(" 3. Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    var breathingActivity = new BreathingActivity();
                    breathingActivity.StartActivity();
                    break;
                case "2":
                    var reflectionActivity = new ReflectionActivity();
                    reflectionActivity.StartActivity();
                    break;
                case "3":
                    var listingActivity = new ListingActivity();
                    listingActivity.StartActivity();
                    break;
                case "4":
                    Console.WriteLine("See you next time!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    break;
            }
        }
    }
}
