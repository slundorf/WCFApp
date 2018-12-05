using Microsoft.VisualStudio.TestTools.UnitTesting;
using BackendWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BackendWCF.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        static TransientDatabase db = new TransientDatabase();
        DateTime testDate = new DateTime(2018, 10, 15, 8, 30, 00);

        [TestMethod()]
        public void CreateEventTest()
        {
            db.deleteAllEvents();

            int id = db.getNewEventId();
            
            Event e = new Event(id, "Testperson Testington d. 1", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);
            //     ArrayList events = db.getAllEvents();

            //     for (int i = 0; i<events.Count; i++)
            //     {

            //         if (e.Equals(events[i]))
            //         {
            //             temp = (Event) events[i];
            //         }

            //     }
            Assert.AreSame(e, db.getEvent(id));
        }

        [TestMethod()]
        public void DeleteEventTest()
        {
            db.deleteAllEvents();

            int id = db.getNewEventId();
            Event e = new Event(id, "Testperson Testington d. 2", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);

            db.deleteEvent(db.getEvent(id));

            Assert.AreNotEqual(e, db.getEvent(id));
        }

        [TestMethod()]
        public void GetAllEventsTest()
        {
            db.deleteAllEvents();
            List<Event> testarray = new List<Event>();

            int id = db.getNewEventId();
            Event e = new Event(id, "Testperson Testington d. 3", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);
            testarray.Add(e);

            id = db.getNewEventId();
            e = new Event(id, "Testperson Testington d. 4", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);
            testarray.Add(e);

            Assert.IsTrue(testarray.SequenceEqual(db.getAllEvents()));
        }

        [TestMethod()]
        public void GetEventTest()
        {
            db.deleteAllEvents();

            int id = db.getNewEventId();
            Event e = new Event(id, "Testperson Testington d. 5", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);

            Assert.AreSame(e, db.getEvent(id));

        }

        [TestMethod()]
        public void SignupForEventTest()
        {

        }

        [TestMethod()]
        public void UpdateEventTest()
        {
            db.deleteAllEvents();

            int id = db.getNewEventId();
            Event e = new Event(id, "Testperson Testington d. 6", "Dette event er en test", testDate, "Testville");
            db.addEvent(e);

            e = new Event(id, "Testperson Testington d. 7", "Dette event er en test", testDate, "Testville");

            db.updateEvent(e);

            Assert.AreEqual(e, db.getEvent(id));
        }

        [TestMethod()]
        public void CancelForEventTest()
        {

        }
    }
}