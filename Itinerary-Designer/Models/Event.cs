using System;

namespace Itinerary_Designer.Models;

public class Event
{
    public string EventName { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime StartDateTime { get; set; }
    public TimeSpan EventDuration { get; set; }
public override string ToString()
        {
            return $"Event: {EventName}\nStart: {StartDateTime}\nDuration: {EventDuration}";
        }

    // Constructor that takes all properties as parameters
    public Event(string eventName, string description, string location, DateTime startDateTime, TimeSpan eventDuration)
    {
        EventName = eventName;
        Description = description;
        Location = location;
        StartDateTime = startDateTime;
        EventDuration = eventDuration;
    }

    // overloaded constructor with some default values set
    public Event(string eventName, DateTime startDateTime, TimeSpan eventDuration)
    {
        EventName = eventName;
        Description = "No description provided";
        Location = "No location provided";
        // Default to current date and time
        StartDateTime = DateTime.Now;
        // Default to 1 hour
        EventDuration = TimeSpan.FromHours(1); 
    }
}

