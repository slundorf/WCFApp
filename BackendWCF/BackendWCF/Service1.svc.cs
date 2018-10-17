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
        public bool CancelForEvent()
        {
            throw new NotImplementedException();
        }

        public bool CreateEvent()
        {
            // Husk at tjekke om et event allerede eksisterer (navn)
            throw new NotImplementedException();
        }

        public bool CreateEvent(string navn, string beskrivelse, string tidspunkt, string sted)
        {
            //generate et random unikt id
            throw new NotImplementedException();
        }

        public bool DeleteEvent()
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvent(Event e)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public bool GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public bool GetAllEventsList()
        {
            throw new NotImplementedException();
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

        public bool GetEvent()
        {
            throw new NotImplementedException();
        }

        public Event GetEvent(Event e)
        {
            throw new NotImplementedException();
        }

        public Event GetEvent(int id)
        {
            throw new NotImplementedException();
        }

        public bool SignupForEvent()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent()
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event e)
        {
            throw new NotImplementedException();
        }

        void IService1.CancelForEvent()
        {
            throw new NotImplementedException();
        }

        void IService1.CreateEvent(string navn, string beskrivelse, string tidspunkt, string sted)
        {
            throw new NotImplementedException();
        }

        ArrayList IService1.GetAllEvents()
        {
            throw new NotImplementedException();
        }

        void IService1.SignupForEvent()
        {
            throw new NotImplementedException();
        }
    }
}
