using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BackendWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        static TransientDatabase db = new TransientDatabase();

        public void CreateEvent(string navn, string beskrivelse, DateTime dato, string sted)
        {
            //generate et random unikt id
            int id = db.getNewEventId();
            Event e = new Event(id, navn, beskrivelse, dato, sted);
            db.addEvent(e);
            Console.WriteLine("Event oprettet: " + e.toString());
        }

        public void DeleteEvent(int id)
        {
            db.deleteEvent(db.getEvent(id));
            Console.WriteLine("Event med id nummer "+id+" er slettet" );
        }

        public List<Event> GetAllEvents()
        {
            return db.getAllEvents();
        }

        public String GetAllEventString()
        {
            return db.getAllEventsString();
        }

        public Event GetEvent(int id)
        {
            return db.getEvent(id);
        }

        public void SignupForEvent()
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event e)
        {
            db.updateEvent(e);
            Console.WriteLine("Event id " + e.Id + " er opdateret med følgende info: " + e.toString());
        }

    }
}
