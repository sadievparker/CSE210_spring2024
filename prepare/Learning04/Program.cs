
class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Sadie Parker", "Linear Algebra");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Dallin Archibald", "Fractions", "1.8", "2-7");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Summer Miller", "English", "How to establish world peace.");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}
