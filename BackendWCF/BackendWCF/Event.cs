using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendWCF
{
    public class Event
    {
        public int id { get; set; }
        public String navn { get; set; }
        public String beskrivelse { get; set; }
        public String tidspunkt { get; set; }
        public String sted { get; set; }
    }
}