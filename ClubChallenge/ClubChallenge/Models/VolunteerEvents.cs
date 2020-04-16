using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class VolunteerEvents
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display( Name ="Date")]
        public DateTime? VEventDate { get; set; }
        [Required]
        [Display(Name = "Start Time")]
        public TimeSpan VEventStartTime { get; set; }
        [Required]
        [Display(Name = "End Time")]
        public TimeSpan VEventEndTime { get; set; }
        public int VEventTotalTime { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}