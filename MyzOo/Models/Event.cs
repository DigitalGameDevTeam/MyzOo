using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Classes
{
    internal class Event
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime HourBegin { get; set; }
        public int Duration { get; set; }
    }
}
