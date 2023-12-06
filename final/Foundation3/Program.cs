using System;

class Program
{
    static void Main(string[] args)
    {
        Address eventAddress = new Address
        {
            Street = "12 Main St",
            City = "Idaho falls",
            State = "Idaho",
            ZipCode = "83404"
        };

        Lecture lectureEvent = new Lecture("New Technologies", "Exploring the latest technologies shaping the future!", new DateTime(2023, 12, 15), eventAddress, "Matthew Strobel", 30);
        Reception receptionEvent = new Reception("Socal Mixer", "A social gathering for singles!", new DateTime(2023, 12, 20), eventAddress, "rsvp@gmail.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Annual company picnic", "Join us for fun and games and great food!", new DateTime(2023, 6, 2), eventAddress, "Sunny weather 70 degrees");

        Event[] events = { lectureEvent, receptionEvent, outdoorEvent };

        foreach (Event ev in events)
        {
            Console.WriteLine("\nStandard Details:");
            Console.WriteLine(ev.GetStandardDetails());

            Console.WriteLine("\nFull Details:");
            Console.WriteLine(ev.GetFullDetails());

            Console.WriteLine("\nShort Description:");
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}
