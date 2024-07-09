public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Pause(5);
        Console.WriteLine("You may begin");

        List<string> list = new List<string>();
        int endTime = Environment.TickCount + Duration * 1000; 

        while (Environment.TickCount < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            list.Add(item);
        }
        
        Console.WriteLine("");
        Console.WriteLine($"You listed {list.Count} items.");

        SaveToFile(prompt, list);
    }

     private void SaveToFile(string prompt, List<string> responses)
    {
        string filePath = "listing_activity_log.txt";
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"Prompt: {prompt}");
            writer.WriteLine("Responses:");
            foreach (string response in responses)
            {
                writer.WriteLine($"- {response}");
            }
            writer.WriteLine($"Total Responses: {responses.Count}");
            writer.WriteLine(new string('~', 20));
        }
        Console.WriteLine("Your responses have been saved to 'listing_activity_log.txt'.");
    }
}
