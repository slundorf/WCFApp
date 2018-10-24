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

        public void CancelForEvent()
        {
            //Afmelder en bruger fra et event
            throw new NotImplementedException();
        }

        public void CreateEvent(string navn, string beskrivelse, string tidspunkt, string sted)
        {
            //generate et random unikt id
            int id = db.getNewEventId();
            Event e = new Event(id, navn, beskrivelse, tidspunkt, sted);
            db.addEvent(e);
        }

        public void DeleteEvent(int id)
        {
            db.deleteEvent(db.getEvent(id));
        }

        public ArrayList GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public String GetAllEventString()
        {
            return db.getAll();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
        }

        public void SignupForEvent()
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event e)
        {
            db.updateEvent(e);
        }

    }
}
