public abstract class MindfulnessActivity
{
    protected string Name { get; set; }
    protected string Description { get; set; }
    protected int Duration { get; set; }

    public void StartActivity()
    {
        DisplayStartingMessage();
        Pause(3); 
        PerformActivity();
        DisplayEndingMessage();
    }

    protected abstract void PerformActivity();

    private void DisplayStartingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to the {Name}!");
        Console.WriteLine("");
        Console.WriteLine($"{Description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session (in seconds)?: ");
        Duration = int.Parse(Console.ReadLine());
         Console.WriteLine("");
        Console.WriteLine("Get ready...");
    }

    private void DisplayEndingMessage()
    {   
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have  completed another {Duration} seconds of the {Name} activity.");
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
