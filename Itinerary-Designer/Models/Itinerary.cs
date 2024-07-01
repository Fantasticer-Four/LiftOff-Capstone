using System;

namespace Trip_Designer.Models;

public class Itinerary
{
    public string ItineraryName { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime StartDateTime { get; set; }
    public TimeSpan ItineraryDuration { get; set; }

     // Default value for EventDuration
        private static readonly TimeSpan DefaultItineraryDuration = TimeSpan.FromHours(1);

        private static readonly DateTime DefaultStartDateTime = DateTime.Now;
public override string ToString()
        {
            return $"Itinerary: {ItineraryName}\nStart: {StartDateTime}\nDuration: {ItineraryDuration}";
        }

    // Constructor that takes all properties as parameters
    public Itinerary(string itineraryName, string description, string location, DateTime startDateTime, TimeSpan itineraryDuration)
    {
        ItineraryName = itineraryName;
        Description = description;
        Location = location;
        StartDateTime = startDateTime;
        ItineraryDuration = itineraryDuration;
    }

    // Overloaded constructor with the default duration value and default startdatetime
        public Itinerary (string eventName, DateTime startDateTime)
        {
            ItineraryName = eventName;
            Description = "No description provided";
            Location = "No location provided";
            StartDateTime = DefaultStartDateTime; //default value
            ItineraryDuration = DefaultItineraryDuration; //default value
        }
}

