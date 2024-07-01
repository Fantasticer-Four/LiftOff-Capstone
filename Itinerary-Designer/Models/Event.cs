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
}

     