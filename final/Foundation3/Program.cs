using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("150 N 2nd E", "Rexburg", "ID", "83440");
        Address address2 = new Address("7123 Michael Ave ", "Gilbert", "AZ", "83456");
        Address address3 = new Address("89 W 2nd Terrace", "Los Angels", "CA", "90005");

        Lecture lecture = new Lecture("The Psychology of Success", "90 min lecture to the road of success.", new DateTime(2024, 7, 25), new TimeSpan(14, 0, 0), address1, "Brother Jones", 100);
        Reception reception = new Reception("Archibald Wedding", "Sadie and Dallin's Wedding Reception", new DateTime(2024, 2, 17), new TimeSpan(18, 0, 0), address2, "archibald@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Pickleball Tournament", "Winner wins $100", new DateTime(2024, 10, 1), new TimeSpan(11, 0, 0), address3, "Partly cloudy");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("");
            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("");
            Console.WriteLine("Short Description: ");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
