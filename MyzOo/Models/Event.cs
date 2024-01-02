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
        public int Duration { get; set; }
        public int NumAttendees { get; set; }
        public string Location { get; set; }
        public List<int> AnimalId { get; set; }

        public Event()
        {
            AnimalId = new List<int>();
        }

        public void SetData(string Id, string Description, DateTime Date, bool IsDecease, string gender, int cell, string food)
        {
            Event.SetData(Id, Description, Date, IsDecease, gender, cell, food);

        }

        public static Event GetEvent(string id, string description)
        {
            EventCrud eventCrud = new EventCrud();
            return eventCrud.GetEvent(id, description);
        }
    }
}
