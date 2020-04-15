using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class Event
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime? EventDate { get; set; }
        [Required]
        public TimeSpan EventStartTime { get; set; }
        [Required]
        public TimeSpan EventEndTime { get; set; }
        public int EventTotalTime{ get; set; }
        public virtual ICollection<Member> Members { get; set; }


    }
}