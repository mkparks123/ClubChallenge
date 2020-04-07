using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class Event
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? EventDate { get; set; }
        public TimeSpan EventStartTime { get; set; }
        public TimeSpan EventEndTime { get; set; }
        public int EventTotalTime { get; set; }
        public virtual ICollection<Member> Members { get; set; }

    }
}