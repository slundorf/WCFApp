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
        private ArrayList events = new ArrayList();
        int unikid = 0;

        public void addEvent(Event e) => events.Add(e);
        public void deleteEvent(Event e) => events.Remove(e);
        public Event getEvent(int id)
        {
            for(int i = 0; i >= events.Count; i++)
            {
                Event e = (Event) events[i];
                if(e.Id == id)
                {
                    return e;
                }
            }
            return null;
        }

        public void updateEvent(Event e)
        {
            for (int i = 0; i >= events.Count; i++)
            {
                Event dbe = (Event) events[i];
                if (e.Id == dbe.Id)
                {
                    int index = events.IndexOf(dbe);
                    events[index] = e;
                }
            }
        }

        public int getNewEventId()
        {
            unikid++;
            return unikid;
        }

    }
}