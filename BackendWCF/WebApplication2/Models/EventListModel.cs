﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceReference1;

namespace WebApplication2.Models
{
    public class EventListModel:List<EventModel>
    {
        public List<EventModel> Events { get; set; }
    }
}