using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendWCF
{
    [Serializable()]
    public class Event
    {
        public int Id { get; set; }
        public String Navn { get; set; }
        public String Beskrivelse { get; set; }
        public DateTime Dato { get; set; }
        public String Sted { get; set; }

        public Event(int id, String navn, String beskrivelse, DateTime dato, String sted)
        {
            Id = id;
            Navn = navn;
            Beskrivelse = beskrivelse;
            Dato = dato;
            Sted = sted;
        }

        public String toString() => "[" + Id + "," + Navn + "," + Beskrivelse + "," + Dato.ToLongDateString() + "," + Sted + "]";
    }
}