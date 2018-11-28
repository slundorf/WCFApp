using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace WebApplication2.Models
{

    public class EventModel:Event
    {
        
        public int id { get; set; }
        public String Navn { get; set; }
        public String Beskrivelse { get; set; }
        public String Tidspunkt { get; set; }
        public String Sted { get; set; }

    }
}
