public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int breathInterval = 5; 
        int cycles = Duration / (2 * breathInterval); 

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            Pause(breathInterval); // Breath in for 5 seconds
            Console.WriteLine("Breathe out...");
            Pause(breathInterval); // Breath out for 5 seconds
        }
    }
}
