using System;

namespace Itinerary.Models
{
    public class Itinerary
    {
        public string ItineraryName { get; set; }

        public int PeopleCount { get; set; }

        public double CalculatedCost { get; set; }
        public List<string> SelectedEvents { get; set; } = new List<string>();

        public int Id { get; set; }
        private static int nextId = 1;

        public Itinerary()
        {
            Id = nextId;
            nextId++;
        }

        public Itinerary(string itineraryname)
        {
            ItineraryName = itineraryname;
            Id = nextId;
            nextId++;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

    public class Event {}
}


// https://github.com/Carolista/CodingEventsCSharp/tree/models