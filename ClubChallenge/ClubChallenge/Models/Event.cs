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
        public virtual ICollection<MemberEventData> MemberEventDatas { get; set; }

    }
}