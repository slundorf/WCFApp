using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendWCF
{
    //En simpel form for database, hvor data ikke er konsistent!
    //Ville i den rigtige verden skulle udskiftes med en SQL database.
  
    public class TransientDatabase
    {
        //Arraylist med alt vores midlertidig data.
        private List<Event> events = new List<Event>();
        int unikid = 0;

        public TransientDatabase()
        {
            //Test data
            addEvent(new Event(getNewEventId(), "Fodboldsturnering", "Vi mødes nede på boldbanerne og spiller.", "Kl. 14.00", "Boldbanerne i 2. kvadrant"));
            addEvent(new Event(getNewEventId(), "Barcrawl", "Ingen beskrivelse", "Kl. 12.00", "Barene på DTU"));
            addEvent(new Event(getNewEventId(), "Paintball", "Vi mødes inde i byen og spiller.", "Kl. 17.00", "København"));
            addEvent(new Event(getNewEventId(), "Bordfodboldsturnering", "Ingen beskrivelse", "Kl. 11.00", "S-huset i Lyngby"));
            addEvent(new Event(getNewEventId(), "Ølsmagning", "Jaaaaa øller", "Kl. 19.00", "København"));
            addEvent(new Event(getNewEventId(), "Kursus i C# .NET", "Ingen beskrivelse", "Kl. 13.00", "DTU Ballerup"));
        }

        public void addEvent(Event e) => events.Add(e);
        public void deleteEvent(Event e) => events.Remove(e);
        public void deleteAllEvents() => events.Clear();
        public Event getEvent(int id)
        {
            for(int i = 0; i < events.Count; i++)
            {
                Event e = events[i];
                if(e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public void updateEvent(Event e)
        {
            for (int i = 0; i < events.Count; i++)
            {
                Event dbe = events[i];
                if (e.Id == dbe.Id)
                {
                    int index = events.IndexOf(dbe);
                    events[index] = e;
                }
            }
        }
        public String getAllEventsString()
        {
            String result = "";
       //     Event[] eventarray = events.ToArray(typeof(Event)) as Event[];
            foreach (Event e in events)
            {
                result += e.toString();
            }
            return result;
        }

        public List<Event> getAllEvents()
        {
            return events;
        }

        public int getNewEventId()
        {
            unikid++;
            return unikid;
        }

    }
}