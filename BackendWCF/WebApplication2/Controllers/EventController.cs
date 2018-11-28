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
        EventModel eventModel = new EventModel();
   
        public IActionResult Index()
        {
            List<EventModel> e = new List<EventModel>();

            e = eventListModel.ToList();

            return View(e);
        }
    }
}