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
        public int Animal { get; set; }
    }
}
