using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GUIWPF
{
    [Serializable()]
    public class Event
    {
        public int Id { get; set; }
        public String Navn { get; set; }
        public String Beskrivelse { get; set; }
        public String Tidspunkt { get; set; }
        public String Sted { get; set; }

        public Event(int id, String navn, String beskrivelse, String tidspunkt, String sted)
        {
            Id = id;
            Navn = navn;
            Beskrivelse = beskrivelse;
            Tidspunkt = tidspunkt;
            Sted = sted;
        }

        public String toString() => "[" + Id + "," + Navn + "," + Beskrivelse + "," + Tidspunkt + "," + Sted + "]";
    }
}