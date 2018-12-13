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
    [ServiceContract]
    public interface IService1
    {
        // Vores metoder som skal kunne kaldes fra en client
        [OperationContract]
        void CreateEvent(String navn, String beskrivelse, String tidspunkt, String sted);

        [OperationContract]
        void UpdateEvent(Event e);

        [OperationContract]
        void DeleteEvent(int id);

        [OperationContract]
        Event GetEvent(int id);

        [OperationContract]
        List<Event> GetAllEvents();

        [OperationContract]
        String GetAllEventString();

        [OperationContract]
        void SignupForEvent();

        [OperationContract]
        void CancelForEvent();

    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
