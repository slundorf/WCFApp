using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using ServiceReference1;

namespace WebApplication2.Controllers
{
    public class EventController : Controller
    {
        EventListModel eventListModel = new EventListModel();
        public IActionResult Index()
        {
            List<Event> events = eventListModel.events.ToList();
            return View(events);
        }
    }
}