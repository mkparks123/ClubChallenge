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
        [Display(Name = "Date")]
        public DateTime? EventDate { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        public TimeSpan EventStartTime { get; set; }
        [Required]
        [Display(Name = "End Time")]
        public TimeSpan EventEndTime { get; set; }
        public int EventTotalTime{ get; set; }
        public virtual ICollection<Member> Members { get; set; }


    }
}