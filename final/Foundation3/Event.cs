using System;

public class Event
{
    protected string EventTitle { get; set; }
    protected string Description { get; set; }
    protected DateTime DateAndTime { get; set; }
    protected Address EventAddress { get; set; }

    public Event(string eventTitle, string description, DateTime dateAndTime, Address address)
    {
        EventTitle = eventTitle;
        Description = description;
        DateAndTime = dateAndTime;
        EventAddress = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {EventTitle}\nDescription: {Description}\nDate & Time: {DateAndTime}\nAddress: {EventAddress}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent: {EventTitle}\nDate: {DateAndTime.Date}";
    }
}
