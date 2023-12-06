using System;

public class OutdoorGathering : Event
{
    private string WeatherForecast { get; set; }

    public OutdoorGathering(string eventTitle, string description, DateTime dateAndTime, Address address, string weatherForecast)
        : base(eventTitle, description, dateAndTime, address)
    {
        WeatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather Forecast: {WeatherForecast}";
    }
}
