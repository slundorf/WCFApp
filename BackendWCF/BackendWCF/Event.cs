﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackendWCF
{
    public class Event
    {
        int id { get; set; }
        String navn { get; set; }
        String beskrivelse { get; set; }
        String tidspunkt { get; set; }
        String sted { get; set; }
    }
}