﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClubChallenge.Models
{
    public class MemberClubHours
    {
        public int Id { get; set; }
        public DateTime? ClockIn { get; set; }
        public DateTime? ClockOut { get; set; }
        [Required]
        public Member Member { get; set; }
    }
}