using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> nums = new List<int>();

        int userInput = -1;

        while (userInput != 0)
        {
            Console.Write("Enter a number: ");
            string usernumbers = Console.ReadLine();
            userInput = int.Parse(usernumbers);

            if( userInput != 0)
            {
                nums.Add(userInput);
            }
        }
        int sum = 0;
            
        foreach (int number in nums)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of your list is: {sum}");

        float average = ((float)sum) / nums.Count;
        Console.WriteLine($"The average of your list is: {average}");

        int largestNum = nums[0];
            
        foreach (int number in nums)
        {
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}