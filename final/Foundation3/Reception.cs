using System;

public class Reception : Event
{
    private string RsvpEmail { get; set; }

    public Reception(string eventTitle, string description, DateTime dateAndTime, Address address, string rsvpEmail)
        : base(eventTitle, description, dateAndTime, address)
    {
        RsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {RsvpEmail}";
    }
}
