﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubChallenge.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}