using MyzOo.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Event
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public DateTime HourBegin { get; set; }
        public DateTime Date {  get; set; }
        public int Duration { get; set; }
        public int NumAttendees { get; set; }
        public string Location { get; set; }
        public List<int> AnimalId { get; set; }

        public Event()
        {
            AnimalId = new List<int>();
        }

        public void SetData(string Id, string Description, DateTime HourBegin, DateTime Date, int Duration, int NumAttendees, string Location, List<int> AnimalId)
        {
            EventCrud eventCrud = new EventCrud();
            eventCrud.SetData(Id, Description, HourBegin, Date, Duration, NumAttendees, Location, AnimalId);
        }

        public static Event GetEvent(string id, string description)
        {
            EventCrud eventCrud = new EventCrud();
            return eventCrud.GetEvent(id, description);
        }
    }
}
