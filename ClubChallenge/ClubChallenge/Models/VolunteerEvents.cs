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
        public DateTime? VEventDate { get; set; }
        [Required]
        public TimeSpan VEventStartTime { get; set; }
        [Required]
        public TimeSpan VEventEndTime { get; set; }
        public int VEventTotalTime { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}