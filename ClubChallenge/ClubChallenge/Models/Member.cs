﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(4, ErrorMessage = "PIN must be 4 numbers long"), MinLength(4, ErrorMessage = "PIN must be 4 numbers long")]
        public string PIN { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}